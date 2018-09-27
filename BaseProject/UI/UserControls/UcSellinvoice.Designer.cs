namespace UI.UserControls
{
    partial class UcSellinvoice
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
            this.addProductButton = new MetroFramework.Controls.MetroButton();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbTypeCoin = new MetroFramework.Controls.MetroComboBox();
            this.productsGridView = new MetroFramework.Controls.MetroGrid();
            this.discountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.taxesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.amountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.quantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.priceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.descriptionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.txtClient = new MetroFramework.Controls.MetroTextBox();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.txtEmployee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNumInvoice = new MetroFramework.Controls.MetroTextBox();
            this.previewInvoiceButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.previewInvoiceButton);
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.productsGridView);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(this.taxesTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.txtEmployee);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel18);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.metroLabel17);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtNumInvoice);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 569);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la Factura";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(875, 142);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(37, 23);
            this.addProductButton.TabIndex = 28;
            this.addProductButton.Text = "+";
            this.addProductButton.UseSelectable = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(837, 70);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.Text = "Limpiar";
            this.ClearButton.UseSelectable = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.cmbTypeCoin);
            this.groupBox3.Location = new System.Drawing.Point(379, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 82);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formas de pago";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(22, 34);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(91, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Tipo modena:";
            // 
            // cmbTypeCoin
            // 
            this.cmbTypeCoin.FormattingEnabled = true;
            this.cmbTypeCoin.ItemHeight = 23;
            this.cmbTypeCoin.Location = new System.Drawing.Point(119, 34);
            this.cmbTypeCoin.Name = "cmbTypeCoin";
            this.cmbTypeCoin.Size = new System.Drawing.Size(168, 29);
            this.cmbTypeCoin.TabIndex = 24;
            this.cmbTypeCoin.UseSelectable = true;
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsGridView.EnableHeadersVisualStyles = false;
            this.productsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGridView.Location = new System.Drawing.Point(23, 182);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(885, 349);
            this.productsGridView.TabIndex = 23;
            this.productsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellEndEdit);
            // 
            // discountTextBox
            // 
            // 
            // 
            // 
            this.discountTextBox.CustomButton.Image = null;
            this.discountTextBox.CustomButton.Location = new System.Drawing.Point(48, 1);
            this.discountTextBox.CustomButton.Name = "";
            this.discountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.discountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.discountTextBox.CustomButton.TabIndex = 1;
            this.discountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.discountTextBox.CustomButton.UseSelectable = true;
            this.discountTextBox.CustomButton.Visible = false;
            this.discountTextBox.Lines = new string[0];
            this.discountTextBox.Location = new System.Drawing.Point(369, 142);
            this.discountTextBox.MaxLength = 32767;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.PasswordChar = '\0';
            this.discountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.discountTextBox.SelectedText = "";
            this.discountTextBox.SelectionLength = 0;
            this.discountTextBox.SelectionStart = 0;
            this.discountTextBox.ShortcutsEnabled = true;
            this.discountTextBox.Size = new System.Drawing.Size(70, 23);
            this.discountTextBox.TabIndex = 16;
            this.discountTextBox.UseSelectable = true;
            this.discountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.discountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // taxesTextBox
            // 
            // 
            // 
            // 
            this.taxesTextBox.CustomButton.Image = null;
            this.taxesTextBox.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.taxesTextBox.CustomButton.Name = "";
            this.taxesTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.taxesTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.taxesTextBox.CustomButton.TabIndex = 1;
            this.taxesTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.taxesTextBox.CustomButton.UseSelectable = true;
            this.taxesTextBox.CustomButton.Visible = false;
            this.taxesTextBox.Lines = new string[0];
            this.taxesTextBox.Location = new System.Drawing.Point(781, 142);
            this.taxesTextBox.MaxLength = 32767;
            this.taxesTextBox.Name = "taxesTextBox";
            this.taxesTextBox.PasswordChar = '\0';
            this.taxesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.taxesTextBox.SelectedText = "";
            this.taxesTextBox.SelectionLength = 0;
            this.taxesTextBox.SelectionStart = 0;
            this.taxesTextBox.ShortcutsEnabled = true;
            this.taxesTextBox.Size = new System.Drawing.Size(88, 23);
            this.taxesTextBox.TabIndex = 16;
            this.taxesTextBox.UseSelectable = true;
            this.taxesTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.taxesTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // amountTextBox
            // 
            // 
            // 
            // 
            this.amountTextBox.CustomButton.Image = null;
            this.amountTextBox.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.amountTextBox.CustomButton.Name = "";
            this.amountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTextBox.CustomButton.TabIndex = 1;
            this.amountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTextBox.CustomButton.UseSelectable = true;
            this.amountTextBox.CustomButton.Visible = false;
            this.amountTextBox.Lines = new string[0];
            this.amountTextBox.Location = new System.Drawing.Point(672, 142);
            this.amountTextBox.MaxLength = 32767;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.PasswordChar = '\0';
            this.amountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTextBox.SelectedText = "";
            this.amountTextBox.SelectionLength = 0;
            this.amountTextBox.SelectionStart = 0;
            this.amountTextBox.ShortcutsEnabled = true;
            this.amountTextBox.Size = new System.Drawing.Size(81, 23);
            this.amountTextBox.TabIndex = 16;
            this.amountTextBox.UseSelectable = true;
            this.amountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // quantityTextBox
            // 
            // 
            // 
            // 
            this.quantityTextBox.CustomButton.Image = null;
            this.quantityTextBox.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.quantityTextBox.CustomButton.Name = "";
            this.quantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityTextBox.CustomButton.TabIndex = 1;
            this.quantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityTextBox.CustomButton.UseSelectable = true;
            this.quantityTextBox.CustomButton.Visible = false;
            this.quantityTextBox.Lines = new string[0];
            this.quantityTextBox.Location = new System.Drawing.Point(561, 142);
            this.quantityTextBox.MaxLength = 32767;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.SelectionLength = 0;
            this.quantityTextBox.SelectionStart = 0;
            this.quantityTextBox.ShortcutsEnabled = true;
            this.quantityTextBox.Size = new System.Drawing.Size(81, 23);
            this.quantityTextBox.TabIndex = 16;
            this.quantityTextBox.UseSelectable = true;
            this.quantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.CustomButton.Image = null;
            this.priceTextBox.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.priceTextBox.CustomButton.Name = "";
            this.priceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.priceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceTextBox.CustomButton.TabIndex = 1;
            this.priceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceTextBox.CustomButton.UseSelectable = true;
            this.priceTextBox.CustomButton.Visible = false;
            this.priceTextBox.Lines = new string[0];
            this.priceTextBox.Location = new System.Drawing.Point(460, 142);
            this.priceTextBox.MaxLength = 32767;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.SelectionLength = 0;
            this.priceTextBox.SelectionStart = 0;
            this.priceTextBox.ShortcutsEnabled = true;
            this.priceTextBox.Size = new System.Drawing.Size(81, 23);
            this.priceTextBox.TabIndex = 16;
            this.priceTextBox.UseSelectable = true;
            this.priceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionTextBox
            // 
            // 
            // 
            // 
            this.descriptionTextBox.CustomButton.Image = null;
            this.descriptionTextBox.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.descriptionTextBox.CustomButton.Name = "";
            this.descriptionTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptionTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTextBox.CustomButton.TabIndex = 1;
            this.descriptionTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTextBox.CustomButton.UseSelectable = true;
            this.descriptionTextBox.CustomButton.Visible = false;
            this.descriptionTextBox.Lines = new string[0];
            this.descriptionTextBox.Location = new System.Drawing.Point(170, 142);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(186, 23);
            this.descriptionTextBox.TabIndex = 16;
            this.descriptionTextBox.UseSelectable = true;
            this.descriptionTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClient
            // 
            // 
            // 
            // 
            this.txtClient.CustomButton.Image = null;
            this.txtClient.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtClient.CustomButton.Name = "";
            this.txtClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClient.CustomButton.TabIndex = 1;
            this.txtClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClient.CustomButton.UseSelectable = true;
            this.txtClient.CustomButton.Visible = false;
            this.txtClient.Lines = new string[0];
            this.txtClient.Location = new System.Drawing.Point(127, 70);
            this.txtClient.MaxLength = 32767;
            this.txtClient.Name = "txtClient";
            this.txtClient.PasswordChar = '\0';
            this.txtClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClient.SelectedText = "";
            this.txtClient.SelectionLength = 0;
            this.txtClient.SelectionStart = 0;
            this.txtClient.ShortcutsEnabled = true;
            this.txtClient.Size = new System.Drawing.Size(193, 23);
            this.txtClient.TabIndex = 16;
            this.txtClient.UseSelectable = true;
            this.txtClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(18, 142);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(130, 23);
            this.codeTextBox.TabIndex = 16;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.codeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeTextBox_KeyUp);
            // 
            // txtEmployee
            // 
            // 
            // 
            // 
            this.txtEmployee.CustomButton.Image = null;
            this.txtEmployee.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtEmployee.CustomButton.Name = "";
            this.txtEmployee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployee.CustomButton.TabIndex = 1;
            this.txtEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployee.CustomButton.UseSelectable = true;
            this.txtEmployee.CustomButton.Visible = false;
            this.txtEmployee.Lines = new string[0];
            this.txtEmployee.Location = new System.Drawing.Point(127, 25);
            this.txtEmployee.MaxLength = 32767;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.PasswordChar = '\0';
            this.txtEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployee.SelectedText = "";
            this.txtEmployee.SelectionLength = 0;
            this.txtEmployee.SelectionStart = 0;
            this.txtEmployee.ShortcutsEnabled = true;
            this.txtEmployee.Size = new System.Drawing.Size(193, 23);
            this.txtEmployee.TabIndex = 16;
            this.txtEmployee.UseSelectable = true;
            this.txtEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(781, 111);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(23, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "IV:";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(459, 111);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(49, 19);
            this.metroLabel18.TabIndex = 14;
            this.metroLabel18.Text = "Precio:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(170, 111);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(79, 19);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "Descripción:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(369, 111);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(39, 19);
            this.metroLabel17.TabIndex = 14;
            this.metroLabel17.Text = "Desc.";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 111);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Código:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(672, 111);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(51, 19);
            this.metroLabel16.TabIndex = 14;
            this.metroLabel16.Text = "Monto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(561, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Cantidad:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Cliente:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Vendedor:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(707, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Num Fact.:";
            // 
            // txtNumInvoice
            // 
            // 
            // 
            // 
            this.txtNumInvoice.CustomButton.Image = null;
            this.txtNumInvoice.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtNumInvoice.CustomButton.Name = "";
            this.txtNumInvoice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumInvoice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumInvoice.CustomButton.TabIndex = 1;
            this.txtNumInvoice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumInvoice.CustomButton.UseSelectable = true;
            this.txtNumInvoice.CustomButton.Visible = false;
            this.txtNumInvoice.Lines = new string[0];
            this.txtNumInvoice.Location = new System.Drawing.Point(787, 30);
            this.txtNumInvoice.MaxLength = 32767;
            this.txtNumInvoice.Name = "txtNumInvoice";
            this.txtNumInvoice.PasswordChar = '\0';
            this.txtNumInvoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumInvoice.SelectedText = "";
            this.txtNumInvoice.SelectionLength = 0;
            this.txtNumInvoice.SelectionStart = 0;
            this.txtNumInvoice.ShortcutsEnabled = true;
            this.txtNumInvoice.Size = new System.Drawing.Size(117, 23);
            this.txtNumInvoice.TabIndex = 18;
            this.txtNumInvoice.UseSelectable = true;
            this.txtNumInvoice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumInvoice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // previewInvoiceButton
            // 
            this.previewInvoiceButton.Location = new System.Drawing.Point(787, 537);
            this.previewInvoiceButton.Name = "previewInvoiceButton";
            this.previewInvoiceButton.Size = new System.Drawing.Size(121, 23);
            this.previewInvoiceButton.TabIndex = 29;
            this.previewInvoiceButton.Text = "Previsualizar factura";
            this.previewInvoiceButton.UseSelectable = true;
            this.previewInvoiceButton.Click += new System.EventHandler(this.previewInvoiceButton_Click);
            // 
            // UcSellinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcSellinvoice";
            this.Size = new System.Drawing.Size(955, 592);
            this.Load += new System.EventHandler(this.UcSellinvoice_Load);
            this.Leave += new System.EventHandler(this.UcSellinvoice_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNumInvoice;
        private MetroFramework.Controls.MetroGrid productsGridView;
        private MetroFramework.Controls.MetroTextBox txtClient;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbTypeCoin;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox discountTextBox;
        private MetroFramework.Controls.MetroTextBox taxesTextBox;
        private MetroFramework.Controls.MetroTextBox amountTextBox;
        private MetroFramework.Controls.MetroTextBox quantityTextBox;
        private MetroFramework.Controls.MetroTextBox priceTextBox;
        private MetroFramework.Controls.MetroTextBox descriptionTextBox;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton ClearButton;
        private MetroFramework.Controls.MetroButton addProductButton;
        private MetroFramework.Controls.MetroButton previewInvoiceButton;
    }
}
