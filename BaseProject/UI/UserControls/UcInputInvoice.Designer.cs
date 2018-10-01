﻿namespace UI.UserControls
{
    partial class UcInputInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.dateDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.providerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.totalPaymentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.dgvInputProduct = new MetroFramework.Controls.MetroGrid();
            this.brandTextBox = new MetroFramework.Controls.MetroTextBox();
            this.subcategoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.styleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ProviderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DestinyComboBox = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DestinyComboBox);
            this.groupBox1.Controls.Add(this.ProviderComboBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.dateDateTime);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.providerTextBox);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 101);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura de entrada de mercaderia";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(828, 64);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(747, 64);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 28;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dateDateTime
            // 
            this.dateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTime.Location = new System.Drawing.Point(718, 14);
            this.dateDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDateTime.Name = "dateDateTime";
            this.dateDateTime.Size = new System.Drawing.Size(194, 29);
            this.dateDateTime.TabIndex = 12;
            this.dateDateTime.Value = new System.DateTime(2018, 9, 26, 14, 53, 58, 0);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(669, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Fecha";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(338, 64);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(118, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Tienda Proveedor:";
            // 
            // providerTextBox
            // 
            // 
            // 
            // 
            this.providerTextBox.CustomButton.Image = null;
            this.providerTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.providerTextBox.CustomButton.Name = "";
            this.providerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.providerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.providerTextBox.CustomButton.TabIndex = 1;
            this.providerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.providerTextBox.CustomButton.UseSelectable = true;
            this.providerTextBox.CustomButton.Visible = false;
            this.providerTextBox.Lines = new string[0];
            this.providerTextBox.Location = new System.Drawing.Point(126, 23);
            this.providerTextBox.MaxLength = 32767;
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.PasswordChar = '\0';
            this.providerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.providerTextBox.SelectedText = "";
            this.providerTextBox.SelectionLength = 0;
            this.providerTextBox.SelectionStart = 0;
            this.providerTextBox.ShortcutsEnabled = true;
            this.providerTextBox.Size = new System.Drawing.Size(193, 23);
            this.providerTextBox.TabIndex = 16;
            this.providerTextBox.UseSelectable = true;
            this.providerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.providerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 24);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Employee";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(646, 509);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(85, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Total a Pagar";
            // 
            // totalPaymentTextBox
            // 
            // 
            // 
            // 
            this.totalPaymentTextBox.CustomButton.Image = null;
            this.totalPaymentTextBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.totalPaymentTextBox.CustomButton.Name = "";
            this.totalPaymentTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalPaymentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalPaymentTextBox.CustomButton.TabIndex = 1;
            this.totalPaymentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalPaymentTextBox.CustomButton.UseSelectable = true;
            this.totalPaymentTextBox.CustomButton.Visible = false;
            this.totalPaymentTextBox.Lines = new string[0];
            this.totalPaymentTextBox.Location = new System.Drawing.Point(737, 509);
            this.totalPaymentTextBox.MaxLength = 32767;
            this.totalPaymentTextBox.Name = "totalPaymentTextBox";
            this.totalPaymentTextBox.PasswordChar = '\0';
            this.totalPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalPaymentTextBox.SelectedText = "";
            this.totalPaymentTextBox.SelectionLength = 0;
            this.totalPaymentTextBox.SelectionStart = 0;
            this.totalPaymentTextBox.ShortcutsEnabled = true;
            this.totalPaymentTextBox.Size = new System.Drawing.Size(199, 23);
            this.totalPaymentTextBox.TabIndex = 24;
            this.totalPaymentTextBox.UseSelectable = true;
            this.totalPaymentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalPaymentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvInputProduct
            // 
            this.dgvInputProduct.AllowUserToResizeRows = false;
            this.dgvInputProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInputProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInputProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInputProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInputProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInputProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInputProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInputProduct.EnableHeadersVisualStyles = false;
            this.dgvInputProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInputProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInputProduct.Location = new System.Drawing.Point(18, 183);
            this.dgvInputProduct.Name = "dgvInputProduct";
            this.dgvInputProduct.ReadOnly = true;
            this.dgvInputProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInputProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInputProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInputProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInputProduct.Size = new System.Drawing.Size(918, 320);
            this.dgvInputProduct.TabIndex = 30;
            // 
            // brandTextBox
            // 
            // 
            // 
            // 
            this.brandTextBox.CustomButton.Image = null;
            this.brandTextBox.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.brandTextBox.CustomButton.Name = "";
            this.brandTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandTextBox.CustomButton.TabIndex = 1;
            this.brandTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandTextBox.CustomButton.UseSelectable = true;
            this.brandTextBox.CustomButton.Visible = false;
            this.brandTextBox.Lines = new string[0];
            this.brandTextBox.Location = new System.Drawing.Point(549, 154);
            this.brandTextBox.MaxLength = 32767;
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.PasswordChar = '\0';
            this.brandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandTextBox.SelectedText = "";
            this.brandTextBox.SelectionLength = 0;
            this.brandTextBox.SelectionStart = 0;
            this.brandTextBox.ShortcutsEnabled = true;
            this.brandTextBox.Size = new System.Drawing.Size(81, 23);
            this.brandTextBox.TabIndex = 51;
            this.brandTextBox.UseSelectable = true;
            this.brandTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.brandTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.brandTextBox_KeyUp);
            // 
            // subcategoryTextBox
            // 
            // 
            // 
            // 
            this.subcategoryTextBox.CustomButton.Image = null;
            this.subcategoryTextBox.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.subcategoryTextBox.CustomButton.Name = "";
            this.subcategoryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subcategoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subcategoryTextBox.CustomButton.TabIndex = 1;
            this.subcategoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subcategoryTextBox.CustomButton.UseSelectable = true;
            this.subcategoryTextBox.CustomButton.Visible = false;
            this.subcategoryTextBox.Lines = new string[0];
            this.subcategoryTextBox.Location = new System.Drawing.Point(655, 154);
            this.subcategoryTextBox.MaxLength = 32767;
            this.subcategoryTextBox.Name = "subcategoryTextBox";
            this.subcategoryTextBox.PasswordChar = '\0';
            this.subcategoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subcategoryTextBox.SelectedText = "";
            this.subcategoryTextBox.SelectionLength = 0;
            this.subcategoryTextBox.SelectionStart = 0;
            this.subcategoryTextBox.ShortcutsEnabled = true;
            this.subcategoryTextBox.Size = new System.Drawing.Size(122, 23);
            this.subcategoryTextBox.TabIndex = 52;
            this.subcategoryTextBox.UseSelectable = true;
            this.subcategoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subcategoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.subcategoryTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.subcategoryTextBox_KeyUp);
            // 
            // styleTextBox
            // 
            // 
            // 
            // 
            this.styleTextBox.CustomButton.Image = null;
            this.styleTextBox.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.styleTextBox.CustomButton.Name = "";
            this.styleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.styleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.styleTextBox.CustomButton.TabIndex = 1;
            this.styleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.styleTextBox.CustomButton.UseSelectable = true;
            this.styleTextBox.CustomButton.Visible = false;
            this.styleTextBox.Lines = new string[0];
            this.styleTextBox.Location = new System.Drawing.Point(411, 154);
            this.styleTextBox.MaxLength = 32767;
            this.styleTextBox.Name = "styleTextBox";
            this.styleTextBox.PasswordChar = '\0';
            this.styleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.styleTextBox.SelectedText = "";
            this.styleTextBox.SelectionLength = 0;
            this.styleTextBox.SelectionStart = 0;
            this.styleTextBox.ShortcutsEnabled = true;
            this.styleTextBox.Size = new System.Drawing.Size(115, 23);
            this.styleTextBox.TabIndex = 53;
            this.styleTextBox.UseSelectable = true;
            this.styleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.styleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.styleTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.styleTextBox_KeyUp);
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(186, 154);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(203, 23);
            this.descriptionTextBox.TabIndex = 54;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.descriptionTextBox_KeyUp);
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(19, 154);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(145, 23);
            this.codeTextBox.TabIndex = 55;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.codeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeTextBox_KeyUp);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(549, 132);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(46, 19);
            this.metroLabel18.TabIndex = 46;
            this.metroLabel18.Text = "Marca";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(186, 132);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(76, 19);
            this.metroLabel15.TabIndex = 47;
            this.metroLabel15.Text = "Descripción";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(655, 132);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(86, 19);
            this.metroLabel17.TabIndex = 48;
            this.metroLabel17.Text = "Subcategoria";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(19, 132);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(53, 19);
            this.metroLabel10.TabIndex = 49;
            this.metroLabel10.Text = "Código";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(411, 132);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 19);
            this.metroLabel11.TabIndex = 50;
            this.metroLabel11.Text = "Estilo";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(793, 136);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 33);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Agregar Nuevo";
            this.metroButton1.UseSelectable = true;
            // 
            // ProviderComboBox
            // 
            this.ProviderComboBox.FormattingEnabled = true;
            this.ProviderComboBox.ItemHeight = 23;
            this.ProviderComboBox.Location = new System.Drawing.Point(462, 58);
            this.ProviderComboBox.Name = "ProviderComboBox";
            this.ProviderComboBox.Size = new System.Drawing.Size(193, 29);
            this.ProviderComboBox.TabIndex = 30;
            this.ProviderComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Tienda Destino:";
            // 
            // DestinyComboBox
            // 
            this.DestinyComboBox.FormattingEnabled = true;
            this.DestinyComboBox.ItemHeight = 23;
            this.DestinyComboBox.Location = new System.Drawing.Point(126, 58);
            this.DestinyComboBox.Name = "DestinyComboBox";
            this.DestinyComboBox.Size = new System.Drawing.Size(193, 29);
            this.DestinyComboBox.TabIndex = 30;
            this.DestinyComboBox.UseSelectable = true;
            // 
            // UcInputInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.subcategoryTextBox);
            this.Controls.Add(this.styleTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dgvInputProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalPaymentTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcInputInvoice";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcInputInvoice_Load);
            this.Leave += new System.EventHandler(this.UcInputInvoice_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dateDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox providerTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox totalPaymentTextBox;
        private MetroFramework.Controls.MetroGrid dgvInputProduct;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox brandTextBox;
        private MetroFramework.Controls.MetroTextBox subcategoryTextBox;
        private MetroFramework.Controls.MetroTextBox styleTextBox;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox DestinyComboBox;
        private MetroFramework.Controls.MetroComboBox ProviderComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
