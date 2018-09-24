﻿namespace UI.UserControls
{
    partial class UcProduct
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectImage = new MetroFramework.Controls.MetroButton();
            this.btnUpdateProduct = new MetroFramework.Controls.MetroTile();
            this.btnAddProduct = new MetroFramework.Controls.MetroTile();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.cmbBrand = new MetroFramework.Controls.MetroComboBox();
            this.cmbIvi = new MetroFramework.Controls.MetroComboBox();
            this.cmbNonExistent = new MetroFramework.Controls.MetroComboBox();
            this.cmbSubcategory = new MetroFramework.Controls.MetroComboBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.txaDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtLowerPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtNormalPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtEnterQuantity = new MetroFramework.Controls.MetroTextBox();
            this.txtStyle = new MetroFramework.Controls.MetroTextBox();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteProduct = new MetroFramework.Controls.MetroTile();
            this.dgvProduct = new MetroFramework.Controls.MetroGrid();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtEstableQuantity = new MetroFramework.Controls.MetroTextBox();
            this.btnCleanProduct = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.btnUpdateProduct);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.pbProduct);
            this.groupBox1.Controls.Add(this.cmbBrand);
            this.groupBox1.Controls.Add(this.cmbIvi);
            this.groupBox1.Controls.Add(this.cmbNonExistent);
            this.groupBox1.Controls.Add(this.cmbSubcategory);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.txaDescription);
            this.groupBox1.Controls.Add(this.txtLowerPrice);
            this.groupBox1.Controls.Add(this.txtNormalPrice);
            this.groupBox1.Controls.Add(this.txtEstableQuantity);
            this.groupBox1.Controls.Add(this.txtEnterQuantity);
            this.groupBox1.Controls.Add(this.txtStyle);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(44, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Producto";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(676, 237);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(107, 23);
            this.btnSelectImage.TabIndex = 5;
            this.btnSelectImage.Text = "Seleccionar imagen";
            this.btnSelectImage.UseSelectable = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.ActiveControl = null;
            this.btnUpdateProduct.Location = new System.Drawing.Point(675, 353);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(108, 41);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Text = "Modificar";
            this.btnUpdateProduct.UseSelectable = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ActiveControl = null;
            this.btnAddProduct.Location = new System.Drawing.Point(675, 292);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(108, 41);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseSelectable = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Location = new System.Drawing.Point(611, 48);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(221, 183);
            this.pbProduct.TabIndex = 3;
            this.pbProduct.TabStop = false;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.ItemHeight = 23;
            this.cmbBrand.Location = new System.Drawing.Point(133, 159);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(120, 29);
            this.cmbBrand.TabIndex = 2;
            this.cmbBrand.UseSelectable = true;
            // 
            // cmbIvi
            // 
            this.cmbIvi.FormattingEnabled = true;
            this.cmbIvi.ItemHeight = 23;
            this.cmbIvi.Location = new System.Drawing.Point(133, 212);
            this.cmbIvi.Name = "cmbIvi";
            this.cmbIvi.Size = new System.Drawing.Size(120, 29);
            this.cmbIvi.TabIndex = 2;
            this.cmbIvi.UseSelectable = true;
            // 
            // cmbNonExistent
            // 
            this.cmbNonExistent.FormattingEnabled = true;
            this.cmbNonExistent.ItemHeight = 23;
            this.cmbNonExistent.Location = new System.Drawing.Point(432, 153);
            this.cmbNonExistent.Name = "cmbNonExistent";
            this.cmbNonExistent.Size = new System.Drawing.Size(140, 29);
            this.cmbNonExistent.TabIndex = 2;
            this.cmbNonExistent.UseSelectable = true;
            // 
            // cmbSubcategory
            // 
            this.cmbSubcategory.FormattingEnabled = true;
            this.cmbSubcategory.ItemHeight = 23;
            this.cmbSubcategory.Location = new System.Drawing.Point(432, 104);
            this.cmbSubcategory.Name = "cmbSubcategory";
            this.cmbSubcategory.Size = new System.Drawing.Size(140, 29);
            this.cmbSubcategory.TabIndex = 2;
            this.cmbSubcategory.UseSelectable = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(432, 48);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(140, 29);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.UseSelectable = true;
            // 
            // txaDescription
            // 
            // 
            // 
            // 
            this.txaDescription.CustomButton.Image = null;
            this.txaDescription.CustomButton.Location = new System.Drawing.Point(113, 2);
            this.txaDescription.CustomButton.Name = "";
            this.txaDescription.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txaDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txaDescription.CustomButton.TabIndex = 1;
            this.txaDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txaDescription.CustomButton.UseSelectable = true;
            this.txaDescription.CustomButton.Visible = false;
            this.txaDescription.Lines = new string[0];
            this.txaDescription.Location = new System.Drawing.Point(52, 292);
            this.txaDescription.MaxLength = 32767;
            this.txaDescription.Multiline = true;
            this.txaDescription.Name = "txaDescription";
            this.txaDescription.PasswordChar = '\0';
            this.txaDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txaDescription.SelectedText = "";
            this.txaDescription.SelectionLength = 0;
            this.txaDescription.SelectionStart = 0;
            this.txaDescription.ShortcutsEnabled = true;
            this.txaDescription.Size = new System.Drawing.Size(201, 90);
            this.txaDescription.TabIndex = 1;
            this.txaDescription.UseSelectable = true;
            this.txaDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txaDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLowerPrice
            // 
            // 
            // 
            // 
            this.txtLowerPrice.CustomButton.Image = null;
            this.txtLowerPrice.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtLowerPrice.CustomButton.Name = "";
            this.txtLowerPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLowerPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLowerPrice.CustomButton.TabIndex = 1;
            this.txtLowerPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLowerPrice.CustomButton.UseSelectable = true;
            this.txtLowerPrice.CustomButton.Visible = false;
            this.txtLowerPrice.Lines = new string[0];
            this.txtLowerPrice.Location = new System.Drawing.Point(432, 358);
            this.txtLowerPrice.MaxLength = 32767;
            this.txtLowerPrice.Name = "txtLowerPrice";
            this.txtLowerPrice.PasswordChar = '\0';
            this.txtLowerPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLowerPrice.SelectedText = "";
            this.txtLowerPrice.SelectionLength = 0;
            this.txtLowerPrice.SelectionStart = 0;
            this.txtLowerPrice.ShortcutsEnabled = true;
            this.txtLowerPrice.Size = new System.Drawing.Size(140, 23);
            this.txtLowerPrice.TabIndex = 1;
            this.txtLowerPrice.UseSelectable = true;
            this.txtLowerPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLowerPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNormalPrice
            // 
            // 
            // 
            // 
            this.txtNormalPrice.CustomButton.Image = null;
            this.txtNormalPrice.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtNormalPrice.CustomButton.Name = "";
            this.txtNormalPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNormalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNormalPrice.CustomButton.TabIndex = 1;
            this.txtNormalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNormalPrice.CustomButton.UseSelectable = true;
            this.txtNormalPrice.CustomButton.Visible = false;
            this.txtNormalPrice.Lines = new string[0];
            this.txtNormalPrice.Location = new System.Drawing.Point(432, 310);
            this.txtNormalPrice.MaxLength = 32767;
            this.txtNormalPrice.Name = "txtNormalPrice";
            this.txtNormalPrice.PasswordChar = '\0';
            this.txtNormalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNormalPrice.SelectedText = "";
            this.txtNormalPrice.SelectionLength = 0;
            this.txtNormalPrice.SelectionStart = 0;
            this.txtNormalPrice.ShortcutsEnabled = true;
            this.txtNormalPrice.Size = new System.Drawing.Size(140, 23);
            this.txtNormalPrice.TabIndex = 1;
            this.txtNormalPrice.UseSelectable = true;
            this.txtNormalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNormalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEnterQuantity
            // 
            // 
            // 
            // 
            this.txtEnterQuantity.CustomButton.Image = null;
            this.txtEnterQuantity.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtEnterQuantity.CustomButton.Name = "";
            this.txtEnterQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnterQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnterQuantity.CustomButton.TabIndex = 1;
            this.txtEnterQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnterQuantity.CustomButton.UseSelectable = true;
            this.txtEnterQuantity.CustomButton.Visible = false;
            this.txtEnterQuantity.Lines = new string[0];
            this.txtEnterQuantity.Location = new System.Drawing.Point(432, 212);
            this.txtEnterQuantity.MaxLength = 32767;
            this.txtEnterQuantity.Name = "txtEnterQuantity";
            this.txtEnterQuantity.PasswordChar = '\0';
            this.txtEnterQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnterQuantity.SelectedText = "";
            this.txtEnterQuantity.SelectionLength = 0;
            this.txtEnterQuantity.SelectionStart = 0;
            this.txtEnterQuantity.ShortcutsEnabled = true;
            this.txtEnterQuantity.Size = new System.Drawing.Size(140, 23);
            this.txtEnterQuantity.TabIndex = 1;
            this.txtEnterQuantity.UseSelectable = true;
            this.txtEnterQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnterQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStyle
            // 
            // 
            // 
            // 
            this.txtStyle.CustomButton.Image = null;
            this.txtStyle.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtStyle.CustomButton.Name = "";
            this.txtStyle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStyle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStyle.CustomButton.TabIndex = 1;
            this.txtStyle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStyle.CustomButton.UseSelectable = true;
            this.txtStyle.CustomButton.Visible = false;
            this.txtStyle.Lines = new string[0];
            this.txtStyle.Location = new System.Drawing.Point(133, 104);
            this.txtStyle.MaxLength = 32767;
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.PasswordChar = '\0';
            this.txtStyle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStyle.SelectedText = "";
            this.txtStyle.SelectionLength = 0;
            this.txtStyle.SelectionStart = 0;
            this.txtStyle.ShortcutsEnabled = true;
            this.txtStyle.Size = new System.Drawing.Size(120, 23);
            this.txtStyle.TabIndex = 1;
            this.txtStyle.UseSelectable = true;
            this.txtStyle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStyle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(133, 54);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(120, 23);
            this.txtCode.TabIndex = 1;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(301, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Categoria:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(698, 26);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(53, 19);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "Imagen";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(301, 212);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(114, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Cantidad entrada:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(301, 159);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(118, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Factura Inexistente:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(301, 108);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(89, 19);
            this.metroLabel12.TabIndex = 0;
            this.metroLabel12.Text = "Subcategoria:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(52, 216);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "IVI:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(301, 310);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Precio unidad:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(301, 362);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 19);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Precio mínimo:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(52, 262);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Descripción";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(52, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Marca:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Estilo:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Código:";
            // 
            // txtSearchProduct
            // 
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(655, 479);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PromptText = "Ingrese texto a buscar";
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.ShowButton = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(208, 23);
            this.txtSearchProduct.TabIndex = 2;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMark = "Ingrese texto a buscar";
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ActiveControl = null;
            this.btnDeleteProduct.Location = new System.Drawing.Point(755, 750);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(108, 50);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseSelectable = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(83, 508);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(780, 236);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvProduct_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(301, 258);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(86, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "Cantidad fija:";
            // 
            // txtEstableQuantity
            // 
            // 
            // 
            // 
            this.txtEstableQuantity.CustomButton.Image = null;
            this.txtEstableQuantity.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.txtEstableQuantity.CustomButton.Name = "";
            this.txtEstableQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEstableQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEstableQuantity.CustomButton.TabIndex = 1;
            this.txtEstableQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstableQuantity.CustomButton.UseSelectable = true;
            this.txtEstableQuantity.CustomButton.Visible = false;
            this.txtEstableQuantity.Lines = new string[0];
            this.txtEstableQuantity.Location = new System.Drawing.Point(432, 258);
            this.txtEstableQuantity.MaxLength = 32767;
            this.txtEstableQuantity.Name = "txtEstableQuantity";
            this.txtEstableQuantity.PasswordChar = '\0';
            this.txtEstableQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstableQuantity.SelectedText = "";
            this.txtEstableQuantity.SelectionLength = 0;
            this.txtEstableQuantity.SelectionStart = 0;
            this.txtEstableQuantity.ShortcutsEnabled = true;
            this.txtEstableQuantity.Size = new System.Drawing.Size(140, 23);
            this.txtEstableQuantity.TabIndex = 1;
            this.txtEstableQuantity.UseSelectable = true;
            this.txtEstableQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEstableQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCleanProduct
            // 
            this.btnCleanProduct.ActiveControl = null;
            this.btnCleanProduct.Location = new System.Drawing.Point(83, 751);
            this.btnCleanProduct.Name = "btnCleanProduct";
            this.btnCleanProduct.Size = new System.Drawing.Size(108, 50);
            this.btnCleanProduct.TabIndex = 5;
            this.btnCleanProduct.Text = "Limpiar";
            this.btnCleanProduct.UseSelectable = true;
            this.btnCleanProduct.Click += new System.EventHandler(this.btnCleanProduct_Click);
            // 
            // UcProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnCleanProduct);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcProduct";
            this.Size = new System.Drawing.Size(955, 806);
            this.Load += new System.EventHandler(this.UcProduct_Load);
            this.Leave += new System.EventHandler(this.UcProduct_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btnUpdateProduct;
        private MetroFramework.Controls.MetroTile btnAddProduct;
        private System.Windows.Forms.PictureBox pbProduct;
        private MetroFramework.Controls.MetroComboBox cmbBrand;
        private MetroFramework.Controls.MetroComboBox cmbNonExistent;
        private MetroFramework.Controls.MetroComboBox cmbSubcategory;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroTextBox txaDescription;
        private MetroFramework.Controls.MetroTextBox txtLowerPrice;
        private MetroFramework.Controls.MetroTextBox txtNormalPrice;
        private MetroFramework.Controls.MetroTextBox txtEnterQuantity;
        private MetroFramework.Controls.MetroTextBox txtStyle;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroComboBox cmbIvi;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private MetroFramework.Controls.MetroTile btnDeleteProduct;
        private MetroFramework.Controls.MetroButton btnSelectImage;
        private MetroFramework.Controls.MetroGrid dgvProduct;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox txtEstableQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile btnCleanProduct;
    }
}
