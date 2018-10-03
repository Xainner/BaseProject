using BusinessLibrary.Models;
using LogicLibrary;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;

namespace UI.Frames
{
    public partial class FrmSearchProduct : MetroFramework.Forms.MetroForm
    {
        public FrmSearchProduct()
        {
            InitializeComponent();
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            dgvSearchProduct.DataSource = ProductManagement.SelectAllProducts();
        }

        private void FrmSearchProduct_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvSearchProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                UcInputInvoice inputInvoice = new UcInputInvoice();

                string id = dgvSearchProduct.CurrentRow.Cells[0].Value.ToString();
                string code = dgvSearchProduct.CurrentRow.Cells[1].Value.ToString();
                string description = dgvSearchProduct.CurrentRow.Cells[2].Value.ToString();
                string subcategory = dgvSearchProduct.CurrentRow.Cells[3].Value.ToString();
                string quantity = dgvSearchProduct.CurrentRow.Cells[4].Value.ToString();
                string price = dgvSearchProduct.CurrentRow.Cells[5].Value.ToString();

                inputInvoice.dgvInputExitProduct.Rows.Add(id, code, description, subcategory, quantity, price);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string code = codeTextBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (code != " ")
                {
                    List<ProductModel> list = new List<ProductModel>();
                    ProductModel product = ProductManagement.SelectProductByCode(code);
                    list.Add(product);
                    dgvSearchProduct.DataSource = list;
                }
            }
        }

        private void descriptionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string description = descriptionTextBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (description != " ")
                {
                    dgvSearchProduct.DataSource = ProductManagement.SelectProductByDescription(description);
                }
            }
        }

        private void styleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string style = styleTextBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (style != " ")
                {
                    List<ProductModel> list = new List<ProductModel>();
                    ProductModel product = ProductManagement.SelectProductByStyle(style);
                    list.Add(product);
                    dgvSearchProduct.DataSource = list;
                }
            }
        }

        private void brandTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string brand = brandTextBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (brand != " ")
                {
                    foreach (BrandModel brandModel in BrandManagement.SelectBrandByName(brand))
                    {
                        dgvSearchProduct.DataSource = ProductManagement.SelectProductByIdBrand(brandModel.IdBrand.ToString());
                    }
                }
            }
        }

        private void subcategoryTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string subcategory = subcategoryTextBox.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (subcategory != " ")
                {
                    foreach (SubCategoryModel subCategoryModel in SubCategoryManagement.SelectSubCategoryByNames(subcategory))
                    {
                        dgvSearchProduct.DataSource = ProductManagement.SelectProductByIdSubCategory(subCategoryModel.IdsubCategory.ToString());
                    }
                }
            }
        }
    }
}
