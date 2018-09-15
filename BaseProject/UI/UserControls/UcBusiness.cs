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
    public partial class UcBusiness : UserControl
    {
        public UcBusiness()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Negocio";
        }

        private void UcBusiness_Load(object sender, EventArgs e)
        {
            //Mostrar  dgvBusiness
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
            //byte[] logo = pbLogo.Contains.;

            //BusinessManagement.InsertBusiness()
        }

        private void btnUpdateBusiness_Click(object sender, EventArgs e)
        {
            //BusinessManagement.UpdateBusinessById(idBusiness);
        }

        private void txtSearchBusiness_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBusiness_Click(object sender, EventArgs e)
        {
            //BusinessManagement.DeleteBusinessById(idBusiness);
        }
    }
}
