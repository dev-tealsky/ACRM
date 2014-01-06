using DataBurner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//----------------------------
//----------------------------
// If you are viewing this  //
// i'd like to give special //
// thanks to dtsmith94      //
// aka xXExiledXx           //
// not only is he a great   //
// friend, but a devoted    //
// coder! Thanks for the    //
// help!!!!                 //
//                          //
//                -TealSky  //
//----------------------------
//----------------------------

namespace ACRM
{
    public partial class ACRM_GUI : Form
    {
        //Program-Wide Variables
        #region

        public bool ACRM_TAB_WORKING = false;
        public string ACRM_WORKING_TAB = "";

        //ACRM_GUI Instance Varaible
        public static ACRM_GUI GUI_INSTANCE { get; set; }

        //SQL Variables
        #region

        string DBCON { get; set; }

        #endregion

        //Hasher Variables
        #region

        public string[] ACRM_DRAG_FILEPATH_COLLECTION { get; set; }
        public string ACRM_HASH_RESP { get; set; }

        #endregion

        //RDB Reader/Writer Variables
        public string[] ACRM_RDB_FILEPATH { get; set; }

        //Background Workers
        #region
        public BackgroundWorker ACRM_HASH_WORKER;
        public BackgroundWorker ACRM_RDB_WORKER;
        public BackgroundWorker ACRM_SAVE_WORKER;
        public BackgroundWorker ACRM_LOG_WORKER;
        public BackgroundWorker ACRM_MASS_HASH_WORKER;
        public BackgroundWorker ACRM_DB_WORKER;
        public BackgroundWorker ACRM_MONITOR_WORKER;
        #endregion

        //FileName Cipher AKA Matrix
        public FileNameCipher ACRM_NAME_MATRIX = new FileNameCipher();

        //Log related Properties
        ACRM_LOG_MENU ACRM_LOG_MENU = new ACRM_LOG_MENU();

        //RDB Related Binding Lists
        #region

