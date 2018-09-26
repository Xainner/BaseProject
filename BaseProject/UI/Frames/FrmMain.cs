using MetroFramework.Controls;
using System;
using System.Windows.Forms;
using UI.UserControls;

namespace UI
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        static FrmMain _instance;

        public MetroPanel MetroContainer { get => mainPanel; set => mainPanel = value; }

        public MetroLink MetroBack { get => goBackLink; set => goBackLink = value; }

        public ToolStripLabel ToolStripLabel { get => toolStripStatusLabel1; set => toolStripStatusLabel1.Text = ""; }

        public FrmMain()
        {
            InitializeComponent();
        }

        public static FrmMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FrmMain();
                }
                return _instance;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            goBackLink.Visible = false;

            _instance = this;
            UcDashboard dashboard = new UcDashboard
            {
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Add(dashboard);
            toolStripStatusLabel1.Text = "Estás en el dashboard";
        }

        private void goBackLink_Click(object sender, EventArgs e)
        {
            mainPanel.Controls["UcDashboard"].BringToFront();
            goBackLink.Visible = false;
            toolStripStatusLabel1.Text = "Estás en el dashboard";
        }
    }
}
