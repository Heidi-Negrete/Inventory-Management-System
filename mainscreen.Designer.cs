namespace heidi_schwartz_C968
{
    partial class mainscreen
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
            this.dgvPartsMain = new System.Windows.Forms.DataGridView();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.dgvProductsMain = new System.Windows.Forms.DataGridView();
            this.btnPartsSearch = new System.Windows.Forms.Button();
            this.btnProductsSearch = new System.Windows.Forms.Button();
            this.tbPartsSearch = new System.Windows.Forms.TextBox();
            this.tbProductsSearch = new System.Windows.Forms.TextBox();
            this.btnPartsAdd = new System.Windows.Forms.Button();
            this.btnPartsModify = new System.Windows.Forms.Button();
            this.btnPartsDelete = new System.Windows.Forms.Button();
            this.btnProductsDelete = new System.Windows.Forms.Button();
            this.btnProductsModify = new System.Windows.Forms.Button();
            this.btnProductsAdd = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPartsMain
            // 
            this.dgvPartsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsMain.Location = new System.Drawing.Point(20, 227);
            this.dgvPartsMain.Name = "dgvPartsMain";
            this.dgvPartsMain.Size = new System.Drawing.Size(628, 425);
            this.dgvPartsMain.TabIndex = 0;
            this.dgvPartsMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPartsMain_DataBindingComplete);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(13, 13);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(498, 39);
            this.lblMainTitle.TabIndex = 2;
            this.lblMainTitle.Text = "Inventory Management System";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(12, 198);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(83, 33);
            this.lblParts.TabIndex = 3;
            this.lblParts.Text = "Parts";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(688, 198);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(130, 33);
            this.lblProducts.TabIndex = 4;
            this.lblProducts.Text = "Products";
            // 
            // dgvProductsMain
            // 
            this.dgvProductsMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsMain.Location = new System.Drawing.Point(677, 227);
            this.dgvProductsMain.Name = "dgvProductsMain";
            this.dgvProductsMain.Size = new System.Drawing.Size(629, 425);
            this.dgvProductsMain.TabIndex = 7;
            this.dgvProductsMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProductsMain_DataBindingComplete);
            // 
            // btnPartsSearch
            // 
            this.btnPartsSearch.Location = new System.Drawing.Point(412, 203);
            this.btnPartsSearch.Name = "btnPartsSearch";
            this.btnPartsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartsSearch.TabIndex = 8;
            this.btnPartsSearch.Text = "Search";
            this.btnPartsSearch.UseVisualStyleBackColor = true;
            this.btnPartsSearch.Click += new System.EventHandler(this.searchPartsClicked);
            // 
            // btnProductsSearch
            // 
            this.btnProductsSearch.Location = new System.Drawing.Point(1069, 202);
            this.btnProductsSearch.Name = "btnProductsSearch";
            this.btnProductsSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProductsSearch.TabIndex = 9;
            this.btnProductsSearch.Text = "Search";
            this.btnProductsSearch.UseVisualStyleBackColor = true;
            this.btnProductsSearch.Click += new System.EventHandler(this.searchProductsClicked);
            // 
            // tbPartsSearch
            // 
            this.tbPartsSearch.Location = new System.Drawing.Point(493, 205);
            this.tbPartsSearch.Name = "tbPartsSearch";
            this.tbPartsSearch.Size = new System.Drawing.Size(155, 20);
            this.tbPartsSearch.TabIndex = 10;
            // 
            // tbProductsSearch
            // 
            this.tbProductsSearch.Location = new System.Drawing.Point(1150, 204);
            this.tbProductsSearch.Name = "tbProductsSearch";
            this.tbProductsSearch.Size = new System.Drawing.Size(155, 20);
            this.tbProductsSearch.TabIndex = 11;
            // 
            // btnPartsAdd
            // 
            this.btnPartsAdd.Location = new System.Drawing.Point(412, 658);
            this.btnPartsAdd.Name = "btnPartsAdd";
            this.btnPartsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPartsAdd.TabIndex = 12;
            this.btnPartsAdd.Text = "Add";
            this.btnPartsAdd.UseVisualStyleBackColor = true;
            this.btnPartsAdd.Click += new System.EventHandler(this.addPartsClicked);
            // 
            // btnPartsModify
            // 
            this.btnPartsModify.Location = new System.Drawing.Point(493, 657);
            this.btnPartsModify.Name = "btnPartsModify";
            this.btnPartsModify.Size = new System.Drawing.Size(75, 23);
            this.btnPartsModify.TabIndex = 13;
            this.btnPartsModify.Text = "Modify";
            this.btnPartsModify.UseVisualStyleBackColor = true;
            this.btnPartsModify.Click += new System.EventHandler(this.modifyPartsClicked);
            // 
            // btnPartsDelete
            // 
            this.btnPartsDelete.Location = new System.Drawing.Point(573, 657);
            this.btnPartsDelete.Name = "btnPartsDelete";
            this.btnPartsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPartsDelete.TabIndex = 14;
            this.btnPartsDelete.Text = "Delete";
            this.btnPartsDelete.UseVisualStyleBackColor = true;
            this.btnPartsDelete.Click += new System.EventHandler(this.deletePartsClicked);
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Location = new System.Drawing.Point(1230, 658);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductsDelete.TabIndex = 17;
            this.btnProductsDelete.Text = "Delete";
            this.btnProductsDelete.UseVisualStyleBackColor = true;
            this.btnProductsDelete.Click += new System.EventHandler(this.deleteProductsClicked);
            // 
            // btnProductsModify
            // 
            this.btnProductsModify.Location = new System.Drawing.Point(1150, 658);
            this.btnProductsModify.Name = "btnProductsModify";
            this.btnProductsModify.Size = new System.Drawing.Size(75, 23);
            this.btnProductsModify.TabIndex = 16;
            this.btnProductsModify.Text = "Modify";
            this.btnProductsModify.UseVisualStyleBackColor = true;
            this.btnProductsModify.Click += new System.EventHandler(this.modifyProductsClicked);
            // 
            // btnProductsAdd
            // 
            this.btnProductsAdd.Location = new System.Drawing.Point(1069, 659);
            this.btnProductsAdd.Name = "btnProductsAdd";
            this.btnProductsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProductsAdd.TabIndex = 15;
            this.btnProductsAdd.Text = "Add";
            this.btnProductsAdd.UseVisualStyleBackColor = true;
            this.btnProductsAdd.Click += new System.EventHandler(this.addProductsClicked);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Location = new System.Drawing.Point(1179, 716);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(135, 52);
            this.btnMainExit.TabIndex = 18;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.exitClicked);
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 780);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnProductsDelete);
            this.Controls.Add(this.btnProductsModify);
            this.Controls.Add(this.btnProductsAdd);
            this.Controls.Add(this.btnPartsDelete);
            this.Controls.Add(this.btnPartsModify);
            this.Controls.Add(this.btnPartsAdd);
            this.Controls.Add(this.tbProductsSearch);
            this.Controls.Add(this.tbPartsSearch);
            this.Controls.Add(this.btnProductsSearch);
            this.Controls.Add(this.btnPartsSearch);
            this.Controls.Add(this.dgvProductsMain);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.dgvPartsMain);
            this.Controls.Add(this.lblParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainscreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPartsMain;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.DataGridView dgvProductsMain;
        private System.Windows.Forms.Button btnPartsSearch;
        private System.Windows.Forms.Button btnProductsSearch;
        private System.Windows.Forms.TextBox tbPartsSearch;
        private System.Windows.Forms.TextBox tbProductsSearch;
        private System.Windows.Forms.Button btnPartsAdd;
        private System.Windows.Forms.Button btnPartsModify;
        private System.Windows.Forms.Button btnPartsDelete;
        private System.Windows.Forms.Button btnProductsDelete;
        private System.Windows.Forms.Button btnProductsModify;
        private System.Windows.Forms.Button btnProductsAdd;
        private System.Windows.Forms.Button btnMainExit;
    }
}

