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
    public partial class UcClient : MetroFramework.Controls.MetroUserControl
    {
        //---------GLOBALS---------//

        List<ClientModel> clientModels;

        //---------FORM METHODS---------//

        public UcClient()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Área de clientes.";
        }

        private void UcClient_Load(object sender, EventArgs e)
        {
            try
            {
                if (ClientManagement.SelectAllClients() != null)
                {
                    clientModels = ClientManagement.SelectAllClients();
                    WireUpClientsGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Los registros de la base de datos fueron cargados.";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "No se encontraron registros en la base de datos.";
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void UcClient_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        //---------CUSTOM METHODS---------//

        private void WireUpClientsGridView()
        {
            clientsGridView.DataSource = clientModels;
        }

        public void Clear()
        {
            txtNameClient.Text = "";
            txtLastnameClient.Text = "";
            cmbIdentificationType.Text = "";
            txtIdentification.Text = "";
            datepBornDate.Text = "";
            txtEmailClient.Text = "";
        }

        //---------EVENTS---------//

        private void txtSearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchClient.Text;

            try
            {
                if (text != "")
                {
                    clientsGridView.DataSource = ClientManagement.SelectClientByNameOrLastName(text);
                }
                else
                {
                    clientsGridView.DataSource = ClientManagement.SelectAllClients();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void clientsGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtNameClient.Text = clientsGridView.CurrentRow.Cells[1].Value.ToString();
                txtLastnameClient.Text = clientsGridView.CurrentRow.Cells[2].Value.ToString();
                txtEmailClient.Text = clientsGridView.CurrentRow.Cells[5].Value.ToString();
                cmbIdentificationType.SelectedItem = clientsGridView.CurrentRow.Cells[3].Value.ToString();
                txtIdentification.Text = clientsGridView.CurrentRow.Cells[4].Value.ToString();
                datepBornDate.Text = clientsGridView.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //---------BUTTONS---------//

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
            WireUpClientsGridView();
        }

        //---------CRUD---------//

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
                    Clear();
                    WireUpClientsGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Se agregó el cliente de manera correcta.";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al agregar el cliente, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string id = clientsGridView.CurrentRow.Cells[0].Value.ToString();
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
                    Clear();
                    WireUpClientsGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modificó el cliente de manera correcta.";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al modificar el cliente, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string idClient = clientsGridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (ClientManagement.DeleteClientById(idClient))
                {
                    Clear();
                    WireUpClientsGridView();
                    FrmMain.Instance.ToolStripLabel.Text = "Se eliminó el cliente de manera correcta.";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Ha ocurrido un error al eliminar el cliente, inténtelo nuevamente.";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
