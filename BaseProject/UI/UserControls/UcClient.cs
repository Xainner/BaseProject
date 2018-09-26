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
        public UcClient()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de clientes";
        }

        public void Limpiar()
        {
            txtNameClient.Text = "";
            txtLastnameClient.Text = "";
            cmbIdentificationType.Text = "";
            txtIdentification.Text = "";
            datepBornDate.Text = "";
            txtEmailClient.Text = "";

            dgvClient.DataSource = ClientManagement.SelectAllClients();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            
        }

        private void UcClient_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = ClientManagement.SelectAllClients();
        }

        private void dgvClient_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtNameClient.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
                txtLastnameClient.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
                txtEmailClient.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
                cmbIdentificationType.SelectedItem = dgvClient.CurrentRow.Cells[3].Value.ToString();
                txtIdentification.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
                datepBornDate.Text = dgvClient.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchClient.Text;

            try
            {
                if (text != "")
                {
                    dgvClient.DataSource = ClientManagement.SelectClientByNameOrLastName(text);
                }
                else
                {
                    dgvClient.DataSource = ClientManagement.SelectAllClients();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            
        }

        private void UcClient_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //CRUD

        private void createButton_Click(object sender, EventArgs e)
        {
            string name = txtNameClient.Text;
            string lastname = txtLastnameClient.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailClient.Text;

            try
            {
                if (ClientManagement.InsertClient(name, lastname, identif, idType, email, bornDate))
                {
                    dgvClient.DataSource = ClientManagement.SelectAllClients();
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego el cliente correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "No se pudo agregar el cliente";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string id = dgvClient.CurrentRow.Cells[0].Value.ToString();
            string name = txtNameClient.Text;
            string lastname = txtLastnameClient.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailClient.Text;

            try
            {
                if (ClientManagement.UpdateClientById(id, name, lastname, identif, idType, email, bornDate))
                {
                    dgvClient.DataSource = ClientManagement.SelectAllClients();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el cliente correctamente";
                    Limpiar();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string idClient = dgvClient.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (ClientManagement.DeleteClientById(idClient))
                {
                    dgvClient.DataSource = ClientManagement.SelectAllClients();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino el cliente";
                    Limpiar();
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar el cliente";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
