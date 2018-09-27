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
using UI.Frames;

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
            productsGridView.Columns.Add("description", "Descripción");
            productsGridView.Columns.Add("subcategory", "Sub-Categoría");
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

        

        private bool SearchDuplicates(string productCode)
        {
            foreach (DataGridViewRow dataGridViewRow in productsGridView.Rows)
            {
                string code = dataGridViewRow.Cells[1].Value.ToString();
                if (productCode == code)
                {
                    dataGridViewRow.Selected = true;
                    int quantity = int.Parse(productsGridView.CurrentRow.Cells[4].Value.ToString());
                    productsGridView.CurrentRow.Cells[4].Value = (quantity + 1);
                    ModifyProductQuantity();
                    return true;
                }
            }
            return false;
        }
            //
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ModifyProductQuantity()
        {
            decimal amount = decimal.Parse(productsGridView.CurrentRow.Cells[4].Value.ToString());
            decimal price = decimal.Parse(productsGridView.CurrentRow.Cells[5].Value.ToString());
            decimal newPrice = amount * price;
            productsGridView.CurrentRow.Cells[6].Value = newPrice.ToString();

            string tax = "0,13";
            decimal taxes = (newPrice * decimal.Parse(tax));
            productsGridView.CurrentRow.Cells[8].Value = taxes.ToString();
        }

        private void createInvoicePreviewButton_Click(object sender, EventArgs e)
        {
            //string numInvoice = Proceso interno
            //string date = Proceso interno
            string idClient = txtClient.Text;
            string idEmployee = txtEmployee.Text;
            string idUser = txtNumInvoice.Text;
            string coinType = cmbTypeCoin.Text;
            //string iviAmount = txtDaxes.Text;
            //string paymentCash = txtAmountCash.Text;
            string totalDiscount = discountTextBox.Text;
            //string subTotal = txtSubtotal.Text;
            //string total = txtTotalPay.Text;
        }

        public void Clear()
        {
            //string numInvoice = Proceso interno
            //string date = Proceso interno
            txtClient.Text = " ";
            txtEmployee.Text = " ";
            txtNumInvoice.Text = " ";
            cmbTypeCoin.Text = " ";
            //txtDaxes.Text = " ";
            //txtAmountCash.Text = " ";
            //discountTextBox.Text = " ";
            //txtSubtotal.Text = " ";
            //txtTotalPay.Text = " ";
        }



        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                string productCode = codeTextBox.Text;
                ProductModel productModel = ProductManagement.SelectProductByCode(productCode); 

                if (!SearchDuplicates(productCode))
                {
                    SubCategoryModel subCategoryModel = SubCategoryManagement.SelectSubCategoryById(productModel.IdSubCategory.ToString());
                    string tax = "0,13";
                    decimal taxes = (productModel.NormalPrice * decimal.Parse(tax));
                    productsGridView.Rows.Add(productModel.IdProduct.ToString(), productModel.Code, productModel.Description, subCategoryModel.Name, 1, productModel.NormalPrice, productModel.NormalPrice, 0, taxes);
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            
        }

        private void productsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (productsGridView.CurrentCell.ColumnIndex == 4)
            {
                ModifyProductQuantity();
            }
        }

        private void previewInvoiceButton_Click(object sender, EventArgs e)
        {
            FrmInvoice frmInvoice = new FrmInvoice(productsGridView);
            frmInvoice.Show();
        }
    }
}
