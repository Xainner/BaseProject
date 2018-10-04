namespace UI.UserControls
{
    partial class UcAparts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endDateTime = new MetroFramework.Controls.MetroDateTime();
            this.employeeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.StoreComboBox = new MetroFramework.Controls.MetroComboBox();
            this.clientComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddApart = new MetroFramework.Controls.MetroTile();
            this.totalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ResidueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.DiscountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.currentPayTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SubtotalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TaxesTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.typePayComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.dgvAparts = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAparts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endDateTime);
            this.groupBox1.Controls.Add(this.employeeComboBox);
            this.groupBox1.Controls.Add(this.StoreComboBox);
            this.groupBox1.Controls.Add(this.clientComboBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 108);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura de Apartado";
            // 
            // endDateTime
            // 
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTime.Location = new System.Drawing.Point(712, 19);
            this.endDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(200, 29);
            this.endDateTime.TabIndex = 31;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.ItemHeight = 23;
            this.employeeComboBox.Location = new System.Drawing.Point(89, 15);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(193, 29);
            this.employeeComboBox.TabIndex = 30;
            this.employeeComboBox.UseSelectable = true;
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.ItemHeight = 23;
            this.StoreComboBox.Location = new System.Drawing.Point(712, 65);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(193, 29);
            this.StoreComboBox.TabIndex = 30;
            this.StoreComboBox.UseSelectable = true;
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.ItemHeight = 23;
            this.clientComboBox.Location = new System.Drawing.Point(89, 57);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(193, 29);
            this.clientComboBox.TabIndex = 30;
            this.clientComboBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(622, 24);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Fecha Final:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(622, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Tienda";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 65);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Cliente";
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle50;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(25, 174);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(526, 330);
            this.metroGrid1.TabIndex = 30;
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(91, 145);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(152, 23);
            this.codeTextBox.TabIndex = 69;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.codeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeTextBox_KeyUp);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(32, 145);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(53, 19);
            this.metroLabel10.TabIndex = 68;
            this.metroLabel10.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddApart);
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Controls.Add(this.ResidueTextBox);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.DiscountTextBox);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.currentPayTextBox);
            this.groupBox2.Controls.Add(this.SubtotalTextBox);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.TaxesTextBox);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.typePayComboBox);
            this.groupBox2.Location = new System.Drawing.Point(675, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 330);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de Pago";
            // 
            // btnAddApart
            // 
            this.btnAddApart.ActiveControl = null;
            this.btnAddApart.Location = new System.Drawing.Point(157, 287);
            this.btnAddApart.Name = "btnAddApart";
            this.btnAddApart.Size = new System.Drawing.Size(98, 37);
            this.btnAddApart.TabIndex = 3;
            this.btnAddApart.Text = "Facturar";
            this.btnAddApart.UseSelectable = true;
            this.btnAddApart.Click += new System.EventHandler(this.btnAddApart_Click);
            // 
            // totalTextBox
            // 
            // 
            // 
            // 
            this.totalTextBox.CustomButton.Image = null;
            this.totalTextBox.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.totalTextBox.CustomButton.Name = "";
            this.totalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalTextBox.CustomButton.TabIndex = 1;
            this.totalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalTextBox.CustomButton.UseSelectable = true;
            this.totalTextBox.CustomButton.Visible = false;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Lines = new string[0];
            this.totalTextBox.Location = new System.Drawing.Point(123, 158);
            this.totalTextBox.MaxLength = 32767;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.PasswordChar = '\0';
            this.totalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalTextBox.SelectedText = "";
            this.totalTextBox.SelectionLength = 0;
            this.totalTextBox.SelectionStart = 0;
            this.totalTextBox.ShortcutsEnabled = true;
            this.totalTextBox.Size = new System.Drawing.Size(112, 23);
            this.totalTextBox.TabIndex = 2;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalTextBox.UseSelectable = true;
            this.totalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ResidueTextBox
            // 
            // 
            // 
            // 
            this.ResidueTextBox.CustomButton.Image = null;
            this.ResidueTextBox.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.ResidueTextBox.CustomButton.Name = "";
            this.ResidueTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ResidueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ResidueTextBox.CustomButton.TabIndex = 1;
            this.ResidueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResidueTextBox.CustomButton.UseSelectable = true;
            this.ResidueTextBox.CustomButton.Visible = false;
            this.ResidueTextBox.Lines = new string[0];
            this.ResidueTextBox.Location = new System.Drawing.Point(123, 242);
            this.ResidueTextBox.MaxLength = 32767;
            this.ResidueTextBox.Name = "ResidueTextBox";
            this.ResidueTextBox.PasswordChar = '\0';
            this.ResidueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ResidueTextBox.SelectedText = "";
            this.ResidueTextBox.SelectionLength = 0;
            this.ResidueTextBox.SelectionStart = 0;
            this.ResidueTextBox.ShortcutsEnabled = true;
            this.ResidueTextBox.Size = new System.Drawing.Size(112, 23);
            this.ResidueTextBox.TabIndex = 2;
            this.ResidueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResidueTextBox.UseSelectable = true;
            this.ResidueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ResidueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(16, 160);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(89, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Total a Pagar:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 244);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Saldo a Pagar:";
            // 
            // DiscountTextBox
            // 
            // 
            // 
            // 
            this.DiscountTextBox.CustomButton.Image = null;
            this.DiscountTextBox.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.DiscountTextBox.CustomButton.Name = "";
            this.DiscountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DiscountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DiscountTextBox.CustomButton.TabIndex = 1;
            this.DiscountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DiscountTextBox.CustomButton.UseSelectable = true;
            this.DiscountTextBox.CustomButton.Visible = false;
            this.DiscountTextBox.Lines = new string[0];
            this.DiscountTextBox.Location = new System.Drawing.Point(123, 125);
            this.DiscountTextBox.MaxLength = 32767;
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.PasswordChar = '\0';
            this.DiscountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DiscountTextBox.SelectedText = "";
            this.DiscountTextBox.SelectionLength = 0;
            this.DiscountTextBox.SelectionStart = 0;
            this.DiscountTextBox.ShortcutsEnabled = true;
            this.DiscountTextBox.Size = new System.Drawing.Size(112, 23);
            this.DiscountTextBox.TabIndex = 2;
            this.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DiscountTextBox.UseSelectable = true;
            this.DiscountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DiscountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DiscountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DiscountTextBox_KeyUp);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(16, 127);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 19);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Descuento:";
            // 
            // currentPayTextBox
            // 
            // 
            // 
            // 
            this.currentPayTextBox.CustomButton.Image = null;
            this.currentPayTextBox.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.currentPayTextBox.CustomButton.Name = "";
            this.currentPayTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.currentPayTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.currentPayTextBox.CustomButton.TabIndex = 1;
            this.currentPayTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.currentPayTextBox.CustomButton.UseSelectable = true;
            this.currentPayTextBox.CustomButton.Visible = false;
            this.currentPayTextBox.Lines = new string[0];
            this.currentPayTextBox.Location = new System.Drawing.Point(123, 201);
            this.currentPayTextBox.MaxLength = 32767;
            this.currentPayTextBox.Name = "currentPayTextBox";
            this.currentPayTextBox.PasswordChar = '\0';
            this.currentPayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.currentPayTextBox.SelectedText = "";
            this.currentPayTextBox.SelectionLength = 0;
            this.currentPayTextBox.SelectionStart = 0;
            this.currentPayTextBox.ShortcutsEnabled = true;
            this.currentPayTextBox.Size = new System.Drawing.Size(112, 23);
            this.currentPayTextBox.TabIndex = 2;
            this.currentPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currentPayTextBox.UseSelectable = true;
            this.currentPayTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.currentPayTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.currentPayTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.currentPayTextBox_KeyUp);
            // 
            // SubtotalTextBox
            // 
            // 
            // 
            // 
            this.SubtotalTextBox.CustomButton.Image = null;
            this.SubtotalTextBox.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.SubtotalTextBox.CustomButton.Name = "";
            this.SubtotalTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SubtotalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SubtotalTextBox.CustomButton.TabIndex = 1;
            this.SubtotalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SubtotalTextBox.CustomButton.UseSelectable = true;
            this.SubtotalTextBox.CustomButton.Visible = false;
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Lines = new string[0];
            this.SubtotalTextBox.Location = new System.Drawing.Point(123, 92);
            this.SubtotalTextBox.MaxLength = 32767;
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.PasswordChar = '\0';
            this.SubtotalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SubtotalTextBox.SelectedText = "";
            this.SubtotalTextBox.SelectionLength = 0;
            this.SubtotalTextBox.SelectionStart = 0;
            this.SubtotalTextBox.ShortcutsEnabled = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(112, 23);
            this.SubtotalTextBox.TabIndex = 2;
            this.SubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubtotalTextBox.UseSelectable = true;
            this.SubtotalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SubtotalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 203);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Pago Actual:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(16, 94);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(60, 19);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Subtotal:";
            // 
            // TaxesTextBox
            // 
            // 
            // 
            // 
            this.TaxesTextBox.CustomButton.Image = null;
            this.TaxesTextBox.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.TaxesTextBox.CustomButton.Name = "";
            this.TaxesTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TaxesTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TaxesTextBox.CustomButton.TabIndex = 1;
            this.TaxesTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TaxesTextBox.CustomButton.UseSelectable = true;
            this.TaxesTextBox.CustomButton.Visible = false;
            this.TaxesTextBox.Enabled = false;
            this.TaxesTextBox.Lines = new string[0];
            this.TaxesTextBox.Location = new System.Drawing.Point(123, 59);
            this.TaxesTextBox.MaxLength = 32767;
            this.TaxesTextBox.Name = "TaxesTextBox";
            this.TaxesTextBox.PasswordChar = '\0';
            this.TaxesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TaxesTextBox.SelectedText = "";
            this.TaxesTextBox.SelectionLength = 0;
            this.TaxesTextBox.SelectionStart = 0;
            this.TaxesTextBox.ShortcutsEnabled = true;
            this.TaxesTextBox.Size = new System.Drawing.Size(112, 23);
            this.TaxesTextBox.TabIndex = 2;
            this.TaxesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaxesTextBox.UseSelectable = true;
            this.TaxesTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TaxesTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Impuestos:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 24);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Forma de Pago";
            // 
            // typePayComboBox
            // 
            this.typePayComboBox.FormattingEnabled = true;
            this.typePayComboBox.ItemHeight = 23;
            this.typePayComboBox.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.typePayComboBox.Location = new System.Drawing.Point(123, 19);
            this.typePayComboBox.Name = "typePayComboBox";
            this.typePayComboBox.Size = new System.Drawing.Size(112, 29);
            this.typePayComboBox.TabIndex = 0;
            this.typePayComboBox.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(767, 126);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(163, 42);
            this.metroTile2.TabIndex = 71;
            this.metroTile2.Text = "Buscar Factura existente";
            this.metroTile2.UseSelectable = true;
            // 
            // dgvAparts
            // 
            this.dgvAparts.AllowUserToAddRows = false;
            this.dgvAparts.AllowUserToResizeRows = false;
            this.dgvAparts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAparts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAparts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAparts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAparts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAparts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvAparts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAparts.DefaultCellStyle = dataGridViewCellStyle53;
            this.dgvAparts.EnableHeadersVisualStyles = false;
            this.dgvAparts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAparts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAparts.Location = new System.Drawing.Point(25, 174);
            this.dgvAparts.MultiSelect = false;
            this.dgvAparts.Name = "dgvAparts";
            this.dgvAparts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAparts.RowHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dgvAparts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAparts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAparts.Size = new System.Drawing.Size(616, 330);
            this.dgvAparts.TabIndex = 72;
            // 
            // UcAparts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAparts);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcAparts";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcAparts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAparts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox employeeComboBox;
        private MetroFramework.Controls.MetroComboBox StoreComboBox;
        private MetroFramework.Controls.MetroComboBox clientComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime endDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox ResidueTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox currentPayTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox TaxesTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox typePayComboBox;
        private MetroFramework.Controls.MetroTextBox totalTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox DiscountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox SubtotalTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTile btnAddApart;
        private MetroFramework.Controls.MetroTile metroTile2;
        public MetroFramework.Controls.MetroGrid dgvAparts;
    }
}
