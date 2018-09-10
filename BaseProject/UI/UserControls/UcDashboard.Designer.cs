namespace UI.UserControls
{
    partial class UcDashboard
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
            this.btnProducts = new MetroFramework.Controls.MetroTile();
            this.btnBusiness = new MetroFramework.Controls.MetroTile();
            this.btnEmployee = new MetroFramework.Controls.MetroTile();
            this.btnClient = new MetroFramework.Controls.MetroTile();
            this.btnCategory = new MetroFramework.Controls.MetroTile();
            this.btnSalary = new MetroFramework.Controls.MetroTile();
            this.btnPosition = new MetroFramework.Controls.MetroTile();
            this.btnBrand = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.ActiveControl = null;
            this.btnProducts.Location = new System.Drawing.Point(70, 51);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(140, 105);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseSelectable = true;
            // 
            // btnBusiness
            // 
            this.btnBusiness.ActiveControl = null;
            this.btnBusiness.Location = new System.Drawing.Point(254, 51);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(140, 105);
            this.btnBusiness.TabIndex = 0;
            this.btnBusiness.Text = "Negocio";
            this.btnBusiness.UseSelectable = true;
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.ActiveControl = null;
            this.btnEmployee.Location = new System.Drawing.Point(70, 181);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(140, 105);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Empleados";
            this.btnEmployee.UseSelectable = true;
            // 
            // btnClient
            // 
            this.btnClient.ActiveControl = null;
            this.btnClient.Location = new System.Drawing.Point(254, 181);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(140, 105);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Cliente";
            this.btnClient.UseSelectable = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.ActiveControl = null;
            this.btnCategory.Location = new System.Drawing.Point(540, 298);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(140, 105);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Categoria";
            this.btnCategory.UseSelectable = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.ActiveControl = null;
            this.btnSalary.Location = new System.Drawing.Point(724, 298);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(140, 105);
            this.btnSalary.TabIndex = 0;
            this.btnSalary.Text = "Salario";
            this.btnSalary.UseSelectable = true;
            // 
            // btnPosition
            // 
            this.btnPosition.ActiveControl = null;
            this.btnPosition.Location = new System.Drawing.Point(540, 428);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(140, 105);
            this.btnPosition.TabIndex = 0;
            this.btnPosition.Text = "Posición";
            this.btnPosition.UseSelectable = true;
            // 
            // btnBrand
            // 
            this.btnBrand.ActiveControl = null;
            this.btnBrand.Location = new System.Drawing.Point(724, 428);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(140, 105);
            this.btnBrand.TabIndex = 0;
            this.btnBrand.Text = "Marca";
            this.btnBrand.UseSelectable = true;
            // 
            // UcDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrand);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProducts);
            this.Name = "UcDashboard";
            this.Size = new System.Drawing.Size(955, 612);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnProducts;
        private MetroFramework.Controls.MetroTile btnBusiness;
        private MetroFramework.Controls.MetroTile btnEmployee;
        private MetroFramework.Controls.MetroTile btnClient;
        private MetroFramework.Controls.MetroTile btnCategory;
        private MetroFramework.Controls.MetroTile btnSalary;
        private MetroFramework.Controls.MetroTile btnPosition;
        private MetroFramework.Controls.MetroTile btnBrand;
    }
}
