using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using heidi_schwartz_C968.model;

namespace heidi_schwartz_C968
{
    public partial class partscreen : Form
    {
        bool modifyingPart = false;
        enum Source
        { InHouse, Outsourced };
        Source source;
        public partscreen()
        {
            InitializeComponent();

            if (Inventory.CurrentPart == null)
            {
                lblAddModifyPart.Text = "Add Part";
                this.Text = "Add Part";
                tbID.Text = Inventory.generatePartID().ToString();
                rbInHouse.Checked = true;
                lblPartSource.Text = "Company Name";
                source = Source.InHouse;
            }
            else
            {
                modifyingPart = true;
                lblAddModifyPart.Text = "Modify Part";
                this.Text = "Modify Part";
                Part CurrentPart = Inventory.CurrentPart;
                tbID.Text = CurrentPart.PartID.ToString();
                tbName.Text = CurrentPart.Name;
                tbInventory.Text = CurrentPart.InStock.ToString();
                tbPrice.Text = CurrentPart.Price.ToString();
                tbMin.Text = CurrentPart.Min.ToString();
                tbMax.Text = CurrentPart.Max.ToString();

                // check source and set accordingly
                if (CurrentPart is Inhouse)
                {
                    rbInHouse.Checked = true;
                    lblPartSource.Text = "Machine ID";
                    tbPartSource.Text = ((Inhouse)CurrentPart).MachineID.ToString();
                    source = Source.InHouse;
                }
                else
                {
                    rbOutsourced.Checked = true;
                    lblPartSource.Text = "Company Name";
                    tbPartSource.Text = ((Outsourced)CurrentPart).CompanyName;
                    source = Source.Outsourced;
                }
            }

            tbID.Enabled = false;
            btnSavePart.Enabled = false;
        }

        private void rbOutsourcedClicked(object sender, EventArgs e)
        {
            lblPartSource.Text = "Company Name";

            bool isAlphabet = Regex.IsMatch(tbPartSource.Text, "[a-z]", RegexOptions.IgnoreCase);

            if (string.IsNullOrWhiteSpace(tbPartSource.Text) || !isAlphabet)
            {
                tbPartSource.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                tbPartSource.BackColor = System.Drawing.Color.White;
            }

            btnSavePart.Enabled = validatePart();
        }

        private void rbInHouseClicked(object sender, EventArgs e)
        {
            lblPartSource.Text = "Machine ID";

            int num;
            if(!Int32.TryParse(tbPartSource.Text, out num))
            {                 
                tbPartSource.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                tbPartSource.BackColor = System.Drawing.Color.White;
            }

            btnSavePart.Enabled = validatePart();
        }

        private void saveClicked(object sender, EventArgs e)
        {
            int id;
            if (modifyingPart)
            {
                id = Inventory.CurrentPart.PartID;
                Inventory.removePart(Inventory.CurrentPart);

            }
            else
            {
                id = Inventory.generatePartID();
            }

            string name = tbName.Text;
            decimal price = decimal.Parse(tbPrice.Text);
            int inStock = int.Parse(tbInventory.Text);
            int min = int.Parse(tbMin.Text);
            int max = int.Parse(tbMax.Text);

            if (source == Source.InHouse)
            {
                int machineID = int.Parse(tbPartSource.Text);
                Inventory.addPart(new Inhouse(id, name, price, inStock, min, max, machineID));
            }
            else
            {
                string companyName = tbPartSource.Text;
                Inventory.addPart(new Outsourced(id, name, price, inStock, min, max, companyName));
            }

            Inventory.CurrentPart = null;

            Close();
        }

        private void cancelClicked(object sender, EventArgs e)
        {
            Inventory.CurrentPart = null;
            Close();
        }

        private bool validatePart()
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
            }
            else
            {
                tbName.BackColor = System.Drawing.Color.White;
            }
            btnSavePart.Enabled = validatePart();
        }

        private void inventoryTextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(tbInventory.Text, out number))
            {
                tbInventory.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                tbInventory.BackColor = System.Drawing.Color.White;
            }
            btnSavePart.Enabled = validatePart();
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
                return;
            }
            if (!Int32.TryParse(tbMax.Text, out max))
            {
                tbMax.BackColor = System.Drawing.Color.Salmon;
                return;
            }
            if (min > max || (min < 0 || max < 0))
            {
                tbMin.BackColor = System.Drawing.Color.Salmon;
                tbMax.BackColor = System.Drawing.Color.Salmon;
                // please input a valid min and max
            }
            else
            {
                tbMin.BackColor = System.Drawing.Color.White;
                tbMax.BackColor = System.Drawing.Color.White;
            }
            btnSavePart.Enabled = validatePart();
        }

        private void priceTextChanged(object sender, EventArgs e)
        {
            decimal price;
            if (!Decimal.TryParse(tbPrice.Text, out price))
            {
                tbPrice.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                tbPrice.BackColor = System.Drawing.Color.White;
            }
            btnSavePart.Enabled = validatePart();
        }

    }
}
