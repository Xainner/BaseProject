namespace UI.UserControls
{
    partial class UcSellinvoice
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
            this.invoiceIdLabel = new MetroFramework.Controls.MetroLabel();
            this.previewInvoiceButton = new MetroFramework.Controls.MetroButton();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbTypeCoin = new MetroFramework.Controls.MetroComboBox();
            this.productsGridView = new MetroFramework.Controls.MetroGrid();
            this.txtClient = new MetroFramework.Controls.MetroTextBox();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.txtEmployee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invoiceIdLabel);
            this.groupBox1.Controls.Add(this.previewInvoiceButton);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.productsGridView);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.txtEmployee);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 569);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la Factura";
            // 
            // invoiceIdLabel
            // 
            this.invoiceIdLabel.AutoSize = true;
            this.invoiceIdLabel.Location = new System.Drawing.Point(877, 29);
            this.invoiceIdLabel.Name = "invoiceIdLabel";
            this.invoiceIdLabel.Size = new System.Drawing.Size(16, 19);
            this.invoiceIdLabel.TabIndex = 30;
            this.invoiceIdLabel.Text = "0";
            // 
            // previewInvoiceButton
            // 
            this.previewInvoiceButton.Location = new System.Drawing.Point(791, 537);
            this.previewInvoiceButton.Name = "previewInvoiceButton";
            this.previewInvoiceButton.Size = new System.Drawing.Size(121, 23);
            this.previewInvoiceButton.TabIndex = 29;
            this.previewInvoiceButton.Text = "Previsualizar factura";
            this.previewInvoiceButton.UseSelectable = true;
            this.previewInvoiceButton.Click += new System.EventHandler(this.previewInvoiceButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(833, 131);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.Text = "Limpiar";
            this.ClearButton.UseSelectable = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.cmbTypeCoin);
            this.groupBox3.Location = new System.Drawing.Point(379, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 82);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formas de pago";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(15, 34);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(88, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Tipo modena";
            // 
            // cmbTypeCoin
            // 
            this.cmbTypeCoin.FormattingEnabled = true;
            this.cmbTypeCoin.ItemHeight = 23;
            this.cmbTypeCoin.Items.AddRange(new object[] {
            "Colón",
            "Dolar",
            "Euro"});
            this.cmbTypeCoin.Location = new System.Drawing.Point(119, 34);
            this.cmbTypeCoin.Name = "cmbTypeCoin";
            this.cmbTypeCoin.Size = new System.Drawing.Size(168, 29);
            this.cmbTypeCoin.TabIndex = 24;
            this.cmbTypeCoin.UseSelectable = true;
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsGridView.EnableHeadersVisualStyles = false;
            this.productsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.productsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productsGridView.Location = new System.Drawing.Point(23, 160);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(885, 371);
            this.productsGridView.TabIndex = 23;
            this.productsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellEndEdit);
            // 
            // txtClient
            // 
            // 
            // 
            // 
            this.txtClient.CustomButton.Image = null;
            this.txtClient.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtClient.CustomButton.Name = "";
            this.txtClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClient.CustomButton.TabIndex = 1;
            this.txtClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClient.CustomButton.UseSelectable = true;
            this.txtClient.CustomButton.Visible = false;
            this.txtClient.Lines = new string[0];
            this.txtClient.Location = new System.Drawing.Point(127, 74);
            this.txtClient.MaxLength = 32767;
            this.txtClient.Name = "txtClient";
            this.txtClient.PasswordChar = '\0';
            this.txtClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClient.SelectedText = "";
            this.txtClient.SelectionLength = 0;
            this.txtClient.SelectionStart = 0;
            this.txtClient.ShortcutsEnabled = true;
            this.txtClient.Size = new System.Drawing.Size(193, 23);
            this.txtClient.TabIndex = 16;
            this.txtClient.UseSelectable = true;
            this.txtClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(127, 131);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(195, 23);
            this.codeTextBox.TabIndex = 16;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.codeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codeTextBox_KeyUp);
            // 
            // txtEmployee
            // 
            // 
            // 
            // 
            this.txtEmployee.CustomButton.Image = null;
            this.txtEmployee.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtEmployee.CustomButton.Name = "";
            this.txtEmployee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployee.CustomButton.TabIndex = 1;
            this.txtEmployee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployee.CustomButton.UseSelectable = true;
            this.txtEmployee.CustomButton.Visible = false;
            this.txtEmployee.Lines = new string[0];
            this.txtEmployee.Location = new System.Drawing.Point(127, 29);
            this.txtEmployee.MaxLength = 32767;
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.PasswordChar = '\0';
            this.txtEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployee.SelectedText = "";
            this.txtEmployee.SelectionLength = 0;
            this.txtEmployee.SelectionStart = 0;
            this.txtEmployee.ShortcutsEnabled = true;
            this.txtEmployee.Size = new System.Drawing.Size(193, 23);
            this.txtEmployee.TabIndex = 16;
            this.txtEmployee.UseSelectable = true;
            this.txtEmployee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Código";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Cliente";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Vendedor";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(803, 29);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Num Fact.";
            // 
            // UcSellinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcSellinvoice";
            this.Size = new System.Drawing.Size(955, 592);
            this.Load += new System.EventHandler(this.UcSellinvoice_Load);
            this.Leave += new System.EventHandler(this.UcSellinvoice_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid productsGridView;
        private MetroFramework.Controls.MetroTextBox txtClient;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbTypeCoin;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton ClearButton;
        private MetroFramework.Controls.MetroButton previewInvoiceButton;
        private MetroFramework.Controls.MetroLabel invoiceIdLabel;
    }
}