        public BindingList<DB_EFFECTRESOURCE> ACRM_EFFECT_LIST = new BindingList<DB_EFFECTRESOURCE>();
        public BindingList<DB_ENHANCERESOURCE> ACRM_ENHANCE_LIST = new BindingList<DB_ENHANCERESOURCE>();
        public BindingList<DB_ENHANCEFX> ACRM_ENHANCEFX_LIST = new BindingList<DB_ENHANCEFX>();
        public BindingList<DB_FIELDPROPRESOURCE_62> ACRM_FIELDPROP_62_LIST = new BindingList<DB_FIELDPROPRESOURCE_62>();
        public BindingList<DB_FIELDPROPRESOURCE_73> ACRM_FIELDPROP_73_LIST = new BindingList<DB_FIELDPROPRESOURCE_73>();
        public BindingList<DB_ITEMRESOURCE_62> ACRM_ITEM_62_LIST = new BindingList<DB_ITEMRESOURCE_62>();
        public BindingList<DB_ITEMEFFECTRESOURCE> ACRM_ITEMEFFECT_LIST = new BindingList<DB_ITEMEFFECTRESOURCE>();
        public BindingList<DB_JOBRESOURCE> ACRM_JOB_LIST = new BindingList<DB_JOBRESOURCE>();
        public BindingList<DB_QUESTRESOURCE_62> ACRM_QUEST_62_LIST = new BindingList<DB_QUESTRESOURCE_62>();
        public BindingList<DB_SKILLRESOURCE_62> ACRM_SKILL_62_LIST = new BindingList<DB_SKILLRESOURCE_62>();
        public BindingList<DB_SKILLRESOURCE_73> ACRM_SKILL_73_LIST = new BindingList<DB_SKILLRESOURCE_73>();
        public BindingList<DB_SKILLSTAGE> ACRM_SKILLSTAGE_LIST = new BindingList<DB_SKILLSTAGE>();
        public BindingList<DB_SKILLTREEDISPLAY_62> ACRM_SKILLTREE_DISPLAY_LIST = new BindingList<DB_SKILLTREEDISPLAY_62>();
        public BindingList<DB_SKILLTREERESOURCE_62> ACRM_SKILLTREE_RESOURCE_62_LIST = new BindingList<DB_SKILLTREERESOURCE_62>();
        public BindingList<DB_STATERESOURCE_62> ACRM_STATE_62_LIST = new BindingList<DB_STATERESOURCE_62>();
        public BindingList<DB_STATRESOURCE> ACRM_STAT_LIST = new BindingList<DB_STATRESOURCE>();
        public BindingList<DB_STRING> ACRM_STRING_LIST = new BindingList<DB_STRING>();
        public BindingList<DB_SUMMONRESOURCE> ACRM_SUMMON_LIST = new BindingList<DB_SUMMONRESOURCE>();
        public BindingList<DB_SUMMONRESOURCE_4> ACRM_SUMMON_4_LIST = new BindingList<DB_SUMMONRESOURCE_4>();
        public BindingList<DB_SUMMONRESOURCE_5> ACRM_SUMMON_5_LIST = new BindingList<DB_SUMMONRESOURCE_5>();
        public BindingList<DB_SUMMONRESOURCE_62> ACRM_SUMMON_62_LIST = new BindingList<DB_SUMMONRESOURCE_62>();
        public BindingList<DB_MIXRESOURCE> ACRM_MIX_LIST = new BindingList<DB_MIXRESOURCE>();
        public BindingList<DB_MODELEFFECTRESOURCE> ACRM_MODELEFFECT_LIST = new BindingList<DB_MODELEFFECTRESOURCE>();
        public BindingList<DB_MONSTERMOTIONSET_62> ACRM_MONSTERMOTION_62_LIST = new BindingList<DB_MONSTERMOTIONSET_62>();
        public BindingList<DB_MONSTERMOTIONSET_O71> ACRM_MONSTERMOTION_O71_LIST = new BindingList<DB_MONSTERMOTIONSET_O71>();
        public BindingList<DB_MONSTERRESOURCE_62> ACRM_MONSTER_62_LIST = new BindingList<DB_MONSTERRESOURCE_62>();
        public BindingList<DB_NPCRESOURCE> ACRM_NPC_LIST = new BindingList<DB_NPCRESOURCE>();
        public BindingList<DB_TITLERESOURCE> ACRM_TITLE_LIST = new BindingList<DB_TITLERESOURCE>();
        public BindingList<DB_WORLDLOCATIONRESOURCE_62> ACRM_WORLD_62_LIST = new BindingList<DB_WORLDLOCATIONRESOURCE_62>();
        public BindingList<DB_WORLDLOCATIONRESOURCE_73> ACRM_WORLD_73_LIST = new BindingList<DB_WORLDLOCATIONRESOURCE_73>();

        #endregion

        //Tab Related Properties
        #region
        public string[] ACRM_OPENED_TABS_COLLECTION;
        public TabPage ACRM_RDB_TEMP_TAB;
        public DataGridView ACRM_RDB_DGV;
        #endregion

        public float RDB_EPIC { get; set; }

        #endregion

