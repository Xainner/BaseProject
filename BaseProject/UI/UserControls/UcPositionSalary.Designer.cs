namespace UI.UserControls
{
    partial class UcPositionSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPosition = new MetroFramework.Controls.MetroGrid();
            this.txtSearchPosition = new MetroFramework.Controls.MetroTextBox();
            this.txtNamePosition = new MetroFramework.Controls.MetroTextBox();
            this.cmbSalary = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalary = new MetroFramework.Controls.MetroGrid();
            this.txtSearchSalary = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.deleteSalaryButton = new MetroFramework.Controls.MetroButton();
            this.createSalaryButton = new MetroFramework.Controls.MetroButton();
            this.updateSalaryButton = new MetroFramework.Controls.MetroButton();
            this.createPositionButton = new MetroFramework.Controls.MetroButton();
            this.updatePositionButton = new MetroFramework.Controls.MetroButton();
            this.deletePositionButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deletePositionButton);
            this.groupBox2.Controls.Add(this.updatePositionButton);
            this.groupBox2.Controls.Add(this.createPositionButton);
            this.groupBox2.Controls.Add(this.dgvPosition);
            this.groupBox2.Controls.Add(this.txtSearchPosition);
            this.groupBox2.Controls.Add(this.txtNamePosition);
            this.groupBox2.Controls.Add(this.cmbSalary);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(505, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 477);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de posición de trabajo";
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToResizeRows = false;
            this.dgvPosition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPosition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPosition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosition.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPosition.EnableHeadersVisualStyles = false;
            this.dgvPosition.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPosition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPosition.Location = new System.Drawing.Point(6, 153);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPosition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(417, 289);
            this.dgvPosition.TabIndex = 8;
            this.dgvPosition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPosition_MouseClick);
            // 
            // txtSearchPosition
            // 
            // 
            // 
            // 
            this.txtSearchPosition.CustomButton.Image = null;
            this.txtSearchPosition.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSearchPosition.CustomButton.Name = "";
            this.txtSearchPosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchPosition.CustomButton.TabIndex = 1;
            this.txtSearchPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPosition.CustomButton.UseSelectable = true;
            this.txtSearchPosition.CustomButton.Visible = false;
            this.txtSearchPosition.Lines = new string[0];
            this.txtSearchPosition.Location = new System.Drawing.Point(236, 124);
            this.txtSearchPosition.MaxLength = 32767;
            this.txtSearchPosition.Name = "txtSearchPosition";
            this.txtSearchPosition.PasswordChar = '\0';
            this.txtSearchPosition.PromptText = "Ingrese texto a buscar";
            this.txtSearchPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchPosition.SelectedText = "";
            this.txtSearchPosition.SelectionLength = 0;
            this.txtSearchPosition.SelectionStart = 0;
            this.txtSearchPosition.ShortcutsEnabled = true;
            this.txtSearchPosition.Size = new System.Drawing.Size(187, 23);
            this.txtSearchPosition.TabIndex = 6;
            this.txtSearchPosition.UseSelectable = true;
            this.txtSearchPosition.WaterMark = "Ingrese texto a buscar";
            this.txtSearchPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchPosition_KeyPress);
            // 
            // txtNamePosition
            // 
            // 
            // 
            // 
            this.txtNamePosition.CustomButton.Image = null;
            this.txtNamePosition.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txtNamePosition.CustomButton.Name = "";
            this.txtNamePosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamePosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamePosition.CustomButton.TabIndex = 1;
            this.txtNamePosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamePosition.CustomButton.UseSelectable = true;
            this.txtNamePosition.CustomButton.Visible = false;
            this.txtNamePosition.Lines = new string[0];
            this.txtNamePosition.Location = new System.Drawing.Point(108, 31);
            this.txtNamePosition.MaxLength = 32767;
            this.txtNamePosition.Name = "txtNamePosition";
            this.txtNamePosition.PasswordChar = '\0';
            this.txtNamePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamePosition.SelectedText = "";
            this.txtNamePosition.SelectionLength = 0;
            this.txtNamePosition.SelectionStart = 0;
            this.txtNamePosition.ShortcutsEnabled = true;
            this.txtNamePosition.Size = new System.Drawing.Size(315, 23);
            this.txtNamePosition.TabIndex = 3;
            this.txtNamePosition.UseSelectable = true;
            this.txtNamePosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamePosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbSalary
            // 
            this.cmbSalary.FormattingEnabled = true;
            this.cmbSalary.ItemHeight = 23;
            this.cmbSalary.Location = new System.Drawing.Point(108, 80);
            this.cmbSalary.Name = "cmbSalary";
            this.cmbSalary.Size = new System.Drawing.Size(315, 29);
            this.cmbSalary.TabIndex = 2;
            this.cmbSalary.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 31);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Posición";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Salario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateSalaryButton);
            this.groupBox1.Controls.Add(this.createSalaryButton);
            this.groupBox1.Controls.Add(this.deleteSalaryButton);
            this.groupBox1.Controls.Add(this.dgvSalary);
            this.groupBox1.Controls.Add(this.txtSearchSalary);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 477);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de Salarios";
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToResizeRows = false;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalary.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSalary.EnableHeadersVisualStyles = false;
            this.dgvSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSalary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSalary.Location = new System.Drawing.Point(6, 153);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.ReadOnly = true;
            this.dgvSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalary.Size = new System.Drawing.Size(430, 289);
            this.dgvSalary.TabIndex = 8;
            this.dgvSalary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvSalary_MouseClick);
            // 
            // txtSearchSalary
            // 
            // 
            // 
            // 
            this.txtSearchSalary.CustomButton.Image = null;
            this.txtSearchSalary.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSearchSalary.CustomButton.Name = "";
            this.txtSearchSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchSalary.CustomButton.TabIndex = 1;
            this.txtSearchSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchSalary.CustomButton.UseSelectable = true;
            this.txtSearchSalary.CustomButton.Visible = false;
            this.txtSearchSalary.Lines = new string[0];
            this.txtSearchSalary.Location = new System.Drawing.Point(249, 124);
            this.txtSearchSalary.MaxLength = 32767;
            this.txtSearchSalary.Name = "txtSearchSalary";
            this.txtSearchSalary.PasswordChar = '\0';
            this.txtSearchSalary.PromptText = "Ingrese texto a buscar";
            this.txtSearchSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchSalary.SelectedText = "";
            this.txtSearchSalary.SelectionLength = 0;
            this.txtSearchSalary.SelectionStart = 0;
            this.txtSearchSalary.ShortcutsEnabled = true;
            this.txtSearchSalary.Size = new System.Drawing.Size(187, 23);
            this.txtSearchSalary.TabIndex = 6;
            this.txtSearchSalary.UseSelectable = true;
            this.txtSearchSalary.WaterMark = "Ingrese texto a buscar";
            this.txtSearchSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSalary_KeyPress);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(28, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(112, 31);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(50, 23);
            this.txtID.TabIndex = 3;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(112, 80);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(324, 23);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Cantidad";
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
            // deleteSalaryButton
            // 
            this.deleteSalaryButton.Location = new System.Drawing.Point(361, 448);
            this.deleteSalaryButton.Name = "deleteSalaryButton";
            this.deleteSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteSalaryButton.TabIndex = 9;
            this.deleteSalaryButton.Text = "Eliminar";
            this.deleteSalaryButton.UseSelectable = true;
            this.deleteSalaryButton.Click += new System.EventHandler(this.deleteSalaryButton_Click);
            // 
            // createSalaryButton
            // 
            this.createSalaryButton.Location = new System.Drawing.Point(6, 124);
            this.createSalaryButton.Name = "createSalaryButton";
            this.createSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.createSalaryButton.TabIndex = 10;
            this.createSalaryButton.Text = "Agregar";
            this.createSalaryButton.UseSelectable = true;
            this.createSalaryButton.Click += new System.EventHandler(this.createSalaryButton_Click);
            // 
            // updateSalaryButton
            // 
            this.updateSalaryButton.Location = new System.Drawing.Point(87, 124);
            this.updateSalaryButton.Name = "updateSalaryButton";
            this.updateSalaryButton.Size = new System.Drawing.Size(75, 23);
            this.updateSalaryButton.TabIndex = 11;
            this.updateSalaryButton.Text = "Modificar";
            this.updateSalaryButton.UseSelectable = true;
            this.updateSalaryButton.Click += new System.EventHandler(this.updateSalaryButton_Click);
            // 
            // createPositionButton
            // 
            this.createPositionButton.Location = new System.Drawing.Point(6, 124);
            this.createPositionButton.Name = "createPositionButton";
            this.createPositionButton.Size = new System.Drawing.Size(75, 23);
            this.createPositionButton.TabIndex = 9;
            this.createPositionButton.Text = "Agregar";
            this.createPositionButton.UseSelectable = true;
            this.createPositionButton.Click += new System.EventHandler(this.createPositionButton_Click);
            // 
            // updatePositionButton
            // 
            this.updatePositionButton.Location = new System.Drawing.Point(87, 124);
            this.updatePositionButton.Name = "updatePositionButton";
            this.updatePositionButton.Size = new System.Drawing.Size(75, 23);
            this.updatePositionButton.TabIndex = 9;
            this.updatePositionButton.Text = "Modificar";
            this.updatePositionButton.UseSelectable = true;
            this.updatePositionButton.Click += new System.EventHandler(this.updatePositionButton_Click);
            // 
            // deletePositionButton
            // 
            this.deletePositionButton.Location = new System.Drawing.Point(348, 448);
            this.deletePositionButton.Name = "deletePositionButton";
            this.deletePositionButton.Size = new System.Drawing.Size(75, 23);
            this.deletePositionButton.TabIndex = 9;
            this.deletePositionButton.Text = "Eliminar";
            this.deletePositionButton.UseSelectable = true;
            this.deletePositionButton.Click += new System.EventHandler(this.deletePositionButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(859, 503);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // UcPositionSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcPositionSalary";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcPositionSalary_Load);
            this.Leave += new System.EventHandler(this.UcPositionSalary_Leave);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtSearchPosition;
        private MetroFramework.Controls.MetroTextBox txtNamePosition;
        private MetroFramework.Controls.MetroComboBox cmbSalary;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchSalary;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroGrid dgvPosition;
        private MetroFramework.Controls.MetroGrid dgvSalary;
        private MetroFramework.Controls.MetroButton updateSalaryButton;
        private MetroFramework.Controls.MetroButton createSalaryButton;
        private MetroFramework.Controls.MetroButton deleteSalaryButton;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton deletePositionButton;
        private MetroFramework.Controls.MetroButton updatePositionButton;
        private MetroFramework.Controls.MetroButton createPositionButton;
    }
}
