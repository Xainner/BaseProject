using BusinessLibrary.Models;
using LogicLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //dgvSearchProduct.DataSource = ProductManagement.SelectProductByDescription(text);
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {

        }

        private void FrmSearchProduct_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
