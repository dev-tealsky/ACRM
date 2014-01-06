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
    public partial class ACRM_SAVE_TAB_SELECT : Form
    {
        public ACRM_SAVE_TAB_SELECT(string[] ACRM_OPENED_TABS_COLLECTION)
        {
            InitializeComponent();

            foreach (string ACRM_TAB in ACRM_OPENED_TABS_COLLECTION)
            {
                if (ACRM_TAB != "Launcher")
                {
                    ACRM_ACTIVE_TAB_COLLECTION.Items.Add(new ListViewItem(ACRM_TAB));
                }
            }
        }

        private void ACRM_SAVE_TAB_SELECTION_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ACRM_SAVE_TAB_ADD(string tab_name)
        {
            MessageBox.Show(tab_name);
            try
            {
                ACRM_ACTIVE_TAB_COLLECTION.Items.Add(new ListViewItem(tab_name));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ACRM_SELECT_ALL_TABS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ACRM_ACTIVE_TAB_COLLECTION.Items.Count; i++)
            {
                ACRM_ACTIVE_TAB_COLLECTION.Items[i].Checked = true;
            }
        }
    }
}
