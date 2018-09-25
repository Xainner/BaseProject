namespace UI.UserControls
{
    partial class UcInputInvoice
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dateDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.providerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.totalPaymentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.createButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.dateDateTime);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.providerTextBox);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 147);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura de entrada de mercaderia";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(373, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Tienda Kyrios";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(329, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(178, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "San Jóse, San Pedro, Calle 14";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(318, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(203, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Cédula Juridica: 1-1321561-651681";
            // 
            // dateDateTime
            // 
            this.dateDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateTime.Location = new System.Drawing.Point(718, 14);
            this.dateDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDateTime.Name = "dateDateTime";
            this.dateDateTime.Size = new System.Drawing.Size(194, 29);
            this.dateDateTime.TabIndex = 12;
            this.dateDateTime.Value = new System.DateTime(2018, 9, 26, 14, 53, 58, 0);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(669, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Fecha";
            // 
            // providerTextBox
            // 
            // 
            // 
            // 
            this.providerTextBox.CustomButton.Image = null;
            this.providerTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.providerTextBox.CustomButton.Name = "";
            this.providerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.providerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.providerTextBox.CustomButton.TabIndex = 1;
            this.providerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.providerTextBox.CustomButton.UseSelectable = true;
            this.providerTextBox.CustomButton.Visible = false;
            this.providerTextBox.Lines = new string[0];
            this.providerTextBox.Location = new System.Drawing.Point(145, 118);
            this.providerTextBox.MaxLength = 32767;
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.PasswordChar = '\0';
            this.providerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.providerTextBox.SelectedText = "";
            this.providerTextBox.SelectionLength = 0;
            this.providerTextBox.SelectionStart = 0;
            this.providerTextBox.ShortcutsEnabled = true;
            this.providerTextBox.Size = new System.Drawing.Size(193, 23);
            this.providerTextBox.TabIndex = 16;
            this.providerTextBox.UseSelectable = true;
            this.providerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.providerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Proveedor";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(646, 509);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(85, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Total a Pagar";
            // 
            // totalPaymentTextBox
            // 
            // 
            // 
            // 
            this.totalPaymentTextBox.CustomButton.Image = null;
            this.totalPaymentTextBox.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.totalPaymentTextBox.CustomButton.Name = "";
            this.totalPaymentTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalPaymentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalPaymentTextBox.CustomButton.TabIndex = 1;
            this.totalPaymentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalPaymentTextBox.CustomButton.UseSelectable = true;
            this.totalPaymentTextBox.CustomButton.Visible = false;
            this.totalPaymentTextBox.Lines = new string[0];
            this.totalPaymentTextBox.Location = new System.Drawing.Point(737, 509);
            this.totalPaymentTextBox.MaxLength = 32767;
            this.totalPaymentTextBox.Name = "totalPaymentTextBox";
            this.totalPaymentTextBox.PasswordChar = '\0';
            this.totalPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalPaymentTextBox.SelectedText = "";
            this.totalPaymentTextBox.SelectionLength = 0;
            this.totalPaymentTextBox.SelectionStart = 0;
            this.totalPaymentTextBox.ShortcutsEnabled = true;
            this.totalPaymentTextBox.Size = new System.Drawing.Size(199, 23);
            this.totalPaymentTextBox.TabIndex = 24;
            this.totalPaymentTextBox.UseSelectable = true;
            this.totalPaymentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalPaymentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(18, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(114, 23);
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Agregar Productos";
            this.metroButton1.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(18, 198);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(918, 305);
            this.metroGrid1.TabIndex = 30;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(756, 118);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 28;
            this.createButton.Text = "Agregar";
            this.createButton.UseSelectable = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(837, 118);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Limpiar";
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // UcInputInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.totalPaymentTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcInputInvoice";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcInputInvoice_Load);
            this.Leave += new System.EventHandler(this.UcInputInvoice_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dateDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox providerTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox totalPaymentTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton createButton;
    }
}
