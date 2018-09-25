using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Frames;

namespace UI.UserControls
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            UcBusiness ucBusiness = new UcBusiness
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucBusiness);
            FrmMain.Instance.MetroContainer.Controls["ucBusiness"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            UcClient ucClient = new UcClient
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucClient);
            FrmMain.Instance.MetroContainer.Controls["ucClient"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            UcCategory ucCategory = new UcCategory
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucCategory);
            FrmMain.Instance.MetroContainer.Controls["ucCategory"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            UcProduct ucProduct = new UcProduct
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucProduct);
            FrmMain.Instance.MetroContainer.Controls["ucProduct"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            UcPositionSalary ucPositionSalary = new UcPositionSalary
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucPositionSalary);
            FrmMain.Instance.MetroContainer.Controls["ucPositionSalary"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnBrandSize_Click(object sender, EventArgs e)
        {
            FrmBrand frmBrand = new FrmBrand();
            frmBrand.Show();
            FrmMain.Instance.ToolStripLabel.Text = "Estas en el área de tallas y marcas";
            //UcBrandSize ucBrandSize = new UcBrandSize
            //{
            //    Dock = DockStyle.Fill
            //};
            //FrmMain.Instance.MetroContainer.Controls.Add(ucBrandSize);
            //FrmMain.Instance.MetroContainer.Controls["ucBrandSize"].BringToFront();
            //FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            UcEmployee ucEmployee = new UcEmployee
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucEmployee);
            FrmMain.Instance.MetroContainer.Controls["ucEmployee"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnInputInvoice_Click(object sender, EventArgs e)
        {
            UcInputInvoice ucInputInvoice = new UcInputInvoice
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucInputInvoice);
            FrmMain.Instance.MetroContainer.Controls["ucInputInvoice"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnExitInvoice_Click(object sender, EventArgs e)
        {
            UcExitInvoice ucExitInvoice = new UcExitInvoice
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucExitInvoice);
            FrmMain.Instance.MetroContainer.Controls["ucExitInvoice"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnSellinvoice_Click(object sender, EventArgs e)
        {
            UcSellinvoice ucSellinvoice = new UcSellinvoice
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucSellinvoice);
            FrmMain.Instance.MetroContainer.Controls["ucSellinvoice"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }

        private void btnCreditInvoice_Click(object sender, EventArgs e)
        {
            UcCreditInvoice ucCreditInvoice = new UcCreditInvoice
            {
                Dock = DockStyle.Fill
            };
            FrmMain.Instance.MetroContainer.Controls.Add(ucCreditInvoice);
            FrmMain.Instance.MetroContainer.Controls["ucCreditInvoice"].BringToFront();
            FrmMain.Instance.MetroBack.Visible = true;
        }
    }
}
