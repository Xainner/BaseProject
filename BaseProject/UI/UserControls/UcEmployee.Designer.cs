namespace UI.UserControls
{
    partial class UcEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxtCellphone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.btnSelectPhoto = new MetroFramework.Controls.MetroButton();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.txtNacionality = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailEmployee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNameEmployee = new MetroFramework.Controls.MetroTextBox();
            this.txtLastnameEmployee = new MetroFramework.Controls.MetroTextBox();
            this.datepBornDate = new MetroFramework.Controls.MetroDateTime();
            this.txtResidence = new MetroFramework.Controls.MetroTextBox();
            this.txtIdentification = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbChilds = new MetroFramework.Controls.MetroComboBox();
            this.cmbCivilState = new MetroFramework.Controls.MetroComboBox();
            this.cmbIdentificationType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPosition = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.cmbEnterStore = new MetroFramework.Controls.MetroComboBox();
            this.txaObservation = new MetroFramework.Controls.MetroTextBox();
            this.txtWorkStatus = new MetroFramework.Controls.MetroTextBox();
            this.datepEndDate = new MetroFramework.Controls.MetroDateTime();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtxtEmergencyPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmergencyName = new MetroFramework.Controls.MetroTextBox();
            this.btnAddEmployee = new MetroFramework.Controls.MetroTile();
            this.btnUpdateEmployee = new MetroFramework.Controls.MetroTile();
            this.txtSearchEmployee = new MetroFramework.Controls.MetroTextBox();
            this.btnDeleteEmployee = new MetroFramework.Controls.MetroTile();
            this.dgvEmployee = new MetroFramework.Controls.MetroGrid();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCleanEmployee = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtCellphone);
            this.groupBox1.Controls.Add(this.mtxtTelephone);
            this.groupBox1.Controls.Add(this.btnSelectPhoto);
            this.groupBox1.Controls.Add(this.picPhoto);
            this.groupBox1.Controls.Add(this.txtNacionality);
            this.groupBox1.Controls.Add(this.txtEmailEmployee);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel17);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtNameEmployee);
            this.groupBox1.Controls.Add(this.txtLastnameEmployee);
            this.groupBox1.Controls.Add(this.datepBornDate);
            this.groupBox1.Controls.Add(this.txtResidence);
            this.groupBox1.Controls.Add(this.txtIdentification);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.cmbChilds);
            this.groupBox1.Controls.Add(this.cmbCivilState);
            this.groupBox1.Controls.Add(this.cmbIdentificationType);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 295);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Empleado";
            // 
            // mtxtCellphone
            // 
            this.mtxtCellphone.Location = new System.Drawing.Point(118, 164);
            this.mtxtCellphone.Name = "mtxtCellphone";
            this.mtxtCellphone.Size = new System.Drawing.Size(171, 20);
            this.mtxtCellphone.TabIndex = 16;
            // 
            // mtxtTelephone
            // 
            this.mtxtTelephone.Location = new System.Drawing.Point(118, 124);
            this.mtxtTelephone.Name = "mtxtTelephone";
            this.mtxtTelephone.Size = new System.Drawing.Size(171, 20);
            this.mtxtTelephone.TabIndex = 16;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(731, 238);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(98, 23);
            this.btnSelectPhoto.TabIndex = 15;
            this.btnSelectPhoto.Text = "Seleccionar Foto";
            this.btnSelectPhoto.UseSelectable = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(668, 38);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(221, 194);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 14;
            this.picPhoto.TabStop = false;
            // 
            // txtNacionality
            // 
            // 
            // 
            // 
            this.txtNacionality.CustomButton.Image = null;
            this.txtNacionality.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtNacionality.CustomButton.Name = "";
            this.txtNacionality.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNacionality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNacionality.CustomButton.TabIndex = 1;
            this.txtNacionality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNacionality.CustomButton.UseSelectable = true;
            this.txtNacionality.CustomButton.Visible = false;
            this.txtNacionality.Lines = new string[0];
            this.txtNacionality.Location = new System.Drawing.Point(118, 253);
            this.txtNacionality.MaxLength = 32767;
            this.txtNacionality.Name = "txtNacionality";
            this.txtNacionality.PasswordChar = '\0';
            this.txtNacionality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNacionality.SelectedText = "";
            this.txtNacionality.SelectionLength = 0;
            this.txtNacionality.SelectionStart = 0;
            this.txtNacionality.ShortcutsEnabled = true;
            this.txtNacionality.Size = new System.Drawing.Size(171, 23);
            this.txtNacionality.TabIndex = 10;
            this.txtNacionality.UseSelectable = true;
            this.txtNacionality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNacionality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmailEmployee
            // 
            // 
            // 
            // 
            this.txtEmailEmployee.CustomButton.Image = null;
            this.txtEmailEmployee.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtEmailEmployee.CustomButton.Name = "";
            this.txtEmailEmployee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailEmployee.CustomButton.TabIndex = 1;
            this.txtEmailEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailEmployee.CustomButton.UseSelectable = true;
            this.txtEmailEmployee.CustomButton.Visible = false;
            this.txtEmailEmployee.Lines = new string[0];
            this.txtEmailEmployee.Location = new System.Drawing.Point(118, 203);
            this.txtEmailEmployee.MaxLength = 32767;
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.PasswordChar = '\0';
            this.txtEmailEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailEmployee.SelectedText = "";
            this.txtEmailEmployee.SelectionLength = 0;
            this.txtEmailEmployee.SelectionStart = 0;
            this.txtEmailEmployee.ShortcutsEnabled = true;
            this.txtEmailEmployee.Size = new System.Drawing.Size(171, 23);
            this.txtEmailEmployee.TabIndex = 10;
            this.txtEmailEmployee.UseSelectable = true;
            this.txtEmailEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 257);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 19);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Nacionalidad:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(756, 16);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(39, 19);
            this.metroLabel17.TabIndex = 1;
            this.metroLabel17.Text = "Foto:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(328, 257);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(40, 19);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Hijos:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(328, 207);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Estado civil:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(23, 165);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Celular:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 124);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Teléfono:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(328, 165);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Residencia:";
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
            this.metroLabel6.Location = new System.Drawing.Point(21, 207);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "E-mail:";
            // 
            // txtNameEmployee
            // 
            // 
            // 
            // 
            this.txtNameEmployee.CustomButton.Image = null;
            this.txtNameEmployee.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtNameEmployee.CustomButton.Name = "";
            this.txtNameEmployee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameEmployee.CustomButton.TabIndex = 1;
            this.txtNameEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameEmployee.CustomButton.UseSelectable = true;
            this.txtNameEmployee.CustomButton.Visible = false;
            this.txtNameEmployee.Lines = new string[0];
            this.txtNameEmployee.Location = new System.Drawing.Point(118, 27);
            this.txtNameEmployee.MaxLength = 32767;
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.PasswordChar = '\0';
            this.txtNameEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameEmployee.SelectedText = "";
            this.txtNameEmployee.SelectionLength = 0;
            this.txtNameEmployee.SelectionStart = 0;
            this.txtNameEmployee.ShortcutsEnabled = true;
            this.txtNameEmployee.Size = new System.Drawing.Size(171, 23);
            this.txtNameEmployee.TabIndex = 8;
            this.txtNameEmployee.UseSelectable = true;
            this.txtNameEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastnameEmployee
            // 
            // 
            // 
            // 
            this.txtLastnameEmployee.CustomButton.Image = null;
            this.txtLastnameEmployee.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtLastnameEmployee.CustomButton.Name = "";
            this.txtLastnameEmployee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastnameEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastnameEmployee.CustomButton.TabIndex = 1;
            this.txtLastnameEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastnameEmployee.CustomButton.UseSelectable = true;
            this.txtLastnameEmployee.CustomButton.Visible = false;
            this.txtLastnameEmployee.Lines = new string[0];
            this.txtLastnameEmployee.Location = new System.Drawing.Point(118, 76);
            this.txtLastnameEmployee.MaxLength = 32767;
            this.txtLastnameEmployee.Name = "txtLastnameEmployee";
            this.txtLastnameEmployee.PasswordChar = '\0';
            this.txtLastnameEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastnameEmployee.SelectedText = "";
            this.txtLastnameEmployee.SelectionLength = 0;
            this.txtLastnameEmployee.SelectionStart = 0;
            this.txtLastnameEmployee.ShortcutsEnabled = true;
            this.txtLastnameEmployee.Size = new System.Drawing.Size(171, 23);
            this.txtLastnameEmployee.TabIndex = 9;
            this.txtLastnameEmployee.UseSelectable = true;
            this.txtLastnameEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastnameEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datepBornDate
            // 
            this.datepBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepBornDate.Location = new System.Drawing.Point(452, 120);
            this.datepBornDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepBornDate.Name = "datepBornDate";
            this.datepBornDate.Size = new System.Drawing.Size(188, 29);
            this.datepBornDate.TabIndex = 11;
            // 
            // txtResidence
            // 
            // 
            // 
            // 
            this.txtResidence.CustomButton.Image = null;
            this.txtResidence.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtResidence.CustomButton.Name = "";
            this.txtResidence.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtResidence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResidence.CustomButton.TabIndex = 1;
            this.txtResidence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResidence.CustomButton.UseSelectable = true;
            this.txtResidence.CustomButton.Visible = false;
            this.txtResidence.Lines = new string[0];
            this.txtResidence.Location = new System.Drawing.Point(452, 165);
            this.txtResidence.MaxLength = 32767;
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.PasswordChar = '\0';
            this.txtResidence.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResidence.SelectedText = "";
            this.txtResidence.SelectionLength = 0;
            this.txtResidence.SelectionStart = 0;
            this.txtResidence.ShortcutsEnabled = true;
            this.txtResidence.Size = new System.Drawing.Size(188, 23);
            this.txtResidence.TabIndex = 13;
            this.txtResidence.UseSelectable = true;
            this.txtResidence.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResidence.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtIdentification.Location = new System.Drawing.Point(452, 76);
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
            this.metroLabel4.Location = new System.Drawing.Point(328, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tipo Identificación:";
            // 
            // cmbChilds
            // 
            this.cmbChilds.FormattingEnabled = true;
            this.cmbChilds.ItemHeight = 23;
            this.cmbChilds.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbChilds.Location = new System.Drawing.Point(452, 247);
            this.cmbChilds.Name = "cmbChilds";
            this.cmbChilds.Size = new System.Drawing.Size(188, 29);
            this.cmbChilds.TabIndex = 12;
            this.cmbChilds.UseSelectable = true;
            // 
            // cmbCivilState
            // 
            this.cmbCivilState.FormattingEnabled = true;
            this.cmbCivilState.ItemHeight = 23;
            this.cmbCivilState.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado"});
            this.cmbCivilState.Location = new System.Drawing.Point(452, 203);
            this.cmbCivilState.Name = "cmbCivilState";
            this.cmbCivilState.Size = new System.Drawing.Size(188, 29);
            this.cmbCivilState.TabIndex = 12;
            this.cmbCivilState.UseSelectable = true;
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
            this.cmbIdentificationType.Location = new System.Drawing.Point(452, 31);
            this.cmbIdentificationType.Name = "cmbIdentificationType";
            this.cmbIdentificationType.Size = new System.Drawing.Size(188, 29);
            this.cmbIdentificationType.TabIndex = 12;
            this.cmbIdentificationType.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(328, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Identificación:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(328, 120);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Fecha nacimiento:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(295, 76);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(83, 19);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Observación";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(12, 130);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(102, 19);
            this.metroLabel14.TabIndex = 1;
            this.metroLabel14.Text = "Fecha de salida:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(10, 81);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(116, 19);
            this.metroLabel15.TabIndex = 1;
            this.metroLabel15.Text = "Estado de trabajo:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(10, 31);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(119, 19);
            this.metroLabel19.TabIndex = 1;
            this.metroLabel19.Text = "Tienda de entrada:";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(39, 30);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(135, 19);
            this.metroLabel20.TabIndex = 1;
            this.metroLabel20.Text = "Nombre emergencia:";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(40, 109);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(134, 19);
            this.metroLabel21.TabIndex = 1;
            this.metroLabel21.Text = "Teléfono emergencia:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPosition);
            this.groupBox2.Controls.Add(this.metroLabel16);
            this.groupBox2.Controls.Add(this.cmbEnterStore);
            this.groupBox2.Controls.Add(this.metroLabel19);
            this.groupBox2.Controls.Add(this.metroLabel15);
            this.groupBox2.Controls.Add(this.metroLabel14);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.txaObservation);
            this.groupBox2.Controls.Add(this.txtWorkStatus);
            this.groupBox2.Controls.Add(this.datepEndDate);
            this.groupBox2.Location = new System.Drawing.Point(24, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 180);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de trabajo";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.ItemHeight = 23;
            this.cmbPosition.Items.AddRange(new object[] {
            "Ingeniero",
            "Administrador"});
            this.cmbPosition.Location = new System.Drawing.Point(352, 30);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(143, 29);
            this.cmbPosition.TabIndex = 35;
            this.cmbPosition.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(295, 31);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(51, 19);
            this.metroLabel16.TabIndex = 1;
            this.metroLabel16.Text = "Puesto:";
            // 
            // cmbEnterStore
            // 
            this.cmbEnterStore.FormattingEnabled = true;
            this.cmbEnterStore.ItemHeight = 23;
            this.cmbEnterStore.Items.AddRange(new object[] {
            "Kyrios"});
            this.cmbEnterStore.Location = new System.Drawing.Point(135, 30);
            this.cmbEnterStore.Name = "cmbEnterStore";
            this.cmbEnterStore.Size = new System.Drawing.Size(143, 29);
            this.cmbEnterStore.TabIndex = 35;
            this.cmbEnterStore.UseSelectable = true;
            // 
            // txaObservation
            // 
            // 
            // 
            // 
            this.txaObservation.CustomButton.Image = null;
            this.txaObservation.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txaObservation.CustomButton.Name = "";
            this.txaObservation.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txaObservation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txaObservation.CustomButton.TabIndex = 1;
            this.txaObservation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txaObservation.CustomButton.UseSelectable = true;
            this.txaObservation.CustomButton.Visible = false;
            this.txaObservation.Lines = new string[0];
            this.txaObservation.Location = new System.Drawing.Point(295, 98);
            this.txaObservation.MaxLength = 32767;
            this.txaObservation.Multiline = true;
            this.txaObservation.Name = "txaObservation";
            this.txaObservation.PasswordChar = '\0';
            this.txaObservation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txaObservation.SelectedText = "";
            this.txaObservation.SelectionLength = 0;
            this.txaObservation.SelectionStart = 0;
            this.txaObservation.ShortcutsEnabled = true;
            this.txaObservation.Size = new System.Drawing.Size(200, 71);
            this.txaObservation.TabIndex = 10;
            this.txaObservation.UseSelectable = true;
            this.txaObservation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txaObservation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWorkStatus
            // 
            // 
            // 
            // 
            this.txtWorkStatus.CustomButton.Image = null;
            this.txtWorkStatus.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtWorkStatus.CustomButton.Name = "";
            this.txtWorkStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWorkStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWorkStatus.CustomButton.TabIndex = 1;
            this.txtWorkStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWorkStatus.CustomButton.UseSelectable = true;
            this.txtWorkStatus.CustomButton.Visible = false;
            this.txtWorkStatus.Lines = new string[0];
            this.txtWorkStatus.Location = new System.Drawing.Point(135, 81);
            this.txtWorkStatus.MaxLength = 32767;
            this.txtWorkStatus.Name = "txtWorkStatus";
            this.txtWorkStatus.PasswordChar = '\0';
            this.txtWorkStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWorkStatus.SelectedText = "";
            this.txtWorkStatus.SelectionLength = 0;
            this.txtWorkStatus.SelectionStart = 0;
            this.txtWorkStatus.ShortcutsEnabled = true;
            this.txtWorkStatus.Size = new System.Drawing.Size(143, 23);
            this.txtWorkStatus.TabIndex = 10;
            this.txtWorkStatus.UseSelectable = true;
            this.txtWorkStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWorkStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datepEndDate
            // 
            this.datepEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepEndDate.Location = new System.Drawing.Point(135, 127);
            this.datepEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.datepEndDate.Name = "datepEndDate";
            this.datepEndDate.Size = new System.Drawing.Size(143, 29);
            this.datepEndDate.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtxtEmergencyPhone);
            this.groupBox3.Controls.Add(this.metroLabel20);
            this.groupBox3.Controls.Add(this.metroLabel21);
            this.groupBox3.Controls.Add(this.txtEmergencyName);
            this.groupBox3.Location = new System.Drawing.Point(557, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 180);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "En caso de emergencia";
            // 
            // mtxtEmergencyPhone
            // 
            this.mtxtEmergencyPhone.Location = new System.Drawing.Point(18, 131);
            this.mtxtEmergencyPhone.Name = "mtxtEmergencyPhone";
            this.mtxtEmergencyPhone.Size = new System.Drawing.Size(189, 20);
            this.mtxtEmergencyPhone.TabIndex = 16;
            // 
            // txtEmergencyName
            // 
            // 
            // 
            // 
            this.txtEmergencyName.CustomButton.Image = null;
            this.txtEmergencyName.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtEmergencyName.CustomButton.Name = "";
            this.txtEmergencyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmergencyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmergencyName.CustomButton.TabIndex = 1;
            this.txtEmergencyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmergencyName.CustomButton.UseSelectable = true;
            this.txtEmergencyName.CustomButton.Visible = false;
            this.txtEmergencyName.Lines = new string[0];
            this.txtEmergencyName.Location = new System.Drawing.Point(18, 52);
            this.txtEmergencyName.MaxLength = 32767;
            this.txtEmergencyName.Name = "txtEmergencyName";
            this.txtEmergencyName.PasswordChar = '\0';
            this.txtEmergencyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmergencyName.SelectedText = "";
            this.txtEmergencyName.SelectionLength = 0;
            this.txtEmergencyName.SelectionStart = 0;
            this.txtEmergencyName.ShortcutsEnabled = true;
            this.txtEmergencyName.Size = new System.Drawing.Size(189, 23);
            this.txtEmergencyName.TabIndex = 10;
            this.txtEmergencyName.UseSelectable = true;
            this.txtEmergencyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmergencyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.ActiveControl = null;
            this.btnAddEmployee.Location = new System.Drawing.Point(810, 376);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(103, 44);
            this.btnAddEmployee.TabIndex = 32;
            this.btnAddEmployee.Text = "Agregar";
            this.btnAddEmployee.UseSelectable = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.ActiveControl = null;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(810, 450);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(103, 44);
            this.btnUpdateEmployee.TabIndex = 32;
            this.btnUpdateEmployee.Text = "Modificar";
            this.btnUpdateEmployee.UseSelectable = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // txtSearchEmployee
            // 
            // 
            // 
            // 
            this.txtSearchEmployee.CustomButton.Image = null;
            this.txtSearchEmployee.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtSearchEmployee.CustomButton.Name = "";
            this.txtSearchEmployee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchEmployee.CustomButton.TabIndex = 1;
            this.txtSearchEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchEmployee.CustomButton.UseSelectable = true;
            this.txtSearchEmployee.Lines = new string[0];
            this.txtSearchEmployee.Location = new System.Drawing.Point(615, 553);
            this.txtSearchEmployee.MaxLength = 32767;
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PasswordChar = '\0';
            this.txtSearchEmployee.PromptText = "Ingrese texto a buscar";
            this.txtSearchEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.SelectionLength = 0;
            this.txtSearchEmployee.SelectionStart = 0;
            this.txtSearchEmployee.ShortcutsEnabled = true;
            this.txtSearchEmployee.ShowButton = true;
            this.txtSearchEmployee.Size = new System.Drawing.Size(217, 23);
            this.txtSearchEmployee.TabIndex = 10;
            this.txtSearchEmployee.UseSelectable = true;
            this.txtSearchEmployee.WaterMark = "Ingrese texto a buscar";
            this.txtSearchEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchEmployee_KeyPress);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.ActiveControl = null;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(729, 870);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(103, 44);
            this.btnDeleteEmployee.TabIndex = 32;
            this.btnDeleteEmployee.Text = "Eliminar";
            this.btnDeleteEmployee.UseSelectable = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmployee.Location = new System.Drawing.Point(90, 582);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(742, 282);
            this.dgvEmployee.TabIndex = 34;
            this.dgvEmployee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvEmployee_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCleanEmployee
            // 
            this.btnCleanEmployee.ActiveControl = null;
            this.btnCleanEmployee.Location = new System.Drawing.Point(90, 870);
            this.btnCleanEmployee.Name = "btnCleanEmployee";
            this.btnCleanEmployee.Size = new System.Drawing.Size(103, 44);
            this.btnCleanEmployee.TabIndex = 35;
            this.btnCleanEmployee.Text = "Limpiar";
            this.btnCleanEmployee.UseSelectable = true;
            this.btnCleanEmployee.Click += new System.EventHandler(this.btnCleanEmployee_Click);
            // 
            // UcEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnCleanEmployee);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcEmployee";
            this.Size = new System.Drawing.Size(955, 921);
            this.Load += new System.EventHandler(this.UcEmployee_Load);
            this.Leave += new System.EventHandler(this.UcEmployee_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSelectPhoto;
        private System.Windows.Forms.PictureBox picPhoto;
        private MetroFramework.Controls.MetroTextBox txtNacionality;
        private MetroFramework.Controls.MetroTextBox txtEmailEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNameEmployee;
        private MetroFramework.Controls.MetroTextBox txtLastnameEmployee;
        private MetroFramework.Controls.MetroDateTime datepBornDate;
        private MetroFramework.Controls.MetroTextBox txtResidence;
        private MetroFramework.Controls.MetroTextBox txtIdentification;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbChilds;
        private MetroFramework.Controls.MetroComboBox cmbCivilState;
        private MetroFramework.Controls.MetroComboBox cmbIdentificationType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txaObservation;
        private MetroFramework.Controls.MetroTextBox txtWorkStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtEmergencyName;
        private MetroFramework.Controls.MetroTile btnAddEmployee;
        private MetroFramework.Controls.MetroTile btnUpdateEmployee;
        private MetroFramework.Controls.MetroTextBox txtSearchEmployee;
        private MetroFramework.Controls.MetroTile btnDeleteEmployee;
        private System.Windows.Forms.MaskedTextBox mtxtCellphone;
        private System.Windows.Forms.MaskedTextBox mtxtTelephone;
        private System.Windows.Forms.MaskedTextBox mtxtEmergencyPhone;
        private MetroFramework.Controls.MetroGrid dgvEmployee;
        private MetroFramework.Controls.MetroComboBox cmbEnterStore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroDateTime datepEndDate;
        private MetroFramework.Controls.MetroComboBox cmbPosition;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTile btnCleanEmployee;
    }
}
