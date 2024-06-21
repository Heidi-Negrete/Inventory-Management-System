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

        // is this ok?
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

        private bool validateProduct()
        {
            int number;
            decimal price;
            return (!string.IsNullOrWhiteSpace(tbName.Text) && Int32.TryParse(tbInventory.Text, out number)
                && Int32.TryParse(tbMax.Text, out number) && Int32.TryParse(tbMin.Text, out number)
                && Decimal.TryParse(tbPrice.Text, out price));
        }

        private void nameTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbName, "Please enter a valid name.");
            }
            else
            {
                tbName.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbName, "");
            }
            btnSaveProduct.Enabled = validateProduct();
        }

        private void inventoryTextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(tbInventory.Text, out number))
            {
                tbInventory.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbInventory, "Please enter a valid number.");
            }
            else
            {
                tbInventory.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbInventory, "");
            }
            btnSaveProduct.Enabled = validateProduct();
        }

        private void maxTextChanged(object sender, EventArgs e)
        {
            validateMinMax();
        }

        private void minTextChanged(object sender, EventArgs e)
        {
            validateMinMax();
        }

        private void validateMinMax()
        {
            int min;
            int max;
            if (!Int32.TryParse(tbMin.Text, out min))
            {
                tbMin.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbMin, "Please enter a valid number.");
                return;
            }
            if (!Int32.TryParse(tbMax.Text, out max))
            {
                tbMax.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbMax, "Please enter a valid number.");
                return;
            }
            if (min > max || (min < 0 || max < 0))
            {
                tbMin.BackColor = System.Drawing.Color.Salmon;
                tbMax.BackColor = System.Drawing.Color.Salmon;
                // please input a valid min and max
                toolTip.SetError(tbMin, "Please enter a valid minimum and maximum.");
                toolTip.SetError(tbMax, "Please enter a valid minimum and maximum.");
            }
            else
            {
                tbMin.BackColor = System.Drawing.Color.White;
                tbMax.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbMin, "");
                toolTip.SetError(tbMax, "");
            }
            btnSaveProduct.Enabled = validateProduct();
            }

        private void priceTextChanged(object sender, EventArgs e)
        {
            decimal price;
            if (!Decimal.TryParse(tbPrice.Text, out price))
            {
                tbPrice.BackColor = System.Drawing.Color.Salmon;
                toolTip.SetError(tbPrice, "Please enter a valid price.");
            }
            else
            {
                tbPrice.BackColor = System.Drawing.Color.White;
                toolTip.SetError(tbPrice, "");
            }
            btnSaveProduct.Enabled = validateProduct();
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


            CurrentAssociatedParts.Remove(dgvAssociatedParts.CurrentRow.DataBoundItem as Part);

            btnSaveProduct.Enabled = validateProduct();
        }
    }
}
