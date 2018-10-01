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
using ModelLibrary.Models;
using BusinessLibrary.Models;

namespace UI.UserControls
{
    public partial class UcExitInvoice : MetroFramework.Controls.MetroUserControl
    {
        public UcExitInvoice()
        {
            InitializeComponent();
            FrmMain.Instance.ToolStripLabel.Text = "Estas en la pantalla de facturas de salida de mercaderia";
        }

        //List<ExitInvoiceModel> exitInvoices;
        private void WrapProductsGridView()
        {
            //exitInvoices = ExitInvoiceManagement.SelectAllexitInvoices();
            //metroGrid1.DataSource = exitInvoices;
        }

        private void UcExitInvoice_Load(object sender, EventArgs e)
        {
            
        }

        private void UcExitInvoice_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddOutputInvoiceTile_Click(object sender, EventArgs e)
        {
            //List<ProductModel> test = new List<ProductModel>();
            //try
            //{
            //    if (ExitInvoiceManagement.InsertExitInvoice("0", test, dateDateTime.Text, destinyTextBox.Text))
            //    {
            //        FrmMain.Instance.ToolStripLabel.Text = "Agregado correctamente";
            //    } else {
            //        FrmMain.Instance.ToolStripLabel.Text = "Error al agregar";
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void clearTitle_Click(object sender, EventArgs e)
        {
            destinyTextBox.Text = "";
            nameTextBox.Text = "";
            providerTextBox.Text = "";
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            WrapProductsGridView();
        }
    }
}
