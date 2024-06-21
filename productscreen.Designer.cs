namespace heidi_schwartz_C968
{
    partial class productscreen
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
            this.lblAddModifyProduct = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.tbSearchParts = new System.Windows.Forms.TextBox();
            this.btnSearchParts = new System.Windows.Forms.Button();
            this.lblAssociatedParts = new System.Windows.Forms.Label();
            this.lblCandidateParts = new System.Windows.Forms.Label();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddModifyProduct
            // 
            this.lblAddModifyProduct.AutoSize = true;
            this.lblAddModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModifyProduct.Location = new System.Drawing.Point(0, 0);
            this.lblAddModifyProduct.Name = "lblAddModifyProduct";
            this.lblAddModifyProduct.Size = new System.Drawing.Size(211, 33);
            this.lblAddModifyProduct.TabIndex = 0;
            this.lblAddModifyProduct.Text = "text set in code";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbMin);
            this.splitContainer1.Panel1.Controls.Add(this.tbMax);
            this.splitContainer1.Panel1.Controls.Add(this.tbPrice);
            this.splitContainer1.Panel1.Controls.Add(this.tbInventory);
            this.splitContainer1.Panel1.Controls.Add(this.tbName);
            this.splitContainer1.Panel1.Controls.Add(this.tbID);
            this.splitContainer1.Panel1.Controls.Add(this.lblMin);
            this.splitContainer1.Panel1.Controls.Add(this.lblMax);
            this.splitContainer1.Panel1.Controls.Add(this.lblPrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblInventory);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDeletePart);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddPart);
            this.splitContainer1.Panel2.Controls.Add(this.tbSearchParts);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearchParts);
            this.splitContainer1.Panel2.Controls.Add(this.lblAssociatedParts);
            this.splitContainer1.Panel2.Controls.Add(this.lblCandidateParts);
            this.splitContainer1.Panel2.Controls.Add(this.dgvAssociatedParts);
            this.splitContainer1.Panel2.Controls.Add(this.dgvAllParts);
            this.splitContainer1.Size = new System.Drawing.Size(792, 388);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(187, 272);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(74, 20);
            this.tbMin.TabIndex = 11;
            this.tbMin.TextChanged += new System.EventHandler(this.minTextChanged);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(53, 272);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(74, 20);
            this.tbMax.TabIndex = 10;
            this.tbMax.TextChanged += new System.EventHandler(this.maxTextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(106, 204);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(146, 20);
            this.tbPrice.TabIndex = 9;
            this.tbPrice.TextChanged += new System.EventHandler(this.priceTextChanged);
            // 
            // tbInventory
            // 
            this.tbInventory.Location = new System.Drawing.Point(106, 152);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(146, 20);
            this.tbInventory.TabIndex = 8;
            this.tbInventory.TextChanged += new System.EventHandler(this.inventoryTextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 97);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextChanged += new System.EventHandler(this.nameTextChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(106, 50);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(146, 20);
            this.tbID.TabIndex = 6;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(140, 268);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(41, 24);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(1, 268);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(46, 24);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Max";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(43, 204);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(14, 148);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(86, 24);
            this.lblInventory.TabIndex = 2;
            this.lblInventory.Text = "Inventory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(69, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(422, 362);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePart.TabIndex = 19;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.deletePartClicked);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(422, 178);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 18;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.addPartClicked);
            // 
            // tbSearchParts
            // 
            this.tbSearchParts.Location = new System.Drawing.Point(319, -2);
            this.tbSearchParts.Name = "tbSearchParts";
            this.tbSearchParts.Size = new System.Drawing.Size(178, 20);
            this.tbSearchParts.TabIndex = 17;
            // 
            // btnSearchParts
            // 
            this.btnSearchParts.Location = new System.Drawing.Point(238, -2);
            this.btnSearchParts.Name = "btnSearchParts";
            this.btnSearchParts.Size = new System.Drawing.Size(75, 23);
            this.btnSearchParts.TabIndex = 16;
            this.btnSearchParts.Text = "Search";
            this.btnSearchParts.UseVisualStyleBackColor = true;
            // 
            // lblAssociatedParts
            // 
            this.lblAssociatedParts.AutoSize = true;
            this.lblAssociatedParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociatedParts.Location = new System.Drawing.Point(3, 186);
            this.lblAssociatedParts.Name = "lblAssociatedParts";
            this.lblAssociatedParts.Size = new System.Drawing.Size(289, 24);
            this.lblAssociatedParts.TabIndex = 15;
            this.lblAssociatedParts.Text = "Parts Associated with this Product";
            // 
            // lblCandidateParts
            // 
            this.lblCandidateParts.AutoSize = true;
            this.lblCandidateParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateParts.Location = new System.Drawing.Point(3, 0);
            this.lblCandidateParts.Name = "lblCandidateParts";
            this.lblCandidateParts.Size = new System.Drawing.Size(164, 24);
            this.lblCandidateParts.TabIndex = 14;
            this.lblCandidateParts.Text = "All candidate Parts";
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(3, 213);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.Size = new System.Drawing.Size(494, 145);
            this.dgvAssociatedParts.TabIndex = 13;
            this.dgvAssociatedParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.associatedPartsBindingComplete);
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(3, 27);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.Size = new System.Drawing.Size(494, 145);
            this.dgvAllParts.TabIndex = 12;
            this.dgvAllParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.allPartsBindingComplete);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Location = new System.Drawing.Point(596, 443);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(93, 40);
            this.btnSaveProduct.TabIndex = 2;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.saveClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(705, 443);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelClicked);
            // 
            // productscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 495);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblAddModifyProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "productscreen";
            this.Text = "Add/Modify Product";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddModifyProduct;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.TextBox tbSearchParts;
        private System.Windows.Forms.Button btnSearchParts;
        private System.Windows.Forms.Label lblAssociatedParts;
        private System.Windows.Forms.Label lblCandidateParts;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Button btnCancel;
    }
}