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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.dgvBrand = new MetroFramework.Controls.MetroGrid();
            this.txtSearchBrand = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteBrand = new MetroFramework.Controls.MetroTile();
            this.btnUpdateBrand = new MetroFramework.Controls.MetroTile();
            this.btnAddBrand = new MetroFramework.Controls.MetroTile();
            this.txtIDBrand = new MetroFramework.Controls.MetroTextBox();
            this.txtBrand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dgvBrand);
            this.groupBox1.Controls.Add(this.txtSearchBrand);
            this.groupBox1.Controls.Add(this.btnDeleteBrand);
            this.groupBox1.Controls.Add(this.btnUpdateBrand);
            this.groupBox1.Controls.Add(this.btnAddBrand);
            this.groupBox1.Controls.Add(this.txtIDBrand);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(180, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 486);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de marcas de ropa";
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.Location = new System.Drawing.Point(39, 409);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvBrand
            // 
            this.dgvBrand.AllowUserToResizeRows = false;
            this.dgvBrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBrand.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBrand.EnableHeadersVisualStyles = false;
            this.dgvBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBrand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBrand.Location = new System.Drawing.Point(120, 237);
            this.dgvBrand.MultiSelect = false;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.ReadOnly = true;
            this.dgvBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrand.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBrand.RowHeadersVisible = false;
            this.dgvBrand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrand.Size = new System.Drawing.Size(337, 150);
            this.dgvBrand.TabIndex = 7;
            this.dgvBrand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvBrand_MouseClick);
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
            this.txtSearchBrand.Location = new System.Drawing.Point(310, 208);
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
            this.txtSearchBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBrand_KeyPress);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.ActiveControl = null;
            this.btnDeleteBrand.Location = new System.Drawing.Point(463, 409);
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
            this.btnUpdateBrand.Location = new System.Drawing.Point(463, 110);
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
            this.btnAddBrand.Location = new System.Drawing.Point(463, 32);
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
            this.txtIDBrand.Location = new System.Drawing.Point(120, 32);
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
            this.txtBrand.Location = new System.Drawing.Point(120, 106);
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
            this.metroLabel2.Location = new System.Drawing.Point(39, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Marca:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
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
        private MetroFramework.Controls.MetroTextBox txtSearchBrand;
        private MetroFramework.Controls.MetroTile btnDeleteBrand;
        private MetroFramework.Controls.MetroTile btnUpdateBrand;
        private MetroFramework.Controls.MetroTile btnAddBrand;
        private MetroFramework.Controls.MetroTextBox txtIDBrand;
        private MetroFramework.Controls.MetroTextBox txtBrand;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvBrand;
        private MetroFramework.Controls.MetroTile btnClear;
    }
}
