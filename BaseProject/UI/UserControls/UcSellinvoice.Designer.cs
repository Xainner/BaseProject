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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCleanInvoice = new MetroFramework.Controls.MetroTile();
            this.btnGenerateInvoice = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalPay = new MetroFramework.Controls.MetroTextBox();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtPayment = new MetroFramework.Controls.MetroTextBox();
            this.txtTypeChange = new MetroFramework.Controls.MetroTextBox();
            this.txtClient = new MetroFramework.Controls.MetroTextBox();
            this.txtEmployee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.cmbTypePayment = new MetroFramework.Controls.MetroComboBox();
            this.cmbTypeCoin = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtDaxes = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTypeCoin);
            this.groupBox1.Controls.Add(this.cmbTypePayment);
            this.groupBox1.Controls.Add(this.metroGrid1);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.btnCleanInvoice);
            this.groupBox1.Controls.Add(this.btnGenerateInvoice);
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtTotalPay);
            this.groupBox1.Controls.Add(this.txtDaxes);
            this.groupBox1.Controls.Add(this.txtSubtotal);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtPayment);
            this.groupBox1.Controls.Add(this.txtTypeChange);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.txtEmployee);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 645);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la Factura";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(373, 118);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(497, 431);
            this.metroGrid1.TabIndex = 23;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Árticulo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Acción";
            this.Column6.Name = "Column6";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(373, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Tienda Kyrios";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(329, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(178, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "San Jóse, San Pedro, Calle 14";
            // 
            // btnCleanInvoice
            // 
            this.btnCleanInvoice.ActiveControl = null;
            this.btnCleanInvoice.Location = new System.Drawing.Point(591, 577);
            this.btnCleanInvoice.Name = "btnCleanInvoice";
            this.btnCleanInvoice.Size = new System.Drawing.Size(124, 42);
            this.btnCleanInvoice.TabIndex = 22;
            this.btnCleanInvoice.Text = "Limpiar";
            this.btnCleanInvoice.UseSelectable = true;
            this.btnCleanInvoice.Click += new System.EventHandler(this.btnCleanInvoice_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.ActiveControl = null;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(746, 577);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(124, 42);
            this.btnGenerateInvoice.TabIndex = 22;
            this.btnGenerateInvoice.Text = "Generar Factura";
            this.btnGenerateInvoice.UseSelectable = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(733, 57);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(137, 38);
            this.metroTile1.TabIndex = 22;
            this.metroTile1.Text = "Agregar Productos";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(318, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(203, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Cédula Juridica: 1-1321561-651681";
            // 
            // txtTotalPay
            // 
            // 
            // 
            // 
            this.txtTotalPay.CustomButton.Image = null;
            this.txtTotalPay.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtTotalPay.CustomButton.Name = "";
            this.txtTotalPay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPay.CustomButton.TabIndex = 1;
            this.txtTotalPay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPay.CustomButton.UseSelectable = true;
            this.txtTotalPay.CustomButton.Visible = false;
            this.txtTotalPay.Lines = new string[0];
            this.txtTotalPay.Location = new System.Drawing.Point(130, 563);
            this.txtTotalPay.MaxLength = 32767;
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.PasswordChar = '\0';
            this.txtTotalPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPay.SelectedText = "";
            this.txtTotalPay.SelectionLength = 0;
            this.txtTotalPay.SelectionStart = 0;
            this.txtTotalPay.ShortcutsEnabled = true;
            this.txtTotalPay.Size = new System.Drawing.Size(193, 23);
            this.txtTotalPay.TabIndex = 16;
            this.txtTotalPay.UseSelectable = true;
            this.txtTotalPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubtotal
            // 
            // 
            // 
            // 
            this.txtSubtotal.CustomButton.Image = null;
            this.txtSubtotal.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSubtotal.CustomButton.Name = "";
            this.txtSubtotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtotal.CustomButton.TabIndex = 1;
            this.txtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtotal.CustomButton.UseSelectable = true;
            this.txtSubtotal.CustomButton.Visible = false;
            this.txtSubtotal.Lines = new string[0];
            this.txtSubtotal.Location = new System.Drawing.Point(130, 516);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(193, 23);
            this.txtSubtotal.TabIndex = 16;
            this.txtSubtotal.UseSelectable = true;
            this.txtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(130, 431);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(193, 23);
            this.txtDiscount.TabIndex = 16;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPayment
            // 
            // 
            // 
            // 
            this.txtPayment.CustomButton.Image = null;
            this.txtPayment.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtPayment.CustomButton.Name = "";
            this.txtPayment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayment.CustomButton.TabIndex = 1;
            this.txtPayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayment.CustomButton.UseSelectable = true;
            this.txtPayment.CustomButton.Visible = false;
            this.txtPayment.Lines = new string[0];
            this.txtPayment.Location = new System.Drawing.Point(130, 382);
            this.txtPayment.MaxLength = 32767;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayment.SelectedText = "";
            this.txtPayment.SelectionLength = 0;
            this.txtPayment.SelectionStart = 0;
            this.txtPayment.ShortcutsEnabled = true;
            this.txtPayment.Size = new System.Drawing.Size(193, 23);
            this.txtPayment.TabIndex = 16;
            this.txtPayment.UseSelectable = true;
            this.txtPayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTypeChange
            // 
            // 
            // 
            // 
            this.txtTypeChange.CustomButton.Image = null;
            this.txtTypeChange.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtTypeChange.CustomButton.Name = "";
            this.txtTypeChange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTypeChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTypeChange.CustomButton.TabIndex = 1;
            this.txtTypeChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTypeChange.CustomButton.UseSelectable = true;
            this.txtTypeChange.CustomButton.Visible = false;
            this.txtTypeChange.Lines = new string[0];
            this.txtTypeChange.Location = new System.Drawing.Point(130, 335);
            this.txtTypeChange.MaxLength = 32767;
            this.txtTypeChange.Name = "txtTypeChange";
            this.txtTypeChange.PasswordChar = '\0';
            this.txtTypeChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTypeChange.SelectedText = "";
            this.txtTypeChange.SelectionLength = 0;
            this.txtTypeChange.SelectionStart = 0;
            this.txtTypeChange.ShortcutsEnabled = true;
            this.txtTypeChange.Size = new System.Drawing.Size(193, 23);
            this.txtTypeChange.TabIndex = 16;
            this.txtTypeChange.UseSelectable = true;
            this.txtTypeChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTypeChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtClient.Location = new System.Drawing.Point(130, 201);
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
            this.txtEmployee.Location = new System.Drawing.Point(130, 158);
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
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(29, 567);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(90, 19);
            this.metroLabel14.TabIndex = 14;
            this.metroLabel14.Text = "Total a pagar:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(29, 516);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(60, 19);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Subtotal:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(29, 435);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Descuento:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(28, 339);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(86, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "Tipo cambio:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(28, 289);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(91, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Tipo modena:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(29, 245);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = "Tipo Pago:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(28, 382);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Efectivo pago:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(29, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Cliente:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(29, 158);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Empleado:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(29, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Usuario:";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(130, 118);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(193, 23);
            this.txtUser.TabIndex = 18;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTypePayment
            // 
            this.cmbTypePayment.FormattingEnabled = true;
            this.cmbTypePayment.ItemHeight = 23;
            this.cmbTypePayment.Location = new System.Drawing.Point(130, 245);
            this.cmbTypePayment.Name = "cmbTypePayment";
            this.cmbTypePayment.Size = new System.Drawing.Size(193, 29);
            this.cmbTypePayment.TabIndex = 24;
            this.cmbTypePayment.UseSelectable = true;
            // 
            // cmbTypeCoin
            // 
            this.cmbTypeCoin.FormattingEnabled = true;
            this.cmbTypeCoin.ItemHeight = 23;
            this.cmbTypeCoin.Location = new System.Drawing.Point(130, 289);
            this.cmbTypeCoin.Name = "cmbTypeCoin";
            this.cmbTypeCoin.Size = new System.Drawing.Size(193, 29);
            this.cmbTypeCoin.TabIndex = 24;
            this.cmbTypeCoin.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(29, 476);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Impuestos:";
            // 
            // txtDaxes
            // 
            // 
            // 
            // 
            this.txtDaxes.CustomButton.Image = null;
            this.txtDaxes.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtDaxes.CustomButton.Name = "";
            this.txtDaxes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDaxes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDaxes.CustomButton.TabIndex = 1;
            this.txtDaxes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDaxes.CustomButton.UseSelectable = true;
            this.txtDaxes.CustomButton.Visible = false;
            this.txtDaxes.Lines = new string[0];
            this.txtDaxes.Location = new System.Drawing.Point(130, 476);
            this.txtDaxes.MaxLength = 32767;
            this.txtDaxes.Name = "txtDaxes";
            this.txtDaxes.PasswordChar = '\0';
            this.txtDaxes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDaxes.SelectedText = "";
            this.txtDaxes.SelectionLength = 0;
            this.txtDaxes.SelectionStart = 0;
            this.txtDaxes.ShortcutsEnabled = true;
            this.txtDaxes.Size = new System.Drawing.Size(193, 23);
            this.txtDaxes.TabIndex = 16;
            this.txtDaxes.UseSelectable = true;
            this.txtDaxes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDaxes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UcSellinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcSellinvoice";
            this.Size = new System.Drawing.Size(955, 705);
            this.Load += new System.EventHandler(this.UcSellinvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtTotalPay;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroTextBox txtPayment;
        private MetroFramework.Controls.MetroTextBox txtClient;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MetroFramework.Controls.MetroTile btnGenerateInvoice;
        private MetroFramework.Controls.MetroTextBox txtTypeChange;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTile btnCleanInvoice;
        private MetroFramework.Controls.MetroComboBox cmbTypeCoin;
        private MetroFramework.Controls.MetroComboBox cmbTypePayment;
        private MetroFramework.Controls.MetroTextBox txtDaxes;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
