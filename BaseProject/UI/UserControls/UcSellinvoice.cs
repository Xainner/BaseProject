using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLibrary.Models;
using LogicLibrary;

namespace UI.UserControls
{
    public partial class UcSellinvoice : MetroFramework.Controls.MetroUserControl
    {
        //
        List<ProductModel> productModels;
        //
        public UcSellinvoice()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de ventas y su factura";
        }

        private void UcSellinvoice_Load(object sender, EventArgs e)
        {
            WireUpProductsGridView();
        }

        private void UcSellinvoice_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
        //
        private void WireUpProductsGridView()
        {
            productsGridView.Columns.Add("id", "Id");
            productsGridView.Columns.Add("id", "Código");
            productsGridView.Columns.Add("name", "Nombre");
            productsGridView.Columns.Add("description", "Descripción");
            productsGridView.Columns.Add("amount", "Cantidad");
            productsGridView.Columns.Add("price", "Precio");
            productsGridView.Columns.Add("paymentAmount", "Monto");
            productsGridView.Columns.Add("discount", "Descuento");
            productsGridView.Columns.Add("taxes", "I.V.I");

            foreach (DataGridViewColumn dataGridViewColumn in productsGridView.Columns)
            {
                dataGridViewColumn.ReadOnly = true;
            }
            productsGridView.Columns[4].ReadOnly = false;

            productsGridView.MultiSelect = false;
        }

        private void SearchDuplicates(string code)
        {
            int count = 0;
            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                string id = dataGridViewRow.Cells[0].Value.ToString();
                count++;
            }
            MessageBox.Show(count.ToString());
        }
            //
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void createInvoicePreviewButton_Click(object sender, EventArgs e)
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
            string totalDiscount = discountTextBox.Text;
            string subTotal = txtSubtotal.Text;
            string total = txtTotalPay.Text;
        }

        public void Clear()
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
            discountTextBox.Text = " ";
            txtSubtotal.Text = " ";
            txtTotalPay.Text = " ";
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string productCode = codeTextBox.Text;
                //ProductModel productModel = ProductManagement.SelectProductByCode(productCode); 
                SearchDuplicates(productCode);
                productsGridView.Rows.Add("1", "six", "seven", "eight", "eight", "eight", "eight", "eight", "eight");

                //foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
                //{
                //    dataGridViewRow.Cells[4].ReadOnly = false;
                //}
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
