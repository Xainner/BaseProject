﻿namespace UI.UserControls
{
    partial class UcBusiness
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.businessFantasyNameSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.selectImageButton = new MetroFramework.Controls.MetroButton();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtWebPage = new MetroFramework.Controls.MetroTextBox();
            this.txaGeneralAddress = new MetroFramework.Controls.MetroTextBox();
            this.txaMainAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtlegalCertification = new MetroFramework.Controls.MetroTextBox();
            this.txtSocietyName = new MetroFramework.Controls.MetroTextBox();
            this.txtFantasyName = new MetroFramework.Controls.MetroTextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.businessGridView = new MetroFramework.Controls.MetroGrid();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.businessGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // businessFantasyNameSearchTextBox
            // 
            // 
            // 
            // 
            this.businessFantasyNameSearchTextBox.CustomButton.Image = null;
            this.businessFantasyNameSearchTextBox.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.businessFantasyNameSearchTextBox.CustomButton.Name = "";
            this.businessFantasyNameSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.businessFantasyNameSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.businessFantasyNameSearchTextBox.CustomButton.TabIndex = 1;
            this.businessFantasyNameSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.businessFantasyNameSearchTextBox.CustomButton.UseSelectable = true;
            this.businessFantasyNameSearchTextBox.CustomButton.Visible = false;
            this.businessFantasyNameSearchTextBox.Lines = new string[0];
            this.businessFantasyNameSearchTextBox.Location = new System.Drawing.Point(739, 394);
            this.businessFantasyNameSearchTextBox.MaxLength = 32767;
            this.businessFantasyNameSearchTextBox.Name = "businessFantasyNameSearchTextBox";
            this.businessFantasyNameSearchTextBox.PasswordChar = '\0';
            this.businessFantasyNameSearchTextBox.PromptText = "Ingrese texto a buscar";
            this.businessFantasyNameSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.businessFantasyNameSearchTextBox.SelectedText = "";
            this.businessFantasyNameSearchTextBox.SelectionLength = 0;
            this.businessFantasyNameSearchTextBox.SelectionStart = 0;
            this.businessFantasyNameSearchTextBox.ShortcutsEnabled = true;
            this.businessFantasyNameSearchTextBox.Size = new System.Drawing.Size(186, 23);
            this.businessFantasyNameSearchTextBox.TabIndex = 13;
            this.businessFantasyNameSearchTextBox.UseSelectable = true;
            this.businessFantasyNameSearchTextBox.WaterMark = "Ingrese texto a buscar";
            this.businessFantasyNameSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.businessFantasyNameSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.businessFantasyNameSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.businessFantasyNameSearchTextBox_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.selectImageButton);
            this.groupBox1.Controls.Add(this.mtxtTelephone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtWebPage);
            this.groupBox1.Controls.Add(this.txaGeneralAddress);
            this.groupBox1.Controls.Add(this.txaMainAddress);
            this.groupBox1.Controls.Add(this.txtlegalCertification);
            this.groupBox1.Controls.Add(this.txtSocietyName);
            this.groupBox1.Controls.Add(this.txtFantasyName);
            this.groupBox1.Controls.Add(this.pbLogo);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 370);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información general de la tienda";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(749, 329);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Modificar";
            this.updateButton.UseSelectable = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(830, 329);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(668, 329);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // selectImageButton
            // 
            this.selectImageButton.Location = new System.Drawing.Point(725, 224);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(110, 23);
            this.selectImageButton.TabIndex = 9;
            this.selectImageButton.Text = "Seleccionar Logo";
            this.selectImageButton.UseSelectable = true;
            this.selectImageButton.Click += new System.EventHandler(this.selectImageButton_Click);
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(462, 88);
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(161, 20);
            this.mtxtTelephone.TabIndex = 5;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(462, 149);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWebPage
            // 
            // 
            // 
            // 
            this.txtWebPage.CustomButton.Image = null;
            this.txtWebPage.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtWebPage.CustomButton.Name = "";
            this.txtWebPage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWebPage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWebPage.CustomButton.TabIndex = 1;
            this.txtWebPage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWebPage.CustomButton.UseSelectable = true;
            this.txtWebPage.CustomButton.Visible = false;
            this.txtWebPage.Lines = new string[0];
            this.txtWebPage.Location = new System.Drawing.Point(462, 35);
            this.txtWebPage.MaxLength = 32767;
            this.txtWebPage.Name = "txtWebPage";
            this.txtWebPage.PasswordChar = '\0';
            this.txtWebPage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWebPage.SelectedText = "";
            this.txtWebPage.SelectionLength = 0;
            this.txtWebPage.SelectionStart = 0;
            this.txtWebPage.ShortcutsEnabled = true;
            this.txtWebPage.Size = new System.Drawing.Size(161, 23);
            this.txtWebPage.TabIndex = 4;
            this.txtWebPage.UseSelectable = true;
            this.txtWebPage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWebPage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txaGeneralAddress
            // 
            // 
            // 
            // 
            this.txaGeneralAddress.CustomButton.Image = null;
            this.txaGeneralAddress.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txaGeneralAddress.CustomButton.Name = "";
            this.txaGeneralAddress.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txaGeneralAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txaGeneralAddress.CustomButton.TabIndex = 1;
            this.txaGeneralAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txaGeneralAddress.CustomButton.UseSelectable = true;
            this.txaGeneralAddress.CustomButton.Visible = false;
            this.txaGeneralAddress.Lines = new string[0];
            this.txaGeneralAddress.Location = new System.Drawing.Point(368, 242);
            this.txaGeneralAddress.MaxLength = 32767;
            this.txaGeneralAddress.Multiline = true;
            this.txaGeneralAddress.Name = "txaGeneralAddress";
            this.txaGeneralAddress.PasswordChar = '\0';
            this.txaGeneralAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txaGeneralAddress.SelectedText = "";
            this.txaGeneralAddress.SelectionLength = 0;
            this.txaGeneralAddress.SelectionStart = 0;
            this.txaGeneralAddress.ShortcutsEnabled = true;
            this.txaGeneralAddress.Size = new System.Drawing.Size(255, 110);
            this.txaGeneralAddress.TabIndex = 8;
            this.txaGeneralAddress.UseSelectable = true;
            this.txaGeneralAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txaGeneralAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txaMainAddress
            // 
            // 
            // 
            // 
            this.txaMainAddress.CustomButton.Image = null;
            this.txaMainAddress.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.txaMainAddress.CustomButton.Name = "";
            this.txaMainAddress.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txaMainAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txaMainAddress.CustomButton.TabIndex = 1;
            this.txaMainAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txaMainAddress.CustomButton.UseSelectable = true;
            this.txaMainAddress.CustomButton.Visible = false;
            this.txaMainAddress.Lines = new string[0];
            this.txaMainAddress.Location = new System.Drawing.Point(22, 242);
            this.txaMainAddress.MaxLength = 32767;
            this.txaMainAddress.Multiline = true;
            this.txaMainAddress.Name = "txaMainAddress";
            this.txaMainAddress.PasswordChar = '\0';
            this.txaMainAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txaMainAddress.SelectedText = "";
            this.txaMainAddress.SelectionLength = 0;
            this.txaMainAddress.SelectionStart = 0;
            this.txaMainAddress.ShortcutsEnabled = true;
            this.txaMainAddress.Size = new System.Drawing.Size(308, 110);
            this.txaMainAddress.TabIndex = 7;
            this.txaMainAddress.UseSelectable = true;
            this.txaMainAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txaMainAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtlegalCertification
            // 
            // 
            // 
            // 
            this.txtlegalCertification.CustomButton.Image = null;
            this.txtlegalCertification.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtlegalCertification.CustomButton.Name = "";
            this.txtlegalCertification.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtlegalCertification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlegalCertification.CustomButton.TabIndex = 1;
            this.txtlegalCertification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlegalCertification.CustomButton.UseSelectable = true;
            this.txtlegalCertification.CustomButton.Visible = false;
            this.txtlegalCertification.Lines = new string[0];
            this.txtlegalCertification.Location = new System.Drawing.Point(169, 149);
            this.txtlegalCertification.MaxLength = 32767;
            this.txtlegalCertification.Name = "txtlegalCertification";
            this.txtlegalCertification.PasswordChar = '\0';
            this.txtlegalCertification.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlegalCertification.SelectedText = "";
            this.txtlegalCertification.SelectionLength = 0;
            this.txtlegalCertification.SelectionStart = 0;
            this.txtlegalCertification.ShortcutsEnabled = true;
            this.txtlegalCertification.Size = new System.Drawing.Size(161, 23);
            this.txtlegalCertification.TabIndex = 3;
            this.txtlegalCertification.UseSelectable = true;
            this.txtlegalCertification.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlegalCertification.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSocietyName
            // 
            // 
            // 
            // 
            this.txtSocietyName.CustomButton.Image = null;
            this.txtSocietyName.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtSocietyName.CustomButton.Name = "";
            this.txtSocietyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSocietyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSocietyName.CustomButton.TabIndex = 1;
            this.txtSocietyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSocietyName.CustomButton.UseSelectable = true;
            this.txtSocietyName.CustomButton.Visible = false;
            this.txtSocietyName.Lines = new string[0];
            this.txtSocietyName.Location = new System.Drawing.Point(169, 85);
            this.txtSocietyName.MaxLength = 32767;
            this.txtSocietyName.Name = "txtSocietyName";
            this.txtSocietyName.PasswordChar = '\0';
            this.txtSocietyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSocietyName.SelectedText = "";
            this.txtSocietyName.SelectionLength = 0;
            this.txtSocietyName.SelectionStart = 0;
            this.txtSocietyName.ShortcutsEnabled = true;
            this.txtSocietyName.Size = new System.Drawing.Size(161, 23);
            this.txtSocietyName.TabIndex = 2;
            this.txtSocietyName.UseSelectable = true;
            this.txtSocietyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSocietyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFantasyName
            // 
            // 
            // 
            // 
            this.txtFantasyName.CustomButton.Image = null;
            this.txtFantasyName.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtFantasyName.CustomButton.Name = "";
            this.txtFantasyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFantasyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFantasyName.CustomButton.TabIndex = 1;
            this.txtFantasyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFantasyName.CustomButton.UseSelectable = true;
            this.txtFantasyName.CustomButton.Visible = false;
            this.txtFantasyName.Lines = new string[0];
            this.txtFantasyName.Location = new System.Drawing.Point(169, 35);
            this.txtFantasyName.MaxLength = 32767;
            this.txtFantasyName.Name = "txtFantasyName";
            this.txtFantasyName.PasswordChar = '\0';
            this.txtFantasyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFantasyName.SelectedText = "";
            this.txtFantasyName.SelectionLength = 0;
            this.txtFantasyName.SelectionStart = 0;
            this.txtFantasyName.ShortcutsEnabled = true;
            this.txtFantasyName.Size = new System.Drawing.Size(161, 23);
            this.txtFantasyName.TabIndex = 1;
            this.txtFantasyName.UseSelectable = true;
            this.txtFantasyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFantasyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.ContextMenuStrip = this.metroContextMenu1;
            this.pbLogo.Image = global::UI.Properties.Resources.Empty;
            this.pbLogo.Location = new System.Drawing.Point(681, 38);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(196, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(169, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem1.Text = "Agregar imágen";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Modificar imágen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem3.Text = "Quitar imágen";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(22, 210);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(104, 19);
            this.metroLabel9.TabIndex = 3;
            this.metroLabel9.Text = "Dirección exacta";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(368, 90);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Teléfono";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(368, 39);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Página web";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(368, 210);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(112, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Dirección General";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(368, 149);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "E-mail";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 149);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Cédula Juridica";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(134, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nombre de sociedad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre de fantasía";
            // 
            // businessGridView
            // 
            this.businessGridView.AllowUserToResizeRows = false;
            this.businessGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.businessGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.businessGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.businessGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.businessGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.businessGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.businessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.businessGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.businessGridView.EnableHeadersVisualStyles = false;
            this.businessGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.businessGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.businessGridView.Location = new System.Drawing.Point(14, 423);
            this.businessGridView.Name = "businessGridView";
            this.businessGridView.ReadOnly = true;
            this.businessGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.businessGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.businessGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.businessGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessGridView.Size = new System.Drawing.Size(911, 217);
            this.businessGridView.TabIndex = 14;
            this.businessGridView.Click += new System.EventHandler(this.businessGridView_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(850, 659);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseSelectable = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // UcBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.businessGridView);
            this.Controls.Add(this.businessFantasyNameSearchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcBusiness";
            this.Size = new System.Drawing.Size(955, 696);
            this.Load += new System.EventHandler(this.UcBusiness_Load);
            this.Leave += new System.EventHandler(this.UcBusiness_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.businessGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox businessFantasyNameSearchTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtWebPage;
        private MetroFramework.Controls.MetroTextBox txaGeneralAddress;
        private MetroFramework.Controls.MetroTextBox txaMainAddress;
        private MetroFramework.Controls.MetroTextBox txtlegalCertification;
        private MetroFramework.Controls.MetroTextBox txtSocietyName;
        private MetroFramework.Controls.MetroTextBox txtFantasyName;
        private System.Windows.Forms.PictureBox pbLogo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton selectImageButton;
        private MetroFramework.Controls.MetroGrid businessGridView;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton createButton;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
