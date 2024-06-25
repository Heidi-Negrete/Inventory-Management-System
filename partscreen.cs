using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        ErrorProvider toolTip = new ErrorProvider();
        
        public partscreen()
        {
            InitializeComponent();

            toolTip.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            if (Inventory.CurrentPart == null)
            {
                lblAddModifyPart.Text = "Add Part";
                this.Text = "Add Part";
                tbID.Text = Inventory.generatePartID().ToString();
                rbInHouse.Checked = true;
                lblPartSource.Text = "Machine ID";
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
            validatePart();
            btnSavePart.Enabled = false;
        }

        private void rbOutsourcedClicked(object sender, EventArgs e)
        {
            lblPartSource.Text = "Company Name";
            source = Source.Outsourced;
            btnSavePart.Enabled = validatePart();   
        }

        private void rbInHouseClicked(object sender, EventArgs e)
        {
            lblPartSource.Text = "Machine ID";
            source = Source.InHouse;
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
                id = Int32.Parse(tbID.Text);
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

        private void nameTextChanged(object sender, EventArgs e)
        {
            btnSavePart.Enabled = validatePart();
        }

        private void inventoryTextChanged(object sender, EventArgs e)
        {
            btnSavePart.Enabled = validatePart();
        }

        private void maxTextChanged(object sender, EventArgs e)
        {
            btnSavePart.Enabled = validatePart();
        }

        private void minTextChanged(object sender, EventArgs e)
        {
            btnSavePart.Enabled = validatePart();
        }

        private void priceTextChanged(object sender, EventArgs e)
        {
            btnSavePart.Enabled = validatePart();
        }

        private void sourceTextChanged(object sender, EventArgs e)
        {
            btnSavePart.Enabled = validatePart();
        }

        private bool validatePart()
        {
            bool isValid = true;
            decimal price;
            int stock, min, max;

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

            // Validate Source

            if (source.Equals(Source.InHouse))
            {
                int num;
                if (!Int32.TryParse(tbPartSource.Text, out num))
                {
                    tbPartSource.BackColor = System.Drawing.Color.Salmon;
                    toolTip.SetError(tbPartSource, "Please enter a valid machine ID.");
                    isValid = false;
                }
                else
                {
                    tbPartSource.BackColor = System.Drawing.Color.White;
                    toolTip.SetError(tbPartSource, "");
                }
            }
            else
            {
                bool isAlphabet = Regex.IsMatch(tbPartSource.Text, "[a-z]", RegexOptions.IgnoreCase);

                if (string.IsNullOrWhiteSpace(tbPartSource.Text) || !isAlphabet)
                {
                    tbPartSource.BackColor = System.Drawing.Color.Salmon;
                    toolTip.SetError(tbPartSource, "Please enter a valid company name.");
                    isValid = false;
                }
                else
                {
                    tbPartSource.BackColor = System.Drawing.Color.White;
                    toolTip.SetError(tbPartSource, "");
                }
            }


            return isValid;
        }
    }
}
