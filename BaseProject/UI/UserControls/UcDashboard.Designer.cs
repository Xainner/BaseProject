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
            this.btnBrandSize = new MetroFramework.Controls.MetroTile();
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
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
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
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
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
            this.btnCategory.Location = new System.Drawing.Point(578, 401);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(284, 89);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Categoria y Subcategoria";
            this.btnCategory.UseSelectable = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.ActiveControl = null;
            this.btnSalary.Location = new System.Drawing.Point(736, 290);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(125, 86);
            this.btnSalary.TabIndex = 0;
            this.btnSalary.Text = "Salario y Posición";
            this.btnSalary.UseSelectable = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnBrandSize
            // 
            this.btnBrandSize.ActiveControl = null;
            this.btnBrandSize.Location = new System.Drawing.Point(578, 290);
            this.btnBrandSize.Name = "btnBrandSize";
            this.btnBrandSize.Size = new System.Drawing.Size(133, 86);
            this.btnBrandSize.TabIndex = 1;
            this.btnBrandSize.Text = "Marca y Talla";
            this.btnBrandSize.UseSelectable = true;
            this.btnBrandSize.Click += new System.EventHandler(this.btnBrandSize_Click);
            // 
            // UcDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrandSize);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnBusiness);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnProducts);
            this.Name = "UcDashboard";
            this.Size = new System.Drawing.Size(955, 536);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnProducts;
        private MetroFramework.Controls.MetroTile btnBusiness;
        private MetroFramework.Controls.MetroTile btnEmployee;
        private MetroFramework.Controls.MetroTile btnClient;
        private MetroFramework.Controls.MetroTile btnCategory;
        private MetroFramework.Controls.MetroTile btnSalary;
        private MetroFramework.Controls.MetroTile btnBrandSize;
    }
}
