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
            //Cargara los dvg de categoria y subcategoria
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string gender = cmbGender.Text;
            string nameCat = txtNameCategory.Text;

            CategoryManagement.InsertCategory(nameCat);
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string gender = cmbGender.Text;
            string nameCat = txtNameCategory.Text;

            //CategoryManagement.UpdateCategoryById(idCategory, nameCat);
        }

        private void txtSearchCategory_Click(object sender, EventArgs e)
        {
            //CategoryManagement.SelectCategoryById(idCategory);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            //CategoryManagement.DeleteCategoryById(idCategory);
        }

        //------------------------------SECCION DE SUBCATEGORIAS-------------------------------

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            string nameSub = txtNameSub.Text;

            SubCategoryManagement.InsertSubCategory(nameSub);
        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            string nameSub = txtNameSub.Text;

            //SubCategoryManagement.UpdateSubCategoryById(idSubCategory, nameSub);
        }

        private void txtSearchSub_Click(object sender, EventArgs e)
        {
            //SubCategoryManagement.SelectSubCategoryById(idSubCategory);
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            //SubCategoryManagement.DeleteSubCategoryById(idSubCategory);
        }
    }
}