        //Initialize the ACRM Graphic User Interface
        public ACRM_GUI()
        {
            //Initialize all components
            InitializeComponent();

            //
            GUI_INSTANCE = this;

            //Set the Inactive Light
            ACRM_IDLE_LIGHT.Visible = true;

            //Enable Key-Combos
            this.KeyPreview = true;
            //Define a handler to handle key combos
            this.KeyDown += new KeyEventHandler(ARCM_GUI_KEYCOMBO);

            //Handle Minimize/Restore Events
            this.Resize += (o, x) => 
            {
                //If the Window State is being minimized
                if (this.WindowState == FormWindowState.Minimized)
                {
                    //Hide the log
                    ACRM_LOG_MENU.Hide();
                }
                //If the Window State is being restored
                if (this.WindowState == FormWindowState.Normal)
                {
                    //IF log view is enabled
                    if (ACRM_LOAD_LOGS.Text == "Logs  ☑")
                    {
                        //Bring the log up
                        ACRM_LOG_MENU.Show();
                    }
                }
            };

            //Handle rules for the Tab Manager Selection Process
            ACRM_TAB_MANAGER.Selecting += (o, x) =>
            {
                //Disallow click until loading is finished
                if (x.TabPage.Text == ACRM_WORKING_TAB && ACRM_TAB_WORKING)
                {
                    //If click during load, send error to log
                    ACRM_LOG_HANDLER(2, "The tab is still loading please wait for \"Loading Complete!\"");

                    //Cancel the click
                    x.Cancel = true;
                }
            };

            //Create new instance of the ACRM MASH HASH WORKER
            ACRM_MASS_HASH_WORKER = new BackgroundWorker();

            //Define the Workers Job
            ACRM_MASS_HASH_WORKER.DoWork += (obj, x) => { ACRM_PROCESS_FILE_COLLECTION(); };

            //Define post completed actions
            ACRM_MASS_HASH_WORKER.RunWorkerCompleted += (obj, x) => { ACRM_MASS_HASH_WORKER.Dispose(); };

            //Define Hasher Group Mouse Click Handler
            #region
            ACRM_HASHER_GROUP.MouseClick += (obj, c) =>
            {
                //Open File Dialog 
                if (ACRM_HASHER_OPEN_FILE_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Create a collection if more than one file has been selected
                    ACRM_DRAG_FILEPATH_COLLECTION = ACRM_HASHER_OPEN_FILE_DIALOG.FileNames;
                    //Run the Worker
                    ACRM_MASS_HASH_WORKER.RunWorkerAsync();
                }
            };
            #endregion

            //Define Hasher Info Label Mouse Click Handler
            #region
            ACRM_HASHER_INFO.MouseClick += (obj, c) => 
            {     
                //Open File Dialog
                if (ACRM_HASHER_OPEN_FILE_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Create a collection if more than one file has been selected
                    ACRM_DRAG_FILEPATH_COLLECTION = ACRM_HASHER_OPEN_FILE_DIALOG.FileNames;
                    //Run the Worker
                    ACRM_MASS_HASH_WORKER.RunWorkerAsync();
                }  
           };
            #endregion

            //Set the log menus parent to the main form
            ACRM_LOG_MENU.ParentForm = this;
        }

        //Handle some events on the programs load
        private void ACRM_GUI_Load(object sender, EventArgs e)
        {
            //Enable Drag-N-Drop for the Hasher GroupBox
            ACRM_HASHER_GROUP.AllowDrop = true;

            //Enable Drag-N-Drop for the Launcher Tab
            ACRM_LAUNCHER_TAB.AllowDrop = true;

            //Set the default HASHER Response
            ACRM_HASH_RESP = "null";

            //Open the Log Menu
            ACRM_LOAD_LOGS_Click(Parent, EventArgs.Empty);

            //Send initial ACRM log
            ACRM_LOG_HANDLER(0, "Advanced Client Resource Manager has started up...");
        }

        //Hasher:
        #region

        //When the user Drags a file onto the Hasher
        private void ACRM_HASHER_GROUP_DROP(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //Start new background worker 
                ACRM_HASH_WORKER = new BackgroundWorker();
                //Define the work to be done by the background worker
                ACRM_HASH_WORKER.DoWork += (obj, x) =>
                {
                    //Define the Dragged file collection
                    ACRM_DRAG_FILEPATH_COLLECTION = (string[])(e.Data.GetData(DataFormats.FileDrop));

                    //For each directory in the collection
                    foreach (string ACRM_FILE_DIR in ACRM_DRAG_FILEPATH_COLLECTION)
                    {
                        FileAttributes ACRM_FILE_ATTR = File.GetAttributes(ACRM_FILE_DIR);
                        bool ACRM_FOLDER_CHECK = (ACRM_FILE_ATTR & FileAttributes.Directory) == FileAttributes.Directory;

                        //Encode/Deco
                        if (!ACRM_FOLDER_CHECK)
                        {
                            ACRM_ENCODE_CHECK(ACRM_FILE_DIR);
                        }
                        else
                        {
                            string[] ACRM_FOLDER_COLLECTION = Directory.GetFiles(ACRM_FILE_DIR);
                            foreach (string ACRM_FILE_PATH in ACRM_FOLDER_COLLECTION)
                            {
                                ACRM_ENCODE_CHECK(ACRM_FILE_PATH);
                            }
                        }
                    }
                };

                //Define actions to be taken after the worker has completed
                ACRM_HASH_WORKER.RunWorkerCompleted += (obj, x) =>
                {
                    //To avoid problems lets dispose the BackGround Worker
                    ACRM_HASH_WORKER.Dispose();

                    //Temporarily set the Success Label
                    ACRM_HASH_OPERATING_STATUS.Visible = true;

                    //Disable the Drag Here label
                    ACRM_HASHER_INFO.Visible = false;

                    //Start Status Refresh Timer
                    ACRM_HASH_OPERATION_STATUS_TIMER.Start();

                    ACRM_HASH_OPERATION_STATUS_TIMER.Tick += new EventHandler(ACRM_REFRESH_HASHER_STATUS);

                    //If the Response from the Hasher isn't null
                    if (!ACRM_HASH_RESP.Contains("null"))
                    {
                        //Run check to make sure return is valid
                        if (ACRM_HASH_RESP.ToLower().Contains("error"))
                        {
                            //If there is errors print such
                            ACRM_LOG_HANDLER(2, "The encode response contained errors");
                        }
                    }
                };

                if (!ACRM_HASH_WORKER.IsBusy)
                {
                    //Launch the Background Worker
                    ACRM_HASH_WORKER.RunWorkerAsync();
                }
            }
        }

