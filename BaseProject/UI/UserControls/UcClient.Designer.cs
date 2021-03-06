﻿namespace UI.UserControls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.txtEmailClient = new MetroFramework.Controls.MetroTextBox();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNameClient = new MetroFramework.Controls.MetroTextBox();
            this.txtLastnameClient = new MetroFramework.Controls.MetroTextBox();
            this.datepBornDate = new MetroFramework.Controls.MetroDateTime();
            this.txtIdentification = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbIdentificationType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchClient = new MetroFramework.Controls.MetroTextBox();
            this.clientsGridView = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.txtEmailClient);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtNameClient);
            this.groupBox1.Controls.Add(this.txtLastnameClient);
            this.groupBox1.Controls.Add(this.datepBornDate);
            this.groupBox1.Controls.Add(this.txtIdentification);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.cmbIdentificationType);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 156);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(837, 127);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // txtEmailClient
            // 
            // 
            // 
            // 
            this.txtEmailClient.CustomButton.Image = null;
            this.txtEmailClient.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtEmailClient.CustomButton.Name = "";
            this.txtEmailClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailClient.CustomButton.TabIndex = 1;
            this.txtEmailClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailClient.CustomButton.UseSelectable = true;
            this.txtEmailClient.CustomButton.Visible = false;
            this.txtEmailClient.Lines = new string[0];
            this.txtEmailClient.Location = new System.Drawing.Point(412, 27);
            this.txtEmailClient.MaxLength = 32767;
            this.txtEmailClient.Name = "txtEmailClient";
            this.txtEmailClient.PasswordChar = '\0';
            this.txtEmailClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailClient.SelectedText = "";
            this.txtEmailClient.SelectionLength = 0;
            this.txtEmailClient.SelectionStart = 0;
            this.txtEmailClient.ShortcutsEnabled = true;
            this.txtEmailClient.Size = new System.Drawing.Size(159, 23);
            this.txtEmailClient.TabIndex = 10;
            this.txtEmailClient.UseSelectable = true;
            this.txtEmailClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(168, 127);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(87, 127);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 31;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(261, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Apellidos";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 127);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 31;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 76);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "E-mail";
            // 
            // txtNameClient
            // 
            // 
            // 
            // 
            this.txtNameClient.CustomButton.Image = null;
            this.txtNameClient.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtNameClient.CustomButton.Name = "";
            this.txtNameClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameClient.CustomButton.TabIndex = 1;
            this.txtNameClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameClient.CustomButton.UseSelectable = true;
            this.txtNameClient.CustomButton.Visible = false;
            this.txtNameClient.Lines = new string[0];
            this.txtNameClient.Location = new System.Drawing.Point(71, 27);
            this.txtNameClient.MaxLength = 32767;
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.PasswordChar = '\0';
            this.txtNameClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameClient.SelectedText = "";
            this.txtNameClient.SelectionLength = 0;
            this.txtNameClient.SelectionStart = 0;
            this.txtNameClient.ShortcutsEnabled = true;
            this.txtNameClient.Size = new System.Drawing.Size(159, 23);
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
            this.txtLastnameClient.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtLastnameClient.CustomButton.Name = "";
            this.txtLastnameClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastnameClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastnameClient.CustomButton.TabIndex = 1;
            this.txtLastnameClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastnameClient.CustomButton.UseSelectable = true;
            this.txtLastnameClient.CustomButton.Visible = false;
            this.txtLastnameClient.Lines = new string[0];
            this.txtLastnameClient.Location = new System.Drawing.Point(71, 76);
            this.txtLastnameClient.MaxLength = 32767;
            this.txtLastnameClient.Name = "txtLastnameClient";
            this.txtLastnameClient.PasswordChar = '\0';
            this.txtLastnameClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastnameClient.SelectedText = "";
            this.txtLastnameClient.SelectionLength = 0;
            this.txtLastnameClient.SelectionStart = 0;
            this.txtLastnameClient.ShortcutsEnabled = true;
            this.txtLastnameClient.Size = new System.Drawing.Size(159, 23);
            this.txtLastnameClient.TabIndex = 9;
            this.txtLastnameClient.UseSelectable = true;
            this.txtLastnameClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastnameClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datepBornDate
            // 
            this.datepBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepBornDate.Location = new System.Drawing.Point(412, 80);
            this.datepBornDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepBornDate.Name = "datepBornDate";
            this.datepBornDate.Size = new System.Drawing.Size(159, 29);
            this.datepBornDate.TabIndex = 11;
            // 
            // txtIdentification
            // 
            // 
            // 
            // 
            this.txtIdentification.CustomButton.Image = null;
            this.txtIdentification.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtIdentification.CustomButton.Name = "";
            this.txtIdentification.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdentification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdentification.CustomButton.TabIndex = 1;
            this.txtIdentification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdentification.CustomButton.UseSelectable = true;
            this.txtIdentification.CustomButton.Visible = false;
            this.txtIdentification.Lines = new string[0];
            this.txtIdentification.Location = new System.Drawing.Point(741, 76);
            this.txtIdentification.MaxLength = 32767;
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.PasswordChar = '\0';
            this.txtIdentification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdentification.SelectedText = "";
            this.txtIdentification.SelectionLength = 0;
            this.txtIdentification.SelectionStart = 0;
            this.txtIdentification.ShortcutsEnabled = true;
            this.txtIdentification.Size = new System.Drawing.Size(171, 23);
            this.txtIdentification.TabIndex = 13;
            this.txtIdentification.UseSelectable = true;
            this.txtIdentification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdentification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(601, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(134, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tipo de identificación";
            // 
            // cmbIdentificationType
            // 
            this.cmbIdentificationType.FormattingEnabled = true;
            this.cmbIdentificationType.ItemHeight = 23;
            this.cmbIdentificationType.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte",
            "Permiso de trabajo",
            "Residencia",
            "Cédula Jurídica"});
            this.cmbIdentificationType.Location = new System.Drawing.Point(741, 27);
            this.cmbIdentificationType.Name = "cmbIdentificationType";
            this.cmbIdentificationType.Size = new System.Drawing.Size(171, 29);
            this.cmbIdentificationType.TabIndex = 12;
            this.cmbIdentificationType.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(601, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Identificación";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(261, 80);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(130, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Fecha de nacimiento";
            // 
            // txtSearchClient
            // 
            // 
            // 
            // 
            this.txtSearchClient.CustomButton.Image = null;
            this.txtSearchClient.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSearchClient.CustomButton.Name = "";
            this.txtSearchClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchClient.CustomButton.TabIndex = 1;
            this.txtSearchClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchClient.CustomButton.UseSelectable = true;
            this.txtSearchClient.CustomButton.Visible = false;
            this.txtSearchClient.Lines = new string[0];
            this.txtSearchClient.Location = new System.Drawing.Point(748, 179);
            this.txtSearchClient.MaxLength = 32767;
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.PasswordChar = '\0';
            this.txtSearchClient.PromptText = "Ingrese texto a buscar";
            this.txtSearchClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchClient.SelectedText = "";
            this.txtSearchClient.SelectionLength = 0;
            this.txtSearchClient.SelectionStart = 0;
            this.txtSearchClient.ShortcutsEnabled = true;
            this.txtSearchClient.Size = new System.Drawing.Size(187, 23);
            this.txtSearchClient.TabIndex = 23;
            this.txtSearchClient.UseSelectable = true;
            this.txtSearchClient.WaterMark = "Ingrese texto a buscar";
            this.txtSearchClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchClient_KeyPress);
            // 
            // clientsGridView
            // 
            this.clientsGridView.AllowUserToResizeRows = false;
            this.clientsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clientsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientsGridView.EnableHeadersVisualStyles = false;
            this.clientsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clientsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientsGridView.Location = new System.Drawing.Point(17, 208);
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.ReadOnly = true;
            this.clientsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clientsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGridView.Size = new System.Drawing.Size(918, 313);
            this.clientsGridView.TabIndex = 30;
            this.clientsGridView.Click += new System.EventHandler(this.clientsGridView_Click);
            // 
            // UcClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientsGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchClient);
            this.Name = "UcClient";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcClient_Load);
            this.Leave += new System.EventHandler(this.UcClient_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox txtSearchClient;
        private MetroFramework.Controls.MetroGrid clientsGridView;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton clearButton;
    }
}
