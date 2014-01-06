using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACRM
{
    public partial class ACRM_LOG_MENU : Form
    {
        public ACRM_GUI ParentForm { get; set; }

        public ACRM_LOG_MENU()
        {
            InitializeComponent();
        }

        private void ACRM_LOG_MENU_Load(object sender, EventArgs e)
        {
            //Set custom event handlers
            ACRM_LOG_WINDOW.TextChanged += (obj, x) => { ACRM_LOG_WINDOW.ScrollToCaret(); };
        }

        private void ACRM_HIDE_LOGS_Click(object sender, EventArgs e)
        {
            ParentForm.ACRM_LOAD_LOGS.Text = "Logs";
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ACRM_CLEAR_LOGS_Click(object sender, EventArgs e)
        {
            ACRM_LOG_WINDOW.Clear();
        }
    }
}
