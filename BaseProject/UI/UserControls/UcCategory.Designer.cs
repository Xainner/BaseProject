namespace UI.UserControls
{
    partial class UcCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSubCategory = new MetroFramework.Controls.MetroGrid();
            this.txtSearchSub = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateSub = new MetroFramework.Controls.MetroTile();
            this.btnDeleteSub = new MetroFramework.Controls.MetroTile();
            this.btnAddSub = new MetroFramework.Controls.MetroTile();
            this.txtNameSub = new MetroFramework.Controls.MetroTextBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCategory = new MetroFramework.Controls.MetroGrid();
            this.txtSearchCategory = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteCategory = new MetroFramework.Controls.MetroTile();
            this.btnUpdateCategory = new MetroFramework.Controls.MetroTile();
            this.btnAddCategory = new MetroFramework.Controls.MetroTile();
            this.txtIDCategory = new MetroFramework.Controls.MetroTextBox();
            this.txtNameCategory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCleanAll = new MetroFramework.Controls.MetroTile();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSubCategory);
            this.groupBox2.Controls.Add(this.txtSearchSub);
            this.groupBox2.Controls.Add(this.btnUpdateSub);
            this.groupBox2.Controls.Add(this.btnDeleteSub);
            this.groupBox2.Controls.Add(this.btnAddSub);
            this.groupBox2.Controls.Add(this.txtNameSub);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(505, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de subcategorias";
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AllowUserToResizeRows = false;
            this.dgvSubCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSubCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSubCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubCategory.EnableHeadersVisualStyles = false;
            this.dgvSubCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSubCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSubCategory.Location = new System.Drawing.Point(28, 228);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubCategory.Size = new System.Drawing.Size(337, 150);
            this.dgvSubCategory.TabIndex = 8;
            this.dgvSubCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSubCategory_MouseClick);
            // 
            // txtSearchSub
            // 
            // 
            // 
            // 
            this.txtSearchSub.CustomButton.Image = null;
            this.txtSearchSub.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSearchSub.CustomButton.Name = "";
            this.txtSearchSub.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchSub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchSub.CustomButton.TabIndex = 1;
            this.txtSearchSub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchSub.CustomButton.UseSelectable = true;
            this.txtSearchSub.Lines = new string[0];
            this.txtSearchSub.Location = new System.Drawing.Point(218, 191);
            this.txtSearchSub.MaxLength = 32767;
            this.txtSearchSub.Name = "txtSearchSub";
            this.txtSearchSub.PasswordChar = '\0';
            this.txtSearchSub.PromptText = "Ingrese texto a buscar";
            this.txtSearchSub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchSub.SelectedText = "";
            this.txtSearchSub.SelectionLength = 0;
            this.txtSearchSub.SelectionStart = 0;
            this.txtSearchSub.ShortcutsEnabled = true;
            this.txtSearchSub.ShowButton = true;
            this.txtSearchSub.Size = new System.Drawing.Size(147, 23);
            this.txtSearchSub.TabIndex = 6;
            this.txtSearchSub.UseSelectable = true;
            this.txtSearchSub.WaterMark = "Ingrese texto a buscar";
            this.txtSearchSub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchSub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSub_KeyPress);
            // 
            // btnUpdateSub
            // 
            this.btnUpdateSub.ActiveControl = null;
            this.btnUpdateSub.Location = new System.Drawing.Point(315, 124);
            this.btnUpdateSub.Name = "btnUpdateSub";
            this.btnUpdateSub.Size = new System.Drawing.Size(87, 38);
            this.btnUpdateSub.TabIndex = 4;
            this.btnUpdateSub.Text = "Modificar";
            this.btnUpdateSub.UseSelectable = true;
            this.btnUpdateSub.Click += new System.EventHandler(this.btnUpdateSub_Click);
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.ActiveControl = null;
            this.btnDeleteSub.Location = new System.Drawing.Point(281, 394);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteSub.TabIndex = 4;
            this.btnDeleteSub.Text = "Eliminar";
            this.btnDeleteSub.UseSelectable = true;
            this.btnDeleteSub.Click += new System.EventHandler(this.btnDeleteSub_Click);
            // 
            // btnAddSub
            // 
            this.btnAddSub.ActiveControl = null;
            this.btnAddSub.Location = new System.Drawing.Point(315, 46);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(87, 38);
            this.btnAddSub.TabIndex = 4;
            this.btnAddSub.Text = "Agregar";
            this.btnAddSub.UseSelectable = true;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // txtNameSub
            // 
            // 
            // 
            // 
            this.txtNameSub.CustomButton.Image = null;
            this.txtNameSub.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtNameSub.CustomButton.Name = "";
            this.txtNameSub.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameSub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameSub.CustomButton.TabIndex = 1;
            this.txtNameSub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameSub.CustomButton.UseSelectable = true;
            this.txtNameSub.CustomButton.Visible = false;
            this.txtNameSub.Lines = new string[0];
            this.txtNameSub.Location = new System.Drawing.Point(126, 124);
            this.txtNameSub.MaxLength = 32767;
            this.txtNameSub.Name = "txtNameSub";
            this.txtNameSub.PasswordChar = '\0';
            this.txtNameSub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameSub.SelectedText = "";
            this.txtNameSub.SelectionLength = 0;
            this.txtNameSub.SelectionStart = 0;
            this.txtNameSub.ShortcutsEnabled = true;
            this.txtNameSub.Size = new System.Drawing.Size(134, 23);
            this.txtNameSub.TabIndex = 3;
            this.txtNameSub.UseSelectable = true;
            this.txtNameSub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameSub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(126, 46);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(134, 29);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Subcategoria:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Categoria:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCategory);
            this.groupBox1.Controls.Add(this.txtSearchCategory);
            this.groupBox1.Controls.Add(this.btnDeleteCategory);
            this.groupBox1.Controls.Add(this.btnUpdateCategory);
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.txtIDCategory);
            this.groupBox1.Controls.Add(this.txtNameCategory);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 443);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de categorias";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCategory.Location = new System.Drawing.Point(35, 228);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(337, 150);
            this.dgvCategory.TabIndex = 8;
            this.dgvCategory.Click += new System.EventHandler(this.dgvCategory_Click);
            // 
            // txtSearchCategory
            // 
            // 
            // 
            // 
            this.txtSearchCategory.CustomButton.Image = null;
            this.txtSearchCategory.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSearchCategory.CustomButton.Name = "";
            this.txtSearchCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchCategory.CustomButton.TabIndex = 1;
            this.txtSearchCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchCategory.CustomButton.UseSelectable = true;
            this.txtSearchCategory.Lines = new string[0];
            this.txtSearchCategory.Location = new System.Drawing.Point(222, 191);
            this.txtSearchCategory.MaxLength = 32767;
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.PasswordChar = '\0';
            this.txtSearchCategory.PromptText = "Ingrese texto a buscar";
            this.txtSearchCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchCategory.SelectedText = "";
            this.txtSearchCategory.SelectionLength = 0;
            this.txtSearchCategory.SelectionStart = 0;
            this.txtSearchCategory.ShortcutsEnabled = true;
            this.txtSearchCategory.ShowButton = true;
            this.txtSearchCategory.Size = new System.Drawing.Size(147, 23);
            this.txtSearchCategory.TabIndex = 6;
            this.txtSearchCategory.UseSelectable = true;
            this.txtSearchCategory.WaterMark = "Ingrese texto a buscar";
            this.txtSearchCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCategory_KeyPress);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.ActiveControl = null;
            this.btnDeleteCategory.Location = new System.Drawing.Point(285, 394);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Eliminar";
            this.btnDeleteCategory.UseSelectable = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.ActiveControl = null;
            this.btnUpdateCategory.Location = new System.Drawing.Point(315, 124);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(87, 38);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Modificar";
            this.btnUpdateCategory.UseSelectable = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.ActiveControl = null;
            this.btnAddCategory.Location = new System.Drawing.Point(315, 46);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(87, 38);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Agregar";
            this.btnAddCategory.UseSelectable = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtIDCategory
            // 
            // 
            // 
            // 
            this.txtIDCategory.CustomButton.Image = null;
            this.txtIDCategory.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtIDCategory.CustomButton.Name = "";
            this.txtIDCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCategory.CustomButton.TabIndex = 1;
            this.txtIDCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCategory.CustomButton.UseSelectable = true;
            this.txtIDCategory.CustomButton.Visible = false;
            this.txtIDCategory.Enabled = false;
            this.txtIDCategory.Lines = new string[0];
            this.txtIDCategory.Location = new System.Drawing.Point(112, 46);
            this.txtIDCategory.MaxLength = 32767;
            this.txtIDCategory.Name = "txtIDCategory";
            this.txtIDCategory.PasswordChar = '\0';
            this.txtIDCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCategory.SelectedText = "";
            this.txtIDCategory.SelectionLength = 0;
            this.txtIDCategory.SelectionStart = 0;
            this.txtIDCategory.ShortcutsEnabled = true;
            this.txtIDCategory.Size = new System.Drawing.Size(134, 23);
            this.txtIDCategory.TabIndex = 3;
            this.txtIDCategory.UseSelectable = true;
            this.txtIDCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameCategory
            // 
            // 
            // 
            // 
            this.txtNameCategory.CustomButton.Image = null;
            this.txtNameCategory.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtNameCategory.CustomButton.Name = "";
            this.txtNameCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameCategory.CustomButton.TabIndex = 1;
            this.txtNameCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameCategory.CustomButton.UseSelectable = true;
            this.txtNameCategory.CustomButton.Visible = false;
            this.txtNameCategory.Lines = new string[0];
            this.txtNameCategory.Location = new System.Drawing.Point(112, 124);
            this.txtNameCategory.MaxLength = 32767;
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.PasswordChar = '\0';
            this.txtNameCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameCategory.SelectedText = "";
            this.txtNameCategory.SelectionLength = 0;
            this.txtNameCategory.SelectionStart = 0;
            this.txtNameCategory.ShortcutsEnabled = true;
            this.txtNameCategory.Size = new System.Drawing.Size(134, 23);
            this.txtNameCategory.TabIndex = 3;
            this.txtNameCategory.UseSelectable = true;
            this.txtNameCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Categoria:";
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
            // btnCleanAll
            // 
            this.btnCleanAll.ActiveControl = null;
            this.btnCleanAll.Location = new System.Drawing.Point(808, 495);
            this.btnCleanAll.Name = "btnCleanAll";
            this.btnCleanAll.Size = new System.Drawing.Size(126, 38);
            this.btnCleanAll.TabIndex = 9;
            this.btnCleanAll.Text = "Limpiar Campos";
            this.btnCleanAll.UseSelectable = true;
            this.btnCleanAll.Click += new System.EventHandler(this.btnCleanAll_Click);
            // 
            // UcCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCleanAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCategory";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcCategory_Load);
            this.Leave += new System.EventHandler(this.UcCategory_Leave);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtSearchSub;
        private MetroFramework.Controls.MetroTile btnUpdateSub;
        private MetroFramework.Controls.MetroTile btnDeleteSub;
        private MetroFramework.Controls.MetroTile btnAddSub;
        private MetroFramework.Controls.MetroTextBox txtNameSub;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchCategory;
        private MetroFramework.Controls.MetroTile btnDeleteCategory;
        private MetroFramework.Controls.MetroTile btnUpdateCategory;
        private MetroFramework.Controls.MetroTile btnAddCategory;
        private MetroFramework.Controls.MetroTextBox txtNameCategory;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvSubCategory;
        private MetroFramework.Controls.MetroGrid dgvCategory;
        private MetroFramework.Controls.MetroTextBox txtIDCategory;
        private MetroFramework.Controls.MetroTile btnCleanAll;
    }
}
