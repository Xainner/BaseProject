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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchSub = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateSub = new MetroFramework.Controls.MetroTile();
            this.btnDeleteSub = new MetroFramework.Controls.MetroTile();
            this.btnAddSub = new MetroFramework.Controls.MetroTile();
            this.txtNameSub = new MetroFramework.Controls.MetroTextBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchCategory = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteCategory = new MetroFramework.Controls.MetroTile();
            this.btnUpdateCategory = new MetroFramework.Controls.MetroTile();
            this.btnAddCategory = new MetroFramework.Controls.MetroTile();
            this.txtNameCategory = new MetroFramework.Controls.MetroTextBox();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvCategory = new MetroFramework.Controls.MetroGrid();
            this.dgvSubCategory = new MetroFramework.Controls.MetroGrid();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
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
            this.groupBox2.Size = new System.Drawing.Size(429, 476);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de subcategorias";
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
            this.txtSearchSub.Location = new System.Drawing.Point(218, 211);
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
            // 
            // btnDeleteSub
            // 
            this.btnDeleteSub.ActiveControl = null;
            this.btnDeleteSub.Location = new System.Drawing.Point(281, 414);
            this.btnDeleteSub.Name = "btnDeleteSub";
            this.btnDeleteSub.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteSub.TabIndex = 4;
            this.btnDeleteSub.Text = "Eliminar";
            this.btnDeleteSub.UseSelectable = true;
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
            this.groupBox1.Controls.Add(this.txtNameCategory);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 476);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de categorias";
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
            this.txtSearchCategory.Location = new System.Drawing.Point(221, 211);
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
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.ActiveControl = null;
            this.btnDeleteCategory.Location = new System.Drawing.Point(284, 414);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Eliminar";
            this.btnDeleteCategory.UseSelectable = true;
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
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 23;
            this.cmbGender.Location = new System.Drawing.Point(112, 47);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(134, 29);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.UseSelectable = true;
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
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Genero:";
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
            this.dgvCategory.Location = new System.Drawing.Point(34, 248);
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
            this.dgvSubCategory.Location = new System.Drawing.Point(28, 248);
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
            // 
            // UcCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCategory";
            this.Size = new System.Drawing.Size(955, 536);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvSubCategory;
        private MetroFramework.Controls.MetroGrid dgvCategory;
    }
}
