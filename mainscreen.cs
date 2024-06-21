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
    public partial class mainscreen : Form
    {
        // Checklist OK? where should be using try/catch?
        public mainscreen()
        {
            InitializeComponent();

            dgvPartsMain.DataSource = Inventory.AllParts;
            dgvProductsMain.DataSource = Inventory.Products;

            dgvPartsMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductsMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvPartsMain.ReadOnly = true;
            dgvProductsMain.ReadOnly = true;

            dgvPartsMain.MultiSelect = false;
            dgvProductsMain.MultiSelect = false;

            dgvPartsMain.AllowUserToAddRows = false;
            dgvProductsMain.AllowUserToAddRows = false;
        }

        private void dgvPartsMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPartsMain.ClearSelection();
        }

        private void dgvProductsMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProductsMain.ClearSelection();
        }

        private void exitClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartsClicked(object sender, EventArgs e)
        {
            partscreen partaddscreen = new partscreen();
            partaddscreen.ShowDialog();
        }

        private void addProductsClicked(object sender, EventArgs e)
        {
            productscreen productaddscreen = new productscreen();
            productaddscreen.ShowDialog();
        }

        private void modifyPartsClicked(object sender, EventArgs e)
        {
            if (dgvPartsMain.CurrentRow == null || !dgvPartsMain.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }
            Inventory.CurrentPart = dgvPartsMain.CurrentRow.DataBoundItem as Part;
            partscreen partmodifyscreen = new partscreen();
            partmodifyscreen.ShowDialog();
        }

        private void modifyProductsClicked(object sender, EventArgs e)
        {
            if (dgvProductsMain.CurrentRow == null || !dgvProductsMain.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }
            Inventory.CurrentProduct = dgvProductsMain.CurrentRow.DataBoundItem as Product;
            productscreen productmodifyscreen = new productscreen();
            productmodifyscreen.ShowDialog();
            
        }

        private void deletePartsClicked(object sender, EventArgs e)
        {
            if (dgvPartsMain.CurrentRow == null || !dgvPartsMain.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }
            Part CurrentPart = dgvPartsMain.CurrentRow.DataBoundItem as Part;

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {CurrentPart}?", "Delete Part", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            foreach (Product product in Inventory.Products)
            {
                if (product.lookupAssociatedPart(CurrentPart.PartID) != null)
                {
                    MessageBox.Show("Part is associated with a product. Please remove all associations before deleting.");
                    return;
                }
            }
            Inventory.removePart(CurrentPart);

        }

        private void deleteProductsClicked(object sender, EventArgs e)
        {
            if (dgvProductsMain.CurrentRow == null || !dgvProductsMain.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            Product CurrentProduct = dgvProductsMain.CurrentRow.DataBoundItem as Product;
            // double check if user wants to continue
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {CurrentProduct}?", "Delete Product", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (CurrentProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Product has associated parts. Please remove all associated parts before deleting.");
                return;
            }
            Inventory.removeProduct(CurrentProduct.ProductID);
        }

        private void searchPartsClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPartsSearch.Text))
            {
                dgvPartsMain.DataSource = Inventory.AllParts;
                return;
            }

            var results = Inventory.AllParts
                                   .Where(part => part.Name.ToLower()
                                   .Contains(tbPartsSearch.Text.ToLower()))
                                   .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
                return;
            }
            else
            {
                dgvPartsMain.DataSource = results;
            }
        }

        private void searchProductsClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductsSearch.Text))
            {
                dgvProductsMain.DataSource = Inventory.Products;
                return;
            }

            var results = Inventory.Products
                                   .Where(product => product.Name.ToLower()
                                   .Contains(tbProductsSearch.Text.ToLower()))
                                   .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
                return;
            }
            else
            {
                dgvProductsMain.DataSource = results;
            }
        }

        private void searchPartsKeyDowned(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchPartsClicked(sender, e);
            }
        }

        private void searchProductKeyDowned(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchProductsClicked(sender, e);
            }
        }
    }
}
