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
using UI.Utilities;
using ModelLibrary.Models;
using BusinessLibrary.Models;

namespace UI.UserControls
{
    public partial class UcBusiness : MetroFramework.Controls.MetroUserControl
    {
        //---------GLOBALS---------//

        byte[] logo;
        string file;

        List<BusinessModel> businessModels;

        //---------FORM METHODS---------//

        public UcBusiness()
        {
            InitializeComponent();
            FrmMain.Instance.ToolStripLabel.Text = "Área de negocios.";
        }

        private void UcBusiness_Load(object sender, EventArgs e)
        {
            //dgvBusiness.Columns["idBusiness"].DisplayIndex = 0;
            //dgvBusiness.Columns["idBusiness"].HeaderText = "Id";
            try
            {
                if (BusinessManagement.SelectAllBusiness() != null)
                {
                    businessModels = BusinessManagement.SelectAllBusiness();
                    WireUpBusinessGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Los registros de la base de datos fueron cargados.";
                }
            }
            catch (Exception)
            {
                FrmMain.Instance.ToolStripLabel.Text = "No se encontraron registros en la base de datos.";
                throw;
            }
        }

        private void UcBusiness_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //---------CUSTOM METHODS---------//

        public void Clear()
        {
            txtFantasyName.Text = " ";
            txtSocietyName.Text = " ";
            txtlegalCertification.Text = " ";
            mtxtTelephone.Text = " ";
            txaMainAddress.Text = " ";
            txaGeneralAddress.Text = " ";
            txtEmail.Text = " ";
            txtWebPage.Text = " ";
            pbLogo.Image = null;
            file = string.Empty;
            logo = null;
            pbLogo.Image = Properties.Resources.Empty;
        }

        private void WireUpBusinessGridView()
        {
            businessGridView.DataSource = businessModels;
        }

        //---------EVENTS---------//

        private void businessFantasyNameSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(businessFantasyNameSearchTextBox.Text))
                {
                    businessGridView.DataSource = BusinessManagement.SelectBusinessByName(businessFantasyNameSearchTextBox.Text);
                }
                else
                {
                    WireUpBusinessGridView();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JPEG|*.jpg|PNG|*.png",
                Title = "Seleccione la imagen del producto",
                Multiselect = false,
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbLogo.Load(openFileDialog.FileName);
                    logo = ImageManagement.ImageToByte(openFileDialog.FileName);
                }
            }
        }

        private void businessGridView_Click(object sender, EventArgs e)
        {
            try
            {
                if (businessGridView.SelectedRows.Count != 0)
                {
                    Clear();
                    txtFantasyName.Text = businessGridView.CurrentRow.Cells[1].Value.ToString();
                    txtSocietyName.Text = businessGridView.CurrentRow.Cells[2].Value.ToString();
                    txtlegalCertification.Text = businessGridView.CurrentRow.Cells[3].Value.ToString();
                    mtxtTelephone.Text = businessGridView.CurrentRow.Cells[4].Value.ToString();
                    txaMainAddress.Text = businessGridView.CurrentRow.Cells[5].Value.ToString();
                    txaGeneralAddress.Text = businessGridView.CurrentRow.Cells[6].Value.ToString();
                    txtEmail.Text = businessGridView.CurrentRow.Cells[7].Value.ToString();
                    txtWebPage.Text = businessGridView.CurrentRow.Cells[8].Value.ToString();
                    logo = (byte[])businessGridView.CurrentRow.Cells[9].Value;
                    pbLogo.Image = ImageManagement.ByteToImage((byte[])businessGridView.CurrentRow.Cells[9].Value);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //---------BUTTONS---------//

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
            WireUpBusinessGridView();
        }

        //---------CRUD---------//

        private void createButton_Click(object sender, EventArgs e)
        {
            string fantasyName = txtFantasyName.Text;
            string society = txtSocietyName.Text;
            string legalDoc = txtlegalCertification.Text;
            string telephone = mtxtTelephone.Text;
            string mainAddress = txaMainAddress.Text;
            string generalAddress = txaGeneralAddress.Text;
            string email = txtEmail.Text;
            string webPage = txtWebPage.Text;
            byte[] logo = ImageManagement.ImageToByte(file);

            try
            {
                if (BusinessManagement.InsertBusiness(fantasyName, society, legalDoc, telephone, mainAddress, generalAddress,
                    email, webPage, logo))
                {
                    Clear();
                    businessModels = BusinessManagement.SelectAllBusiness();
                    WireUpBusinessGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Negocio agregado correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al agregar el negocio";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string id = businessGridView.CurrentRow.Cells[0].Value.ToString();
            string fantasyName = txtFantasyName.Text;
            string society = txtSocietyName.Text;
            string legalDoc = txtlegalCertification.Text;
            string telephone = mtxtTelephone.Text;
            string mainAddress = txaMainAddress.Text;
            string generalAddress = txaGeneralAddress.Text;
            string email = txtEmail.Text;
            string webPage = txtWebPage.Text;

            if (!string.IsNullOrEmpty(file))
            {
                logo = ImageManagement.ImageToByte(file);
            }

            try
            {
                if (BusinessManagement.UpdateBusinessById(id, fantasyName, society, legalDoc, telephone, mainAddress, generalAddress,
                    email, webPage, logo))
                {
                    Clear();
                    businessModels = BusinessManagement.SelectAllBusiness();
                    WireUpBusinessGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Negocio modificado correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar el negocio";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = businessGridView.CurrentRow.Cells[0].Value.ToString();

                if (BusinessManagement.DeleteBusinessById(id))
                {
                    Clear();
                    businessModels = BusinessManagement.SelectAllBusiness();
                    WireUpBusinessGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "El negocio ha sido elimado correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar el negocio";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
