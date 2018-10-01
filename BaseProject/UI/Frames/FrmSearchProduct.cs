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
        public static string code { get; set; }
        public static string description { get; set; }
        public static string style { get; set; }
        public static string brand { get; set; }
        public static string subcategory { get; set; }

        public FrmSearchProduct(string search)
        {
            InitializeComponent();

            Search(search);
        }

        public void LoadProducts(MetroGrid dgv)
        {
            dgv.Columns.Add("id", "Id");
            dgv.Columns.Add("id", "Código");
            dgv.Columns.Add("description", "Descripción");
            dgv.Columns.Add("subcategory", "Sub-Categoría");
            dgv.Columns.Add("quantity", "Cantidad");
            dgv.Columns.Add("price", "Precio");
            for (int i = 0; i < dgvSearchProduct.Rows.Count; i++)
            {
                dgv.Rows.Add(dgvSearchProduct.Rows[i].Cells[0]);
                dgv.Rows[i].Cells[0].Value = dgvSearchProduct.Rows[i].Cells[0].Value.ToString();
                dgv.Rows[i].Cells[1].Value = dgvSearchProduct.Rows[i].Cells[1].Value.ToString();
                dgv.Rows[i].Cells[2].Value = dgvSearchProduct.Rows[i].Cells[2].Value.ToString();
                dgv.Rows[i].Cells[3].Value = dgvSearchProduct.Rows[i].Cells[3].Value.ToString();
                dgv.Rows[i].Cells[4].Value = dgvSearchProduct.Rows[i].Cells[4].Value.ToString();
                dgv.Rows[i].Cells[5].Value = dgvSearchProduct.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void Search(string text)
        {
            if (!string.IsNullOrEmpty(code))
            {
                List<ProductModel> list = new List<ProductModel>();
                ProductModel product = ProductManagement.SelectProductByCode(text);
                list.Add(product);
                dgvSearchProduct.DataSource = list;
            } else
            {
                if (!string.IsNullOrEmpty(description))
                {
                    dgvSearchProduct.DataSource = ProductManagement.SelectProductByDescription(description);
                }
                else
                {
                    if (!string.IsNullOrEmpty(style))
                    {
                        List<ProductModel> list = new List<ProductModel>();
                        ProductModel product = ProductManagement.SelectProductByStyle(text);
                        list.Add(product);
                        dgvSearchProduct.DataSource = list;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(brand))
                        {
                            foreach (BrandModel brandModel in BrandManagement.SelectBrandByName(brand))
                            {
                                dgvSearchProduct.DataSource = ProductManagement.SelectProductByIdBrand(brandModel.IdBrand.ToString());
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(subcategory))
                            {
                                foreach (SubCategoryModel subCategoryModel in SubCategoryManagement.SelectSubCategoryByNames(subcategory))
                                {
                                    dgvSearchProduct.DataSource = ProductManagement.SelectProductByIdBrand(subCategoryModel.IdsubCategory.ToString());
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {

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
                LoadProducts(inputInvoice.dgvProduct);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
