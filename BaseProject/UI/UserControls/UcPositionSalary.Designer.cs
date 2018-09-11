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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchPosition = new MetroFramework.Controls.MetroTextBox();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.btnUpdatePosition = new MetroFramework.Controls.MetroTile();
            this.btnDeletePosition = new MetroFramework.Controls.MetroTile();
            this.btnAddPosition = new MetroFramework.Controls.MetroTile();
            this.txtNamePosition = new MetroFramework.Controls.MetroTextBox();
            this.cmbSalary = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchSalary = new MetroFramework.Controls.MetroTextBox();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.btnDeleteSalary = new MetroFramework.Controls.MetroTile();
            this.btnUpdateSalary = new MetroFramework.Controls.MetroTile();
            this.btnAddSalary = new MetroFramework.Controls.MetroTile();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchPosition);
            this.groupBox2.Controls.Add(this.dgvPosition);
            this.groupBox2.Controls.Add(this.btnUpdatePosition);
            this.groupBox2.Controls.Add(this.btnDeletePosition);
            this.groupBox2.Controls.Add(this.btnAddPosition);
            this.groupBox2.Controls.Add(this.txtNamePosition);
            this.groupBox2.Controls.Add(this.cmbSalary);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(507, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 476);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Área de posición de trabajo";
            // 
            // txtSearchPosition
            // 
            // 
            // 
            // 
            this.txtSearchPosition.CustomButton.Image = null;
            this.txtSearchPosition.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSearchPosition.CustomButton.Name = "";
            this.txtSearchPosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchPosition.CustomButton.TabIndex = 1;
            this.txtSearchPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPosition.CustomButton.UseSelectable = true;
            this.txtSearchPosition.Lines = new string[0];
            this.txtSearchPosition.Location = new System.Drawing.Point(218, 211);
            this.txtSearchPosition.MaxLength = 32767;
            this.txtSearchPosition.Name = "txtSearchPosition";
            this.txtSearchPosition.PasswordChar = '\0';
            this.txtSearchPosition.PromptText = "Ingrese texto a buscar";
            this.txtSearchPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchPosition.SelectedText = "";
            this.txtSearchPosition.SelectionLength = 0;
            this.txtSearchPosition.SelectionStart = 0;
            this.txtSearchPosition.ShortcutsEnabled = true;
            this.txtSearchPosition.ShowButton = true;
            this.txtSearchPosition.Size = new System.Drawing.Size(147, 23);
            this.txtSearchPosition.TabIndex = 6;
            this.txtSearchPosition.UseSelectable = true;
            this.txtSearchPosition.WaterMark = "Ingrese texto a buscar";
            this.txtSearchPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvPosition
            // 
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Location = new System.Drawing.Point(59, 260);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(309, 138);
            this.dgvPosition.TabIndex = 5;
            // 
            // btnUpdatePosition
            // 
            this.btnUpdatePosition.ActiveControl = null;
            this.btnUpdatePosition.Location = new System.Drawing.Point(315, 124);
            this.btnUpdatePosition.Name = "btnUpdatePosition";
            this.btnUpdatePosition.Size = new System.Drawing.Size(87, 38);
            this.btnUpdatePosition.TabIndex = 4;
            this.btnUpdatePosition.Text = "Modificar";
            this.btnUpdatePosition.UseSelectable = true;
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.ActiveControl = null;
            this.btnDeletePosition.Location = new System.Drawing.Point(281, 414);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(87, 38);
            this.btnDeletePosition.TabIndex = 4;
            this.btnDeletePosition.Text = "Eliminar";
            this.btnDeletePosition.UseSelectable = true;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.ActiveControl = null;
            this.btnAddPosition.Location = new System.Drawing.Point(315, 46);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(87, 38);
            this.btnAddPosition.TabIndex = 4;
            this.btnAddPosition.Text = "Agregar";
            this.btnAddPosition.UseSelectable = true;
            // 
            // txtNamePosition
            // 
            // 
            // 
            // 
            this.txtNamePosition.CustomButton.Image = null;
            this.txtNamePosition.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtNamePosition.CustomButton.Name = "";
            this.txtNamePosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNamePosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNamePosition.CustomButton.TabIndex = 1;
            this.txtNamePosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNamePosition.CustomButton.UseSelectable = true;
            this.txtNamePosition.CustomButton.Visible = false;
            this.txtNamePosition.Lines = new string[0];
            this.txtNamePosition.Location = new System.Drawing.Point(126, 50);
            this.txtNamePosition.MaxLength = 32767;
            this.txtNamePosition.Name = "txtNamePosition";
            this.txtNamePosition.PasswordChar = '\0';
            this.txtNamePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNamePosition.SelectedText = "";
            this.txtNamePosition.SelectionLength = 0;
            this.txtNamePosition.SelectionStart = 0;
            this.txtNamePosition.ShortcutsEnabled = true;
            this.txtNamePosition.Size = new System.Drawing.Size(134, 23);
            this.txtNamePosition.TabIndex = 3;
            this.txtNamePosition.UseSelectable = true;
            this.txtNamePosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNamePosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbSalary
            // 
            this.cmbSalary.FormattingEnabled = true;
            this.cmbSalary.ItemHeight = 23;
            this.cmbSalary.Location = new System.Drawing.Point(126, 118);
            this.cmbSalary.Name = "cmbSalary";
            this.cmbSalary.Size = new System.Drawing.Size(134, 29);
            this.cmbSalary.TabIndex = 2;
            this.cmbSalary.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Posición:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Salario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchSalary);
            this.groupBox1.Controls.Add(this.dgvSalary);
            this.groupBox1.Controls.Add(this.btnDeleteSalary);
            this.groupBox1.Controls.Add(this.btnUpdateSalary);
            this.groupBox1.Controls.Add(this.btnAddSalary);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 476);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de Salarios";
            // 
            // txtSearchSalary
            // 
            // 
            // 
            // 
            this.txtSearchSalary.CustomButton.Image = null;
            this.txtSearchSalary.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSearchSalary.CustomButton.Name = "";
            this.txtSearchSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchSalary.CustomButton.TabIndex = 1;
            this.txtSearchSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchSalary.CustomButton.UseSelectable = true;
            this.txtSearchSalary.Lines = new string[0];
            this.txtSearchSalary.Location = new System.Drawing.Point(221, 211);
            this.txtSearchSalary.MaxLength = 32767;
            this.txtSearchSalary.Name = "txtSearchSalary";
            this.txtSearchSalary.PasswordChar = '\0';
            this.txtSearchSalary.PromptText = "Ingrese texto a buscar";
            this.txtSearchSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchSalary.SelectedText = "";
            this.txtSearchSalary.SelectionLength = 0;
            this.txtSearchSalary.SelectionStart = 0;
            this.txtSearchSalary.ShortcutsEnabled = true;
            this.txtSearchSalary.ShowButton = true;
            this.txtSearchSalary.Size = new System.Drawing.Size(147, 23);
            this.txtSearchSalary.TabIndex = 6;
            this.txtSearchSalary.UseSelectable = true;
            this.txtSearchSalary.WaterMark = "Ingrese texto a buscar";
            this.txtSearchSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(62, 260);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.Size = new System.Drawing.Size(309, 138);
            this.dgvSalary.TabIndex = 5;
            // 
            // btnDeleteSalary
            // 
            this.btnDeleteSalary.ActiveControl = null;
            this.btnDeleteSalary.Location = new System.Drawing.Point(284, 414);
            this.btnDeleteSalary.Name = "btnDeleteSalary";
            this.btnDeleteSalary.Size = new System.Drawing.Size(87, 38);
            this.btnDeleteSalary.TabIndex = 4;
            this.btnDeleteSalary.Text = "Eliminar";
            this.btnDeleteSalary.UseSelectable = true;
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.ActiveControl = null;
            this.btnUpdateSalary.Location = new System.Drawing.Point(315, 124);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(87, 38);
            this.btnUpdateSalary.TabIndex = 4;
            this.btnUpdateSalary.Text = "Modificar";
            this.btnUpdateSalary.UseSelectable = true;
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.ActiveControl = null;
            this.btnAddSalary.Location = new System.Drawing.Point(315, 46);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.Size = new System.Drawing.Size(87, 38);
            this.btnAddSalary.TabIndex = 4;
            this.btnAddSalary.Text = "Agregar";
            this.btnAddSalary.UseSelectable = true;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(112, 124);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(134, 23);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Cantidad:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(112, 50);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(134, 23);
            this.txtID.TabIndex = 3;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UcPositionSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcPositionSalary";
            this.Size = new System.Drawing.Size(955, 536);
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
        private System.Windows.Forms.DataGridView dgvPosition;
        private MetroFramework.Controls.MetroTile btnUpdatePosition;
        private MetroFramework.Controls.MetroTile btnDeletePosition;
        private MetroFramework.Controls.MetroTile btnAddPosition;
        private MetroFramework.Controls.MetroTextBox txtNamePosition;
        private MetroFramework.Controls.MetroComboBox cmbSalary;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchSalary;
        private System.Windows.Forms.DataGridView dgvSalary;
        private MetroFramework.Controls.MetroTile btnDeleteSalary;
        private MetroFramework.Controls.MetroTile btnUpdateSalary;
        private MetroFramework.Controls.MetroTile btnAddSalary;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtID;
    }
}
