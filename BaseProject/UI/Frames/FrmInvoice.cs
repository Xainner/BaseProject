using MetroFramework.Controls;
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
    public partial class FrmInvoice : MetroFramework.Forms.MetroForm
    {
        public FrmInvoice(MetroGrid metroGrid)
        {
            InitializeComponent();
            
            WireUpForm(metroGrid);
        }

        private void WireUpForm(MetroGrid metroGrid)
        {
            metroGrid1.Columns.Add("id", "Id");
            metroGrid1.Columns.Add("id", "Código");
            metroGrid1.Columns.Add("description", "Descripción");
            metroGrid1.Columns.Add("subcategory", "Sub-Categoría");
            metroGrid1.Columns.Add("amount", "Cantidad");
            metroGrid1.Columns.Add("price", "Precio");
            metroGrid1.Columns.Add("paymentAmount", "Monto");
            metroGrid1.Columns.Add("discount", "Descuento");
            metroGrid1.Columns.Add("taxes", "I.V.I");
            try
            {
                metroGrid1.Rows.Clear();
                for (int i = 0; i < metroGrid.Rows.Count; i++)
                {
                    metroGrid1.Rows.Add(metroGrid.Rows[i].Cells[0]);
                    metroGrid1.Rows[i].Cells[0].Value = metroGrid.Rows[i].Cells[0].Value.ToString();
                    metroGrid1.Rows[i].Cells[1].Value = metroGrid.Rows[i].Cells[1].Value.ToString();
                    metroGrid1.Rows[i].Cells[2].Value = metroGrid.Rows[i].Cells[2].Value.ToString();
                    metroGrid1.Rows[i].Cells[3].Value = metroGrid.Rows[i].Cells[3].Value.ToString();
                    metroGrid1.Rows[i].Cells[4].Value = metroGrid.Rows[i].Cells[4].Value.ToString();
                    metroGrid1.Rows[i].Cells[5].Value = metroGrid.Rows[i].Cells[5].Value.ToString();
                    metroGrid1.Rows[i].Cells[6].Value = metroGrid.Rows[i].Cells[6].Value.ToString();
                    metroGrid1.Rows[i].Cells[7].Value = metroGrid.Rows[i].Cells[7].Value.ToString();
                    metroGrid1.Rows[i].Cells[8].Value = metroGrid.Rows[i].Cells[8].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void FrmInvoice_Leave(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
