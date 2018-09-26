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
using ModelLibrary.Models;

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

        public void SortAll()
        {
            dgvCategory.DataSource = CategoryManagement.SelectAllCategories();
            dgvSubCategory.DataSource = SubCategoryManagement.SelectAllSubCategories();
            cmbCategory.DataSource = CategoryManagement.SelectAllCategories();
            cmbCategory.DisplayMember = "Name";
        }

        private void UcCategory_Load(object sender, EventArgs e)
        {
            SortAll();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            
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
                    //dgvCategory.DataSource = CategoryManagement.Select; buscar por categoria
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
            
        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchSub_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchSub.Text;

            try
            {
                if (text != "")
                {
                    //dgvSubCategory.DataSource = SubCategoryManagement.se; buscar por subcategoria 
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
            
        }

        private void dgvSubCategory_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (CategoryModel item in cmbCategory.Items)
                {
                    int idCategory = int.Parse(dgvSubCategory.CurrentRow.Cells[2].Value.ToString());
                    if (item.IdCategory == idCategory)
                    {
                        cmbCategory.SelectedItem = item;
                    }
                }

                txtNameSub.Text = dgvSubCategory.CurrentRow.Cells[1].Value.ToString();
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
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        //----- CRUD---

        //SUBCATEGORY

        private void deleteSubCategoryButton_Click(object sender, EventArgs e)
        {
            string id = dgvSubCategory.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (SubCategoryManagement.DeleteSubCategoryById(id))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino la Subcategoria correctamente";
                    SortAll(); CleanAll();
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

        private void createSubCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryModel categoryModel = (CategoryModel)cmbCategory.SelectedItem;
            string subcategory = txtNameSub.Text;

            try
            {
                if (SubCategoryManagement.InsertSubCategory(subcategory, categoryModel.IdCategory.ToString()))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego la Subcategoria correctamente";
                    SortAll(); CleanAll();
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

        private void updateSubCategoryButton_Click(object sender, EventArgs e)
        {
            string id = dgvSubCategory.CurrentRow.Cells[0].Value.ToString();
            string category = cmbCategory.Text;
            string subcategory = txtNameSub.Text;

            try
            {
                if (SubCategoryManagement.UpdateSubCategoryById(id, category, subcategory))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego la Subcategoria correctamente";
                    SortAll(); CleanAll();
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


        //----------CATEGORY//

        private void createCategoryButton_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;
            string category = txtNameCategory.Text;

            try
            {
                if (CategoryManagement.InsertCategory(category))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se inserto la categoria correctamente";
                    SortAll(); CleanAll();
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

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;
            string category = txtNameCategory.Text;

            try
            {
                if (CategoryManagement.UpdateCategoryById(id, category))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico la categoria correctamente";
                    SortAll(); CleanAll();
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

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;

            try
            {
                if (CategoryManagement.DeleteCategoryById(id))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino la categoria correctamente";
                    SortAll(); CleanAll();
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
    }
}
