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
    public partial class UcCategory : UserControl
    {
        public UcCategory()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Categorias y Subcategorias";
        }

        private void CleanAll()
        {
            txtIDCategory.Text = " ";
            txtNameCategory.Text = " ";
            txtNameSub.Text = " ";
            dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
            dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
        }

        private void UcCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
            dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
            cmbCategory.DataSource = CategoryManagement.SelectAllCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;
            string category = txtNameCategory.Text;

            try
            {
                if (CategoryManagement.InsertCategory(category))
                {
                    dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Se inserto la categoria correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al insertar la categoria";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;
            string category = txtNameCategory.Text;

            try
            {
                if (CategoryManagement.UpdateCategoryById(id, category))
                {
                    dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico la categoria correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar la categoria";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;

            try
            {
                if (CategoryManagement.DeleteCategoryById(id))
                {
                    dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino la categoria correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar la categoria";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            try
            {
                txtIDCategory.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                txtNameCategory.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchCategory.Text;

            try
            {
                if (text != "")
                {
                    //dgvCategory.DataSource = CategoryManagement.Select;
                }
                else
                {
                    //dgvCategory.DataSource = ClientManagement.SelectAllClients();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //--------------------------SECTOR DE SUBCATEGORIAS----------------------------------

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            string subcategory = txtNameSub.Text;

            try
            {
                if (SubCategoryManagement.InsertSubCategory(subcategory, category))
                {
                    dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego la Subcategoria correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al agregar la Subcategoria";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {
            string id = dgvSubCategory.CurrentRow.Cells[0].Value.ToString();
            string category = cmbCategory.Text;
            string subcategory = txtNameSub.Text;

            try
            {
                if (SubCategoryManagement.UpdateSubCategoryById(id, category, subcategory))
                {
                    dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego la Subcategoria correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al agregar la Subcategoria";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchSub.Text;

            try
            {
                if (text != "")
                {
                    //dgvSubCategory.DataSource = SubCategoryManagement.se;
                }
                else
                {
                    //dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            string id = dgvSubCategory.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (SubCategoryManagement.DeleteSubCategoryById(id))
                {
                    dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino la Subcategoria correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar la Subcategoria";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvSubCategory_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                cmbCategory.SelectedItem = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                txtNameSub.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UcCategory_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
