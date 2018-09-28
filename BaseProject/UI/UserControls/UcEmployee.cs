﻿using System;
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
    public partial class UcEmployee : MetroFramework.Controls.MetroUserControl
    {
        byte[] photo;
        string file;

        public UcEmployee()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de empleados";
        }

        public void CleanEmployee()
        {
            txtNameEmployee.Text = " ";
            txtLastnameEmployee.Text = " ";
            mtxtTelephone.Text = " ";
            mtxtCellphone.Text = " ";
            cmbIdentificationType.SelectedItem = " ";
            txtIdentification.Text = " ";
            datepBornDate.Value = DateTime.Today;
            txtEmailEmployee.Text = " ";
            txtNacionality.Text = " ";
            txtResidence.Text = " ";
            cmbCivilState.SelectedItem = " ";
            cmbChilds.SelectedItem = " ";

            picPhoto.Image = null; 

            cmbEnterStore.SelectedItem = " ";
            cmbPosition.SelectedItem = " ";
            workingStateComboBox.Text = " ";
            startDateDateTime.Value = DateTime.Today;
            endDateDateTime.Value = DateTime.Today;
            txaObservation.Text = " ";

            txtEmergencyName.Text = " ";
            mtxtEmergencyPhone.Text = " ";

            file = string.Empty;
            photo = null;
        }

        private void UcEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = EmployeeManagement.SelectAllEmployees();
            cmbPosition.DataSource = PositionManagement.SelectAllPositions();
            cmbPosition.DisplayMember = "positionName";
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    photo = ImageManagement.ImageToByte(openFileDialog1.FileName);
                    picPhoto.Load(this.openFileDialog1.FileName);
                    file = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error al cargar la imagen: " + ex.ToString();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtNameEmployee.Text;
            string lastname = txtLastnameEmployee.Text;
            string telephone = mtxtTelephone.Text;
            string cellphone = mtxtCellphone.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailEmployee.Text;
            string nationality = txtNacionality.Text;
            string residence = txtResidence.Text;
            string civilStatus = cmbCivilState.Text;
            string childs = cmbChilds.Text;
            photo = ImageManagement.ImageToByte(file); 

            string enterStore = cmbEnterStore.Text;

            PositionModel position = (PositionModel)cmbPosition.SelectedItem;

            string statusWorking = workingStateComboBox.Text;
            string startDate = startDateDateTime.Text;
            string observation = txaObservation.Text;

            string emergencyName = txtEmergencyName.Text;
            string emergencyPhone = mtxtEmergencyPhone.Text;

            try
            {
                if (EmployeeManagement.InsertEmployee(name, lastname, idType, identif, residence, bornDate, civilStatus, childs, telephone,
                    cellphone, enterStore, nationality, position.idPosition.ToString(), statusWorking, startDate, observation, photo, emergencyName, emergencyPhone))
                {
                    dgvEmployee.DataSource = EmployeeManagement.SelectAllEmployees();
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego el trabajador correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "No se pudo agregar el trabajador";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string id = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
            string name = txtNameEmployee.Text;
            string lastname = txtLastnameEmployee.Text;
            string telephone = mtxtTelephone.Text;
            string cellphone = mtxtCellphone.Text;
            string idType = cmbIdentificationType.Text;
            string identif = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string email = txtEmailEmployee.Text;
            string nationality = txtNacionality.Text;
            string residence = txtResidence.Text;
            string civilStatus = cmbCivilState.Text;
            string childs = cmbChilds.Text;

            string enterStore = cmbEnterStore.Text;

            PositionModel position = (PositionModel)cmbPosition.SelectedItem;

            string statusWorking = workingStateComboBox.Text;
            string startDate = startDateDateTime.Text;
            string endDate = startDateDateTime.Text;
            string observation = txaObservation.Text;

            string emergencyName = txtEmergencyName.Text;
            string emergencyPhone = mtxtEmergencyPhone.Text;

            if (!string.IsNullOrEmpty(file))
            {
                photo = ImageManagement.ImageToByte(file);
            }

            try
            {
                if (EmployeeManagement.UpdateEmployeeById(id, name, lastname, idType, identif, residence, bornDate, civilStatus, childs, telephone,
                    cellphone, enterStore, nationality, position.idPosition.ToString(), statusWorking, startDate, endDate, observation, photo, emergencyName, emergencyPhone))
                {
                    dgvEmployee.DataSource = EmployeeManagement.SelectAllEmployees();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el trabajador correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "No se pudo modificar el trabajador";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchEmployee.Text;

            try
            {
                if (text != "")
                {
                    dgvEmployee.DataSource = EmployeeManagement.SelecEmployeeByNameOrLastName(text);
                }
                else
                {
                    dgvEmployee.DataSource = EmployeeManagement.SelectAllEmployees();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string idEmployee = dgvEmployee.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (EmployeeManagement.DeleteEmployeeById(idEmployee))
                {
                    dgvEmployee.DataSource = EmployeeManagement.SelectAllEmployees();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino el trabajador";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar el trabajador";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtNameEmployee.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                txtLastnameEmployee.Text = dgvEmployee.CurrentRow.Cells[2].Value.ToString();
                cmbIdentificationType.SelectedItem = dgvEmployee.CurrentRow.Cells[3].Value.ToString();
                txtIdentification.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
                mtxtTelephone.Text = dgvEmployee.CurrentRow.Cells[9].Value.ToString();
                mtxtCellphone.Text = dgvEmployee.CurrentRow.Cells[10].Value.ToString();
                datepBornDate.Text = dgvEmployee.CurrentRow.Cells[6].Value.ToString();
                txtEmailEmployee.Text = dgvEmployee.CurrentRow.Cells[8].Value.ToString();
                txtNacionality.Text = dgvEmployee.CurrentRow.Cells[12].Value.ToString();
                txtResidence.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
                cmbCivilState.SelectedItem = dgvEmployee.CurrentRow.Cells[7].Value.ToString();
                cmbChilds.SelectedItem = dgvEmployee.CurrentRow.Cells[8].Value.ToString();

                photo = (byte[])dgvEmployee.CurrentRow.Cells[18].Value;
                picPhoto.Image = ImageManagement.ByteToImage((byte[])dgvEmployee.CurrentRow.Cells[18].Value);

                cmbEnterStore.SelectedItem = dgvEmployee.CurrentRow.Cells[11].Value.ToString(); 
                cmbPosition.SelectedItem = dgvEmployee.CurrentRow.Cells[13].Value.ToString(); 
                workingStateComboBox.SelectedItem = dgvEmployee.CurrentRow.Cells[14].Value.ToString(); 
                startDateDateTime.Text = dgvEmployee.CurrentRow.Cells[15].Value.ToString(); 
                txaObservation.Text = dgvEmployee.CurrentRow.Cells[17].Value.ToString(); 

                txtEmergencyName.Text = dgvEmployee.CurrentRow.Cells[19].Value.ToString(); 
                mtxtEmergencyPhone.Text = dgvEmployee.CurrentRow.Cells[20].Value.ToString(); 
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void UcEmployee_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCleanEmployee_Click(object sender, EventArgs e)
        {
            CleanEmployee();
        }
    }
}
