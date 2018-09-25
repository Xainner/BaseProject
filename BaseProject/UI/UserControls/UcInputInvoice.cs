using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary.Models;
using LogicLibrary;

namespace UI.UserControls
{
    public partial class UcInputInvoice : UserControl
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
            metroGrid1.DataSource = productModel;
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
            try
            {
                if (InputInvoiceManagement.InsertinputInvoice(null, dateDateTime.Text, providerTextBox.Text))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Agregado correctamente";
                } else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error al agregar";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void clearTitle_Click(object sender, EventArgs e)
        {
            providerTextBox.Text = "";
            totalPaymentTextBox.Text = "";
        }
    }
}
