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
            
            FrmMain.Instance.ToolStripLabel.Text = "Estas en el área de tallas y marcas";
        }

        public void CleanBrand()
        {
            txtIDBrand.Text = " ";
            txtBrand.Text = " ";

            dgvBrand.DataSource = BrandManagement.SelectAllBrands();
        }

        private void UcBrandSize_Load(object sender, EventArgs e)
        {
            dgvBrand.DataSource = BrandManagement.SelectAllBrands();
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
                    dgvBrand.DataSource = BrandManagement.SelectAllBrands();
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
                if (BrandManagement.UpdateBrandById(id, brand))
                {
                    dgvBrand.DataSource = BrandManagement.SelectAllBrands();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico la marca correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar la marca";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchBrand_Click(object sender, EventArgs e)
        {
            string text = txtSearchBrand.Text;

            BrandManagement.SelectBrandByName(text);
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            string id = txtIDBrand.Text;

            try
            {
                if (BrandManagement.DeleteBrandById(id))
                {
                    dgvBrand.DataSource = BrandManagement.SelectAllBrands();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino la marca correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar la marca";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        private void dgvBrand_MouseClick(object sender, MouseEventArgs e)
        {
            txtIDBrand.Text = dgvBrand.CurrentRow.Cells[0].Value.ToString();
            txtBrand.Text = dgvBrand.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSearchBrand_KeyPress(object sender, KeyPressEventArgs e)
        {         
            try
            {
                string text = txtSearchBrand.Text;

                if (text != "")
                {
                    dgvBrand.DataSource = BrandManagement.SelectBrandByName(text);
                }
                else
                {
                    dgvBrand.DataSource = BrandManagement.SelectAllBrands();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcBrandSize_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanBrand();
        }
    }
}
