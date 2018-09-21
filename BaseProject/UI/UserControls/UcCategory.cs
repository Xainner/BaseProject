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

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Categorias";
        }

        private void UcCategory_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
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
    }
}
