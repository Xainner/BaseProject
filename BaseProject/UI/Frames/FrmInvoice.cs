using BusinessLibrary.Models;
using LogicLibrary;
using LogicLibrary.LogicManagement;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Frames
{
    public partial class FrmInvoice : MetroFramework.Forms.MetroForm
    {
        DetailExternalSellinvoiceModel DetailExternalSellinvoiceModel;
        public FrmInvoice(string idInvoice, DetailExternalSellinvoiceModel detailExternalSellinvoiceModel, MetroGrid metroGrid)
        {
            InitializeComponent();
            
            WireUpForm(metroGrid);
            metroLabel3.Text = idInvoice;
            DetailExternalSellinvoiceModel = detailExternalSellinvoiceModel;
        }

        private void WireUpForm(MetroGrid metroGrid)
        {
            try
            {
                metroGrid1.Columns.Add("id", "Id");
                metroGrid1.Columns.Add("id", "Código");
                metroGrid1.Columns.Add("description", "Descripción");
                metroGrid1.Columns.Add("subcategory", "Sub-Categoría");
                metroGrid1.Columns.Add("quantity", "Cantidad");
                metroGrid1.Columns.Add("price", "Precio");
                metroGrid1.Columns.Add("paymentAmount", "Monto");
                metroGrid1.Columns.Add("discount", "Descuento (%)");
                metroGrid1.Columns.Add("taxes", "I.V.I");
                for (int i = 0; i < metroGrid.Rows.Count; i++)
                {
                    metroGrid1.Rows.Add(metroGrid.Rows[i].Cells[0]);
                    metroGrid1.Rows[i].Cells[0].Value = metroGrid.Rows[i].Cells[0].Value.ToString();
                    metroGrid1.Rows[i].Cells[1].Value = metroGrid.Rows[i].Cells[1].Value.ToString();
                    metroGrid1.Rows[i].Cells[2].Value = metroGrid.Rows[i].Cells[2].Value.ToString();
                    metroGrid1.Rows[i].Cells[3].Value = metroGrid.Rows[i].Cells[3].Value.ToString();
                    metroGrid1.Rows[i].Cells[4].Value = metroGrid.Rows[i].Cells[4].Value.ToString();
                    metroGrid1.Rows[i].Cells[5].Value = metroGrid.Rows[i].Cells[5].Value.ToString();
                    metroGrid1.Rows[i].Cells[6].Value = metroGrid.Rows[i].Cells[6].Value.ToString();
                    metroGrid1.Rows[i].Cells[7].Value = metroGrid.Rows[i].Cells[7].Value.ToString();
                    metroGrid1.Rows[i].Cells[8].Value = metroGrid.Rows[i].Cells[8].Value.ToString();
                }
                decimal taxes = 0;
                foreach (DataGridViewRow dataGridViewRow in metroGrid1.Rows)
                {
                    taxes += decimal.Parse(dataGridViewRow.Cells[8].Value.ToString());
                }
                taxesTextBox.Text = taxes.ToString();

                decimal subtotal = 0;
                foreach (DataGridViewRow dataGridViewRow in metroGrid1.Rows)
                {
                    subtotal += decimal.Parse(dataGridViewRow.Cells[6].Value.ToString());
                }

                decimal totalDiscount = 0;
                foreach (DataGridViewRow dataGridViewRow in metroGrid1.Rows)
                {
                    decimal amount = decimal.Parse(dataGridViewRow.Cells[6].Value.ToString());
                    decimal discount = decimal.Parse(dataGridViewRow.Cells[7].Value.ToString());

                    totalDiscount += amount * (discount / 100);
                }

                subTotalTextBox.Text = subtotal.ToString();
                discountTextBox.Text = totalDiscount.ToString();
                decimal totalPayment = subtotal - totalDiscount;
                totalPaymentTextBox.Text = totalPayment.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void FrmInvoice_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void createInvoicePreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                DetailExternalSellinvoiceModel.Total = decimal.Parse(totalPaymentTextBox.Text);
                DetailExternalSellinvoiceModel.TotalDiscount = decimal.Parse(discountTextBox.Text);
                DetailExternalSellinvoiceModel.SubTotal = decimal.Parse(subTotalTextBox.Text);
                DetailExternalSellinvoiceModel.CashDeposit = decimal.Parse(cashAmountTextBox.Text);
                DetailExternalSellinvoiceModel.CreditDeposit = decimal.Parse(creditAmountTextBox.Text);

                DetailExternalSellInvoiceManagement.InsertExternalSellinvoice(DetailExternalSellinvoiceModel.IdClient, DetailExternalSellinvoiceModel.IdEmployee, DetailExternalSellinvoiceModel.IdBusiness, DetailExternalSellinvoiceModel.CurrencyType, decimal.Parse(taxesTextBox.Text), decimal.Parse(cashAmountTextBox.Text), decimal.Parse(creditAmountTextBox.Text), decimal.Parse(discountTextBox.Text), decimal.Parse(subTotalTextBox.Text), decimal.Parse(totalPaymentTextBox.Text));

                foreach (DataGridViewRow dataGridViewRow in metroGrid1.Rows)
                {
                    ExternalInvoiceSellManagement.InsertExternalInvoice(metroLabel3.Text, dataGridViewRow.Cells[1].Value.ToString());
                }
                MetroFramework.MetroMessageBox.Show(this, "Se registró la factura de manera exitosa.");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ChangeAdjustment()
        {
            decimal creditAmount = decimal.Parse(creditAmountTextBox.Text);
            decimal cashAmount = decimal.Parse(cashAmountTextBox.Text);
            decimal totalPayment = decimal.Parse(totalPaymentTextBox.Text);
            changeTextBox.Text = ((creditAmount + cashAmount) - totalPayment).ToString();
        }

        private void cashAmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(cashAmountTextBox.Text) && !cashAmountTextBox.Text.Equals("0"))
            {
                ChangeAdjustment();
            }
        }

        private void creditAmountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(creditAmountTextBox.Text) && !creditAmountTextBox.Text.Equals("0"))
            {
                ChangeAdjustment();
            }
        }
    }
}
