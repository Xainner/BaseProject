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

namespace UI.UserControls
{
    public partial class UcBrandSize : UserControl
    {
        public UcBrandSize()
        {
            InitializeComponent();
            
            FrmMain.Instance.ToolStripLabel.Text = "Estas en el área de tallas y marcas";
        }

        List<BrandModel> brand = new List<BrandModel>();
        private void UcBrandSize_Load(object sender, EventArgs e)
        {
            brand = BrandManagement.SelectAlBrands();
            dgvBrand.DataSource = brand;
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            string id = txtIDBrand.Text;
            string brand = txtBrand.Text;

            try
            {
                if (BrandManagement.InsertBusiness(brand))
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Se agrego la marca correctamente";
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "No se agrego la marca";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
