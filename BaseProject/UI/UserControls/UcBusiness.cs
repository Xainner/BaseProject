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

namespace UI.UserControls
{
    public partial class UcBusiness : UserControl
    {
        byte[] logo;
        string file;

        public UcBusiness()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Negocio";
        }

        public void CleanBusiness()
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
            dgvBusiness.DataSource = BusinessManagement.SelectAllBusiness();
            //dgvBusiness.Columns["idBusiness"].DisplayIndex = 0;
            //dgvBusiness.Columns["idBusiness"].HeaderText = "Id";
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            string fantasyName = txtFantasyName.Text;
            string society = txtSocietyName.Text;
            string legalDoc = txtlegalCertification.Text;
            string telephone = mtxtTelephone.Text;
            string mainAddress = txaMainAddress.Text;
            string generalAddress = txaGeneralAddress.Text;
            string email = txtEmail.Text;
            string webPage = txtWebPage.Text;
            logo = ImageManagement.ImageToByte(pbLogo.Image);

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

        private void btnUpdateBusiness_Click(object sender, EventArgs e)
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

        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            string id = dgvBusiness.CurrentRow.Cells[0].Value.ToString();

            try
            {
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

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    file = openFileDialog1.FileName;
                    pbLogo.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error al cargar la imagen: " + ex.ToString();
            }
        }

        private void txtSearchBusiness_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchBusiness.Text;

            try
            {
                if (text != " ")
                {
                    //BusinessManagement.SelectBusinessById(); falta buscar por nombre de negocio
                }
                else
                {
                    dgvBusiness.DataSource = BusinessManagement.SelectAllBusiness();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanBusiness();
        }

        private void UcBusiness_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
        private void dgvBusiness_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CleanBusiness();
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

                MessageBox.Show(pbLogo.ImageLocation);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
