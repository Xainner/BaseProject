using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModelLibrary.Models;
using LogicLibrary;
using BusinessLibrary.Models;
using UI.Frames;

namespace UI.UserControls
{
    public partial class UcInputInvoice : MetroFramework.Controls.MetroUserControl
    {
        public UcInputInvoice()
        {
            InitializeComponent();

            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de facturas de entrada";
        }

        List<ProductModel> productModel;
        private void WrapProductsGridView()
        {
            productModel = ProductManagement.SelectAllProducts();
            dgvInputProduct.DataSource = productModel;
        }

        private void toSearch(Object sender, string search)
        {
            string obj = ((MetroFramework.Controls.MetroTextBox)sender).Text;

            if (!string.IsNullOrEmpty(search))
            {
                FrmSearchProduct.Code = search;
                FrmSearchProduct frmInvoice = new FrmSearchProduct(obj);
                frmInvoice.Show();
            }
        }

        private void UcInputInvoice_Load(object sender, EventArgs e)
        {

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
            
        }

        //CRUD

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputInvoiceManagement.InsertinputInvoice(null, dateDateTime.Text, providerTextBox.Text))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Agregado correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al agregar";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            providerTextBox.Text = string.Empty;
            totalPaymentTextBox.Text = string.Empty;
        }

        private void descriptionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string description = descriptionTextBox.Text;

                try
                {
                    if (description != " ")
                    {
                        FrmSearchProduct frmInvoice = new FrmSearchProduct(description);
                        frmInvoice.Show();

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string code = codeTextBox.Text;
                try
                {
                    if (code != " ")
                    {
                        FrmSearchProduct frmInvoice = new FrmSearchProduct(code);
                        frmInvoice.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void styleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string style = styleTextBox.Text;
                try
                {
                    if (style != " ")
                    {
                        FrmSearchProduct frmInvoice = new FrmSearchProduct(style);
                        frmInvoice.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void brandTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string brand = subcategoryTextBox.Text;
                try
                {
                    if (brand != " ")
                    {
                        FrmSearchProduct frmInvoice = new FrmSearchProduct(brand);
                        frmInvoice.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void subcategoryTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string subCategory = subcategoryTextBox.Text;
                try
                {
                    if (subCategory != " ")
                    {
                        FrmSearchProduct frmInvoice = new FrmSearchProduct(subCategory);
                        frmInvoice.Show();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
