namespace UI.Frames
{
    partial class FrmBrand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.brandsGridView = new MetroFramework.Controls.MetroGrid();
            this.brandNameSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.idBrandTextBox = new MetroFramework.Controls.MetroTextBox();
            this.brandNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.brandsGridView);
            this.groupBox1.Controls.Add(this.brandNameSearchTextBox);
            this.groupBox1.Controls.Add(this.idBrandTextBox);
            this.groupBox1.Controls.Add(this.brandNameTextBox);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(20, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 293);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de marcas de ropa";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 264);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 264);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 15;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(514, 264);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(87, 264);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // brandsGridView
            // 
            this.brandsGridView.AllowUserToResizeRows = false;
            this.brandsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brandsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brandsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.brandsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brandsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.brandsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.brandsGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.brandsGridView.EnableHeadersVisualStyles = false;
            this.brandsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.brandsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brandsGridView.Location = new System.Drawing.Point(6, 105);
            this.brandsGridView.MultiSelect = false;
            this.brandsGridView.Name = "brandsGridView";
            this.brandsGridView.ReadOnly = true;
            this.brandsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brandsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.brandsGridView.RowHeadersVisible = false;
            this.brandsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.brandsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brandsGridView.Size = new System.Drawing.Size(580, 150);
            this.brandsGridView.TabIndex = 7;
            this.brandsGridView.Click += new System.EventHandler(this.brandsGridView_Click);
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
            this.brandNameSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.brandNameSearchTextBox_KeyUp);
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 416);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBrand";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.FrmBrand_Load);
            this.Leave += new System.EventHandler(this.FrmBrand_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid brandsGridView;
        private MetroFramework.Controls.MetroTextBox brandNameSearchTextBox;
        private MetroFramework.Controls.MetroTextBox idBrandTextBox;
        private MetroFramework.Controls.MetroTextBox brandNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton updateButton;
    }
}