namespace UI.UserControls
{
    partial class UcBrandSize
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSize = new MetroFramework.Controls.MetroGrid();
            this.txtSearchSize = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateSize = new MetroFramework.Controls.MetroTile();
            this.btnDeleteSize = new MetroFramework.Controls.MetroTile();
            this.btnAddSize = new MetroFramework.Controls.MetroTile();
            this.txtSize = new MetroFramework.Controls.MetroTextBox();
            this.txtIDSize = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBrand = new MetroFramework.Controls.MetroGrid();
            this.txtSearchBrand = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteBrand = new MetroFramework.Controls.MetroTile();
            this.btnUpdateBrand = new MetroFramework.Controls.MetroTile();
            this.btnAddBrand = new MetroFramework.Controls.MetroTile();
            this.txtIDBrand = new MetroFramework.Controls.MetroTextBox();
            this.txtBrand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSize);
            this.groupBox2.Controls.Add(this.txtSearchSize);
            this.groupBox2.Controls.Add(this.btnUpdateSize);
            this.groupBox2.Controls.Add(this.btnDeleteSize);
            this.groupBox2.Controls.Add(this.btnAddSize);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.txtIDSize);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(502, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 476);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de Tallas";
            // 
            // dgvSize
            // 
            this.dgvSize.AllowUserToResizeRows = false;
            this.dgvSize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSize.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSize.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSize.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSize.EnableHeadersVisualStyles = false;
            this.dgvSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSize.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSize.Location = new System.Drawing.Point(31, 248);
            this.dgvSize.Name = "dgvSize";
            this.dgvSize.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSize.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSize.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSize.Size = new System.Drawing.Size(337, 150);
            this.dgvSize.TabIndex = 7;
            // 
            // txtSearchSize
            // 
            // 
            // 
            // 
            this.txtSearchSize.CustomButton.Image = null;
            this.txtSearchSize.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSearchSize.CustomButton.Name = "";
            this.txtSearchSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchSize.CustomButton.TabIndex = 1;
            this.txtSearchSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchSize.CustomButton.UseSelectable = true;
            this.txtSearchSize.Lines = new string[0];
            this.txtSearchSize.Location = new System.Drawing.Point(218, 211);
            this.txtSearchSize.MaxLength = 32767;
            this.txtSearchSize.Name = "txtSearchSize";
            this.txtSearchSize.PasswordChar = '\0';
            this.txtSearchSize.PromptText = "Ingrese texto a buscar";
            this.txtSearchSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchSize.SelectedText = "";
            this.txtSearchSize.SelectionLength = 0;
            this.txtSearchSize.SelectionStart = 0;
            this.txtSearchSize.ShortcutsEnabled = true;
            this.txtSearchSize.ShowButton = true;
            this.txtSearchSize.Size = new System.Drawing.Size(147, 23);
            this.txtSearchSize.TabIndex = 6;
            this.txtSearchSize.UseSelectable = true;
            this.txtSearchSize.WaterMark = "Ingrese texto a buscar";
            this.txtSearchSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdateSize
            // 
            this.btnUpdateSize.ActiveControl = null;
            this.btnUpdateSize.Location = new System.Drawing.Point(315, 124);
            this.btnUpdateSize.Name = "btnUpdateSize";
            this.btnUpdateSize.Size = new System.Drawing.Size(87, 38);
            this.btnUpdateSize.TabIndex = 4;
            this.btnUpdateSize.Text = "Modificar";
            this.btnUpdateSize.UseSelectable = true;
            // 
            // btnDeleteSize
            // 
            this.btnDeleteSize.ActiveControl = null;
            this.btnDeleteSize.Location = new System.Drawing.Point(281, 414);
            this.btnDeleteSize.Name = "btnDeleteSize";
            this.btnDeleteSize.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteSize.TabIndex = 4;
            this.btnDeleteSize.Text = "Eliminar";
            this.btnDeleteSize.UseSelectable = true;
            // 
            // btnAddSize
            // 
            this.btnAddSize.ActiveControl = null;
            this.btnAddSize.Location = new System.Drawing.Point(315, 46);
            this.btnAddSize.Name = "btnAddSize";
            this.btnAddSize.Size = new System.Drawing.Size(87, 38);
            this.btnAddSize.TabIndex = 4;
            this.btnAddSize.Text = "Agregar";
            this.btnAddSize.UseSelectable = true;
            // 
            // txtSize
            // 
            // 
            // 
            // 
            this.txtSize.CustomButton.Image = null;
            this.txtSize.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtSize.CustomButton.Name = "";
            this.txtSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSize.CustomButton.TabIndex = 1;
            this.txtSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSize.CustomButton.UseSelectable = true;
            this.txtSize.CustomButton.Visible = false;
            this.txtSize.Lines = new string[0];
            this.txtSize.Location = new System.Drawing.Point(126, 124);
            this.txtSize.MaxLength = 32767;
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSize.SelectedText = "";
            this.txtSize.SelectionLength = 0;
            this.txtSize.SelectionStart = 0;
            this.txtSize.ShortcutsEnabled = true;
            this.txtSize.Size = new System.Drawing.Size(134, 23);
            this.txtSize.TabIndex = 3;
            this.txtSize.UseSelectable = true;
            this.txtSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIDSize
            // 
            // 
            // 
            // 
            this.txtIDSize.CustomButton.Image = null;
            this.txtIDSize.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtIDSize.CustomButton.Name = "";
            this.txtIDSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDSize.CustomButton.TabIndex = 1;
            this.txtIDSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDSize.CustomButton.UseSelectable = true;
            this.txtIDSize.CustomButton.Visible = false;
            this.txtIDSize.Enabled = false;
            this.txtIDSize.Lines = new string[0];
            this.txtIDSize.Location = new System.Drawing.Point(126, 50);
            this.txtIDSize.MaxLength = 32767;
            this.txtIDSize.Name = "txtIDSize";
            this.txtIDSize.PasswordChar = '\0';
            this.txtIDSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDSize.SelectedText = "";
            this.txtIDSize.SelectionLength = 0;
            this.txtIDSize.SelectionStart = 0;
            this.txtIDSize.ShortcutsEnabled = true;
            this.txtIDSize.Size = new System.Drawing.Size(134, 23);
            this.txtIDSize.TabIndex = 3;
            this.txtIDSize.UseSelectable = true;
            this.txtIDSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(24, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "ID:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Talla:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBrand);
            this.groupBox1.Controls.Add(this.txtSearchBrand);
            this.groupBox1.Controls.Add(this.btnDeleteBrand);
            this.groupBox1.Controls.Add(this.btnUpdateBrand);
            this.groupBox1.Controls.Add(this.btnAddBrand);
            this.groupBox1.Controls.Add(this.txtIDBrand);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 476);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de marcas de ropa";
            // 
            // dgvBrand
            // 
            this.dgvBrand.AllowUserToResizeRows = false;
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBrand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBrand.Location = new System.Drawing.Point(31, 248);
            this.dgvBrand.MultiSelect = false;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBrand.RowHeadersVisible = false;
            this.dgvBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.Size = new System.Drawing.Size(337, 150);
            this.dgvBrand.TabIndex = 7;
            this.dgvBrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrand_CellContentClick);
            // 
            // txtSearchBrand
            // 
            // 
            // 
            // 
            this.txtSearchBrand.CustomButton.Image = null;
            this.txtSearchBrand.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSearchBrand.CustomButton.Name = "";
            this.txtSearchBrand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchBrand.CustomButton.TabIndex = 1;
            this.txtSearchBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBrand.CustomButton.UseSelectable = true;
            this.txtSearchBrand.Lines = new string[0];
            this.txtSearchBrand.Location = new System.Drawing.Point(221, 211);
            this.txtSearchBrand.MaxLength = 32767;
            this.txtSearchBrand.Name = "txtSearchBrand";
            this.txtSearchBrand.PasswordChar = '\0';
            this.txtSearchBrand.PromptText = "Ingrese texto a buscar";
            this.txtSearchBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBrand.SelectedText = "";
            this.txtSearchBrand.SelectionLength = 0;
            this.txtSearchBrand.SelectionStart = 0;
            this.txtSearchBrand.ShortcutsEnabled = true;
            this.txtSearchBrand.ShowButton = true;
            this.txtSearchBrand.Size = new System.Drawing.Size(147, 23);
            this.txtSearchBrand.TabIndex = 6;
            this.txtSearchBrand.UseSelectable = true;
            this.txtSearchBrand.WaterMark = "Ingrese texto a buscar";
            this.txtSearchBrand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchBrand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBrand.Click += new System.EventHandler(this.txtSearchBrand_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.ActiveControl = null;
            this.btnDeleteBrand.Location = new System.Drawing.Point(284, 414);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteBrand.TabIndex = 4;
            this.btnDeleteBrand.Text = "Eliminar";
            this.btnDeleteBrand.UseSelectable = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.ActiveControl = null;
            this.btnUpdateBrand.Location = new System.Drawing.Point(315, 124);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(87, 38);
            this.btnUpdateBrand.TabIndex = 4;
            this.btnUpdateBrand.Text = "Modificar";
            this.btnUpdateBrand.UseSelectable = true;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.ActiveControl = null;
            this.btnAddBrand.Location = new System.Drawing.Point(315, 46);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(87, 38);
            this.btnAddBrand.TabIndex = 4;
            this.btnAddBrand.Text = "Agregar";
            this.btnAddBrand.UseSelectable = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // txtIDBrand
            // 
            // 
            // 
            // 
            this.txtIDBrand.CustomButton.Image = null;
            this.txtIDBrand.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtIDBrand.CustomButton.Name = "";
            this.txtIDBrand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDBrand.CustomButton.TabIndex = 1;
            this.txtIDBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDBrand.CustomButton.UseSelectable = true;
            this.txtIDBrand.CustomButton.Visible = false;
            this.txtIDBrand.Enabled = false;
            this.txtIDBrand.Lines = new string[0];
            this.txtIDBrand.Location = new System.Drawing.Point(112, 50);
            this.txtIDBrand.MaxLength = 32767;
            this.txtIDBrand.Name = "txtIDBrand";
            this.txtIDBrand.PasswordChar = '\0';
            this.txtIDBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDBrand.SelectedText = "";
            this.txtIDBrand.SelectionLength = 0;
            this.txtIDBrand.SelectionStart = 0;
            this.txtIDBrand.ShortcutsEnabled = true;
            this.txtIDBrand.Size = new System.Drawing.Size(134, 23);
            this.txtIDBrand.TabIndex = 3;
            this.txtIDBrand.UseSelectable = true;
            this.txtIDBrand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDBrand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBrand
            // 
            // 
            // 
            // 
            this.txtBrand.CustomButton.Image = null;
            this.txtBrand.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtBrand.CustomButton.Name = "";
            this.txtBrand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBrand.CustomButton.TabIndex = 1;
            this.txtBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBrand.CustomButton.UseSelectable = true;
            this.txtBrand.CustomButton.Visible = false;
            this.txtBrand.Lines = new string[0];
            this.txtBrand.Location = new System.Drawing.Point(112, 124);
            this.txtBrand.MaxLength = 32767;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBrand.SelectedText = "";
            this.txtBrand.SelectionLength = 0;
            this.txtBrand.SelectionStart = 0;
            this.txtBrand.ShortcutsEnabled = true;
            this.txtBrand.Size = new System.Drawing.Size(134, 23);
            this.txtBrand.TabIndex = 3;
            this.txtBrand.UseSelectable = true;
            this.txtBrand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBrand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Marca:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // UcBrandSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcBrandSize";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcBrandSize_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtSearchSize;
        private MetroFramework.Controls.MetroTile btnUpdateSize;
        private MetroFramework.Controls.MetroTile btnDeleteSize;
        private MetroFramework.Controls.MetroTile btnAddSize;
        private MetroFramework.Controls.MetroTextBox txtSize;
        private MetroFramework.Controls.MetroTextBox txtIDSize;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchBrand;
        private MetroFramework.Controls.MetroTile btnDeleteBrand;
        private MetroFramework.Controls.MetroTile btnUpdateBrand;
        private MetroFramework.Controls.MetroTile btnAddBrand;
        private MetroFramework.Controls.MetroTextBox txtIDBrand;
        private MetroFramework.Controls.MetroTextBox txtBrand;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvSize;
        private MetroFramework.Controls.MetroGrid dgvBrand;
    }
}
