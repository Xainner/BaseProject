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
using UI.Utilities;
using ModelLibrary.Models;
using BusinessLibrary.Models;

namespace UI.UserControls
{
    public partial class UcProduct : MetroFramework.Controls.MetroUserControl
    {
        byte[] photo;
        string file;

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
            rbIviRecorder.Select();
            txaDescription.Text = "";
            cmbCategory.Text = "";
            cmbSubcategory.Text = "";
            rbNonexistenPermit.Select();
            txtEnterQuantity.Text = "";
            txtEstableQuantity.Text = "";
            txtNormalPrice.Text = "";
            txtLowerPrice.Text = "";
            pbProduct.Image = null;

            file = string.Empty;
            photo = null;
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = ProductManagement.SelectAllProducts();
            cmbBrand.DataSource = BrandManagement.SelectAllBrands();
            cmbBrand.DisplayMember = "Name";
            cmbCategory.DataSource = CategoryManagement.SelectAllCategories();
            cmbCategory.DisplayMember = "Name";
            cmbSubcategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
            cmbSubcategory.DisplayMember = "Name";

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    file = openFileDialog1.FileName;
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
            BrandModel brand = (BrandModel)cmbBrand.SelectedItem;
            bool ivi = true;
            string description = txaDescription.Text;
            SubCategoryModel subcategory = (SubCategoryModel)cmbSubcategory.SelectedItem;
            bool nonExistingInvoice = true;
            string enterQuantity = txtEnterQuantity.Text;
            string estableQuantity = txtEstableQuantity.Text;
            string unityPrice = txtNormalPrice.Text;
            string lowerPrice = txtLowerPrice.Text;

            byte[] foto = ImageManagement.ImageToByte(pbProduct.Image);

            if (rbIviExcent.Checked)
            {
                ivi = false;
            }

            if (rbNonexistingNoPermit.Checked)
            {
                nonExistingInvoice = false;
            }

            try
            {
                if (ProductManagement.InsertProduct(code, style, brand.IdBrand.ToString(), description, subcategory.idsubCategory.ToString(), unityPrice, lowerPrice,
                    estableQuantity, enterQuantity, foto, ivi, nonExistingInvoice))
                {
                    dgvProduct.DataSource = ProductManagement.SelectAllProducts();
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego el producto correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error, no se pudo agregar el producto";
                }
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
            BrandModel brand = (BrandModel)cmbBrand.SelectedItem;
            bool ivi = true;
            string description = txaDescription.Text;
            SubCategoryModel subcategory = (SubCategoryModel)cmbSubcategory.SelectedItem;
            bool nonExistingInvoice = true;
            string enterQuantity = txtEnterQuantity.Text;
            string estableQuantity = txtEstableQuantity.Text;
            string unityPrice = txtNormalPrice.Text;
            string lowerPrice = txtLowerPrice.Text;

            if (rbIviExcent.Checked)
            {
                ivi = false;
            }

            if (rbNonexistingNoPermit.Checked)
            {
                nonExistingInvoice = false;
            }

            if (!string.IsNullOrEmpty(file))
            {
                photo = ImageManagement.ImageToByte(file);
            }

            try
            {
                if (ProductManagement.UpdateProductById(id, code, style, brand.IdBrand.ToString(), description, subcategory.idsubCategory.ToString(), unityPrice, lowerPrice,
                    estableQuantity, enterQuantity, photo, ivi, nonExistingInvoice))
                {
                    dgvProduct.DataSource = ProductManagement.SelectAllProducts();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el producto correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error, no se pudo modificar el producto";
                }
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
                txtCode.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                txtStyle.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                //cmbBrand.SelectedItem = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                txaDescription.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
                //cmbSubcategory.SelectedItem = dgvProduct.CurrentRow.Cells[5].Value.ToString();
                txtNormalPrice.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
                txtLowerPrice.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
                txtEstableQuantity.Text = dgvProduct.CurrentRow.Cells[8].Value.ToString();
                txtEnterQuantity.Text = dgvProduct.CurrentRow.Cells[9].Value.ToString();

                foreach (BrandModel item in cmbBrand.Items)
                {
                    int idBrand = int.Parse(dgvProduct.CurrentRow.Cells[3].Value.ToString());
                    if (item.idBrand == idBrand)
                    {
                        cmbBrand.SelectedItem = item;
                    }
                }

                foreach (SubCategoryModel item in cmbSubcategory.Items)
                {
                    int idSubCat = int.Parse(dgvProduct.CurrentRow.Cells[5].Value.ToString());

                    if (item.idsubCategory == idSubCat)
                    {
                        cmbSubcategory.SelectedItem = item;

                        foreach (CategoryModel item2 in cmbCategory.Items)
                        {
                            if (item2.idCategory == item.idCategory)
                            {
                                cmbCategory.SelectedItem = item2;
                            }
                        }
                    }
                }

                photo = (byte[])dgvProduct.CurrentRow.Cells[10].Value;
                pbProduct.Image = ImageManagement.ByteToImage((byte[])dgvProduct.CurrentRow.Cells[10].Value);

                if (dgvProduct.CurrentRow.Cells[11].Value.Equals(true))
                {
                    rbIviRecorder.Select();
                }
                else
                {
                    rbIviExcent.Select();
                }

                if (dgvProduct.CurrentRow.Cells[12].Value.Equals(true))
                {
                    rbNonexistenPermit.Select();
                }
                else
                {
                    rbNonexistingNoPermit.Select();
                }
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
