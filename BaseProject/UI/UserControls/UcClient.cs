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
using BusinessLibrary.Models;

namespace UI.UserControls
{
    public partial class UcClient : UserControl
    {
        //ClientManagement client = new ClientManagement();

        public UcClient()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de clientes";
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = txtNameClient.Text;
            string lastname = txtLastnameClient.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailClient.Text;

            ClientManagement.InsertClient(name, lastname, identif, idType, email, bornDate);

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            string name = txtNameClient.Text;
            string lastname = txtLastnameClient.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailClient.Text;

            //ClientManagement.UpdateClientById(id, name, lastname, identif, idType, email, bornDate);

        }

        private void txtSearchClient_Click(object sender, EventArgs e)
        {
            //ClientManagement.SelectClientByName(idClient);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            //ClientManagement.DeleteClientById(idClient);
        }

        private void UcClient_Load(object sender, EventArgs e)
        {
            //List<ClientModel> = ClientManagement.SelectAllClients();

            //dgvClient = 
        }
    }
}
