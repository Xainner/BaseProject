namespace UI.UserControls
{
    partial class UcExitInvoice
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
            this.AddOutputInvoiceTile = new MetroFramework.Controls.MetroTile();
            this.clearTitle = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.totalPaymentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dateDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destinyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.addProductsButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddOutputInvoiceTile
            // 
            this.AddOutputInvoiceTile.ActiveControl = null;
            this.AddOutputInvoiceTile.Location = new System.Drawing.Point(100, 486);
            this.AddOutputInvoiceTile.Name = "AddOutputInvoiceTile";
            this.AddOutputInvoiceTile.Size = new System.Drawing.Size(96, 38);
            this.AddOutputInvoiceTile.TabIndex = 21;
            this.AddOutputInvoiceTile.Text = "Realizar";
            this.AddOutputInvoiceTile.UseSelectable = true;
            this.AddOutputInvoiceTile.Click += new System.EventHandler(this.AddOutputInvoiceTile_Click);
            // 
            // clearTitle
            // 
            this.clearTitle.ActiveControl = null;
            this.clearTitle.Location = new System.Drawing.Point(751, 171);
            this.clearTitle.Name = "clearTitle";
            this.clearTitle.Size = new System.Drawing.Size(96, 38);
            this.clearTitle.TabIndex = 22;
            this.clearTitle.Text = "Limpiar";
            this.clearTitle.UseSelectable = true;
            this.clearTitle.Click += new System.EventHandler(this.clearTitle_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(541, 444);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(89, 19);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Total a Pagar:";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
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
            this.metroGrid1.Location = new System.Drawing.Point(100, 246);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.metroGrid1.Size = new System.Drawing.Size(735, 192);
            this.metroGrid1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
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
            this.providerTextBox.Location = new System.Drawing.Point(130, 167);
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
            this.totalPaymentTextBox.Location = new System.Drawing.Point(636, 444);
            this.totalPaymentTextBox.MaxLength = 32767;
            this.totalPaymentTextBox.Name = "totalPaymentTextBox";
            this.totalPaymentTextBox.PasswordChar = '\0';
            this.totalPaymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalPaymentTextBox.SelectedText = "";
            this.totalPaymentTextBox.SelectionLength = 0;
            this.totalPaymentTextBox.SelectionStart = 0;
            this.totalPaymentTextBox.ShortcutsEnabled = true;
            this.totalPaymentTextBox.Size = new System.Drawing.Size(199, 23);
            this.totalPaymentTextBox.TabIndex = 17;
            this.totalPaymentTextBox.UseSelectable = true;
            this.totalPaymentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalPaymentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(130, 118);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(193, 23);
            this.nameTextBox.TabIndex = 18;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(29, 118);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Nombre:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(29, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Proveedor:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(401, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Fecha:";
            // 
            // dateDateTime
            // 
            this.dateDateTime.Location = new System.Drawing.Point(480, 171);
            this.dateDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateDateTime.Name = "dateDateTime";
            this.dateDateTime.Size = new System.Drawing.Size(244, 29);
            this.dateDateTime.TabIndex = 12;
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(329, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(178, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "San Jóse, San Pedro, Calle 14";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.clearTitle);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.dateDateTime);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.providerTextBox);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.destinyTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(49, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 215);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura de salida de mercaderia";
            // 
            // destinyTextBox
            // 
            // 
            // 
            // 
            this.destinyTextBox.CustomButton.Image = null;
            this.destinyTextBox.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.destinyTextBox.CustomButton.Name = "";
            this.destinyTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.destinyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.destinyTextBox.CustomButton.TabIndex = 1;
            this.destinyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.destinyTextBox.CustomButton.UseSelectable = true;
            this.destinyTextBox.CustomButton.Visible = false;
            this.destinyTextBox.Lines = new string[0];
            this.destinyTextBox.Location = new System.Drawing.Point(480, 118);
            this.destinyTextBox.MaxLength = 32767;
            this.destinyTextBox.Name = "destinyTextBox";
            this.destinyTextBox.PasswordChar = '\0';
            this.destinyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.destinyTextBox.SelectedText = "";
            this.destinyTextBox.SelectionLength = 0;
            this.destinyTextBox.SelectionStart = 0;
            this.destinyTextBox.ShortcutsEnabled = true;
            this.destinyTextBox.Size = new System.Drawing.Size(244, 23);
            this.destinyTextBox.TabIndex = 18;
            this.destinyTextBox.UseSelectable = true;
            this.destinyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.destinyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(401, 118);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = "Destino:";
            // 
            // addProductsButton
            // 
            this.addProductsButton.Location = new System.Drawing.Point(100, 444);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(147, 23);
            this.addProductsButton.TabIndex = 24;
            this.addProductsButton.Text = "Agregar productos";
            this.addProductsButton.UseSelectable = true;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // UcExitInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddOutputInvoiceTile);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.totalPaymentTextBox);
            this.Name = "UcExitInvoice";
            this.Size = new System.Drawing.Size(955, 536);
            this.Load += new System.EventHandler(this.UcExitInvoice_Load);
            this.Leave += new System.EventHandler(this.UcExitInvoice_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile AddOutputInvoiceTile;
        private MetroFramework.Controls.MetroTile clearTitle;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroTextBox providerTextBox;
        private MetroFramework.Controls.MetroTextBox totalPaymentTextBox;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dateDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox destinyTextBox;
        private MetroFramework.Controls.MetroButton addProductsButton;
    }
}