        //Handle what happens when a file is drug onto the group box
        private void ACRM_HASHER_GROUP_ENTER(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        #endregion

        //RDB:
        #region

        //Handle an RDB entering the form
        private void ACRM_FORM_RDB_ENTER(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        //Handle an RDB dropped onto the form
        private void ACRM_FORM_RDB_DROP(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //Start new background worker 
                ACRM_RDB_WORKER = new BackgroundWorker();
                //Define the work to be done by the background worker
                ACRM_RDB_WORKER.DoWork += (obj, x) =>
                {
                    //Define the Dragged files path
                    ACRM_RDB_FILEPATH = (string[])(e.Data.GetData(DataFormats.FileDrop));

                    //For each file in the collection
                    foreach (String rdb in ACRM_RDB_FILEPATH)
                    {
                        ACRM_TAB_MANAGER_PREP_TAB(rdb);
                    }

                };

                //Define actions to be taken after the worker has completed
                ACRM_RDB_WORKER.RunWorkerCompleted += (obj, x) =>
                {
                    //To avoid problems lets dispose the BackGround Worker
                    ACRM_RDB_WORKER.Dispose();

                    //If the Response from the Hasher isn't null
                    if (!ACRM_HASH_RESP.Contains("null"))
                    {
                        //Run check to make sure return is valid
                        if (ACRM_HASH_RESP.ToLower().Contains("error"))
                        {
                            //If there is errors print such
                            ACRM_LOG_HANDLER(2, "The encode response contained errors");
                        }
                    }
                };
                //Launch the Background Worker
                ACRM_RDB_WORKER.RunWorkerAsync();
            }
        }

        //Handle Open RDB Button being clicked
        private void ACRM_OPEN_RDB_BUTTON_Click(object sender, EventArgs e)
        {
            //Show the Open File Dialog Menu || then if the user presses OK
            if (ACRM_RDB_OPEN_FILE_DIALOG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Start new background worker 
                ACRM_RDB_WORKER = new BackgroundWorker();

                //Define the work to be done by the background worker
                ACRM_RDB_WORKER.DoWork += (obj, x) =>
                {
                    //For each file (or rdb) selected by the user
                    foreach (string rdb in ACRM_RDB_OPEN_FILE_DIALOG.FileNames)
                    {
                        //Prep a new tab for this rdb 
                        ACRM_TAB_MANAGER_PREP_TAB(rdb);
                    }
                };

                ACRM_RDB_WORKER.RunWorkerAsync();
            }
        }

        //Handle Requests to close tabs
        private void ACRE_TAB_MANAGER_DoubleClick(object sender, EventArgs e)
        {
            if (ACRM_TAB_MANAGER.SelectedTab.ToString().Contains("Launcher") == false)
            {
                ACRM_TAB_MANAGER.TabPages.Remove(ACRM_TAB_MANAGER.SelectedTab);
            }
        }

        //Handle Load Database Table(s) requests
        private void ACRM_LOAD_DB_BUTTON_Click(object sender, EventArgs e)
        {
            //Define Database Table Selection Window
            ACRM_OPEN_DB_SELECT db_select = new ACRM_OPEN_DB_SELECT();
            //Define action on selection window close
            db_select.FormClosed += (obj, x) => 
            {
                //Define Database Connection String
                if (!string.IsNullOrEmpty(Properties.Settings.Default.db_host_port))
                {
                    //Form the connection string if NOT using a custom port!
                    DBCON = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Connection Timeout=5", Properties.Settings.Default.db_host_ip, Properties.Settings.Default.db_table_name, Properties.Settings.Default.db_table_user, Properties.Settings.Default.db_table_pass);

                    if (db_select.ACRM_TABLE_LIST != null)
                    {
                        //For each table name selected
                        foreach (string ACRM_TABLE_NAME in db_select.ACRM_TABLE_LIST)
                        {
                            try
                            {
                                //Create a new instance of the DB Worker
                                ACRM_DB_WORKER = new BackgroundWorker();
                                //Define work to be done by the worker
                                ACRM_DB_WORKER.DoWork += (o, c) =>
                                {
                                    ACRM_LOG_HANDLER(2, "Loading " + ACRM_TABLE_NAME + " database");

                                    ACRM_CHANGE_ACTIVITY_STATUS(true);

                                    //Read the Database Table
                                    ACRM_READ_RDB_DB_TABLE(DBCON, ACRM_TABLE_NAME);
                                };

                                //Run the DB Worker
                                ACRM_DB_WORKER.RunWorkerAsync();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }                   
                }
                else
                {
                    //Form the connection string if using a custom port!
                    DBCON = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Connection Timeout=5", Properties.Settings.Default.db_host_ip + "," + Properties.Settings.Default.db_host_port, Properties.Settings.Default.db_table_name, Properties.Settings.Default.db_table_user, Properties.Settings.Default.db_table_pass);

                    //For each table name selected
                    foreach (string ACRM_TABLE_NAME in db_select.ACRM_TABLE_LIST)
                    {
                        //Read the Table
                        ACRM_READ_RDB_DB_TABLE(DBCON, ACRM_TABLE_NAME);
                    }
                }
            };

            //Show the Database Table Selection Window
            db_select.ShowDialog();
        }

        //Handle RDB Save Requests
        private void ACRM_SAVE_RDB_BUTTON_Click(object sender, EventArgs e)
        {
            //Define the Tabs Collection
            ACRM_OPENED_TABS_COLLECTION = new string[ACRM_TAB_MANAGER.TabCount];

            //Define the Tab Index
            int ACRM_TAB_INDEX = 0;

            //For each Tab Page in the collection
            foreach (TabPage page in ACRM_TAB_MANAGER.TabPages)
            {
                //Add new entry to array
                ACRM_OPENED_TABS_COLLECTION[ACRM_TAB_INDEX] = page.Text;

                //Increase the Tab Index by 1
                ACRM_TAB_INDEX++;
            }

            //Define the Tab Selection Window and pass it the collection
            ACRM_SAVE_TAB_SELECT tab_select = new ACRM_SAVE_TAB_SELECT(ACRM_OPENED_TABS_COLLECTION);

            //Once the Tab Select Menu has been closed
            tab_select.FormClosed += (obj, x) => 
            {
                //Define a new Array of Selected Tabs
                string[] ACRM_TAB_SELECTED_LIST = new string[tab_select.ACRM_ACTIVE_TAB_COLLECTION.CheckedItems.Count];
                //Define the Selected List Index
                int ACRM_TAB_SELECTED_LIST_INDEX = 0;
                //For Each Tab in the Collection
                foreach (ListViewItem ACRM_TAB in tab_select.ACRM_ACTIVE_TAB_COLLECTION.CheckedItems)
                {
                    //Add to the array
                    ACRM_TAB_SELECTED_LIST[ACRM_TAB_SELECTED_LIST_INDEX]  = ACRM_TAB.Text;
                    ACRM_TAB_SELECTED_LIST_INDEX++;
                }

                //Send info to log
                ACRM_LOG_HANDLER(2, "User requested RDB Save Operation...");

                //Create a list of tabs to be displayed
                var TAB_LIST = string.Join(Environment.NewLine, ACRM_TAB_SELECTED_LIST);

                //If the tab_list is not empty
                if (!string.IsNullOrEmpty(TAB_LIST))
                {
                    //Warn the user they are about to commit a save
                    if (MessageBox.Show("You are about to save the following rdbs:\n\n" + TAB_LIST + "\n\nAre you sure you wish to continue?", "Save RDB Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        //Send info to log
                        ACRM_LOG_HANDLER(2, "Save Operation Confirmed...");
                        //Shower the user save folder dialog and wait for OK
                        if (ACRM_RDB_SAVE_FOLDER_DIALOG.ShowDialog() == DialogResult.OK)
                        {
                            ACRM_CHANGE_ACTIVITY_STATUS(true);

                            //Define a new background worker to commit save
                            ACRM_SAVE_WORKER = new BackgroundWorker();

                                //For each selected tab in the list
                                foreach (string ACRM_RDB_NAME in ACRM_TAB_SELECTED_LIST)
                                {
                                    ////Define the work to be done
                                    //ACRM_SAVE_WORKER.DoWork += (o, z) =>
                                    //{
                                    new System.Threading.Thread(() =>
                                        {
                                            //Read the RDB
                                            ACRM_SAVE_RDB(Path.Combine(ACRM_RDB_SAVE_FOLDER_DIALOG.SelectedPath, ACRM_RDB_NAME + ".rdb"));
                                        }).Start();
                                    //};

                                    ////Run the worker
                                    //ACRM_SAVE_WORKER.RunWorkerAsync();

                                    //while (ACRM_SAVE_WORKER.IsBusy) { }
                                }
                        }
                    }
                    else
                    {
                        //Send info to the log
                        ACRM_LOG_HANDLER(2, "User canceled RDB save operation!");
                    }
                }
            };

            //Show the Tab Select Menu
            tab_select.ShowDialog();
        }

        #endregion

        //Misc:
        #region
        //Handle the Log Button being pressed
        private void ACRM_LOAD_LOGS_Click(object sender, EventArgs e)
        {
            //Show the log menu
            ACRM_LOG_MENU.Show();

            if (!ACRM_LOAD_LOGS.Text.Contains("  ☑"))
            {
                ACRM_LOAD_LOGS.Text = "Logs  ☑";
            }
            else
            {
                ACRM_LOG_MENU.Hide();
                ACRM_LOAD_LOGS.Text = "Logs  ☐";
            }
        }

        //Handle the Team button being pressed
        private void ARCM_OPEN_THE_TEAM_Click(object sender, EventArgs e)
        {
            ACRM_THE_TEAM ACRM_TEAM = new ACRM_THE_TEAM();
            ACRM_TEAM.ShowDialog();
        }

        //Handle the DB Settings button being pressed
        private void ACRM_EDIT_OPEN_DB_SETTINGS_Click(object sender, EventArgs e)
        {
            ACRM_DB_SETTINGS ACRM_DB_SETTINGS = new ACRM_DB_SETTINGS();
            ACRM_DB_SETTINGS.ShowDialog();
        }

        //Handle initial key-press event
        private void ACRM_MENU_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.KeyDown += new KeyEventHandler(ARCM_GUI_KEYCOMBO);
        }

        //Handle Basic Info open request
        public void ACRM_OPEN_BASIC_INFO_Click(object sender, EventArgs e)
        {
            ACRM_BASIC_INFO ACRM_BASIC = new ACRM_BASIC_INFO();
            ACRM_BASIC.ShowDialog();
        }

        //Handle a cpu timer tick
        private void ACRM_CPU_TIMER_Tick(object sender, EventArgs e)
        {
            //Create a new background work to monitor CPU/RAM
            ACRM_MONITOR_WORKER = new BackgroundWorker();
            //Define the workers "work to be done"
            ACRM_MONITOR_WORKER.DoWork += (o, x) =>
            {
                //Start the resource monitor
                ACRM_RESOURCE_MONITOR();
            };
            //Run the worker
            ACRM_MONITOR_WORKER.RunWorkerAsync();
        }
        #endregion
    }
}
