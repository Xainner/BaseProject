namespace UI.UserControls
{
    partial class UcClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailClient = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNameClient = new MetroFramework.Controls.MetroTextBox();
            this.txtLastnameClient = new MetroFramework.Controls.MetroTextBox();
            this.datepBornDate = new MetroFramework.Controls.MetroDateTime();
            this.txtIdentification = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbIdentificationType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnDeleteClient = new MetroFramework.Controls.MetroTile();
            this.btnUpdateClient = new MetroFramework.Controls.MetroTile();
            this.btnAddClient = new MetroFramework.Controls.MetroTile();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.txtSearchClient = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailClient);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtNameClient);
            this.groupBox1.Controls.Add(this.txtLastnameClient);
            this.groupBox1.Controls.Add(this.datepBornDate);
            this.groupBox1.Controls.Add(this.txtIdentification);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.cmbIdentificationType);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Location = new System.Drawing.Point(43, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 189);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // txtEmailClient
            // 
            // 
            // 
            // 
            this.txtEmailClient.CustomButton.Image = null;
            this.txtEmailClient.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtEmailClient.CustomButton.Name = "";
            this.txtEmailClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailClient.CustomButton.TabIndex = 1;
            this.txtEmailClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailClient.CustomButton.UseSelectable = true;
            this.txtEmailClient.CustomButton.Visible = false;
            this.txtEmailClient.Lines = new string[0];
            this.txtEmailClient.Location = new System.Drawing.Point(93, 120);
            this.txtEmailClient.MaxLength = 32767;
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.PasswordChar = '\0';
            this.txtEmailClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailClient.SelectedText = "";
            this.txtEmailClient.SelectionLength = 0;
            this.txtEmailClient.SelectionStart = 0;
            this.txtEmailClient.ShortcutsEnabled = true;
            this.txtEmailClient.Size = new System.Drawing.Size(171, 23);
            this.txtEmailClient.TabIndex = 10;
            this.txtEmailClient.UseSelectable = true;
            this.txtEmailClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Apellido:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 120);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "E-mail:";
            // 
            // txtNameClient
            // 
            // 
            // 
            // 
            this.txtNameClient.CustomButton.Image = null;
            this.txtNameClient.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtNameClient.CustomButton.Name = "";
            this.txtNameClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameClient.CustomButton.TabIndex = 1;
            this.txtNameClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameClient.CustomButton.UseSelectable = true;
            this.txtNameClient.CustomButton.Visible = false;
            this.txtNameClient.Lines = new string[0];
            this.txtNameClient.Location = new System.Drawing.Point(93, 27);
            this.txtNameClient.MaxLength = 32767;
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.PasswordChar = '\0';
            this.txtNameClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameClient.SelectedText = "";
            this.txtNameClient.SelectionLength = 0;
            this.txtNameClient.SelectionStart = 0;
            this.txtNameClient.ShortcutsEnabled = true;
            this.txtNameClient.Size = new System.Drawing.Size(171, 23);
            this.txtNameClient.TabIndex = 8;
            this.txtNameClient.UseSelectable = true;
            this.txtNameClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastnameClient
            // 
            // 
            // 
            // 
            this.txtLastnameClient.CustomButton.Image = null;
            this.txtLastnameClient.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtLastnameClient.CustomButton.Name = "";
            this.txtLastnameClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastnameClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastnameClient.CustomButton.TabIndex = 1;
            this.txtLastnameClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastnameClient.CustomButton.UseSelectable = true;
            this.txtLastnameClient.CustomButton.Visible = false;
            this.txtLastnameClient.Lines = new string[0];
            this.txtLastnameClient.Location = new System.Drawing.Point(93, 76);
            this.txtLastnameClient.MaxLength = 32767;
            this.txtLastnameClient.Name = "txtLastnameClient";
            this.txtLastnameClient.PasswordChar = '\0';
            this.txtLastnameClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastnameClient.SelectedText = "";
            this.txtLastnameClient.SelectionLength = 0;
            this.txtLastnameClient.SelectionStart = 0;
            this.txtLastnameClient.ShortcutsEnabled = true;
            this.txtLastnameClient.Size = new System.Drawing.Size(171, 23);
            this.txtLastnameClient.TabIndex = 9;
            this.txtLastnameClient.UseSelectable = true;
            this.txtLastnameClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastnameClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datepBornDate
            // 
            this.datepBornDate.Location = new System.Drawing.Point(426, 120);
            this.datepBornDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepBornDate.Name = "datepBornDate";
            this.datepBornDate.Size = new System.Drawing.Size(244, 29);
            this.datepBornDate.TabIndex = 11;
            // 
            // txtIdentification
            // 
            // 
            // 
            // 
            this.txtIdentification.CustomButton.Image = null;
            this.txtIdentification.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtIdentification.CustomButton.Name = "";
            this.txtIdentification.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdentification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdentification.CustomButton.TabIndex = 1;
            this.txtIdentification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdentification.CustomButton.UseSelectable = true;
            this.txtIdentification.CustomButton.Visible = false;
            this.txtIdentification.Lines = new string[0];
            this.txtIdentification.Location = new System.Drawing.Point(426, 76);
            this.txtIdentification.MaxLength = 32767;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.PasswordChar = '\0';
            this.txtIdentification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdentification.SelectedText = "";
            this.txtIdentification.SelectionLength = 0;
            this.txtIdentification.SelectionStart = 0;
            this.txtIdentification.ShortcutsEnabled = true;
            this.txtIdentification.Size = new System.Drawing.Size(188, 23);
            this.txtIdentification.TabIndex = 13;
            this.txtIdentification.UseSelectable = true;
            this.txtIdentification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdentification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(302, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tipo Identificación:";
            // 
            // cmbIdentificationType
            // 
            this.cmbIdentificationType.FormattingEnabled = true;
            this.cmbIdentificationType.ItemHeight = 23;
            this.cmbIdentificationType.Location = new System.Drawing.Point(426, 31);
            this.cmbIdentificationType.Name = "cmbIdentificationType";
            this.cmbIdentificationType.Size = new System.Drawing.Size(188, 29);
            this.cmbIdentificationType.TabIndex = 12;
            this.cmbIdentificationType.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(302, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Identificación:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(302, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Fecha nacimiento:";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.ActiveControl = null;
            this.btnDeleteClient.Location = new System.Drawing.Point(643, 481);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(83, 42);
            this.btnDeleteClient.TabIndex = 27;
            this.btnDeleteClient.Text = "Eliminar";
            this.btnDeleteClient.UseSelectable = true;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.ActiveControl = null;
            this.btnUpdateClient.Location = new System.Drawing.Point(816, 97);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(83, 43);
            this.btnUpdateClient.TabIndex = 26;
            this.btnUpdateClient.Text = "Actualizar";
            this.btnUpdateClient.UseSelectable = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.ActiveControl = null;
            this.btnAddClient.Location = new System.Drawing.Point(816, 35);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(83, 42);
            this.btnAddClient.TabIndex = 25;
            this.btnAddClient.Text = "Agregar";
            this.btnAddClient.UseSelectable = true;
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(117, 252);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(609, 213);
            this.dgvClient.TabIndex = 24;
            // 
            // txtSearchClient
            // 
            // 
            // 
            // 
            this.txtSearchClient.CustomButton.Image = null;
            this.txtSearchClient.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.txtSearchClient.CustomButton.Name = "";
            this.txtSearchClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchClient.CustomButton.TabIndex = 1;
            this.txtSearchClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchClient.CustomButton.UseSelectable = true;
            this.txtSearchClient.Lines = new string[0];
            this.txtSearchClient.Location = new System.Drawing.Point(561, 223);
            this.txtSearchClient.MaxLength = 32767;
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.PasswordChar = '\0';
            this.txtSearchClient.PromptText = "Ingrese texto a buscar";
            this.txtSearchClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchClient.SelectedText = "";
            this.txtSearchClient.SelectionLength = 0;
            this.txtSearchClient.SelectionStart = 0;
            this.txtSearchClient.ShortcutsEnabled = true;
            this.txtSearchClient.ShowButton = true;
            this.txtSearchClient.Size = new System.Drawing.Size(165, 23);
            this.txtSearchClient.TabIndex = 23;
            this.txtSearchClient.UseSelectable = true;
            this.txtSearchClient.WaterMark = "Ingrese texto a buscar";
            this.txtSearchClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UcClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.txtSearchClient);
            this.Name = "UcClient";
            this.Size = new System.Drawing.Size(955, 536);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtEmailClient;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNameClient;
        private MetroFramework.Controls.MetroTextBox txtLastnameClient;
        private MetroFramework.Controls.MetroDateTime datepBornDate;
        private MetroFramework.Controls.MetroTextBox txtIdentification;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbIdentificationType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile btnDeleteClient;
        private MetroFramework.Controls.MetroTile btnUpdateClient;
        private MetroFramework.Controls.MetroTile btnAddClient;
        private System.Windows.Forms.DataGridView dgvClient;
        private MetroFramework.Controls.MetroTextBox txtSearchClient;
    }
}
