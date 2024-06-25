namespace heidi_schwartz_C968
{
    partial class partscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddModifyPart = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.tbPartSource = new System.Windows.Forms.TextBox();
            this.lblPartSource = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddModifyPart
            // 
            this.lblAddModifyPart.AutoSize = true;
            this.lblAddModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModifyPart.Location = new System.Drawing.Point(2, 18);
            this.lblAddModifyPart.Name = "lblAddModifyPart";
            this.lblAddModifyPart.Size = new System.Drawing.Size(211, 33);
            this.lblAddModifyPart.TabIndex = 2;
            this.lblAddModifyPart.Text = "text set in code";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(250, 285);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(74, 20);
            this.tbMin.TabIndex = 23;
            this.tbMin.TextChanged += new System.EventHandler(this.minTextChanged);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(116, 285);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(74, 20);
            this.tbMax.TabIndex = 22;
            this.tbMax.TextChanged += new System.EventHandler(this.maxTextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(118, 188);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(146, 20);
            this.tbPrice.TabIndex = 21;
            this.tbPrice.TextChanged += new System.EventHandler(this.priceTextChanged);
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(118, 237);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(146, 20);
            this.tbInventory.TabIndex = 20;
            this.tbInventory.TextChanged += new System.EventHandler(this.inventoryTextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(118, 135);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 19;
            this.tbName.TextChanged += new System.EventHandler(this.nameTextChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(118, 88);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(146, 20);
            this.tbID.TabIndex = 18;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(203, 281);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(41, 24);
            this.lblMin.TabIndex = 17;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(64, 281);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(46, 24);
            this.lblMax.TabIndex = 16;
            this.lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(7, 184);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(105, 24);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price / Cost";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(12, 232);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(86, 24);
            this.lblInventory.TabIndex = 14;
            this.lblInventory.Text = "Inventory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(69, 83);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 24);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInHouse.Location = new System.Drawing.Point(156, 27);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(101, 24);
            this.rbInHouse.TabIndex = 24;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.Click += new System.EventHandler(this.rbInHouseClicked);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutsourced.Location = new System.Drawing.Point(263, 27);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(120, 24);
            this.rbOutsourced.TabIndex = 25;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.Click += new System.EventHandler(this.rbOutsourcedClicked);
            // 
            // tbPartSource
            // 
            this.tbPartSource.Location = new System.Drawing.Point(157, 330);
            this.tbPartSource.Name = "tbPartSource";
            this.tbPartSource.Size = new System.Drawing.Size(146, 20);
            this.tbPartSource.TabIndex = 26;
            this.tbPartSource.TextChanged += new System.EventHandler(this.sourceTextChanged);
            // 
            // lblPartSource
            // 
            this.lblPartSource.AutoSize = true;
            this.lblPartSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartSource.Location = new System.Drawing.Point(4, 326);
            this.lblPartSource.Name = "lblPartSource";
            this.lblPartSource.Size = new System.Drawing.Size(136, 24);
            this.lblPartSource.TabIndex = 27;
            this.lblPartSource.Text = "text set in code";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(280, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelClicked);
            // 
            // btnSavePart
            // 
            this.btnSavePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePart.Location = new System.Drawing.Point(171, 368);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(93, 40);
            this.btnSavePart.TabIndex = 28;
            this.btnSavePart.Text = "Save";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.saveClicked);
            // 
            // partscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 425);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSavePart);
            this.Controls.Add(this.lblPartSource);
            this.Controls.Add(this.tbPartSource);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbInventory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAddModifyPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "partscreen";
            this.Text = "text set in code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddModifyPart;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.TextBox tbPartSource;
        private System.Windows.Forms.Label lblPartSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSavePart;
    }
}