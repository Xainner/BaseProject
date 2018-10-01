﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModelLibrary.Models;
using LogicLibrary;
using BusinessLibrary.Models;
using UI.Frames;
using MetroFramework.Controls;

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

        public MetroGrid dgvProduct { get; set ; }

        private void WrapProductsGridView()
        {
            productModel = ProductManagement.SelectAllProducts();
            dgvInputProduct.DataSource = dgvProduct;
        }

        private void toSearch(Object sender, string search)
        {
            string obj = ((MetroFramework.Controls.MetroTextBox)sender).Text;

            if (!string.IsNullOrEmpty(search))
            {
                FrmSearchProduct.code = search;
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
            WrapProductsGridView();
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
                string obj = descriptionTextBox.Text;

                if (!string.IsNullOrEmpty(obj))
                {
                    FrmSearchProduct.description = obj;
                    FrmSearchProduct frmInvoice = new FrmSearchProduct(obj);
                    frmInvoice.Show();
                }
            }
        }

        private void codeTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string obj = codeTextBox.Text;

                if (!string.IsNullOrEmpty(obj))
                {
                    FrmSearchProduct.code = obj;
                    FrmSearchProduct frmInvoice = new FrmSearchProduct(obj);
                    frmInvoice.Show();
                }
            }
        }

        private void styleTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string obj = styleTextBox.Text;

                if (!string.IsNullOrEmpty(obj))
                {
                    FrmSearchProduct.style = obj;
                    FrmSearchProduct frmInvoice = new FrmSearchProduct(obj);
                    frmInvoice.Show();
                }
            }
        }

        private void brandTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string obj = brandTextBox.Text;

                if (!string.IsNullOrEmpty(obj))
                {
                    FrmSearchProduct.brand = obj;
                    FrmSearchProduct frmInvoice = new FrmSearchProduct(obj);
                    frmInvoice.Show();
                }
            }
        }

        private void subcategoryTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string obj = subcategoryTextBox.Text;

                if (!string.IsNullOrEmpty(obj))
                {
                    FrmSearchProduct.subcategory = obj;
                    FrmSearchProduct frmInvoice = new FrmSearchProduct(obj);
                    frmInvoice.Show();
                }
            }
        }
    }
}
