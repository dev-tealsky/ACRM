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
    public partial class ACRM_OPEN_DB_SELECT : Form
    {
        public ACRM_OPEN_DB_SELECT()
        {
            InitializeComponent();
        }

        public string[] ACRM_TABLE_LIST;
        private void ACRM_SET_DB_SELECTION_Click(object sender, EventArgs e)
        {
            ACRM_TABLE_LIST = new string[ACRM_TABLE_COLLECTION.CheckedItems.Count];
            int ACRM_TABLE_INDEX = 0;
            foreach(ListViewItem ACRM_TABLE in ACRM_TABLE_COLLECTION.CheckedItems)
            {
                ACRM_TABLE_LIST[ACRM_TABLE_INDEX] = ACRM_TABLE.Text;
            }
            this.Close();
        }
    }
}
