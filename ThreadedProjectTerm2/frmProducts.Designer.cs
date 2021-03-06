﻿namespace ThreadedProjectTerm2
{
    partial class frmProducts
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
            this.components = new System.ComponentModel.Container();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProductShowEdit = new System.Windows.Forms.Button();
            this.btnProductShowAddNew = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.grpProductAddEdit = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductCancel = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.txtProdAddEdit = new System.Windows.Forms.TextBox();
            this.grpProductButtons = new System.Windows.Forms.GroupBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpProdSupplier = new System.Windows.Forms.GroupBox();
            this.lvProdSuppliers = new System.Windows.Forms.ListView();
            this.PSId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnProdSupplierDelete = new System.Windows.Forms.Button();
            this.btnProdSupplierAdd = new System.Windows.Forms.Button();
            this.grpProdSupplierAdd = new System.Windows.Forms.GroupBox();
            this.btnProdSupplierCancel = new System.Windows.Forms.Button();
            this.cboProductSupplierAdd = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProdSupplierSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).BeginInit();
            this.grpProductAddEdit.SuspendLayout();
            this.grpProductButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.grpProdSupplier.SuspendLayout();
            this.grpProdSupplierAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productSupplierBindingSource
            // 
            this.productSupplierBindingSource.DataSource = typeof(TravelExpertsClasses.ProductSupplier);
            // 
            // btnProductShowEdit
            // 
            this.btnProductShowEdit.Location = new System.Drawing.Point(79, 18);
            this.btnProductShowEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductShowEdit.Name = "btnProductShowEdit";
            this.btnProductShowEdit.Size = new System.Drawing.Size(63, 21);
            this.btnProductShowEdit.TabIndex = 3;
            this.btnProductShowEdit.Text = "Edit";
            this.btnProductShowEdit.UseVisualStyleBackColor = true;
            this.btnProductShowEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductShowAddNew
            // 
            this.btnProductShowAddNew.Location = new System.Drawing.Point(12, 18);
            this.btnProductShowAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductShowAddNew.Name = "btnProductShowAddNew";
            this.btnProductShowAddNew.Size = new System.Drawing.Size(63, 21);
            this.btnProductShowAddNew.TabIndex = 5;
            this.btnProductShowAddNew.Text = "Add new";
            this.btnProductShowAddNew.UseVisualStyleBackColor = true;
            this.btnProductShowAddNew.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(149, 18);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(63, 21);
            this.btnProductDelete.TabIndex = 6;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // grpProductAddEdit
            // 
            this.grpProductAddEdit.Controls.Add(this.btnProductAdd);
            this.grpProductAddEdit.Controls.Add(this.btnProductCancel);
            this.grpProductAddEdit.Controls.Add(this.btnProductSave);
            this.grpProductAddEdit.Controls.Add(this.txtProdAddEdit);
            this.grpProductAddEdit.Location = new System.Drawing.Point(14, 368);
            this.grpProductAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.grpProductAddEdit.Name = "grpProductAddEdit";
            this.grpProductAddEdit.Padding = new System.Windows.Forms.Padding(2);
            this.grpProductAddEdit.Size = new System.Drawing.Size(239, 83);
            this.grpProductAddEdit.TabIndex = 8;
            this.grpProductAddEdit.TabStop = false;
            this.grpProductAddEdit.Text = "Add/Edit Product";
            this.grpProductAddEdit.Visible = false;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(25, 52);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(50, 21);
            this.btnProductAdd.TabIndex = 3;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click_1);
            // 
            // btnProductCancel
            // 
            this.btnProductCancel.Location = new System.Drawing.Point(79, 52);
            this.btnProductCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductCancel.Name = "btnProductCancel";
            this.btnProductCancel.Size = new System.Drawing.Size(50, 21);
            this.btnProductCancel.TabIndex = 2;
            this.btnProductCancel.Text = "Cancel";
            this.btnProductCancel.UseVisualStyleBackColor = true;
            this.btnProductCancel.Click += new System.EventHandler(this.btnProductCancel_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(17, 52);
            this.btnProductSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(50, 21);
            this.btnProductSave.TabIndex = 1;
            this.btnProductSave.Text = "Save";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // txtProdAddEdit
            // 
            this.txtProdAddEdit.Location = new System.Drawing.Point(17, 26);
            this.txtProdAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.txtProdAddEdit.Name = "txtProdAddEdit";
            this.txtProdAddEdit.Size = new System.Drawing.Size(205, 20);
            this.txtProdAddEdit.TabIndex = 0;
            // 
            // grpProductButtons
            // 
            this.grpProductButtons.Controls.Add(this.lstProducts);
            this.grpProductButtons.Controls.Add(this.btnProductShowAddNew);
            this.grpProductButtons.Controls.Add(this.btnProductShowEdit);
            this.grpProductButtons.Controls.Add(this.btnProductDelete);
            this.grpProductButtons.Location = new System.Drawing.Point(19, 62);
            this.grpProductButtons.Margin = new System.Windows.Forms.Padding(2);
            this.grpProductButtons.Name = "grpProductButtons";
            this.grpProductButtons.Padding = new System.Windows.Forms.Padding(2);
            this.grpProductButtons.Size = new System.Drawing.Size(235, 294);
            this.grpProductButtons.TabIndex = 10;
            this.grpProductButtons.TabStop = false;
            // 
            // lstProducts
            // 
            this.lstProducts.DataSource = this.productBindingSource1;
            this.lstProducts.DisplayMember = "ProdName";
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(12, 55);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(205, 225);
            this.lstProducts.TabIndex = 11;
            this.lstProducts.ValueMember = "ProductId";
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged_1);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(TravelExpertsClasses.Product);
            // 
            // grpProdSupplier
            // 
            this.grpProdSupplier.Controls.Add(this.lvProdSuppliers);
            this.grpProdSupplier.Controls.Add(this.btnProdSupplierDelete);
            this.grpProdSupplier.Controls.Add(this.btnProdSupplierAdd);
            this.grpProdSupplier.Location = new System.Drawing.Point(273, 62);
            this.grpProdSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.grpProdSupplier.Name = "grpProdSupplier";
            this.grpProdSupplier.Padding = new System.Windows.Forms.Padding(2);
            this.grpProdSupplier.Size = new System.Drawing.Size(358, 293);
            this.grpProdSupplier.TabIndex = 11;
            this.grpProdSupplier.TabStop = false;
            this.grpProdSupplier.Text = "Suppliers for product [insert product name]";
            // 
            // lvProdSuppliers
            // 
            this.lvProdSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PSId,
            this.supName});
            this.lvProdSuppliers.FullRowSelect = true;
            this.lvProdSuppliers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvProdSuppliers.Location = new System.Drawing.Point(12, 60);
            this.lvProdSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.lvProdSuppliers.MultiSelect = false;
            this.lvProdSuppliers.Name = "lvProdSuppliers";
            this.lvProdSuppliers.Size = new System.Drawing.Size(329, 215);
            this.lvProdSuppliers.TabIndex = 7;
            this.lvProdSuppliers.UseCompatibleStateImageBehavior = false;
            this.lvProdSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // PSId
            // 
            this.PSId.Text = "PSid";
            this.PSId.Width = 0;
            // 
            // supName
            // 
            this.supName.Text = "Supplier Name";
            this.supName.Width = 300;
            // 
            // btnProdSupplierDelete
            // 
            this.btnProdSupplierDelete.Location = new System.Drawing.Point(12, 25);
            this.btnProdSupplierDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdSupplierDelete.Name = "btnProdSupplierDelete";
            this.btnProdSupplierDelete.Size = new System.Drawing.Size(162, 23);
            this.btnProdSupplierDelete.TabIndex = 6;
            this.btnProdSupplierDelete.Text = "Remove supplier from product";
            this.btnProdSupplierDelete.UseVisualStyleBackColor = true;
            this.btnProdSupplierDelete.Click += new System.EventHandler(this.btnProdSupplierDelete_Click);
            // 
            // btnProdSupplierAdd
            // 
            this.btnProdSupplierAdd.Location = new System.Drawing.Point(178, 25);
            this.btnProdSupplierAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdSupplierAdd.Name = "btnProdSupplierAdd";
            this.btnProdSupplierAdd.Size = new System.Drawing.Size(162, 23);
            this.btnProdSupplierAdd.TabIndex = 5;
            this.btnProdSupplierAdd.Text = "Add supplier for this product";
            this.btnProdSupplierAdd.UseVisualStyleBackColor = true;
            this.btnProdSupplierAdd.Click += new System.EventHandler(this.btnProdSupplierAdd_Click);
            // 
            // grpProdSupplierAdd
            // 
            this.grpProdSupplierAdd.Controls.Add(this.btnProdSupplierCancel);
            this.grpProdSupplierAdd.Controls.Add(this.cboProductSupplierAdd);
            this.grpProdSupplierAdd.Controls.Add(this.btnProdSupplierSave);
            this.grpProdSupplierAdd.Location = new System.Drawing.Point(273, 368);
            this.grpProdSupplierAdd.Margin = new System.Windows.Forms.Padding(2);
            this.grpProdSupplierAdd.Name = "grpProdSupplierAdd";
            this.grpProdSupplierAdd.Padding = new System.Windows.Forms.Padding(2);
            this.grpProdSupplierAdd.Size = new System.Drawing.Size(358, 83);
            this.grpProdSupplierAdd.TabIndex = 9;
            this.grpProdSupplierAdd.TabStop = false;
            this.grpProdSupplierAdd.Text = "Add Supplier to Product";
            this.grpProdSupplierAdd.Visible = false;
            // 
            // btnProdSupplierCancel
            // 
            this.btnProdSupplierCancel.Location = new System.Drawing.Point(70, 52);
            this.btnProdSupplierCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdSupplierCancel.Name = "btnProdSupplierCancel";
            this.btnProdSupplierCancel.Size = new System.Drawing.Size(50, 21);
            this.btnProdSupplierCancel.TabIndex = 4;
            this.btnProdSupplierCancel.Text = "Cancel";
            this.btnProdSupplierCancel.UseVisualStyleBackColor = true;
            this.btnProdSupplierCancel.Click += new System.EventHandler(this.btnProdSupplierCancel_Click);
            // 
            // cboProductSupplierAdd
            // 
            this.cboProductSupplierAdd.DataSource = this.supplierBindingSource;
            this.cboProductSupplierAdd.DisplayMember = "SupName";
            this.cboProductSupplierAdd.FormattingEnabled = true;
            this.cboProductSupplierAdd.Location = new System.Drawing.Point(16, 27);
            this.cboProductSupplierAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cboProductSupplierAdd.Name = "cboProductSupplierAdd";
            this.cboProductSupplierAdd.Size = new System.Drawing.Size(325, 21);
            this.cboProductSupplierAdd.TabIndex = 0;
            this.cboProductSupplierAdd.ValueMember = "SupID";
            // 
            // btnProdSupplierSave
            // 
            this.btnProdSupplierSave.Location = new System.Drawing.Point(16, 52);
            this.btnProdSupplierSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdSupplierSave.Name = "btnProdSupplierSave";
            this.btnProdSupplierSave.Size = new System.Drawing.Size(50, 21);
            this.btnProdSupplierSave.TabIndex = 3;
            this.btnProdSupplierSave.Text = "Add";
            this.btnProdSupplierSave.UseVisualStyleBackColor = true;
            this.btnProdSupplierSave.Click += new System.EventHandler(this.btnProdSupplierSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Products";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpProdSupplier);
            this.Controls.Add(this.grpProdSupplierAdd);
            this.Controls.Add(this.grpProductButtons);
            this.Controls.Add(this.grpProductAddEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProducts";
            this.Text = "Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProducts_FormClosed);
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).EndInit();
            this.grpProductAddEdit.ResumeLayout(false);
            this.grpProductAddEdit.PerformLayout();
            this.grpProductButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.grpProdSupplier.ResumeLayout(false);
            this.grpProdSupplierAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btnProductShowEdit;
        private System.Windows.Forms.Button btnProductShowAddNew;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.BindingSource productSupplierBindingSource;
        private System.Windows.Forms.GroupBox grpProductAddEdit;
        private System.Windows.Forms.Button btnProductCancel;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.TextBox txtProdAddEdit;
        private System.Windows.Forms.GroupBox grpProductButtons;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.GroupBox grpProdSupplier;
        private System.Windows.Forms.ListView lvProdSuppliers;
        private System.Windows.Forms.ColumnHeader PSId;
        private System.Windows.Forms.ColumnHeader supName;
        private System.Windows.Forms.GroupBox grpProdSupplierAdd;
        private System.Windows.Forms.Button btnProdSupplierCancel;
        private System.Windows.Forms.ComboBox cboProductSupplierAdd;
        private System.Windows.Forms.Button btnProdSupplierSave;
        private System.Windows.Forms.Button btnProdSupplierDelete;
        private System.Windows.Forms.Button btnProdSupplierAdd;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Label label1;
    }
}