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
            this.deleteSubCategoryButton = new MetroFramework.Controls.MetroButton();
            this.updateSubCategoryButton = new MetroFramework.Controls.MetroButton();
            this.createSubCategoryButton = new MetroFramework.Controls.MetroButton();
            this.subCategoryGridView = new MetroFramework.Controls.MetroGrid();
            this.subCategoryNameSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.txtNameSub = new MetroFramework.Controls.MetroTextBox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateCategoryButton = new MetroFramework.Controls.MetroButton();
            this.createCategoryButton = new MetroFramework.Controls.MetroButton();
            this.deleteCategoryButton = new MetroFramework.Controls.MetroButton();
            this.categoryGridView = new MetroFramework.Controls.MetroGrid();
            this.categoryNameSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.txtIDCategory = new MetroFramework.Controls.MetroTextBox();
            this.txtNameCategory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteSubCategoryButton);
            this.groupBox2.Controls.Add(this.updateSubCategoryButton);
            this.groupBox2.Controls.Add(this.createSubCategoryButton);
            this.groupBox2.Controls.Add(this.subCategoryGridView);
            this.groupBox2.Controls.Add(this.subCategoryNameSearchTextBox);
            this.groupBox2.Controls.Add(this.txtNameSub);
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(505, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 477);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de subcategorías";
            // 
            // deleteSubCategoryButton
            // 
            this.deleteSubCategoryButton.Location = new System.Drawing.Point(348, 448);
            this.deleteSubCategoryButton.Name = "deleteSubCategoryButton";
            this.deleteSubCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSubCategoryButton.TabIndex = 11;
            this.deleteSubCategoryButton.Text = "Eliminar";
            this.deleteSubCategoryButton.UseSelectable = true;
            this.deleteSubCategoryButton.Click += new System.EventHandler(this.deleteSubCategoryButton_Click);
            // 
            // updateSubCategoryButton
            // 
            this.updateSubCategoryButton.Location = new System.Drawing.Point(87, 124);
            this.updateSubCategoryButton.Name = "updateSubCategoryButton";
            this.updateSubCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.updateSubCategoryButton.TabIndex = 10;
            this.updateSubCategoryButton.Text = "Modificar";
            this.updateSubCategoryButton.UseSelectable = true;
            this.updateSubCategoryButton.Click += new System.EventHandler(this.updateSubCategoryButton_Click);
            // 
            // createSubCategoryButton
            // 
            this.createSubCategoryButton.Location = new System.Drawing.Point(6, 124);
            this.createSubCategoryButton.Name = "createSubCategoryButton";
            this.createSubCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.createSubCategoryButton.TabIndex = 9;
            this.createSubCategoryButton.Text = "Agregar";
            this.createSubCategoryButton.UseSelectable = true;
            this.createSubCategoryButton.Click += new System.EventHandler(this.createSubCategoryButton_Click);
            // 
            // subCategoryGridView
            // 
            this.subCategoryGridView.AllowUserToResizeRows = false;
            this.subCategoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subCategoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subCategoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.subCategoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.subCategoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subCategoryGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.subCategoryGridView.EnableHeadersVisualStyles = false;
            this.subCategoryGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subCategoryGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.subCategoryGridView.Location = new System.Drawing.Point(6, 153);
            this.subCategoryGridView.Name = "subCategoryGridView";
            this.subCategoryGridView.ReadOnly = true;
            this.subCategoryGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subCategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.subCategoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subCategoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subCategoryGridView.Size = new System.Drawing.Size(417, 289);
            this.subCategoryGridView.TabIndex = 8;
            this.subCategoryGridView.Click += new System.EventHandler(this.subCategoryGridView_Click);
            // 
            // subCategoryNameSearchTextBox
            // 
            // 
            // 
            // 
            this.subCategoryNameSearchTextBox.CustomButton.Image = null;
            this.subCategoryNameSearchTextBox.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.subCategoryNameSearchTextBox.CustomButton.Name = "";
            this.subCategoryNameSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subCategoryNameSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subCategoryNameSearchTextBox.CustomButton.TabIndex = 1;
            this.subCategoryNameSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subCategoryNameSearchTextBox.CustomButton.UseSelectable = true;
            this.subCategoryNameSearchTextBox.CustomButton.Visible = false;
            this.subCategoryNameSearchTextBox.Lines = new string[0];
            this.subCategoryNameSearchTextBox.Location = new System.Drawing.Point(236, 124);
            this.subCategoryNameSearchTextBox.MaxLength = 32767;
            this.subCategoryNameSearchTextBox.Name = "subCategoryNameSearchTextBox";
            this.subCategoryNameSearchTextBox.PasswordChar = '\0';
            this.subCategoryNameSearchTextBox.PromptText = "Ingrese texto a buscar";
            this.subCategoryNameSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subCategoryNameSearchTextBox.SelectedText = "";
            this.subCategoryNameSearchTextBox.SelectionLength = 0;
            this.subCategoryNameSearchTextBox.SelectionStart = 0;
            this.subCategoryNameSearchTextBox.ShortcutsEnabled = true;
            this.subCategoryNameSearchTextBox.Size = new System.Drawing.Size(187, 23);
            this.subCategoryNameSearchTextBox.TabIndex = 6;
            this.subCategoryNameSearchTextBox.UseSelectable = true;
            this.subCategoryNameSearchTextBox.WaterMark = "Ingrese texto a buscar";
            this.subCategoryNameSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subCategoryNameSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.subCategoryNameSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subCategoryNameSearchTextBox_KeyPress);
            // 
            // txtNameSub
            // 
            // 
            // 
            // 
            this.txtNameSub.CustomButton.Image = null;
            this.txtNameSub.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txtNameSub.CustomButton.Name = "";
            this.txtNameSub.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameSub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameSub.CustomButton.TabIndex = 1;
            this.txtNameSub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameSub.CustomButton.UseSelectable = true;
            this.txtNameSub.CustomButton.Visible = false;
            this.txtNameSub.Lines = new string[0];
            this.txtNameSub.Location = new System.Drawing.Point(108, 80);
            this.txtNameSub.MaxLength = 32767;
            this.txtNameSub.Name = "txtNameSub";
            this.txtNameSub.PasswordChar = '\0';
            this.txtNameSub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameSub.SelectedText = "";
            this.txtNameSub.SelectionLength = 0;
            this.txtNameSub.SelectionStart = 0;
            this.txtNameSub.ShortcutsEnabled = true;
            this.txtNameSub.Size = new System.Drawing.Size(315, 23);
            this.txtNameSub.TabIndex = 3;
            this.txtNameSub.UseSelectable = true;
            this.txtNameSub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameSub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(108, 31);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(315, 29);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Subcategoría";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Categoría";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateCategoryButton);
            this.groupBox1.Controls.Add(this.createCategoryButton);
            this.groupBox1.Controls.Add(this.deleteCategoryButton);
            this.groupBox1.Controls.Add(this.categoryGridView);
            this.groupBox1.Controls.Add(this.categoryNameSearchTextBox);
            this.groupBox1.Controls.Add(this.txtIDCategory);
            this.groupBox1.Controls.Add(this.txtNameCategory);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 477);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de categorias";
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.Location = new System.Drawing.Point(87, 124);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.updateCategoryButton.TabIndex = 11;
            this.updateCategoryButton.Text = "Modificar";
            this.updateCategoryButton.UseSelectable = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.Location = new System.Drawing.Point(6, 124);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.createCategoryButton.TabIndex = 10;
            this.createCategoryButton.Text = "Agregar";
            this.createCategoryButton.UseSelectable = true;
            this.createCategoryButton.Click += new System.EventHandler(this.createCategoryButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(361, 448);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCategoryButton.TabIndex = 9;
            this.deleteCategoryButton.Text = "Eliminar";
            this.deleteCategoryButton.UseSelectable = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.AllowUserToResizeRows = false;
            this.categoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.categoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoryGridView.EnableHeadersVisualStyles = false;
            this.categoryGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.categoryGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryGridView.Location = new System.Drawing.Point(6, 153);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.ReadOnly = true;
            this.categoryGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categoryGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryGridView.Size = new System.Drawing.Size(430, 289);
            this.categoryGridView.TabIndex = 8;
            this.categoryGridView.Click += new System.EventHandler(this.categoryGridView_Click);
            // 
            // categoryNameSearchTextBox
            // 
            // 
            // 
            // 
            this.categoryNameSearchTextBox.CustomButton.Image = null;
            this.categoryNameSearchTextBox.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.categoryNameSearchTextBox.CustomButton.Name = "";
            this.categoryNameSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.categoryNameSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.categoryNameSearchTextBox.CustomButton.TabIndex = 1;
            this.categoryNameSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.categoryNameSearchTextBox.CustomButton.UseSelectable = true;
            this.categoryNameSearchTextBox.CustomButton.Visible = false;
            this.categoryNameSearchTextBox.Lines = new string[0];
            this.categoryNameSearchTextBox.Location = new System.Drawing.Point(249, 124);
            this.categoryNameSearchTextBox.MaxLength = 32767;
            this.categoryNameSearchTextBox.Name = "categoryNameSearchTextBox";
            this.categoryNameSearchTextBox.PasswordChar = '\0';
            this.categoryNameSearchTextBox.PromptText = "Ingrese texto a buscar";
            this.categoryNameSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.categoryNameSearchTextBox.SelectedText = "";
            this.categoryNameSearchTextBox.SelectionLength = 0;
            this.categoryNameSearchTextBox.SelectionStart = 0;
            this.categoryNameSearchTextBox.ShortcutsEnabled = true;
            this.categoryNameSearchTextBox.Size = new System.Drawing.Size(187, 23);
            this.categoryNameSearchTextBox.TabIndex = 6;
            this.categoryNameSearchTextBox.UseSelectable = true;
            this.categoryNameSearchTextBox.WaterMark = "Ingrese texto a buscar";
            this.categoryNameSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.categoryNameSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.categoryNameSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categoryNameSearchTextBox_KeyPress);
            // 
            // txtIDCategory
            // 
            // 
            // 
            // 
            this.txtIDCategory.CustomButton.Image = null;
            this.txtIDCategory.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txtIDCategory.CustomButton.Name = "";
            this.txtIDCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCategory.CustomButton.TabIndex = 1;
            this.txtIDCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCategory.CustomButton.UseSelectable = true;
            this.txtIDCategory.CustomButton.Visible = false;
            this.txtIDCategory.Enabled = false;
            this.txtIDCategory.Lines = new string[0];
            this.txtIDCategory.Location = new System.Drawing.Point(112, 31);
            this.txtIDCategory.MaxLength = 32767;
            this.txtIDCategory.Name = "txtIDCategory";
            this.txtIDCategory.PasswordChar = '\0';
            this.txtIDCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCategory.SelectedText = "";
            this.txtIDCategory.SelectionLength = 0;
            this.txtIDCategory.SelectionStart = 0;
            this.txtIDCategory.ShortcutsEnabled = true;
            this.txtIDCategory.Size = new System.Drawing.Size(50, 23);
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
            this.txtNameCategory.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtNameCategory.CustomButton.Name = "";
            this.txtNameCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameCategory.CustomButton.TabIndex = 1;
            this.txtNameCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameCategory.CustomButton.UseSelectable = true;
            this.txtNameCategory.CustomButton.Visible = false;
            this.txtNameCategory.Lines = new string[0];
            this.txtNameCategory.Location = new System.Drawing.Point(112, 80);
            this.txtNameCategory.MaxLength = 32767;
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.PasswordChar = '\0';
            this.txtNameCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameCategory.SelectedText = "";
            this.txtNameCategory.SelectionLength = 0;
            this.txtNameCategory.SelectionStart = 0;
            this.txtNameCategory.ShortcutsEnabled = true;
            this.txtNameCategory.Size = new System.Drawing.Size(324, 23);
            this.txtNameCategory.TabIndex = 3;
            this.txtNameCategory.UseSelectable = true;
            this.txtNameCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Categoría";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(859, 503);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // UcCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCategory";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcCategory_Load);
            this.Leave += new System.EventHandler(this.UcCategory_Leave);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox subCategoryNameSearchTextBox;
        private MetroFramework.Controls.MetroTextBox txtNameSub;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox categoryNameSearchTextBox;
        private MetroFramework.Controls.MetroTextBox txtNameCategory;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid subCategoryGridView;
        private MetroFramework.Controls.MetroGrid categoryGridView;
        private MetroFramework.Controls.MetroTextBox txtIDCategory;
        private MetroFramework.Controls.MetroButton deleteSubCategoryButton;
        private MetroFramework.Controls.MetroButton updateSubCategoryButton;
        private MetroFramework.Controls.MetroButton createSubCategoryButton;
        private MetroFramework.Controls.MetroButton updateCategoryButton;
        private MetroFramework.Controls.MetroButton createCategoryButton;
        private MetroFramework.Controls.MetroButton deleteCategoryButton;
        private MetroFramework.Controls.MetroButton clearButton;
    }
}
