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
using BusinessLibrary.Models;

namespace UI.UserControls
{
    public partial class UcCategory : MetroFramework.Controls.MetroUserControl
    {
        //---------GLOBALS---------//

        List<CategoryModel> categoryModels;
        List<SubCategoryModel> subCategoryModels;

        //---------FORM METHODS---------//

        public UcCategory()
        {
            InitializeComponent();
            FrmMain.Instance.ToolStripLabel.Text = "Área de categorías y subcategorías.";
        }

        private void UcCategory_Load(object sender, EventArgs e)
        {
            try
            {
                if (CategoryManagement.SelectAllCategories() != null && SubCategoryManagement.SelectAllSubCategories() != null)
                {
                    categoryModels = CategoryManagement.SelectAllCategories();
                    FrmMain.Instance.ToolStripLabel.Text = "Los registros de la base de datos fueron cargados.";
                    WireUpCategoryGridView();
                    WireUpSubCategoryGridView();
                    WireUpCategoryComboBox();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void UcCategory_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //---------CUSTOM METHODS---------//

        private void WireUpCategoryGridView()
        {
            categoryGridView.DataSource = categoryModels;
        }

        private void WireUpSubCategoryGridView()
        {
            subCategoryGridView.DataSource = subCategoryModels;
        }

        private void WireUpCategoryComboBox()
        {
            cmbCategory.DataSource = categoryModels;
            cmbCategory.DisplayMember = "Name";
        }

        private void Clear()
        {
            txtIDCategory.Text = " ";
            txtNameCategory.Text = " ";
            txtNameSub.Text = " ";
        }

        //---------BUTTONS---------//

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
            WireUpCategoryGridView();
            WireUpSubCategoryGridView();
            WireUpCategoryComboBox();
        }

        //---------SUBCATEGORY---------//

        //---------EVENTS---------//

        private void subCategoryNameSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = subCategoryNameSearchTextBox.Text;

            try
            {
                if (!string.IsNullOrEmpty(subCategoryNameSearchTextBox.Text))
                {
                    subCategoryGridView.DataSource = BusinessManagement.SelectBusinessByName(subCategoryNameSearchTextBox.Text);
                }
                else
                {
                    WireUpSubCategoryGridView();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void subCategoryGridView_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (CategoryModel item in cmbCategory.Items)
                {
                    int idCategory = int.Parse(subCategoryGridView.CurrentRow.Cells[2].Value.ToString());
                    if (item.IdCategory == idCategory)
                    {
                        cmbCategory.SelectedItem = item;
                        break;
                    }
                }

                txtNameSub.Text = subCategoryGridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //---------CRUD---------//

        private void createSubCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryModel categoryModel = (CategoryModel)cmbCategory.SelectedItem;
            string subcategory = txtNameSub.Text;

            try
            {
                if (SubCategoryManagement.InsertSubCategory(subcategory, categoryModel.IdCategory.ToString()))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se agregó la subcategoría de manera correcta.";
                    Clear();
                    subCategoryModels = SubCategoryManagement.SelectAllSubCategories();
                    WireUpSubCategoryGridView();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al agregar la subcategoría, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateSubCategoryButton_Click(object sender, EventArgs e)
        {
            string id = subCategoryGridView.CurrentRow.Cells[0].Value.ToString();
            string category = cmbCategory.Text;
            string subcategory = txtNameSub.Text;

            try
            {
                if (SubCategoryManagement.UpdateSubCategoryById(id, category, subcategory))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se modificó la subcategoría de manera correcta.";
                    Clear();
                    subCategoryModels = SubCategoryManagement.SelectAllSubCategories();
                    WireUpSubCategoryGridView();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al modificar la subcategoría, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteSubCategoryButton_Click(object sender, EventArgs e)
        {
            string id = subCategoryGridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (SubCategoryManagement.DeleteSubCategoryById(id))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se eliminó la subcategoría de manera correcta.";
                    Clear();
                    subCategoryModels = SubCategoryManagement.SelectAllSubCategories();
                    WireUpSubCategoryGridView();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al eliminar la subcategoría, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //---------CATEGORY---------//

        //---------EVENTS---------//

        private void categoryNameSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = categoryNameSearchTextBox.Text;

            try
            {
                if (!string.IsNullOrEmpty(categoryNameSearchTextBox.Text))
                {
                    categoryGridView.DataSource = CategoryManagement.SelectCategoryByName(categoryNameSearchTextBox.Text);
                }
                else
                {
                    WireUpCategoryGridView();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void categoryGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtIDCategory.Text = categoryGridView.CurrentRow.Cells[0].Value.ToString();
                txtNameCategory.Text = categoryGridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //---------CRUD---------//

        private void createCategoryButton_Click(object sender, EventArgs e)
        {
            string id = txtIDCategory.Text;
            string category = txtNameCategory.Text;

            try
            {
                if (CategoryManagement.InsertCategory(category))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se insertó la categoría de manera correcta.";
                    Clear();
                    categoryModels = CategoryManagement.SelectAllCategories();
                    WireUpCategoryGridView();
                    WireUpCategoryComboBox();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al agregar la categoría, inténtelo nuevamente.";
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
                    FrmMain.Instance.ToolStripLabel.Text = "Se modificó la categoría de manera correcta.";
                    Clear();
                    categoryModels = CategoryManagement.SelectAllCategories();
                    WireUpCategoryGridView();
                    WireUpCategoryComboBox();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al modificar la categoría, inténtelo nuevamente.";
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
                    FrmMain.Instance.ToolStripLabel.Text = "Se eliminó la categoría de manera correcta.";
                    Clear();
                    categoryModels = CategoryManagement.SelectAllCategories();
                    WireUpCategoryGridView();
                    WireUpCategoryComboBox();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al eliminar la categoría, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
