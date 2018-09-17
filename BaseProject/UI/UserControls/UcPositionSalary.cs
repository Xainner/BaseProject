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
    public partial class UcPositionSalary : UserControl
    {
        public UcPositionSalary()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de Salarios y Posiciones";
        }

        private void UcPositionSalary_Load(object sender, EventArgs e)
        {
            //Se cargara en el dgv todos los salarios y posiciones
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string salary = txtQuantity.Text;

            //error en la logica y los atributos
            //SalaryManagement.InsertSalary();
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string salary = txtQuantity.Text;

            //error en la logica y los atributos
            //SalaryManagement.UpdateSalaryById();
        }

        private void txtSearchSalary_Click(object sender, EventArgs e)
        {
            //SalaryManagement.SelectSalaryById(idSalary);
        }

        private void btnDeleteSalary_Click(object sender, EventArgs e)
        {
            //SalaryManagement.DeleteSalaryById(idSalary);
        }

        //------------------------SECCION DE POSICIONES-------------------------

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            string namePos = txtNamePosition.Text;
            string salary = cmbSalary.Text;

            PositionManagement.InsertPosition(namePos, salary);
        }

        private void btnUpdatePosition_Click(object sender, EventArgs e)
        {
            string namePos = txtNamePosition.Text;
            string salary = cmbSalary.Text;

            //PositionManagement.UpdatePositionById(idPosition, namePos, salary);
        }

        private void txtSearchPosition_Click(object sender, EventArgs e)
        {
            //PositionManagement.SelectPositionById(idPosition);
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            //PositionManagement.DeletePositionById(idPosition);
        }
    }
}
