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

        public void CleanProduct()
        {
            txtCode.Text = "";
            txtStyle.Text = "";
            cmbBrand.Text = "";
            cmbIvi.Text = "";
            txaDescription.Text = "";
            cmbCategory.Text = "";
            cmbSubcategory.Text = "";
            cmbNonExistent.Text = "";
            txtEnterQuantity.Text = "";
            txtEstableQuantity.Text = "";
            txtNormalPrice.Text = "";
            txtLowerPrice.Text = "";
            pbProduct.Image = null;
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = ProductManagement.SelectAllProducts();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pbProduct.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error al cargar la imagen: " + ex.ToString();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string style = txtStyle.Text;
            string brand = cmbBrand.Text;
            string ivi = cmbIvi.Text;
            string description = txaDescription.Text;
            string category = cmbCategory.Text;
            string subcategory = cmbSubcategory.Text;
            string nonExistingInvoice = cmbNonExistent.Text;
            string enterQuantity = txtEnterQuantity.Text;
            string estableQuantity = txtEstableQuantity.Text;
            string unityPrice = txtNormalPrice.Text;
            string lowerPrice = txtLowerPrice.Text;

            //todavia tiene talla
            try
            {
                //if (ProductManagement.InsertProduct(code, style, brand, description, category, subcategory, unityPrice, lowerPrice, 
                //    estableQuantity, enterQuantity, foto, ivi, nonExistingInvoice)
                //{
                //    dgvProduct.DataSource = ProductManagement.SelectAllProducts();
                //    FrmMain.Instance.ToolStripLabel.Text = "Se agrego el producto correctamente";
                //}
                //else
                //{
                //    FrmMain.Instance.ToolStripLabel.Text = "Error, no se pudo agregar el producto";
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string id = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            string code = txtCode.Text;
            string style = txtStyle.Text;
            string brand = cmbBrand.Text;
            string ivi = cmbIvi.Text;
            string description = txaDescription.Text;
            string category = cmbCategory.Text;
            string subcategory = cmbSubcategory.Text;
            string nonExistingInvoice = cmbNonExistent.Text;
            string enterQuantity = txtEnterQuantity.Text;
            string estableQuantity = txtEstableQuantity.Text;
            string unityPrice = txtNormalPrice.Text;
            string lowerPrice = txtLowerPrice.Text;
            //foto
            //todavia tiene talla
            try
            {
                //if (ProductManagement.UpdateProductById(id, code, style, brand, description, category, subcategory, unityPrice, lowerPrice,
                //    estableQuantity, enterQuantity, foto, ivi, nonExistingInvoice)
                //{
                //    dgvProduct.DataSource = ProductManagement.SelectAllProducts();
                //    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el producto correctamente";
                //}
                //else
                //{
                //    FrmMain.Instance.ToolStripLabel.Text = "Error, no se pudo modificar el producto";
                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchProduct.Text;

            try
            {
                if (text != " ")
                {
                    ProductManagement.SelectProductByCode(text);
                    ProductManagement.SelectProductByDescription(text);
                    ProductManagement.SelectProductByIdBrand(text);
                    ProductManagement.SelectProductByIdCategory(text);
                    ProductManagement.SelectProductByStyle(text);
                }
                else
                {
                    dgvProduct.DataSource = ProductManagement.SelectAllProducts();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string id = dgvProduct.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (ProductManagement.DeleteProductById(id))
                {
                    dgvProduct.DataSource = ProductManagement.SelectAllProducts();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino el producto correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar el producto";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvProduct_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtCode.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                txtStyle.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                cmbBrand.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                cmbIvi.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                txaDescription.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
                cmbCategory.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
                cmbSubcategory.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
                cmbNonExistent.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
                txtEnterQuantity.Text = dgvProduct.CurrentRow.Cells[8].Value.ToString();
                txtEstableQuantity.Text = dgvProduct.CurrentRow.Cells[9].Value.ToString();
                txtNormalPrice.Text = dgvProduct.CurrentRow.Cells[10].Value.ToString();
                txtLowerPrice.Text = dgvProduct.CurrentRow.Cells[11].Value.ToString();
                //pbProduct.Image = dgvProduct.CurrentRow.Cells[12].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UcProduct_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCleanProduct_Click(object sender, EventArgs e)
        {
            CleanProduct();
        }
    }
}
