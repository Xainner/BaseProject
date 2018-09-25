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

namespace UI.UserControls
{
    public partial class UcPositionSalary : MetroFramework.Controls.MetroUserControl
    {
        public UcPositionSalary()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Salarios y Posiciones";
        }

        public void CleanAll()
        {
            txtID.Text = " ";
            txtQuantity.Text = " ";
            txtNamePosition.Text = " ";
            cmbSalary.SelectedItem = " ";
        }

        public void sortAll()
        {
            dgvSalary.DataSource = SalaryManagement.SelectAllSalaries();
            dgvPosition.DataSource = PositionManagement.SelectAllPositions();
            cmbSalary.DataSource = SalaryManagement.SelectAllSalaries();
            cmbSalary.DisplayMember = "salaryAmount";
        }

        private void UcPositionSalary_Load(object sender, EventArgs e)
        {
            sortAll();
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string salary = txtQuantity.Text;

            try
            {
                if (SalaryManagement.UpdateSalaryById(id, salary))
                {
                    sortAll();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el salario correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar el salario";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearchSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchSalary.Text;

            try
            {
                if (text != "")
                {
                    dgvSalary.DataSource = SalaryManagement.SelectSalaryByRegistrationDate(text);
                    //Buscar por cantidad
                }
                else
                {
                    dgvSalary.DataSource = SalaryManagement.SelectAllSalaries();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeleteSalary_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSalary_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtID.Text = dgvSalary.CurrentRow.Cells[0].Value.ToString();
                txtQuantity.Text = dgvSalary.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //-------------------------SECCION DE POSICIONES--------------------------------

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdatePosition_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtSearchPosition.Text;

            try
            {
                if (text != "")
                {
                    //dgvPosition.DataSource = PositionManagement.se; Buscar por nombre de posicion
                }
                else
                {
                    //dgvPosition.DataSource = PositionManagement.SelectAllPositions();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPosition_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtNamePosition.Text = dgvPosition.CurrentRow.Cells[1].Value.ToString();

                foreach (SalaryModel item in cmbSalary.Items)
                {
                    int idSalary = int.Parse(dgvPosition.CurrentRow.Cells[2].Value.ToString());
                    if (item.IdSalary == idSalary)
                    {
                        cmbSalary.SelectedItem = item;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UcPositionSalary_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        //CRUD

        private void createSalaryButton_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string salary = txtQuantity.Text;

            try
            {
                if (SalaryManagement.InsertSalary(salary))
                {
                    sortAll();
                    FrmMain.Instance.ToolStripLabel.Text = "Se inserto el salario correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al insertar el salario";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updateSalaryButton_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string salary = txtQuantity.Text;

            try
            {
                if (SalaryManagement.UpdateSalaryById(id, salary))
                {
                    sortAll();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el salario correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar el salario";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteSalaryButton_Click(object sender, EventArgs e)
        {
            string id = dgvSalary.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (SalaryManagement.DeleteSalaryById(id))
                {
                    sortAll();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino el salario correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar el salario";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void createPositionButton_Click(object sender, EventArgs e)
        {
            string position = txtNamePosition.Text;
            SalaryModel salary = (SalaryModel)cmbSalary.SelectedItem;

            try
            {
                if (PositionManagement.InsertPosition(position, salary.IdSalary.ToString()))
                {
                    dgvPosition.DataSource = PositionManagement.SelectAllPositions();
                    FrmMain.Instance.ToolStripLabel.Text = "Se inserto la posicion de trabajo correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al insertar la posicion de trabajo";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void updatePositionButton_Click(object sender, EventArgs e)
        {
            string id = dgvPosition.CurrentRow.Cells[0].Value.ToString();
            string position = txtNamePosition.Text;
            SalaryModel salary = (SalaryModel)cmbSalary.SelectedItem;

            try
            {
                if (PositionManagement.UpdatePositionById(id, position, salary.IdSalary.ToString()))
                {
                    dgvPosition.DataSource = PositionManagement.SelectAllPositions();
                    FrmMain.Instance.ToolStripLabel.Text = "Se modifico la Posicion correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al modificar la Posicion";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deletePositionButton_Click(object sender, EventArgs e)
        {
            string id = dgvPosition.CurrentRow.Cells[0].Value.ToString();

            try
            {
                if (PositionManagement.DeletePositionById(id))
                {
                    dgvPosition.DataSource = PositionManagement.SelectAllPositions();
                    FrmMain.Instance.ToolStripLabel.Text = "Se elimino la Posicion correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al eliminar la Posicion";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
