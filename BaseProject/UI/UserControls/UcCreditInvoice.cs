using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class UcCreditInvoice : UserControl
    {
        public UcCreditInvoice()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de ventas a credito";
        }

        public void CleanCreditinvoice()
        {
            //string numInvoice = Proceso interno
            //string date = Proceso interno
            txtClient.Text = " ";
            txtEmployee.Text = " ";
            txtUser.Text = " ";
            cmbTypeCoin.Text = " ";
            cmbTypePayment.Text = " ";
            txtDaxes.Text = " ";
            txtTypeChange.Text = " ";
            txtPayment.Text = " ";
            txtDiscount.Text = " ";
            txtSubtotal.Text = " ";
            txtTotalPay.Text = " ";

            txtRange.Text = " ";
            txtInterest.Text = " ";
            txtAmountOfDues.Text = " ";
            txtCashDeposit.Text = " ";
            txtCardDeposit.Text = " ";
            txtInflation.Text = " ";
        }

        private void UcCreditInvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            //string numInvoice = Proceso interno
            //string date = Proceso interno
            string idClient = txtClient.Text;
            string idEmployee = txtEmployee.Text;
            string idUser = txtUser.Text;
            string coinType = cmbTypeCoin.Text;
            string paymentType = cmbTypePayment.Text;
            string iviAmount = txtDaxes.Text;
            string currencyType = txtTypeChange.Text;
            string paymentCash = txtPayment.Text;
            string totalDiscount = txtDiscount.Text;
            string subTotal = txtSubtotal.Text;
            string total = txtTotalPay.Text;
            string range = txtRange.Text;
            string interests = txtInterest.Text;
            string amountOfDues = txtAmountOfDues.Text;
            string cashDeposit = txtCashDeposit.Text;
            string cardDeposit = txtCardDeposit.Text;
            string inflation = txtInflation.Text;

        }

        private void btnCleanCreditInvoice_Click(object sender, EventArgs e)
        {
            CleanCreditinvoice();
        }
    }
}
