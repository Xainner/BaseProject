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
    public partial class UcBrandSize : UserControl
    {
        public UcBrandSize()
        {
            InitializeComponent();
        }

        private void UcBrandSize_Load(object sender, EventArgs e)
        {
            //Se cargan los data grid view
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            string nameBrand = txtBrand.Text;

            BrandManagement.InsertBrand(nameBrand);
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            string nameBrand = txtBrand.Text;

            //BrandManagement.UpdateBrandById(idBrand, nameBrand);
        }

        private void txtSearchBrand_Click(object sender, EventArgs e)
        {
            //BrandManagement.SelectBrandById(idBrand);
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            //BrandManagement.DeleteBrandById(idBrand);
        }

        //----------------------SECCION DE TALLAS--------------------------

        private void btnAddSize_Click(object sender, EventArgs e)
        {
            string size = txtSize.Text;

            //Falta el size DataManagemet
        }

        private void btnUpdateSize_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchSize_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {

        }
    }
}
