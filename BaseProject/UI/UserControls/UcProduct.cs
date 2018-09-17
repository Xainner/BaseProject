using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;

namespace UI.UserControls
{
    public partial class UcProduct : UserControl
    {
        public UcProduct()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Productos";
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {
            //cargar la dgv con todos los productos
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string style = txtStyle.Text;
            string brand = cmbBrand.Text;
            string description = txaDescription.Text;
            string category = cmbCategory.Text;
            string subcategory = cmbSubcategory.Text;
            string existingInvoice = cmbNonExistent.Text;
            string inputQuantity = txtInputQuantity.Text;
            string normalPrice = txtNormalPrice.Text;
            string lowerPrice = txtLowerPrice.Text;
            string ivi = cmbIvi.Text;
            //byte[] img = pbProduct;
            string size = cmbSize.Text;
            //falta la cantidad de entrada de mercaderia por mes, cantidad estable

            //ProductManagement.InsertProduct(code, style, brand, description, category, subcategory, normalPrice, lowerPrice, inputQuantity,
            //    lowerPrice, img, ivi, existingInvoice, size);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string style = txtStyle.Text;
            string brand = cmbBrand.Text;
            string description = txaDescription.Text;
            string category = cmbCategory.Text;
            string subcategory = cmbSubcategory.Text;
            string existingInvoice = cmbNonExistent.Text;
            string inputQuantity = txtInputQuantity.Text;
            string normalPrice = txtNormalPrice.Text;
            string lowerPrice = txtLowerPrice.Text;
            string ivi = cmbIvi.Text;
            //byte[] img = pbProduct;
            string size = cmbSize.Text;

            //ProductManagement.UpdateProductById(idProduct, code, style, brand, description, category, subcategory, normalPrice, lowerPrice,
            //    inputQuantity, )
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //ProductManagement.SelectProductById(idProduct);
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //ProductManagement.DeleteProductById(idProduct);
        }
    }
}
