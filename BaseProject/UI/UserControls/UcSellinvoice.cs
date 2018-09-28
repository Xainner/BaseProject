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
    public partial class UcSellinvoice : MetroFramework.Controls.MetroUserControl
    {
        public UcSellinvoice()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de ventas y su factura"; 
        }

        public void CleanSellinvoice()
        {
            //string numInvoice = Proceso interno
            //string date = Proceso interno
            txtClient.Text = " ";
            txtEmployee.Text = " ";
            txtNumInvoice.Text = " ";
            cmbTypeCoin.Text = " ";
            txtDaxes.Text = " ";
            txtTypeChange.Text = " ";
            txtAmountCash.Text = " ";
            txtDiscount.Text = " ";
            txtSubtotal.Text = " ";
            txtTotalPay.Text = " "; 
        }

        private void UcSellinvoice_Load(object sender, EventArgs e)
        {

        }

        private void btnCleanInvoice_Click(object sender, EventArgs e)
        {
            CleanSellinvoice();
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            //string numInvoice = Proceso interno
            //string date = Proceso interno
            string idClient = txtClient.Text;
            string idEmployee = txtEmployee.Text;
            string idUser = txtNumInvoice.Text;
            string coinType = cmbTypeCoin.Text;
            string iviAmount = txtDaxes.Text;
            string currencyType = txtTypeChange.Text;
            string paymentCash = txtAmountCash.Text;
            string totalDiscount = txtDiscount.Text;
            string subTotal = txtSubtotal.Text;
            string total = txtTotalPay.Text;
        }
    }
}
