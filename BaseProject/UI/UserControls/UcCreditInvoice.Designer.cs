namespace UI.UserControls
{
    partial class UcCreditInvoice
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInflation = new MetroFramework.Controls.MetroTextBox();
            this.txtCardDeposit = new MetroFramework.Controls.MetroTextBox();
            this.txtCashDeposit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtAmountOfDues = new MetroFramework.Controls.MetroTextBox();
            this.txtInterest = new MetroFramework.Controls.MetroTextBox();
            this.txtRange = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.dgvCreditInvoice = new MetroFramework.Controls.MetroGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCleanCreditInvoice = new MetroFramework.Controls.MetroTile();
            this.btnGenerateInvoice = new MetroFramework.Controls.MetroTile();
            this.btnAddProduct = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbTypeCoin = new MetroFramework.Controls.MetroComboBox();
            this.cmbTypePayment = new MetroFramework.Controls.MetroComboBox();
            this.txtTotalPay = new MetroFramework.Controls.MetroTextBox();
            this.txtDaxes = new MetroFramework.Controls.MetroTextBox();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtPayment = new MetroFramework.Controls.MetroTextBox();
            this.txtTypeChange = new MetroFramework.Controls.MetroTextBox();
            this.txtClient = new MetroFramework.Controls.MetroTextBox();
            this.txtEmployee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTypeCoin);
            this.groupBox1.Controls.Add(this.cmbTypePayment);
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvCreditInvoice);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.btnCleanCreditInvoice);
            this.groupBox1.Controls.Add(this.btnGenerateInvoice);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 794);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la Factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInflation);
            this.groupBox2.Controls.Add(this.txtCardDeposit);
            this.groupBox2.Controls.Add(this.txtCashDeposit);
            this.groupBox2.Controls.Add(this.metroLabel18);
            this.groupBox2.Controls.Add(this.metroLabel19);
            this.groupBox2.Controls.Add(this.metroLabel20);
            this.groupBox2.Controls.Add(this.txtAmountOfDues);
            this.groupBox2.Controls.Add(this.txtInterest);
            this.groupBox2.Controls.Add(this.txtRange);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.metroLabel17);
            this.groupBox2.Location = new System.Drawing.Point(45, 622);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 154);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Credito";
            // 
            // txtInflation
            // 
            // 
            // 
            // 
            this.txtInflation.CustomButton.Image = null;
            this.txtInflation.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtInflation.CustomButton.Name = "";
            this.txtInflation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInflation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInflation.CustomButton.TabIndex = 1;
            this.txtInflation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInflation.CustomButton.UseSelectable = true;
            this.txtInflation.CustomButton.Visible = false;
            this.txtInflation.Lines = new string[0];
            this.txtInflation.Location = new System.Drawing.Point(469, 117);
            this.txtInflation.MaxLength = 32767;
            this.txtInflation.Name = "txtInflation";
            this.txtInflation.PasswordChar = '\0';
            this.txtInflation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInflation.SelectedText = "";
            this.txtInflation.SelectionLength = 0;
            this.txtInflation.SelectionStart = 0;
            this.txtInflation.ShortcutsEnabled = true;
            this.txtInflation.Size = new System.Drawing.Size(193, 23);
            this.txtInflation.TabIndex = 26;
            this.txtInflation.UseSelectable = true;
            this.txtInflation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInflation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCardDeposit
            // 
            // 
            // 
            // 
            this.txtCardDeposit.CustomButton.Image = null;
            this.txtCardDeposit.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtCardDeposit.CustomButton.Name = "";
            this.txtCardDeposit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCardDeposit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCardDeposit.CustomButton.TabIndex = 1;
            this.txtCardDeposit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCardDeposit.CustomButton.UseSelectable = true;
            this.txtCardDeposit.CustomButton.Visible = false;
            this.txtCardDeposit.Lines = new string[0];
            this.txtCardDeposit.Location = new System.Drawing.Point(469, 70);
            this.txtCardDeposit.MaxLength = 32767;
            this.txtCardDeposit.Name = "txtCardDeposit";
            this.txtCardDeposit.PasswordChar = '\0';
            this.txtCardDeposit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardDeposit.SelectedText = "";
            this.txtCardDeposit.SelectionLength = 0;
            this.txtCardDeposit.SelectionStart = 0;
            this.txtCardDeposit.ShortcutsEnabled = true;
            this.txtCardDeposit.Size = new System.Drawing.Size(193, 23);
            this.txtCardDeposit.TabIndex = 27;
            this.txtCardDeposit.UseSelectable = true;
            this.txtCardDeposit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCardDeposit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCashDeposit
            // 
            // 
            // 
            // 
            this.txtCashDeposit.CustomButton.Image = null;
            this.txtCashDeposit.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtCashDeposit.CustomButton.Name = "";
            this.txtCashDeposit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCashDeposit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashDeposit.CustomButton.TabIndex = 1;
            this.txtCashDeposit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashDeposit.CustomButton.UseSelectable = true;
            this.txtCashDeposit.CustomButton.Visible = false;
            this.txtCashDeposit.Lines = new string[0];
            this.txtCashDeposit.Location = new System.Drawing.Point(469, 19);
            this.txtCashDeposit.MaxLength = 32767;
            this.txtCashDeposit.Name = "txtCashDeposit";
            this.txtCashDeposit.PasswordChar = '\0';
            this.txtCashDeposit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashDeposit.SelectedText = "";
            this.txtCashDeposit.SelectionLength = 0;
            this.txtCashDeposit.SelectionStart = 0;
            this.txtCashDeposit.ShortcutsEnabled = true;
            this.txtCashDeposit.Size = new System.Drawing.Size(193, 23);
            this.txtCashDeposit.TabIndex = 28;
            this.txtCashDeposit.UseSelectable = true;
            this.txtCashDeposit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCashDeposit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(344, 118);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(114, 19);
            this.metroLabel18.TabIndex = 23;
            this.metroLabel18.Text = "Inflacion Intereses:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(344, 67);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(97, 19);
            this.metroLabel19.TabIndex = 24;
            this.metroLabel19.Text = "Abono credito:";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(344, 20);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(101, 19);
            this.metroLabel20.TabIndex = 25;
            this.metroLabel20.Text = "Abono efectivo:";
            // 
            // txtAmountOfDues
            // 
            // 
            // 
            // 
            this.txtAmountOfDues.CustomButton.Image = null;
            this.txtAmountOfDues.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtAmountOfDues.CustomButton.Name = "";
            this.txtAmountOfDues.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmountOfDues.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountOfDues.CustomButton.TabIndex = 1;
            this.txtAmountOfDues.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountOfDues.CustomButton.UseSelectable = true;
            this.txtAmountOfDues.CustomButton.Visible = false;
            this.txtAmountOfDues.Lines = new string[0];
            this.txtAmountOfDues.Location = new System.Drawing.Point(114, 114);
            this.txtAmountOfDues.MaxLength = 32767;
            this.txtAmountOfDues.Name = "txtAmountOfDues";
            this.txtAmountOfDues.PasswordChar = '\0';
            this.txtAmountOfDues.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountOfDues.SelectedText = "";
            this.txtAmountOfDues.SelectionLength = 0;
            this.txtAmountOfDues.SelectionStart = 0;
            this.txtAmountOfDues.ShortcutsEnabled = true;
            this.txtAmountOfDues.Size = new System.Drawing.Size(193, 23);
            this.txtAmountOfDues.TabIndex = 20;
            this.txtAmountOfDues.UseSelectable = true;
            this.txtAmountOfDues.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountOfDues.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInterest
            // 
            // 
            // 
            // 
            this.txtInterest.CustomButton.Image = null;
            this.txtInterest.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtInterest.CustomButton.Name = "";
            this.txtInterest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInterest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInterest.CustomButton.TabIndex = 1;
            this.txtInterest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInterest.CustomButton.UseSelectable = true;
            this.txtInterest.CustomButton.Visible = false;
            this.txtInterest.Lines = new string[0];
            this.txtInterest.Location = new System.Drawing.Point(114, 67);
            this.txtInterest.MaxLength = 32767;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.PasswordChar = '\0';
            this.txtInterest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInterest.SelectedText = "";
            this.txtInterest.SelectionLength = 0;
            this.txtInterest.SelectionStart = 0;
            this.txtInterest.ShortcutsEnabled = true;
            this.txtInterest.Size = new System.Drawing.Size(193, 23);
            this.txtInterest.TabIndex = 21;
            this.txtInterest.UseSelectable = true;
            this.txtInterest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInterest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRange
            // 
            // 
            // 
            // 
            this.txtRange.CustomButton.Image = null;
            this.txtRange.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtRange.CustomButton.Name = "";
            this.txtRange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRange.CustomButton.TabIndex = 1;
            this.txtRange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRange.CustomButton.UseSelectable = true;
            this.txtRange.CustomButton.Visible = false;
            this.txtRange.Lines = new string[0];
            this.txtRange.Location = new System.Drawing.Point(114, 16);
            this.txtRange.MaxLength = 32767;
            this.txtRange.Name = "txtRange";
            this.txtRange.PasswordChar = '\0';
            this.txtRange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRange.SelectedText = "";
            this.txtRange.SelectionLength = 0;
            this.txtRange.SelectionStart = 0;
            this.txtRange.ShortcutsEnabled = true;
            this.txtRange.Size = new System.Drawing.Size(193, 23);
            this.txtRange.TabIndex = 22;
            this.txtRange.UseSelectable = true;
            this.txtRange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(13, 118);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(92, 19);
            this.metroLabel15.TabIndex = 17;
            this.metroLabel15.Text = "Monto cuotas:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(13, 67);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 18;
            this.metroLabel16.Text = "Intereses:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(13, 20);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(44, 19);
            this.metroLabel17.TabIndex = 19;
            this.metroLabel17.Text = "Plazo:";
            // 
            // dgvCreditInvoice
            // 
            this.dgvCreditInvoice.AllowUserToResizeRows = false;
            this.dgvCreditInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditInvoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCreditInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCreditInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCreditInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCreditInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCreditInvoice.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCreditInvoice.EnableHeadersVisualStyles = false;
            this.dgvCreditInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCreditInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCreditInvoice.Location = new System.Drawing.Point(373, 118);
            this.dgvCreditInvoice.Name = "dgvCreditInvoice";
            this.dgvCreditInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCreditInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCreditInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditInvoice.Size = new System.Drawing.Size(497, 482);
            this.dgvCreditInvoice.TabIndex = 23;
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
            // btnCleanCreditInvoice
            // 
            this.btnCleanCreditInvoice.ActiveControl = null;
            this.btnCleanCreditInvoice.Location = new System.Drawing.Point(757, 622);
            this.btnCleanCreditInvoice.Name = "btnCleanCreditInvoice";
            this.btnCleanCreditInvoice.Size = new System.Drawing.Size(124, 42);
            this.btnCleanCreditInvoice.TabIndex = 22;
            this.btnCleanCreditInvoice.Text = "Limpiar";
            this.btnCleanCreditInvoice.UseSelectable = true;
            this.btnCleanCreditInvoice.Click += new System.EventHandler(this.btnCleanCreditInvoice_Click);
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.ActiveControl = null;
            this.btnGenerateInvoice.Location = new System.Drawing.Point(757, 734);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(124, 42);
            this.btnGenerateInvoice.TabIndex = 22;
            this.btnGenerateInvoice.Text = "Generar Factura";
            this.btnGenerateInvoice.UseSelectable = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.ActiveControl = null;
            this.btnAddProduct.Location = new System.Drawing.Point(733, 57);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(137, 38);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "Agregar Productos";
            this.btnAddProduct.UseSelectable = true;
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
            // cmbTypeCoin
            // 
            this.cmbTypeCoin.FormattingEnabled = true;
            this.cmbTypeCoin.ItemHeight = 23;
            this.cmbTypeCoin.Location = new System.Drawing.Point(132, 289);
            this.cmbTypeCoin.Name = "cmbTypeCoin";
            this.cmbTypeCoin.Size = new System.Drawing.Size(193, 29);
            this.cmbTypeCoin.TabIndex = 46;
            this.cmbTypeCoin.UseSelectable = true;
            // 
            // cmbTypePayment
            // 
            this.cmbTypePayment.FormattingEnabled = true;
            this.cmbTypePayment.ItemHeight = 23;
            this.cmbTypePayment.Location = new System.Drawing.Point(132, 245);
            this.cmbTypePayment.Name = "cmbTypePayment";
            this.cmbTypePayment.Size = new System.Drawing.Size(193, 29);
            this.cmbTypePayment.TabIndex = 45;
            this.cmbTypePayment.UseSelectable = true;
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
            this.txtTotalPay.Location = new System.Drawing.Point(132, 563);
            this.txtTotalPay.MaxLength = 32767;
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.PasswordChar = '\0';
            this.txtTotalPay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPay.SelectedText = "";
            this.txtTotalPay.SelectionLength = 0;
            this.txtTotalPay.SelectionStart = 0;
            this.txtTotalPay.ShortcutsEnabled = true;
            this.txtTotalPay.Size = new System.Drawing.Size(193, 23);
            this.txtTotalPay.TabIndex = 41;
            this.txtTotalPay.UseSelectable = true;
            this.txtTotalPay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtDaxes.Location = new System.Drawing.Point(132, 476);
            this.txtDaxes.MaxLength = 32767;
            this.txtDaxes.Name = "txtDaxes";
            this.txtDaxes.PasswordChar = '\0';
            this.txtDaxes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDaxes.SelectedText = "";
            this.txtDaxes.SelectionLength = 0;
            this.txtDaxes.SelectionStart = 0;
            this.txtDaxes.ShortcutsEnabled = true;
            this.txtDaxes.Size = new System.Drawing.Size(193, 23);
            this.txtDaxes.TabIndex = 40;
            this.txtDaxes.UseSelectable = true;
            this.txtDaxes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDaxes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtSubtotal.Location = new System.Drawing.Point(132, 516);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(193, 23);
            this.txtSubtotal.TabIndex = 39;
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
            this.txtDiscount.Location = new System.Drawing.Point(132, 431);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(193, 23);
            this.txtDiscount.TabIndex = 38;
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
            this.txtPayment.Location = new System.Drawing.Point(132, 382);
            this.txtPayment.MaxLength = 32767;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayment.SelectedText = "";
            this.txtPayment.SelectionLength = 0;
            this.txtPayment.SelectionStart = 0;
            this.txtPayment.ShortcutsEnabled = true;
            this.txtPayment.Size = new System.Drawing.Size(193, 23);
            this.txtPayment.TabIndex = 37;
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
            this.txtTypeChange.Location = new System.Drawing.Point(132, 335);
            this.txtTypeChange.MaxLength = 32767;
            this.txtTypeChange.Name = "txtTypeChange";
            this.txtTypeChange.PasswordChar = '\0';
            this.txtTypeChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTypeChange.SelectedText = "";
            this.txtTypeChange.SelectionLength = 0;
            this.txtTypeChange.SelectionStart = 0;
            this.txtTypeChange.ShortcutsEnabled = true;
            this.txtTypeChange.Size = new System.Drawing.Size(193, 23);
            this.txtTypeChange.TabIndex = 36;
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
            this.txtClient.Location = new System.Drawing.Point(132, 201);
            this.txtClient.MaxLength = 32767;
            this.txtClient.Name = "txtClient";
            this.txtClient.PasswordChar = '\0';
            this.txtClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClient.SelectedText = "";
            this.txtClient.SelectionLength = 0;
            this.txtClient.SelectionStart = 0;
            this.txtClient.ShortcutsEnabled = true;
            this.txtClient.Size = new System.Drawing.Size(193, 23);
            this.txtClient.TabIndex = 42;
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
            this.txtEmployee.Location = new System.Drawing.Point(132, 158);
            this.txtEmployee.MaxLength = 32767;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.PasswordChar = '\0';
            this.txtEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployee.SelectedText = "";
            this.txtEmployee.SelectionLength = 0;
            this.txtEmployee.SelectionStart = 0;
            this.txtEmployee.ShortcutsEnabled = true;
            this.txtEmployee.Size = new System.Drawing.Size(193, 23);
            this.txtEmployee.TabIndex = 43;
            this.txtEmployee.UseSelectable = true;
            this.txtEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(31, 476);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Impuestos:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(31, 567);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(90, 19);
            this.metroLabel14.TabIndex = 32;
            this.metroLabel14.Text = "Total a pagar:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(31, 516);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(60, 19);
            this.metroLabel12.TabIndex = 31;
            this.metroLabel12.Text = "Subtotal:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(31, 435);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "Descuento:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(30, 339);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(86, 19);
            this.metroLabel13.TabIndex = 29;
            this.metroLabel13.Text = "Tipo cambio:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(30, 289);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(91, 19);
            this.metroLabel11.TabIndex = 28;
            this.metroLabel11.Text = "Tipo modena:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(31, 245);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 27;
            this.metroLabel9.Text = "Tipo Pago:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(30, 382);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 19);
            this.metroLabel8.TabIndex = 33;
            this.metroLabel8.Text = "Efectivo pago:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Cliente:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(31, 158);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Empleado:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 25;
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
            this.txtUser.Location = new System.Drawing.Point(132, 118);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(193, 23);
            this.txtUser.TabIndex = 44;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UcCreditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCreditInvoice";
            this.Size = new System.Drawing.Size(955, 829);
            this.Load += new System.EventHandler(this.UcCreditInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtInflation;
        private MetroFramework.Controls.MetroTextBox txtCardDeposit;
        private MetroFramework.Controls.MetroTextBox txtCashDeposit;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox txtAmountOfDues;
        private MetroFramework.Controls.MetroTextBox txtInterest;
        private MetroFramework.Controls.MetroTextBox txtRange;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroGrid dgvCreditInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnGenerateInvoice;
        private MetroFramework.Controls.MetroTile btnAddProduct;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btnCleanCreditInvoice;
        private MetroFramework.Controls.MetroComboBox cmbTypeCoin;
        private MetroFramework.Controls.MetroComboBox cmbTypePayment;
        private MetroFramework.Controls.MetroTextBox txtTotalPay;
        private MetroFramework.Controls.MetroTextBox txtDaxes;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroTextBox txtPayment;
        private MetroFramework.Controls.MetroTextBox txtTypeChange;
        private MetroFramework.Controls.MetroTextBox txtClient;
        private MetroFramework.Controls.MetroTextBox txtEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtUser;
    }
}
