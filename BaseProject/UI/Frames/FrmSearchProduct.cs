using BusinessLibrary.Models;
using LogicLibrary;
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
    public partial class FrmSearchProduct : MetroFramework.Forms.MetroForm
    {
        public FrmSearchProduct(string search)
        {
            InitializeComponent();

            LoadDescription(search);
        }

        public void LoadDescription (string info)
        {
            //dgvSearchProduct.Columns.Add("idProduct", "ID");
            //dgvSearchProduct.Columns.Add("code", "Código");
            //dgvSearchProduct.Columns.Add("idBrand", "Marca");
            //dgvSearchProduct.Columns.Add("Description", "Descripción");
            //dgvSearchProduct.Columns.Add("idsubCategory", "Sub-Categoria");
            //dgvSearchProduct.Columns.Add("varibleQuantity", "Cantidad");
            //dgvSearchProduct.Columns.Add("Ivi", "IVI");

            try
            {
                dgvSearchProduct.DataSource = ProductManagement.SelectProductByDescription(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
