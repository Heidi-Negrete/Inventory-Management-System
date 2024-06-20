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
            throw new NotImplementedException();
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
            Inventory.removeProduct(CurrentProduct.ProductID);
        }

        private void searchPartsClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void searchProductsClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void partSearchTextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void productSearchTextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
