using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModelLibrary.Models;
using LogicLibrary;
using BusinessLibrary.Models;
using UI.Frames;
using MetroFramework.Controls;
using LogicLibrary.LogicManagement;

namespace UI.UserControls
{
    public partial class UcInputInvoice : MetroFramework.Controls.MetroUserControl
    {
        public UcInputInvoice()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de facturas de entrada y salida";
        }

        private void WrapProductsGridView()
        {
            dgvInputExitProduct.Columns.Add("id", "Id");
            dgvInputExitProduct.Columns.Add("id", "Código");
            dgvInputExitProduct.Columns.Add("description", "Descripción");
            dgvInputExitProduct.Columns.Add("subcategory", "Sub-Categoría");
            dgvInputExitProduct.Columns.Add("quantity", "Cantidad");
            dgvInputExitProduct.Columns.Add("price", "Precio");

            foreach (DataGridViewColumn dataGridViewColumn in dgvInputExitProduct.Columns)
            {
                dataGridViewColumn.ReadOnly = true;
            }
            dgvInputExitProduct.Columns[4].ReadOnly = false;
            dgvInputExitProduct.MultiSelect = false;
        }

        private bool SearchDuplicates(string productCode)
        {
            for (int i = 0; i < dgvInputExitProduct.RowCount; i++)
            {
                string code = dgvInputExitProduct.Rows[i].Cells[1].Value.ToString();
                if (productCode == code)
                {
                    int quantity = int.Parse(dgvInputExitProduct.Rows[i].Cells[4].Value.ToString());
                    dgvInputExitProduct.Rows[i].Cells[4].Value = (quantity + 1);
                    return true;
                }
            }
            return false;
        }

        private void UcInputInvoice_Load(object sender, EventArgs e)
        {
            EmployeeComboBox.DataSource = EmployeeManagement.SelectAllEmployees();
            EmployeeComboBox.DisplayMember = "Name";
            DestinyComboBox.DataSource = BusinessManagement.SelectAllBusiness();
            DestinyComboBox.DisplayMember = "fantasyName";
            ProviderComboBox.DataSource = BusinessManagement.SelectAllBusiness();
            ProviderComboBox.DisplayMember = "fantasyName";
            WrapProductsGridView();
        }

        private void UcInputInvoice_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void addInputInvoiceTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void clearTitle_Click(object sender, EventArgs e)
        {
            WrapProductsGridView();
        }

        //CRUD

        private void clearButton_Click(object sender, EventArgs e)
        {
            dgvInputExitProduct.Rows.Clear();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            UcProduct ucProduct = new UcProduct
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucProduct);
            FrmMain.Instance.MetroContainer.Controls["ucProduct"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
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
                    dgvInputExitProduct.Rows.Add(productModel.IdProduct.ToString(), productModel.Code, productModel.Description, subCategoryModel.Name, 1, productModel.NormalPrice);
                }
                codeTextBox.Focus();
                codeTextBox.Text = string.Empty;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FrmSearchProduct frmSearchProduct = new FrmSearchProduct();
            frmSearchProduct.Show();
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            EmployeeModel employee = (EmployeeModel)EmployeeComboBox.SelectedItem;
            BusinessModel destiny = (BusinessModel)DestinyComboBox.SelectedItem;
            BusinessModel provider = (BusinessModel)ProviderComboBox.SelectedItem;

            try
            {
                if (DetaillsInputExitManagement.InsertDetailsInputExit(employee.IdEmployee.ToString(), destiny.IdBusiness.ToString(), provider.IdBusiness.ToString()))
                {
                    InputExitDetaillsModel id = DetaillsInputExitManagement.SelectDetailsInputExitID();

                    for (int i = 0; i < dgvInputExitProduct.RowCount; i++)
                    {
                        string idProduct = dgvInputExitProduct.Rows[i].Cells[0].Value.ToString();
                        string quantity = dgvInputExitProduct.Rows[i].Cells[4].Value.ToString();

                        if (InputExitInvoiceManagement.InsertInputExitInvoice(id.idNumInvoice.ToString(), idProduct, quantity))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se agrego correctamente la factura de entrada";
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
    }
}
