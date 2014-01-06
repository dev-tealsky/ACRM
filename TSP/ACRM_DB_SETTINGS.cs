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
    public partial class ACRM_DB_SETTINGS : Form
    {
        string db_host_ip = Properties.Settings.Default.db_host_ip;
        string db_host_port = Properties.Settings.Default.db_host_port;
        string db_table_name = Properties.Settings.Default.db_table_name;
        string db_table_user = Properties.Settings.Default.db_table_user;
        string db_table_pass = Properties.Settings.Default.db_table_pass;

        public ACRM_DB_SETTINGS()
        {
            InitializeComponent();
        }

        private void ACRM_DB_SETTINGS_Load(object sender, EventArgs e)
        {
            ACRM_HOST_IP_INPUT.Text = db_host_ip;
            ACRM_HOST_PORT_INPUT.Text = db_host_port;
            ACRM_TABLE_NAME_INPUT.Text = db_table_name;
            ACRM_TABLE_USER_INPUT.Text = db_table_user;
            ACRM_TABLE_PASS_INPUT.Text = db_table_pass;
        }

        private void ACRM_SAVE_DB_SETTINGS_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.db_host_ip = ACRM_HOST_IP_INPUT.Text;
            Properties.Settings.Default.db_host_port = ACRM_HOST_PORT_INPUT.Text;
            Properties.Settings.Default.db_table_name = ACRM_TABLE_NAME_INPUT.Text;
            Properties.Settings.Default.db_table_user = ACRM_TABLE_USER_INPUT.Text;
            Properties.Settings.Default.db_table_pass = ACRM_TABLE_PASS_INPUT.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            this.Dispose();
        }
    }
}
