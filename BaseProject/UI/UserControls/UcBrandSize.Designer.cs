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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBrand = new MetroFramework.Controls.MetroGrid();
            this.brandNameSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.idBrandTextBox = new MetroFramework.Controls.MetroTextBox();
            this.brandNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBrand);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.brandNameSearchTextBox);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.idBrandTextBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.brandNameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(180, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 293);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBrand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBrand.Location = new System.Drawing.Point(6, 105);
            this.dgvBrand.MultiSelect = false;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBrand.RowHeadersVisible = false;
            this.dgvBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.Size = new System.Drawing.Size(580, 150);
            this.dgvBrand.TabIndex = 7;
            this.dgvBrand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBrand_MouseClick);
            // 
            // brandNameSearchTextBox
            // 
            // 
            // 
            // 
            this.brandNameSearchTextBox.CustomButton.Image = null;
            this.brandNameSearchTextBox.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.brandNameSearchTextBox.CustomButton.Name = "";
            this.brandNameSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandNameSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandNameSearchTextBox.CustomButton.TabIndex = 1;
            this.brandNameSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandNameSearchTextBox.CustomButton.UseSelectable = true;
            this.brandNameSearchTextBox.CustomButton.Visible = false;
            this.brandNameSearchTextBox.Lines = new string[0];
            this.brandNameSearchTextBox.Location = new System.Drawing.Point(367, 76);
            this.brandNameSearchTextBox.MaxLength = 32767;
            this.brandNameSearchTextBox.Name = "brandNameSearchTextBox";
            this.brandNameSearchTextBox.PasswordChar = '\0';
            this.brandNameSearchTextBox.PromptText = "Ingrese la marca a buscar...";
            this.brandNameSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandNameSearchTextBox.SelectedText = "";
            this.brandNameSearchTextBox.SelectionLength = 0;
            this.brandNameSearchTextBox.SelectionStart = 0;
            this.brandNameSearchTextBox.ShortcutsEnabled = true;
            this.brandNameSearchTextBox.Size = new System.Drawing.Size(219, 23);
            this.brandNameSearchTextBox.TabIndex = 6;
            this.brandNameSearchTextBox.UseSelectable = true;
            this.brandNameSearchTextBox.WaterMark = "Ingrese la marca a buscar...";
            this.brandNameSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandNameSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.brandNameSearchTextBox.Click += new System.EventHandler(this.txtSearchBrand_Click);
            this.brandNameSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBrand_KeyPress);
            // 
            // idBrandTextBox
            // 
            // 
            // 
            // 
            this.idBrandTextBox.CustomButton.Image = null;
            this.idBrandTextBox.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.idBrandTextBox.CustomButton.Name = "";
            this.idBrandTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idBrandTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idBrandTextBox.CustomButton.TabIndex = 1;
            this.idBrandTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idBrandTextBox.CustomButton.UseSelectable = true;
            this.idBrandTextBox.CustomButton.Visible = false;
            this.idBrandTextBox.Enabled = false;
            this.idBrandTextBox.Lines = new string[0];
            this.idBrandTextBox.Location = new System.Drawing.Point(65, 32);
            this.idBrandTextBox.MaxLength = 32767;
            this.idBrandTextBox.Name = "idBrandTextBox";
            this.idBrandTextBox.PasswordChar = '\0';
            this.idBrandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idBrandTextBox.SelectedText = "";
            this.idBrandTextBox.SelectionLength = 0;
            this.idBrandTextBox.SelectionStart = 0;
            this.idBrandTextBox.ShortcutsEnabled = true;
            this.idBrandTextBox.Size = new System.Drawing.Size(77, 23);
            this.idBrandTextBox.TabIndex = 3;
            this.idBrandTextBox.UseSelectable = true;
            this.idBrandTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idBrandTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // brandNameTextBox
            // 
            // 
            // 
            // 
            this.brandNameTextBox.CustomButton.Image = null;
            this.brandNameTextBox.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.brandNameTextBox.CustomButton.Name = "";
            this.brandNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandNameTextBox.CustomButton.TabIndex = 1;
            this.brandNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandNameTextBox.CustomButton.UseSelectable = true;
            this.brandNameTextBox.CustomButton.Visible = false;
            this.brandNameTextBox.Lines = new string[0];
            this.brandNameTextBox.Location = new System.Drawing.Point(220, 32);
            this.brandNameTextBox.MaxLength = 32767;
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.PasswordChar = '\0';
            this.brandNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandNameTextBox.SelectedText = "";
            this.brandNameTextBox.SelectionLength = 0;
            this.brandNameTextBox.SelectionStart = 0;
            this.brandNameTextBox.ShortcutsEnabled = true;
            this.brandNameTextBox.Size = new System.Drawing.Size(181, 23);
            this.brandNameTextBox.TabIndex = 3;
            this.brandNameTextBox.UseSelectable = true;
            this.brandNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 32);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Marca";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Id";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(511, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 261);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 261);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Agregar";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(87, 261);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UcBrandSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcBrandSize";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcBrandSize_Load);
            this.Leave += new System.EventHandler(this.UcBrandSize_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox brandNameSearchTextBox;
        private MetroFramework.Controls.MetroTextBox idBrandTextBox;
        private MetroFramework.Controls.MetroTextBox brandNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvBrand;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
    }
}
