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
            string id = dgvClient.CurrentRow.Cells[0].Value.ToString();
            string name = txtNameClient.Text;
            string lastname = txtLastnameClient.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailClient.Text;

            ClientManagement.UpdateClientById(id, name, lastname, identif, idType, email, bornDate);

        }

        private void txtSearchClient_Click(object sender, EventArgs e)
        {
            string idClient = dgvClient.CurrentRow.Cells[0].Value.ToString();

            //ClientManagement.SelectClientByNameOrLastName(idClient);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            string idClient = dgvClient.CurrentRow.Cells[0].Value.ToString();

            ClientManagement.DeleteClientById(idClient);
        }

        private void UcClient_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = ClientManagement.SelectAllClients();
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameClient.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            txtLastnameClient.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            txtEmailClient.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            cmbIdentificationType.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
            txtIdentification.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
            datepBornDate.Text = dgvClient.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
