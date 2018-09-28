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
        public FrmInvoice()
        {
            InitializeComponent();
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
