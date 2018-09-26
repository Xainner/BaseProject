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

namespace UI.UserControls
{
    public partial class UcBusiness : MetroFramework.Controls.MetroUserControl
    {
        byte[] logo;
        string file;

        //---------GLOBALS---------//

        List<BusinessModel> businessModels;

        public UcBusiness()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Negocio";
        }

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
                }
            }
            catch (Exception)
            {
                FrmMain.Instance.ToolStripLabel.Text = "No se encontraron registros en la base de datos.";
                throw;
            }
        }

        private void WireUpBusinessGridView()
        {
            dgvBusiness.DataSource = businessModels;

        }

        private void UcBusiness_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }


        //---------BUTTONS---------//

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
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
            byte[] logo = ImageManagement.ImageToByte(pbLogo.Image);

            try
            {
                if (BusinessManagement.InsertBusiness(fantasyName, society, legalDoc, telephone, mainAddress, generalAddress,
                    email, webPage, logo))
                {
                    dgvBusiness.DataSource = BusinessManagement.SelectAllBusiness();
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
            string id = dgvBusiness.CurrentRow.Cells[0].Value.ToString();
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
                    dgvBusiness.DataSource = BusinessManagement.SelectAllBusiness();
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
                string id = dgvBusiness.CurrentRow.Cells[0].Value.ToString();

                if (BusinessManagement.DeleteBusinessById(id))
                {
                    dgvBusiness.DataSource = BusinessManagement.SelectAllBusiness();
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

        private void dgvBusiness_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBusiness.SelectedRows.Count != 0)
                {
                    Clear();
                    txtFantasyName.Text = dgvBusiness.CurrentRow.Cells[1].Value.ToString();
                    txtSocietyName.Text = dgvBusiness.CurrentRow.Cells[2].Value.ToString();
                    txtlegalCertification.Text = dgvBusiness.CurrentRow.Cells[3].Value.ToString();
                    mtxtTelephone.Text = dgvBusiness.CurrentRow.Cells[4].Value.ToString();
                    txaMainAddress.Text = dgvBusiness.CurrentRow.Cells[5].Value.ToString();
                    txaGeneralAddress.Text = dgvBusiness.CurrentRow.Cells[6].Value.ToString();
                    txtEmail.Text = dgvBusiness.CurrentRow.Cells[7].Value.ToString();
                    txtWebPage.Text = dgvBusiness.CurrentRow.Cells[8].Value.ToString();
                    logo = (byte[])dgvBusiness.CurrentRow.Cells[9].Value;
                    pbLogo.Image = ImageManagement.ByteToImage((byte[])dgvBusiness.CurrentRow.Cells[9].Value);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void txtSearchBusiness_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearchBusiness.Text))
                {
                    dgvBusiness.DataSource = BusinessManagement.SelectBusinessByName(txtSearchBusiness.Text);
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

        }
    }
}
