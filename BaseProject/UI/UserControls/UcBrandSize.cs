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
using BusinessLibrary.Models;

namespace UI.UserControls
{
    public partial class UcBrandSize : UserControl
    {
        public UcBrandSize()
        {
            InitializeComponent();
            
            FrmMain.Instance.ToolStripLabel.Text = "Estas en el área de tallas y marcas";
            txtIDBrand.Text = "";
            txtBrand.Text = "";
        }

        private void UcBrandSize_Load(object sender, EventArgs e)
        {
            dgvBrand.DataSource = BrandManagement.SelectAlBrands();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            string id = txtIDBrand.Text;
            string brand = txtBrand.Text;

            try
            {
                if (BrandManagement.InsertBusiness(brand))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego la marca correctamente";
                    dgvBrand.DataSource = BrandManagement.SelectAlBrands();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "No se agrego la marca";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            string id = txtIDBrand.Text; //dgvBrand.CurrentRow.Cells[0].Value.ToString();
            string brand = txtBrand.Text;

            try
            {
                BrandManagement.UpdateBrandById(id, brand);
                dgvBrand.DataSource = BrandManagement.SelectAlBrands();
                FrmMain.Instance.ToolStripLabel.Text = "Se modifico la marca correctamente";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchBrand_Click(object sender, EventArgs e)
        {
            //Hacer metodo para buscar por nombre
            //BrandManagement.SelectBrandById()
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            string id = txtIDBrand.Text;

            try
            {
                BrandManagement.DeleteBrandById(id);
                dgvBrand.DataSource = BrandManagement.SelectAlBrands();
                FrmMain.Instance.ToolStripLabel.Text = "Se elimino la marca correctamente";
            }
            catch (Exception)
            {

                throw;
            }

            BrandManagement.DeleteBrandById(id);

            dgvBrand.DataSource = BrandManagement.SelectAlBrands();
        }

        private void dgvBrand_SelectionChanged(object sender, EventArgs e)
        {
            txtIDBrand.Text = dgvBrand.CurrentRow.Cells[0].Value.ToString();
            txtBrand.Text = dgvBrand.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
