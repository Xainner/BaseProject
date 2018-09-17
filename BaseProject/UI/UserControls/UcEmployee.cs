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
    public partial class UcEmployee : UserControl
    {
        public UcEmployee()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de empleados";
        }

        private void UcEmployee_Load(object sender, EventArgs e)
        {
            //cargar el dvg de empleados
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtNameEmployee.Text;
            string lastname = txtLastnameEmployee.Text;
            string telephone = mtxtTelephone.Text;
            string cellphone = mtxtCellphone.Text;
            string email = txtEmailEmployee.Text;
            string nationality = txtNacionality.Text;
            string identificationType = cmbIdentificationType.Text;
            string id = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string residence = txtResidence.Text;
            string civilStatus = cmbCivilState.Text;
            string childs = cmbChilds.Text;
            //byte[] image = picPhoto;

            string position = cmbPosition.Text;
            string enterStore = txtEnterStore.Text;
            string workStatus = txtWorkStatus.Text;
            string exitDate = txtExitDate.Text;
            string observation = txaObservation.Text;
            string emergencyName = txtEmergencyName.Text;
            string emergencyCell = mtxtEmergencyPhone.Text;

            //EmployeeManagement.InsertEmployee(name, lastname, identificationType, id, residence, bornDate, civilStatus, childs,
            //    telephone, cellphone, enterStore, nationality, position, workStatus, enterStore, enterStore, observation,
            //    image, emergencyName, emergencyCell);
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string name = txtNameEmployee.Text;
            string lastname = txtLastnameEmployee.Text;
            string telephone = mtxtTelephone.Text;
            string cellphone = mtxtCellphone.Text;
            string email = txtEmailEmployee.Text;
            string nationality = txtNacionality.Text;
            string identificationType = cmbIdentificationType.Text;
            string id = txtIdentification.Text;
            string bornDate = datepBornDate.Text;
            string residence = txtResidence.Text;
            string civilStatus = cmbCivilState.Text;
            string childs = cmbChilds.Text;
            //byte[] image = picPhoto;

            string position = cmbPosition.Text;
            string enterStore = txtEnterStore.Text;
            string workStatus = txtWorkStatus.Text;
            string exitDate = txtExitDate.Text;
            string observation = txaObservation.Text;
            string emergencyName = txtEmergencyName.Text;
            string emergencyCell = mtxtEmergencyPhone.Text;

            //EmployeeManagement.UpdateEmployeeById(idEmployee, name, lastname, identificationType, id, residence, bornDate, civilStatus, childs,
            //    telephone, cellphone, enterStore, nationality, position, workStatus, enterStore, enterStore, observation,
            //    image, emergencyName, emergencyCell);
        }

        private void txtSearchEmployee_Click(object sender, EventArgs e)
        {
            //EmployeeManagement.SelectEmployeeById(idEmployee);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //EmployeeManagement.DeleteEmployeeById(idEmployee);
        }

    }
}
