using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using LogicLibrary;
using ModelLibrary.Models;

namespace UI.Frames
{
    public partial class FrmBrand : MetroForm
    {
        //---------GLOBALS---------//
        List<BrandModel> brandModels;

        public FrmBrand()
        {
            InitializeComponent();
            Resizable = false;
            ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        //---------FORM METHODS---------//

        private void FrmBrand_Load(object sender, EventArgs e)
        {
            try
            {
                if (BrandManagement.SelectAllBrands() != null)
                {
                    brandModels = BrandManagement.SelectAllBrands();
                    WireUpBrandsGridView();
                } else
                {
                    toolStripStatusLabel1.Text = "No se encontraron registros en la base de datos.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmBrand_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Estás en el Dashboard";
            Dispose();
        }

        //---------CUSTOM METHODS---------//
        private void Clear()
        {
            brandNameSearchTextBox.Text = "";
            brandNameTextBox.Text = "";
            idBrandTextBox.Text = "";
        }

        private void WireUpBrandsGridView()
        {
            Clear();
            brandsGridView.DataSource = brandModels;
        }

        //---------BUTTONS---------//

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //---------OTHER METHODS---------//

        private void brandsGridView_Click(object sender, EventArgs e)
        {
            try
            {
                if (brandsGridView.SelectedRows != null)
                {
                    idBrandTextBox.Text = brandsGridView.CurrentRow.Cells[0].Value.ToString();
                    brandNameTextBox.Text = brandsGridView.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //---------CRUD---------//

        private void createButton_Click(object sender, EventArgs e)
        {
            string id = idBrandTextBox.Text;
            string brand = brandNameTextBox.Text;

            try
            {
                if (BrandManagement.InsertBusiness(brand))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se agregó la marca de manera correcta.";
                    brandsGridView.DataSource = BrandManagement.SelectAllBrands();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al agregar la marca, inténtelo nuevamente.";
                }
            }
            catch (Exception ex)
            {
                throw;
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
                    brandsGridView.DataSource = BrandManagement.SelectAllBrands();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modificó la marca de manera correcta.";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al modificar la marca, inténtelo nuevamente.";
                }
            }
            catch (Exception ex)
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
                    brandsGridView.DataSource = BrandManagement.SelectAllBrands();
                    FrmMain.Instance.ToolStripLabel.Text = "Se eliminó la marca de manera correcta";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al eliminar la marca, inténtelo nuevamente.";
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
