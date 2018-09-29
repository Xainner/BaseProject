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
        public FrmSearchProduct(string search)
        {
            InitializeComponent();

            Search(search);
        }

        public static string code;

        public static string Code { get => code; set => code = value; }

        private void Search(string text)
        {
            List<ProductModel> list = new List<ProductModel>();
            ProductModel product = ProductManagement.SelectProductByCode(text);
            list.Add(product);
            dgvSearchProduct.DataSource = list;

            //dgvSearchProduct.DataSource = ProductManagement.SelectProductByDescription(text);
        }

        private void FrmSearchProduct_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
