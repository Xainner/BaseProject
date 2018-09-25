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

        public void Clear()
        {
            idBrandTextBox.Text = " ";
            brandNameTextBox.Text = " ";

            dgvBrand.DataSource = BrandManagement.SelectAllBrands();
        }

        private void UcBrandSize_Load(object sender, EventArgs e)
        {
            dgvBrand.DataSource = BrandManagement.SelectAllBrands();
        }

        private void txtSearchBrand_Click(object sender, EventArgs e)
        {
            string text = brandNameSearchTextBox.Text;

            BrandManagement.SelectBrandByName(text);
        }

        private void dgvBrand_MouseClick(object sender, MouseEventArgs e)
        {
            idBrandTextBox.Text = dgvBrand.CurrentRow.Cells[0].Value.ToString();
            brandNameTextBox.Text = dgvBrand.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSearchBrand_KeyPress(object sender, KeyPressEventArgs e)
        {         
            try
            {
                string text = brandNameSearchTextBox.Text;

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

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //--------------CRUD--------------//

        private void createButton_Click(object sender, EventArgs e)
        {
            string id = idBrandTextBox.Text;
            string brand = brandNameTextBox.Text;

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            string id = idBrandTextBox.Text; //dgvBrand.CurrentRow.Cells[0].Value.ToString();
            string brand = brandNameTextBox.Text;

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string id = idBrandTextBox.Text;

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

        
    }
}
