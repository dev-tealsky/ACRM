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
    public partial class ACRM_RDB_EPIC : Form
    {
        public ACRM_RDB_EPIC()
        {
            InitializeComponent();

            //Handle the epic combo box value being changed
            SELECTED_RDB_EPIC.SelectedIndexChanged += (o, x) => 
            {
                //Send the new value to the main gui for later processing in ACRM_FUNCTIONS
                this.Invoke(new MethodInvoker(delegate { ACRM_GUI.GUI_INSTANCE.RDB_EPIC = Convert.ToSingle(SELECTED_RDB_EPIC.Text); }));
               
                //Close this window
                this.Close();
            };
        }
    }
}
