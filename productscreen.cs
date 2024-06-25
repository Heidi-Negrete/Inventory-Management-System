using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using heidi_schwartz_C968.model;

namespace heidi_schwartz_C968
{
    public partial class productscreen : Form
    {
        bool modifyingProduct = false;
        private BindingList<Part> CurrentAssociatedParts;
        ErrorProvider toolTip = new ErrorProvider();

        public productscreen()
        {
            InitializeComponent();

            toolTip.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            if (Inventory.CurrentProduct == null)
            {
                lblAddModifyProduct.Text = "Add Product";
                this.Text = "Add Product";
                tbID.Text = Inventory.generateProductID().ToString();
                CurrentAssociatedParts = new BindingList<Part>();
            }
            else
            {
                modifyingProduct = true;
                lblAddModifyProduct.Text = "Modify Product";
                this.Text = "Modify Product";
                Product CurrentProduct = Inventory.CurrentProduct;
                tbID.Text = CurrentProduct.ProductID.ToString();
                tbName.Text = CurrentProduct.Name;
                tbInventory.Text = CurrentProduct.InStock.ToString();
                tbPrice.Text = CurrentProduct.Price.ToString();
                tbMin.Text = CurrentProduct.Min.ToString();
                tbMax.Text = CurrentProduct.Max.ToString();

                CurrentAssociatedParts = Inventory.CurrentProduct.AssociatedParts;
            }

            dgvAssociatedParts.DataSource = CurrentAssociatedParts;
            tbID.Enabled = false;
            validateProduct();
            btnSaveProduct.Enabled = false;

            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.ReadOnly = true;
            dgvAssociatedParts.ReadOnly = true;
            dgvAllParts.MultiSelect = false;
            dgvAssociatedParts.MultiSelect = false;
            dgvAllParts.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToAddRows = false;
        }

        private void allPartsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllParts.ClearSelection();
        }

        private void associatedPartsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAssociatedParts.ClearSelection();
        }

        private void saveClicked(object sender, EventArgs e)
        {
            int id;
            if (modifyingProduct)
            {
                id = Inventory.CurrentProduct.ProductID;
                Inventory.removeProduct(Inventory.CurrentProduct.ProductID);

            }
            else
            {
                id = Inventory.generateProductID();
            }

            string name = tbName.Text;
            decimal price = decimal.Parse(tbPrice.Text);
            int inStock = int.Parse(tbInventory.Text);
            int min = int.Parse(tbMin.Text);
            int max = int.Parse(tbMax.Text);

            Inventory.addProduct(new Product(id, name, price, inStock, min, max));

            Product product = Inventory.lookupProduct(id);

            if (CurrentAssociatedParts != null)
            {
                foreach (Part part in CurrentAssociatedParts)
                {
                    product.addAssociatedPart(part);
                }
            }
            
            Inventory.CurrentProduct = null;
            CurrentAssociatedParts = null;

            Close();
        }

        private void cancelClicked(object sender, EventArgs e)
        {
            Inventory.CurrentProduct = null;
            CurrentAssociatedParts = null;
            Close();
        }

        private void addPartClicked(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null || !dgvAllParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }
            
            CurrentAssociatedParts.Add(dgvAllParts.CurrentRow.DataBoundItem as Part);


            btnSaveProduct.Enabled = validateProduct();
        }

        private void deletePartClicked(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null || !dgvAssociatedParts.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            CurrentAssociatedParts.Remove(dgvAssociatedParts.CurrentRow.DataBoundItem as Part);

            btnSaveProduct.Enabled = validateProduct();
        }

        private void searchPartsClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchParts.Text))
            {
                dgvAllParts.DataSource = Inventory.AllParts;
                return;
            }

            var results = Inventory.AllParts
                                   .Where(part => part.Name.ToLower()
                                   .Contains(tbSearchParts.Text.ToLower()))
                                   .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
                return;
            }
            else
            {
                dgvAllParts.DataSource = results;
            }
        }

        private void searchBoxKeyDowned(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPartsClicked(sender, e);
            }
        }

        private void nameTextChanged(object sender, EventArgs e)
        {
            btnSaveProduct.Enabled = validateProduct();
        }

        private void priceTextChanged(object sender, EventArgs e)
        {
            btnSaveProduct.Enabled = validateProduct();
        }

        private void inventoryTextChanged(object sender, EventArgs e)
        {
            btnSaveProduct.Enabled = validateProduct();
        }

        private void maxTextChanged(object sender, EventArgs e)
        {
            btnSaveProduct.Enabled = validateProduct();
        }

        private void minTextChanged(object sender, EventArgs e)
        {
            btnSaveProduct.Enabled = validateProduct();
        }

        private bool validateProduct()
        {
            int min;
            int max;
            int stock;
            decimal price;
            bool isValid = true;

            // Validate Name and Price

            if (!Decimal.TryParse(tbPrice.Text, out price))
            {
                tbPrice.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbPrice, "Please enter a valid price.");
                isValid = false;
            }
            else
            {
                tbPrice.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbPrice, "");
            }

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbName, "Please enter a valid name.");
                isValid = false;
            }
            else
            {
                tbName.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbName, "");
            }

            // Validate Inventory and Min/Max for valid numbers.

            if (!Int32.TryParse(tbInventory.Text, out stock))
            {
                tbInventory.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbInventory, "Please enter a valid number.");
                isValid = false;
            }
            else
            {
                tbInventory.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbInventory, "");
            }

            if (!Int32.TryParse(tbMin.Text, out min))
            {
                tbMin.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbMin, "Please enter a valid number.");
                isValid = false;
            }
            if (!Int32.TryParse(tbMax.Text, out max))
            {
                tbMax.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbMax, "Please enter a valid number.");
                isValid = false;
            }

            if (isValid) // if numeric, start checking range validity
            {

                if (min > max || (min < 0 || max < 0))
                {
                    tbMin.BackColor = System.Drawing.Color.Salmon;
                    tbMax.BackColor = System.Drawing.Color.Salmon;
                    if (min > max)
                    {
                        toolTip.SetError(tbMin, "Minimum must be less than maximum.");
                        toolTip.SetError(tbMax, "Maximum must be greater than minimum.");
                    }
                    else
                    {
                        toolTip.SetError(tbMin, "Please enter a valid minimum and maximum.");
                        toolTip.SetError(tbMax, "Please enter a valid minimum and maximum.");
                    }
                    isValid = false;
                }
                else if (min > stock || max < stock)
                {
                    tbMin.BackColor = System.Drawing.Color.Salmon;
                    tbMax.BackColor = System.Drawing.Color.Salmon;
                    tbInventory.BackColor = System.Drawing.Color.Salmon;
                    toolTip.SetError(tbInventory, "Inventory must be between the minimum and maximum.");
                    toolTip.SetError(tbMin, "Inventory must be greater than or equal to minimum.");
                    toolTip.SetError(tbMax, "Inventory must be less than or equal to the maximum.");
                    isValid = false;
                }
                else
                {
                    tbMin.BackColor = System.Drawing.Color.White;
                    tbMax.BackColor = System.Drawing.Color.White;
                    toolTip.SetError(tbInventory, "");
                    toolTip.SetError(tbMin, "");
                    toolTip.SetError(tbMax, "");
                }
            }

            return isValid; 
        }
    }
}
