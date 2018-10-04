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
using BusinessLibrary.Models;
using LogicLibrary.LogicManagement;

namespace UI.UserControls
{
    public partial class UcAparts : MetroFramework.Controls.MetroUserControl
    {
        public UcAparts()
        {
            InitializeComponent();
            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de facturas por apartados";
        }

        private void WrapProductsGridView()
        {
            try
            {
                dgvAparts.Columns.Add("id", "Id");
                dgvAparts.Columns.Add("code", "Código");
                dgvAparts.Columns.Add("description", "Descripción");
                dgvAparts.Columns.Add("subcategory", "Sub-Categoría");
                dgvAparts.Columns.Add("quantity", "Cantidad");
                dgvAparts.Columns.Add("price", "Precio");
                dgvAparts.Columns.Add("total", "Total");
                dgvAparts.Columns.Add("discount", "Descuento");
                dgvAparts.Columns.Add("taxes", "I.V.I");

                foreach (DataGridViewColumn dataGridViewColumn in dgvAparts.Columns)
                {
                    dataGridViewColumn.ReadOnly = true;
                }
                dgvAparts.Columns[4].ReadOnly = false;
                dgvAparts.MultiSelect = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UcAparts_Load(object sender, EventArgs e)
        {
            employeeComboBox.DataSource = EmployeeManagement.SelectAllEmployees();
            employeeComboBox.DisplayMember = "Name";
            StoreComboBox.DataSource = BusinessManagement.SelectAllBusiness();
            StoreComboBox.DisplayMember = "fantasyName";
            clientComboBox.DataSource = ClientManagement.SelectAllClients();
            clientComboBox.DisplayMember = "Name";
            WrapProductsGridView();
        }

        private bool SearchDuplicates(string productCode)
        {
            try
            {
                for (int i = 0; i < dgvAparts.RowCount; i++)
                {
                    string code = dgvAparts.Rows[i].Cells[1].Value.ToString();
                    decimal price = decimal.Parse(dgvAparts.Rows[i].Cells[5].Value.ToString());
                    if (productCode == code)
                    {
                        int quantity = int.Parse(dgvAparts.Rows[i].Cells[4].Value.ToString());
                        quantity++;
                        dgvAparts.Rows[i].Cells[4].Value = quantity;
                        dgvAparts.Rows[i].Cells[6].Value = (price * quantity);
                        UpdateTaxes();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UpdateTaxes()
        {
            try
            {
                decimal quantity = decimal.Parse(dgvAparts.CurrentRow.Cells[4].Value.ToString());
                decimal price = decimal.Parse(dgvAparts.CurrentRow.Cells[5].Value.ToString());
                decimal amount = quantity * price;

                decimal discount = decimal.Parse(dgvAparts.CurrentRow.Cells[7].Value.ToString());
                //decimal newAmount = amount - (amount * (discount / 100));

                dgvAparts.CurrentRow.Cells[6].Value = amount.ToString("##,##0.00");

                string tax = "0,13";
                decimal taxes = (amount * decimal.Parse(tax));
                dgvAparts.CurrentRow.Cells[8].Value = taxes.ToString("##,##0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void setInformation()
        {
            try
            {
                decimal price = 0;
                decimal ivi = 0;
                for (int i = 0; i < dgvAparts.RowCount; i++)
                {
                    int currentQuantity = int.Parse(dgvAparts.Rows[i].Cells[4].Value.ToString());
                    for (int j = 0; j < currentQuantity; j++)
                    {
                        price = price + decimal.Parse(dgvAparts.Rows[i].Cells[5].Value.ToString());
                        ivi = ivi + decimal.Parse(dgvAparts.Rows[i].Cells[8].Value.ToString());
                    }
                }
                SubtotalTextBox.Text = price.ToString();
                TaxesTextBox.Text = ivi.ToString();
            }
            catch (Exception)
            {

                throw;
            }     
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
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
                        dgvAparts.Rows.Add(productModel.IdProduct.ToString(), productModel.Code, productModel.Description, subCategoryModel.Name, 1, productModel.NormalPrice, productModel.NormalPrice, 0, taxes.ToString("##,##0.00"));
                    }
                    codeTextBox.Focus();
                    codeTextBox.Text = string.Empty;
                    setInformation();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddApart_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = (EmployeeModel)employeeComboBox.SelectedItem;
            ClientModel client = (ClientModel)clientComboBox.SelectedItem;
            BusinessModel businness = (BusinessModel)StoreComboBox.SelectedItem;
            string endDate = endDateTime.Text;
            string paymentType = typePayComboBox.Text;
            string discount = DiscountTextBox.Text;
            string subtotal = SubtotalTextBox.Text;
            string total = totalTextBox.Text;
            string currentPay = currentPayTextBox.Text;
            string ivi = TaxesTextBox.Text;
            string residue = ResidueTextBox.Text;

            try
            {
                if (DetailApartManagement.InsertDetailApart(employee.IdEmployee.ToString(), client.IdClient.ToString(), businness.IdBusiness.ToString(),
                    endDate, discount, subtotal, total, paymentType, currentPay, ivi, residue))
                {
                    DetailApartModel id = DetailApartManagement.SelectDetailsApartID();

                    for (int i = 0; i < dgvAparts.RowCount; i++)
                    {
                        string idProduct = dgvAparts.Rows[i].Cells[0].Value.ToString();
                        int quantity = int.Parse(dgvAparts.Rows[i].Cells[4].Value.ToString());

                        if (ApartInvoiceManagement.InsertApartInvoice(id.idDetailApart.ToString(), idProduct, quantity.ToString()))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Apartado agregado correctamente";
                        }
                        else
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Error al agregar la factura de entrada";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DiscountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            decimal subtotal = decimal.Parse(SubtotalTextBox.Text);
            decimal discount = decimal.Parse(DiscountTextBox.Text);
            decimal total = subtotal - discount;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    totalTextBox.Text = total.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void currentPayTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            decimal totalPay = decimal.Parse(totalTextBox.Text);
            decimal currentPay = decimal.Parse(currentPayTextBox.Text);
            decimal residue = totalPay - currentPay;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ResidueTextBox.Text = residue.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
