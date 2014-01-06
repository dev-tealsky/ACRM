using DataBurner;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACRM
{
    //Define a partially public class attached to the main form
    public partial class ACRM_GUI : Form
    {
        //Basic Functions:
        #region

        //Enumerate months for later use
        enum Month
        {
            January = 1,
            Feburary = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }

        //Handle Key Combo's
        public void ARCM_GUI_KEYCOMBO(object sender, KeyEventArgs e)
        {
            //Open DB Settings
            if (e.Control && e.KeyCode == Keys.C) //Ctrl+C
            {
                ACRM_EDIT_OPEN_DB_SETTINGS_Click(this, EventArgs.Empty);
            }
            //Open RDB
            if (e.Control && e.KeyCode == Keys.O) //Ctrl+O 
            {
                ACRM_OPEN_RDB_BUTTON_Click(this, EventArgs.Empty);
            }
            //Save RDB
            if (e.Control && e.KeyCode == Keys.S) //Ctrl+S
            {
                ACRM_SAVE_RDB_BUTTON_Click(this, EventArgs.Empty);
            }
            //Open DB
            if (e.Control && e.KeyCode == Keys.D) //Ctrl+D
            {
                ACRM_LOAD_DB_BUTTON_Click(this, EventArgs.Empty);
            }
            //Toggle Log
            if (e.Control && e.KeyCode == Keys.L) //Ctrl+L
            {
                ACRM_LOAD_LOGS_Click(this, EventArgs.Empty);
            }
        }

        #endregion

        //Hash Functions:
        #region

        //Refresh the operating status of the File Hasher
        public void ACRM_REFRESH_HASHER_STATUS(object sender, EventArgs e)
        {
            ACRM_HASH_OPERATING_STATUS.Visible = false;
            ACRM_HASHER_INFO.Visible = true;
            ACRM_HASH_OPERATION_STATUS_TIMER.Stop();
        }

        //Check file ENCODE Status 
        public string ACRM_ENCODE_CHECK(string fileLoc)
        {
            ACRM_CHANGE_ACTIVITY_STATUS(true);

            // Code to read the contents of the text file
            if (File.Exists(fileLoc))
            {
                bool ACRM_FILENAME_IS_ENCODED = ACRM_NAME_MATRIX.IsEncodedName(Path.GetFileName(fileLoc));

                //If the filename is encoded
                if (ACRM_FILENAME_IS_ENCODED == true)
                {
                    //Output info to the log
                    this.Invoke((MethodInvoker)delegate { ACRM_LOG_HANDLER(2, "File Check: File Is Hashed"); });

                    //Unhash the file
                    ACRM_CONVERT_FILE(0, fileLoc);

                    //Set the Hashers Response
                    ACRM_HASH_RESP = "true";

                    return "acrm_resp_fileok_encoded_true";
                }
                //If the filename is not encoded
                else
                {
                    //Output info to the log
                    this.Invoke((MethodInvoker)delegate { ACRM_LOG_HANDLER(2, "File Check: File Not Unhashed"); });

                    //Hash the file
                    ACRM_CONVERT_FILE(1, fileLoc);

                    //Set the Hashers Response
                    ACRM_HASH_RESP = "false";

                    return "acrm_resp_fileok_encoded_false";
                }
            }
            else
            {
                ACRM_CHANGE_ACTIVITY_STATUS(false);

                //Output info to the log
                this.Invoke((MethodInvoker)delegate { ACRM_LOG_HANDLER(2, "File Load Error!"); });

                return "acrm_resp_file_error";
            }
        }

        //Handle file conversion from unhashed<>hashed state
        public bool ACRM_CONVERT_FILE(int convert_type, string fileLoc)
        {
            //If the file is being unhashed
            if (convert_type == 0)
            {
                //If the file doesn't already exist
                if (!File.Exists(Path.GetDirectoryName(fileLoc) + "\\" + ACRM_NAME_MATRIX.DecodeFileName(Path.GetFileName(fileLoc))))
                {
                    this.Invoke((MethodInvoker)delegate { ACRM_LOG_HANDLER(1, "===========================" +
                                                                               "\n\n" +
                                                                               "Hash Name: " + 
                                                                               Path.GetFileName(fileLoc) + 
                                                                               "\n\n" + 
                                                                               "Real Name: " + 
                                                                               ACRM_NAME_MATRIX.DecodeFileName(Path.GetFileName(fileLoc)) +
                                                                               "\n\n" + 
                                                                               "File Unhashing Completed!" +
                                                                               "\n" +
                                                                               "==========================="
                                                                               ); });
                    //
                    File.Move(fileLoc, Path.GetDirectoryName(fileLoc) + "\\" + ACRM_NAME_MATRIX.DecodeFileName(Path.GetFileName(fileLoc)));

                    ACRM_CHANGE_ACTIVITY_STATUS(false);

                    return true;
                }
            }
            //If the file is being hashed
            else
            {
                //If the file doesn't already exist
                if (!File.Exists(Path.GetDirectoryName(fileLoc) + "\\" + ACRM_NAME_MATRIX.EncodeFileName(Path.GetFileName(fileLoc))))
                {
                    this.Invoke((MethodInvoker)delegate { ACRM_LOG_HANDLER(1,  "===========================" +
                                                                               "\n\n" +
                                                                               "Real Name: " +
                                                                               Path.GetFileName(fileLoc) +
                                                                               "\n\n" +
                                                                               "Hash Name: " + ACRM_NAME_MATRIX.EncodeFileName(Path.GetFileName(fileLoc)) + 
                                                                               "\n\n" +
                                                                               "File Hashing Completed!" +
                                                                               "\n" +
                                                                               "==========================="
                                                                               ); });
                    
                    //
                    File.Move(fileLoc, Path.GetDirectoryName(fileLoc) + "\\" + ACRM_NAME_MATRIX.EncodeFileName(Path.GetFileName(fileLoc)));

                    ACRM_CHANGE_ACTIVITY_STATUS(false);

                    return true;
                }
            }

            ACRM_CHANGE_ACTIVITY_STATUS(false);

            return false;
        }

        #endregion

        //Log Functions:
        #region

        //Handle log updates
        public void ACRM_LOG_HANDLER(int line_type, string log_msg)
        {
            ACRM_LOG_WORKER = new System.ComponentModel.BackgroundWorker();
            ACRM_LOG_WORKER.DoWork += (o, x) =>
            {             //If the line type is valid and there is an actual log message
                if (line_type > -1 && !string.IsNullOrEmpty(log_msg))
                {
                    //This is the first message of the log window
                    if (line_type == 0)
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_MENU.ACRM_LOG_WINDOW.Text = log_msg; }));
                    }
                    //Append after one new line
                    if (line_type == 1)
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_MENU.ACRM_LOG_WINDOW.AppendText("\n" + log_msg); }));
                    }
                    //Append after two new lines
                    if (line_type == 2)
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_MENU.ACRM_LOG_WINDOW.AppendText("\n\n" + log_msg); }));
                    }
                }
                else
                {
                    MessageBox.Show("There was an error handling the log request!", "ACRM Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            ACRM_LOG_WORKER.RunWorkerAsync();
        }

        #endregion

        //RDB Functions:
        #region

        //Handle "IS RDB" check
        public bool ACRM_PREP_RDB(string rdb_name)
        {
            //If the name does not contain the .rdb extension
            if (!rdb_name.ToLower().Contains(".rdb"))
            {
                return false;
            }
            //If the name does contain .rdb extension
            else
            {
                return true;
            }
        }

        //Read the RDB 
        public void ACRM_READ_RDB(string rdb_filepath)
        {
            //Set the Activity Light 
            ACRM_CHANGE_ACTIVITY_STATUS(true);

            //Set the RDB_EPIC to default
            RDB_EPIC = 0.0f;

            //Grab the rdb name
            string ACRM_RDB_FILENAME = Path.GetFileNameWithoutExtension(rdb_filepath);

            //Using a Binary Reader (br) read the rdb 
            using (BinaryReader br = new BinaryReader(File.OpenRead(rdb_filepath), new ASCIIEncoding()))
            {
                //Try to read the file (So we can catch exceptions)
                //=================================================
                #region
                try
                {
                    //Read File Header (CONSTANT)
                    String ACRM_RDB_FILEDATE = ASCIIEncoding.ASCII.GetString(br.ReadBytes(8));

                    //Read the 120 Bytes of Blank Space
                    br.ReadBytes(120);

                    //Read the RDB Row Count
                    Int32 ACRM_RDB_FILEROWS = br.ReadInt32();

                    //Define the Epic Selection Menu
                    ACRM_RDB_EPIC ACRM_EPIC_SELECT = new ACRM_RDB_EPIC();

                    //Decide how to read RDB based on name
                    //=====================================
                    //=====================================

                    //db_enhance.rdb
                    #region
                    if (ACRM_RDB_FILENAME.ToLower() == "db_enhance"|| ACRM_RDB_FILENAME.ToLower() == "db_enhance(ascii)")
                    {
                        //Clear the binding list to avoid duplication of entries
                        this.Invoke(new MethodInvoker(delegate { ACRM_ENHANCE_LIST.Clear(); }));

                        //Write rdb info to the log
                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "Enhance RDB Loading..." +
                            "\n" +
                            "===============================" +
                            "\n" +
                            "File Info: " +
                            "\n" +
                            "===============================" +
                            "\n" +
                            "Date Created: " +
                            Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                            " " +
                            ACRM_RDB_FILEDATE.Substring(6, 2) +
                            ", " +
                            ACRM_RDB_FILEDATE.Substring(0, 4) +
                            "\n" +
                            "Entries: " +
                            ACRM_RDB_FILEROWS +
                            "\n" +
                             "==============================="
                            );
                        }));

                        //Set the Dynamic RDB DataGrid (Previously created) to the bindinglist being used
                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_ENHANCE_LIST; }));

                        //Begin reading the physical file
                        //while the br OR binaryreader is reading OR NOT AT EOF (PeekChar != -1)
                        while (br.PeekChar() != -1)
                        {
                            //Create new instance of the DB_ENHANCE.cs (or class) which holds the structure and read/write functions for this rdb
                            DB_ENHANCERESOURCE ACRM_ENHANCE_BL = new DB_ENHANCERESOURCE();
                            //Call the DB_ENHANCE.cs read file function
                            ACRM_ENHANCE_BL.ReadFile(br);
                            //For each time the file is read, add that info to the binding-list
                            this.Invoke(new MethodInvoker(delegate { ACRM_ENHANCE_LIST.Add(ACRM_ENHANCE_BL); }));
                        }
                    }
                    #endregion

                    //FieldPropResource (MEF) [Current Support: 6.2, 7.3]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_fieldprop"))
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }
                        
                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if(RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 FieldProp Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_FIELDPROP_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "FieldProp (6.2) RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the fieldprop Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_FIELDPROP_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_FIELDPROPRESOURCE_62 ACRM_FIELDPROP_BL = new DB_FIELDPROPRESOURCE_62();
                                
                                //Read the row
                                ACRM_FIELDPROP_BL.ReadFile(br);

                                //Add the row to the fieldprop bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_FIELDPROP_62_LIST.Add(ACRM_FIELDPROP_BL); }));
                            }
                        }
                        else if (RDB_EPIC >= 7.3f)
                        {
                            //Clear the 6.2 FieldProp Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_FIELDPROP_73_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "FieldProp (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the fieldprop Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_FIELDPROP_73_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_FIELDPROPRESOURCE_73 ACRM_FIELDPROP_BL = new DB_FIELDPROPRESOURCE_73();

                                //Read the row
                                ACRM_FIELDPROP_BL.ReadFile(br);

                                //Add the row to the fieldprop bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_FIELDPROP_73_LIST.Add(ACRM_FIELDPROP_BL); }));
                            }
                        }
                        else if (RDB_EPIC == 7.4f)
                        {

                        }
                        else if (RDB_EPIC == 8.1f)
                        {

                        }
                        else if (RDB_EPIC == 8.2f)
                        {

                        }
                        //-------------------------------------------
                    }
                    #endregion

                    //EffectResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_effectresource"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_EFFECT_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "Effect RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_EFFECT_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_EFFECTRESOURCE ACRM_EFFECT_BL = new DB_EFFECTRESOURCE();
                            ACRM_EFFECT_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_EFFECT_LIST.Add(ACRM_EFFECT_BL); }));
                        }
                    }
                    #endregion

                    //EnhanceFX
                    #region
                    if (ACRM_RDB_FILENAME.ToLower() == "db_enhancefx" || ACRM_RDB_FILENAME.ToLower() == "db_enhancefx(ascii)")
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_ENHANCEFX_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "EnhanceFX RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );

                            //Set tab is loading flag to true
                            ACRM_TAB_WORKING = true;
                            ACRM_WORKING_TAB = Path.GetFileNameWithoutExtension(rdb_filepath);

                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_ENHANCEFX_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_ENHANCEFX ACRM_ENHANCEFX_BL = new DB_ENHANCEFX();
                            ACRM_ENHANCEFX_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_ENHANCEFX_LIST.Add(ACRM_ENHANCEFX_BL); }));
                        }
                    }
                    #endregion

                    //Item (MEF) [Current Support: 6.2]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower() == "db_item" || ACRM_RDB_FILENAME.ToLower() == "db_item(ascii)")
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 Item Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_ITEM_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Item (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );

                                ACRM_TAB_WORKING = true;
                                ACRM_WORKING_TAB = Path.GetFileNameWithoutExtension(rdb_filepath);
                            }));

                            //Set the RDB DataGridView DataSource as the Item Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_ITEM_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_ITEMRESOURCE_62 ACRM_ITEM_BL = new DB_ITEMRESOURCE_62();

                                //Read the row
                                ACRM_ITEM_BL.ReadFile(br);

                                //Add the row to the item bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_ITEM_62_LIST.Add(ACRM_ITEM_BL); }));
                            }
                        }
                    }
                    #endregion

                    //ItemEffectResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_itemeffect"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_ITEMEFFECT_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "ItemEffect RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_ITEMEFFECT_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_ITEMEFFECTRESOURCE ACRM_ITEMEFFECT_BL = new DB_ITEMEFFECTRESOURCE();
                            ACRM_ITEMEFFECT_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_ITEMEFFECT_LIST.Add(ACRM_ITEMEFFECT_BL); }));
                        }
                    }
                    #endregion

                    //Job Resource 
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_job"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_JOB_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "Job RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_JOB_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_JOBRESOURCE ACRM_JOB_BL = new DB_JOBRESOURCE();
                            ACRM_JOB_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_JOB_LIST.Add(ACRM_JOB_BL); }));
                        }
                    }
                    #endregion

                    //QuestResource (MEF) [Current Support: 6.2]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower() == "db_quest" || ACRM_RDB_FILENAME.ToLower() == "db_quest(ascii)")
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 Quest Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_QUEST_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Quest (6.2) RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the Quest Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_QUEST_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_QUESTRESOURCE_62 ACRM_QUEST_BL = new DB_QUESTRESOURCE_62();

                                //Read the row
                                ACRM_QUEST_BL.ReadFile(br);

                                //Add the row to the fieldprop bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_QUEST_62_LIST.Add(ACRM_QUEST_BL); }));
                            }
                        }
                        else if (RDB_EPIC == 7.3f)
                        {

                        }
                        else if (RDB_EPIC == 7.4f)
                        {

                        }
                        else if (RDB_EPIC == 8.1f)
                        {

                        }
                        else if (RDB_EPIC == 8.2f)
                        {

                        }
                        //-------------------------------------------
                    }
                    #endregion

                    //SkillResource (MEF) [Current Support 6.2, 7.3]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower() == "db_skill" || ACRM_RDB_FILENAME.ToLower() == "db_skill(ascii)")
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 Skill Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_SKILL_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Skill (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the Skill Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SKILL_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_SKILLRESOURCE_62 ACRM_SKILL_BL = new DB_SKILLRESOURCE_62();

                                //Read the row
                                ACRM_SKILL_BL.ReadFile(br);

                                //Add the row to the skill bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_SKILL_62_LIST.Add(ACRM_SKILL_BL); }));
                            }
                        }
                        else if (RDB_EPIC == 7.3f)
                        {
                            //Clear the 6.2 Skill Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_SKILL_73_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Skill (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the Skill Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SKILL_73_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_SKILLRESOURCE_73 ACRM_SKILL_BL = new DB_SKILLRESOURCE_73();

                                //Read the row
                                ACRM_SKILL_BL.ReadFile(br);

                                //Add the row to the skill bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_SKILL_73_LIST.Add(ACRM_SKILL_BL); }));
                            }
                        }
                    }
                    #endregion

                    //SkillStage 
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("skillstage"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_SKILLSTAGE_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "SkillStage RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SKILLSTAGE_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_SKILLSTAGE ACRM_SKILLSTAGE_BL = new DB_SKILLSTAGE();
                            ACRM_SKILLSTAGE_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_SKILLSTAGE_LIST.Add(ACRM_SKILLSTAGE_BL); }));
                        }
                    }
                    #endregion

                    //SkillTreeDisplay 
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_skilltreedisplay"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_SKILLTREE_DISPLAY_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "SkillTreeDisplay RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SKILLTREE_DISPLAY_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_SKILLTREEDISPLAY_62 ACRM_SKILLTREE_DISPLAY_BL = new DB_SKILLTREEDISPLAY_62();
                            ACRM_SKILLTREE_DISPLAY_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_SKILLTREE_DISPLAY_LIST.Add(ACRM_SKILLTREE_DISPLAY_BL); }));
                        }
                    }
                    #endregion

                    //SkillTreeResource (MEF) [Current Support: 6.2]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_skilltree"))
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }
                        else if (RDB_EPIC == 6.2f)
                        {
                            this.Invoke(new MethodInvoker(delegate { ACRM_SKILLTREE_RESOURCE_62_LIST.Clear(); }));

                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "SkillTreeDisplay RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SKILLTREE_RESOURCE_62_LIST; }));

                            int num1 = 0; 
                            int num2 = 0;
                            while (br.PeekChar() != -1)
                            {
                                if (num2 == num1)
                                {
                                    num2 = 0;
                                    num1 = br.ReadInt32();
                                }

                                    DB_SKILLTREERESOURCE_62 ACRM_SKILLTREE_BL = new DB_SKILLTREERESOURCE_62();
                                    ACRM_SKILLTREE_BL.ReadFile(br);
                                    this.Invoke(new MethodInvoker(delegate { ACRM_SKILLTREE_RESOURCE_62_LIST.Add(ACRM_SKILLTREE_BL); }));

                                    num2++;
                            }
                        }
                    }
                            
                    #endregion

                    //StatResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_basic"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_STAT_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "Stat RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_STAT_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_STATRESOURCE ACRM_STAT_BL = new DB_STATRESOURCE();
                            ACRM_STAT_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_STAT_LIST.Add(ACRM_STAT_BL); }));
                        }
                    }
                    #endregion

                    //StateResource (MEF) [Current Support: 6.2]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_tenacity"))
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_STATE_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "State (6.2) RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_STATE_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_STATERESOURCE_62 ACRM_STATE_BL = new DB_STATERESOURCE_62();

                                //Read the row
                                ACRM_STATE_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_STATE_62_LIST.Add(ACRM_STATE_BL); }));
                            }
                        }
                        else if (RDB_EPIC == 7.3f)
                        {

                        }
                        else if (RDB_EPIC == 7.4f)
                        {

                        }
                        else if (RDB_EPIC == 8.1f)
                        {

                        }
                        else if (RDB_EPIC == 8.2f)
                        {

                        }
                        //-------------------------------------------
                    }
                    #endregion

                    //SummonResource (MEF) [Current Support: 4,5,6.2]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_creature"))
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (Convert.ToInt32(RDB_EPIC) <= 3)
                        {
                            //Clear the Summon Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_SUMMON_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Creature (" + RDB_EPIC.ToString() + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SUMMON_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_SUMMONRESOURCE ACRM_SUMMON_BL = new DB_SUMMONRESOURCE();

                                //Read the row
                                ACRM_SUMMON_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_SUMMON_LIST.Add(ACRM_SUMMON_BL); }));
                            }
                        }
                        else if (Convert.ToInt32(RDB_EPIC) == 4)
                        {
                            //Clear the 4 Summon Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_SUMMON_4_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Creature (" + RDB_EPIC.ToString() + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SUMMON_4_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_SUMMONRESOURCE_4 ACRM_SUMMON_BL = new DB_SUMMONRESOURCE_4();

                                //Read the row
                                ACRM_SUMMON_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_SUMMON_4_LIST.Add(ACRM_SUMMON_BL); }));
                            }
                        }
                        else if (RDB_EPIC >= 5.1f && RDB_EPIC <= 8.1f)
                        {
                            //Clear the 5 Summon Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_SUMMON_5_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Creature (" + RDB_EPIC.ToString() + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_SUMMON_5_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_SUMMONRESOURCE_5 ACRM_SUMMON_BL = new DB_SUMMONRESOURCE_5();

                                //Read the row
                                ACRM_SUMMON_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_SUMMON_5_LIST.Add(ACRM_SUMMON_BL); }));
                            }
                        }
                        else if (RDB_EPIC == 8.2f)
                        {

                        }
                        //-------------------------------------------
                    }
                    #endregion

                    //StringResource (MEF) [Current Support: 6+]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_string"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_STRING_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "String RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );

                            ACRM_TAB_WORKING = true;
                            ACRM_WORKING_TAB = Path.GetFileNameWithoutExtension(rdb_filepath);
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_STRING_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_STRING ACRM_STRING_BL = new DB_STRING();
                            ACRM_STRING_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_STRING_LIST.Add(ACRM_STRING_BL); }));
                        }
                    }
                    #endregion

                    //MixResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_combine"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_MIX_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "Combine (Mix) RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_MIX_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_MIXRESOURCE ACRM_MIX_BL = new DB_MIXRESOURCE();
                            ACRM_MIX_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_MIX_LIST.Add(ACRM_MIX_BL); }));
                        }
                    }
                    #endregion

                    //ModelEffectResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_modeleffect"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_MODELEFFECT_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "ModelEffect RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_MODELEFFECT_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_MODELEFFECTRESOURCE ACRM_MODELEFFECT_BL = new DB_MODELEFFECTRESOURCE();
                            ACRM_MODELEFFECT_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_MODELEFFECT_LIST.Add(ACRM_MODELEFFECT_BL); }));
                        }
                    }
                    #endregion

                    //MonsterMotionSet (MEF) [Current Support: 6.2, 7.3+]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_monstermotion"))
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 MotionSet Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_MONSTERMOTION_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "MonsterMotionSet (6.2) RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_MONSTERMOTION_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_MONSTERMOTIONSET_62 ACRM_MOTIONSET_BL = new DB_MONSTERMOTIONSET_62();

                                //Read the row
                                ACRM_MOTIONSET_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_MONSTERMOTION_62_LIST.Add(ACRM_MOTIONSET_BL); }));
                            }
                        }
                        else if (RDB_EPIC >= 7.3f)
                        {
                            //Clear the 7.3+ MotionSet Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_MONSTERMOTION_O71_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "MonsterMotionSet (7.3+) RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the State Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_MONSTERMOTION_O71_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_MONSTERMOTIONSET_O71 ACRM_MOTIONSET_BL = new DB_MONSTERMOTIONSET_O71();

                                //Read the row
                                ACRM_MOTIONSET_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_MONSTERMOTION_O71_LIST.Add(ACRM_MOTIONSET_BL); }));
                            }
                        }
                        //-------------------------------------------
                    }
                    #endregion

                    //MonsterResource (MEF) [Current Support: 6.2]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower() == "db_monster" || ACRM_RDB_FILENAME.ToLower() == "db_monster(ascii)")
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 Monster Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_MONSTER_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "Monster (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the Monster Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_MONSTER_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_MONSTERRESOURCE_62 ACRM_MONSTER_BL = new DB_MONSTERRESOURCE_62();

                                //Read the row
                                ACRM_MONSTER_BL.ReadFile(br);

                                //Add the row to the state bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_MONSTER_62_LIST.Add(ACRM_MONSTER_BL); }));
                            }
                        }
                        //-------------------------------------------
                    }
                    #endregion

                    //NPCResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("npc"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_NPC_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "NPC RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );

                            ACRM_TAB_WORKING = true;
                            ACRM_WORKING_TAB = Path.GetFileNameWithoutExtension(rdb_filepath);
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_NPC_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_NPCRESOURCE ACRM_NPC_BL = new DB_NPCRESOURCE();
                            ACRM_NPC_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_NPC_LIST.Add(ACRM_NPC_BL); }));
                        }
                    }
                    #endregion

                    //TitleResource
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("title"))
                    {
                        this.Invoke(new MethodInvoker(delegate { ACRM_TITLE_LIST.Clear(); }));

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //Write info to the Log
                            ACRM_LOG_HANDLER
                            (2, "Title RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );

                            ACRM_TAB_WORKING = true;
                            ACRM_WORKING_TAB = Path.GetFileNameWithoutExtension(rdb_filepath);
                        }));

                        this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_TITLE_LIST; }));

                        while (br.PeekChar() != -1)
                        {
                            DB_TITLERESOURCE ACRM_TITLE_BL = new DB_TITLERESOURCE();
                            ACRM_TITLE_BL.ReadFile(br);
                            this.Invoke(new MethodInvoker(delegate { ACRM_TITLE_LIST.Add(ACRM_TITLE_BL); }));
                        }
                    }
                    #endregion

                    //WorldLocation (MEF) [Current Support: 6.2, 7.3]
                    #region
                    if (ACRM_RDB_FILENAME.ToLower().Contains("_worldlocation"))
                    {
                        //Show the RDB Epic Selection Menu
                        ACRM_EPIC_SELECT.ShowDialog();

                        //Make sure the RDB_EPIC is not it's default value
                        if (RDB_EPIC == 0.0f)
                        {
                            ACRM_LOG_HANDLER(2, "You have not selected an Epic!");
                        }

                        //If the epic is valid, lets begin processing
                        //-------------------------------------------
                        else if (RDB_EPIC == 6.2f)
                        {
                            //Clear the 6.2 World Locaiton Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_WORLD_62_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "WorldLocation (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the World Location Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_WORLD_62_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_WORLDLOCATIONRESOURCE_62 ACRM_WORLD_BL = new DB_WORLDLOCATIONRESOURCE_62();

                                //Read the row
                                ACRM_WORLD_BL.ReadFile(br);

                                //Add the row to the World Locaiton bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_WORLD_62_LIST.Add(ACRM_WORLD_BL); }));
                            }
                        }
                        else if (RDB_EPIC == 7.3f)
                        {
                            //Clear the 7.3 World Locaiton Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_WORLD_73_LIST.Clear(); }));

                            //Send the information from the header to the Log Menu
                            this.Invoke(new MethodInvoker(delegate
                            {
                                //Write info to the Log
                                ACRM_LOG_HANDLER
                                (2, "WorldLocation (" + RDB_EPIC + ") RDB Loading..." +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "File Info: " +
                                "\n" +
                                "===============================" +
                                "\n" +
                                "Date Created: " +
                                Enum.GetValues(typeof(Month)).GetValue(Convert.ToInt32(ACRM_RDB_FILEDATE.Substring(4, 2)) - 1) +
                                " " +
                                ACRM_RDB_FILEDATE.Substring(6, 2) +
                                ", " +
                                ACRM_RDB_FILEDATE.Substring(0, 4) +
                                "\n" +
                                "Entries: " +
                                ACRM_RDB_FILEROWS +
                                "\n" +
                                 "==============================="
                                );
                            }));

                            //Set the RDB DataGridView DataSource as the World Location Binding List
                            this.Invoke(new MethodInvoker(delegate { ACRM_RDB_DGV.DataSource = ACRM_WORLD_73_LIST; }));

                            //While the binary reader (br) has not read to the end of the file
                            while (br.PeekChar() != -1)
                            {
                                //Define the Structure file for this RDB
                                DB_WORLDLOCATIONRESOURCE_73 ACRM_WORLD_BL = new DB_WORLDLOCATIONRESOURCE_73();

                                //Read the row
                                ACRM_WORLD_BL.ReadFile(br);

                                //Add the row to the World Locaiton bindinglist
                                this.Invoke(new MethodInvoker(delegate { ACRM_WORLD_73_LIST.Add(ACRM_WORLD_BL); }));
                            }
                        }
                    }
                    #endregion

                    //=====================================
                    //=====================================

                    //Send Load Completed to the Log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, "Load Completed!"); }));

                    //Set the Tab Working flag to false
                    this.Invoke(new MethodInvoker(delegate { ACRM_TAB_WORKING = false; }));

                    //Change ACRM Activity Status
                    ACRM_CHANGE_ACTIVITY_STATUS(false);
                }
                
                //Catch Exceptions
                catch (Exception ex)
                {
                    //Change ACRM Activity Status
                    ACRM_CHANGE_ACTIVITY_STATUS(false);

                    //Send the error message to the log window
                    ACRM_LOG_HANDLER(2, ex.ToString());
                }
                //=====================================
                #endregion
                //=================================================
            }
        }

        //Save the RDB
        public void ACRM_SAVE_RDB(string rdb_filepath)
        {
            //Using Binary Writer
            using (BinaryWriter bw = new BinaryWriter(File.Create(rdb_filepath)))
            {
                //Write the Header
                bw.Write(ACRM_BYTE_CONVERTER.GetFileHeader());

                //Send informational output to log
                this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, Path.GetFileName(rdb_filepath) + " Prepared for Saving..."); }));

                //Convert RDB_FILEPATH to filename
                string RDB_FILENAME = Path.GetFileNameWithoutExtension(rdb_filepath);

                //ACRM_LOG_HANDLER(2, "DEBUG MESSAGE: " + RDB_FILENAME);

                //BasicStat
                #region
                if (RDB_FILENAME.Contains("_basic"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_STAT_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_STATRESOURCE ACRM_STAT_BL in ACRM_STAT_LIST)
                    {
                        //Write to the RDB
                        ACRM_STAT_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_STAT_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //CombineResource
                #region
                if (RDB_FILENAME.Contains("_mix"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_MIX_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_MIXRESOURCE ACRM_MIX_BL in ACRM_MIX_LIST)
                    {
                        //Write to the RDB
                        ACRM_MIX_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_MIX_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //EffectResource
                #region
                if (RDB_FILENAME.Contains("_effectresource"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_EFFECT_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_EFFECTRESOURCE ACRM_EFFECT_BL in ACRM_EFFECT_LIST)
                    {
                        //Write to the RDB
                        ACRM_EFFECT_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_EFFECT_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //EnhanceResource
                #region
                if (RDB_FILENAME.Contains("_enhance"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_ENHANCE_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_ENHANCERESOURCE ACRM_ENHANCE_BL in ACRM_ENHANCE_LIST)
                    {
                        //Write to the RDB
                        ACRM_ENHANCE_BL.SaveFile(bw);
                    }
                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_ENHANCE_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //FieldPropResource
                #region
                if (RDB_FILENAME.Contains("_fieldprop"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_FIELDPROP_62_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_FIELDPROPRESOURCE_62 ACRM_FIELDPROP_BL in ACRM_FIELDPROP_62_LIST)
                    {
                        //Write to the RDB
                        ACRM_FIELDPROP_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_FIELDPROP_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //ItemEffectResource
                #region
                if (RDB_FILENAME.Contains("_itemeffect"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_ITEMEFFECT_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_ITEMEFFECTRESOURCE ACRM_ITEMEFFECT_BL in ACRM_ITEMEFFECT_LIST)
                    {
                        //Write to the RDB
                        ACRM_ITEMEFFECT_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_ITEMEFFECT_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //JobResource
                #region
                if (RDB_FILENAME.Contains("_job"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_JOB_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_JOBRESOURCE ACRM_JOB_BL in ACRM_JOB_LIST)
                    {
                        //Write to the RDB
                        ACRM_JOB_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_JOB_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //ItemResource
                #region
                if (Path.GetFileNameWithoutExtension(rdb_filepath) == "db_item" || Path.GetFileNameWithoutExtension(rdb_filepath) == "db_item(ascii)")
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_ITEM_62_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_ITEMRESOURCE_62 ARCM_ITEM_BL in ACRM_ITEM_62_LIST)
                    {
                        //Write to the RDB
                        ARCM_ITEM_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_ITEM_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                 #endregion

                //MixResource
                #region
                if (RDB_FILENAME.Contains("_combine"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_MIX_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_MIXRESOURCE ACRM_MIX_BL in ACRM_MIX_LIST)
                    {
                        //Write to the RDB
                        ACRM_MIX_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_MIX_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //ModelEffectResource
                #region
                if (RDB_FILENAME.Contains("_modeleffect"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_MODELEFFECT_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_MODELEFFECTRESOURCE ACRM_MODELEFFECT_BL in ACRM_MODELEFFECT_LIST)
                    {
                        //Write to the RDB
                        ACRM_MODELEFFECT_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_MODELEFFECT_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //MonsterMotionSet
                #region
                if (RDB_FILENAME.Contains("_monstermotion"))
                {
                    //Determine which method to use for saving
                    if (ACRM_MONSTERMOTION_62_LIST.Count > 0 && ACRM_MONSTERMOTION_O71_LIST.Count == 0)
                    {
                        //Write the Row Count for this rdb
                        bw.Write(ACRM_MONSTERMOTION_62_LIST.Count);

                        //For each entry in the associated RDB Binding List
                        foreach (DB_MONSTERMOTIONSET_62 ACRM_MONSTERMOTION_62_BL in ACRM_MONSTERMOTION_62_LIST)
                        {
                            //Write to the RDB
                            ACRM_MONSTERMOTION_62_BL.SaveFile(bw);
                        }

                        //Send information output to log
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_MONSTERMOTION_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                    }
                    else if (ACRM_MONSTERMOTION_62_LIST.Count == 0 && ACRM_MONSTERMOTION_O71_LIST.Count > 0)
                    {

                    }
                    else if (ACRM_MONSTERMOTION_62_LIST.Count > 0 && ACRM_MONSTERMOTION_O71_LIST.Count > 0)
                    {

                    }
                }
                #endregion

                //MonsterResource
                #region
                if (RDB_FILENAME.Contains("db_monster"))
                {
                    //Determine which method to use for saving
                    if (ACRM_MONSTER_62_LIST.Count > 0)//&& ACRM_MONSTER_071_LIST.Count == 0)
                    {
                        //Write the Row Count for this rdb
                        bw.Write(ACRM_MONSTER_62_LIST.Count);

                        //For each entry in the associated RDB Binding List
                        foreach (DB_MONSTERRESOURCE_62 ACRM_MONSTER_BL in ACRM_MONSTER_62_LIST)
                        {
                            //Write to the RDB
                            ACRM_MONSTER_BL.SaveFile(bw);
                        }

                        //Send information output to log
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_MONSTER_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                    }
                    /*else if (ACRM_MONSTERMOTION_62_LIST.Count == 0 && ACRM_MONSTERMOTION_O71_LIST.Count > 0)
                    {

                    }
                    else if (ACRM_MONSTERMOTION_62_LIST.Count > 0 && ACRM_MONSTERMOTION_O71_LIST.Count > 0)
                    {

                    }*/
                }
                #endregion

                //NPCResource
                #region
                if (RDB_FILENAME.Contains("_npc"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_NPC_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_NPCRESOURCE ACRM_NPC_BL in ACRM_NPC_LIST)
                    {
                        //Write to the RDB
                        ACRM_NPC_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_NPC_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //QuestResource
                #region
                if (RDB_FILENAME.Contains("db_quest"))
                {
                    if (ACRM_QUEST_62_LIST.Count > 0)
                    {
                        
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_QUEST_62_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_QUESTRESOURCE_62 ACRM_QUEST_BL in ACRM_QUEST_62_LIST)
                    {
                        //Write to the RDB
                        ACRM_QUEST_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_QUEST_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                
                    }
                }
                #endregion

                //TitleResource
                #region
                if (RDB_FILENAME.Contains("db_title"))
                {
                    if (ACRM_TITLE_LIST.Count > 0)
                    {

                        //Write the Row Count for this rdb
                        bw.Write(ACRM_TITLE_LIST.Count);

                        //For each entry in the associated RDB Binding List
                        foreach (DB_TITLERESOURCE ACRM_TITLE_BL in ACRM_TITLE_LIST)
                        {
                            //Write to the RDB
                            ACRM_TITLE_BL.SaveFile(bw);
                        }

                        //Send information output to log
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_QUEST_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));

                    }
                }
                #endregion

                //SkillStage
                #region
                if (RDB_FILENAME.Contains("stage"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_SKILLSTAGE_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_SKILLSTAGE ACRM_SKILLSTAGE_BL in ACRM_SKILLSTAGE_LIST)
                    {
                        //Write to the RDB
                        ACRM_SKILLSTAGE_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_SKILLSTAGE_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //SkillTreeResource
                #region
                if (RDB_FILENAME ==  "db_skilltree" || RDB_FILENAME ==  "db_skilltree(ascii)")
                {
                    //Write the Row Count for this rdb
                    //bw.Write(ACRM_SKILLTREE_RESOURCE_62_LIST.Count);

                    int num1 = 0;
                    Int32 num2 = 0;
                    Int32 _number = 0;

                    //For each entry in the associated RDB Binding List
                    foreach (DB_SKILLTREERESOURCE_62 ACRM_SKILL_BL in ACRM_SKILLTREE_RESOURCE_62_LIST)
                    {
                        int num3 = ACRM_SKILL_BL.job_id;

                        if (num1 != num3)
                        {
                            num1 = num3;
                            num2++;
                        }
                    }

                    bw.Write(num2);

                    num1 = 0;

                    foreach (DB_SKILLTREERESOURCE_62 ACRM_SKILL_BL in ACRM_SKILLTREE_RESOURCE_62_LIST)
                    {
                        Int32 num4 = ACRM_SKILL_BL.job_id;

                        if (num1 != num4)
                        {
                            _number = ACRM_SKILL_BL.get_number(num4, ACRM_SKILLTREE_RESOURCE_62_LIST.Count, ACRM_SKILLTREE_RESOURCE_62_LIST);
                            num1 = num4;
                            bw.Write(_number);
                        }

                        bw.Write(num4);

                        //Write to the RDB
                        ACRM_SKILL_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, num2.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //StringResource
                #region
                if (RDB_FILENAME.Contains("_string"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_STRING_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_STRING ACRM_STRING_BL in ACRM_STRING_LIST)
                    {
                        //Write to the RDB
                        ACRM_STRING_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_STRING_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion

                //WorldLocation
                #region
                if (RDB_FILENAME.Contains("_world"))
                {
                    //Write the Row Count for this rdb
                    bw.Write(ACRM_ITEM_62_LIST.Count);

                    //For each entry in the associated RDB Binding List
                    foreach (DB_WORLDLOCATIONRESOURCE_62 ACRM_WORLD_BL in ACRM_WORLD_62_LIST)
                    {
                        //Write to the RDB
                        ACRM_WORLD_BL.SaveFile(bw);
                    }

                    //Send information output to log
                    this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, ACRM_WORLD_62_LIST.Count.ToString() + " Rows in " + Path.GetFileName(rdb_filepath) + " has been saved"); }));
                }
                #endregion
            }

            //Turn off the Activity Light
            ACRM_CHANGE_ACTIVITY_STATUS(false);
        }

        //Process Selected Files for Hashing
        public void ACRM_PROCESS_FILE_COLLECTION()
        {
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
        }

        #endregion

        //DB Functions:
        #region

        //Prepare to read DB Table
        public void ACRM_READ_RDB_DB_TABLE(string DBCON, string table_name)
        {
            //CombineResource
            if (table_name.ToLower() == "mix")
            {
                ACRM_TAB_MANAGER_ADD("db_combineres(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_mixresource(ascii)");
            }

            //EffectResource
            if (table_name.ToLower() == "effect")
            {
                ACRM_TAB_MANAGER_ADD("db_effectresource(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_effectresource(ascii)");
            }

            //EnhanceResource
            if (table_name.ToLower() == "enhance")
            {
                ACRM_TAB_MANAGER_ADD("db_enhance(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_enhance(ascii)");
            }

            //FieldPropResource
            if (table_name.ToLower() == "fieldprop")
            {
                ACRM_TAB_MANAGER_ADD("db_fieldpropresource(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_fieldpropresource(ascii)");
            }

            //ItemResource
            if (table_name.ToLower() == "item")
            {
                ACRM_TAB_MANAGER_ADD("db_item(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_item(ascii)");
            }

            //MonsterMotionSet
            if (table_name.ToLower() == "motionset")
            {
                ACRM_TAB_MANAGER_ADD("db_monstermotionset(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_monstermotionset(ascii)");
            }

            //ModelEffect
            if (table_name.ToLower() == "modeleffect")
            {
                ACRM_TAB_MANAGER_ADD("db_modeleffectresource(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_modeleffectresource(ascii)");
            }

            //SkillStage
            if (table_name.ToLower() == "skillstage")
            {
                ACRM_TAB_MANAGER_ADD("db_skillstage(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_skillstage(ascii)");
            }

            //SkillTreeResource
            if (table_name.ToLower() == "skilltreeresource")
            {
                ACRM_TAB_MANAGER_ADD("db_skilltree(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_skilltreeresource(ascii)");
            }

            //StatResource
            if (table_name.ToLower() == "stat")
            {
                ACRM_TAB_MANAGER_ADD("db_basicstat(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_basicstat(ascii)");
            }

            //StringResource
            if (table_name.ToLower() == "string")
            {
                ACRM_TAB_MANAGER_ADD("db_string(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_string(ascii)");
            }

            //WorldLocation
            if (table_name.ToLower() == "worldlocation")
            {
                ACRM_TAB_MANAGER_ADD("db_worldlocation(ascii)");
                ACRM_LOAD_DB_TABLE(DBCON, "db_worldlocation(ascii)");
            }
        }

        //Read the DB Table
        public void ACRM_LOAD_DB_TABLE(string DBCODN, string table_name)
        {
            try
            {
                SqlConnection ACRM_SQLCON = new SqlConnection(DBCON);

                ACRM_SQLCON.Open();

                ACRM_TAB_WORKING = true;
                ACRM_WORKING_TAB = Path.GetFileNameWithoutExtension(table_name);

                //CombineResource
                #region
                if (table_name.Contains("_mix"))
                {
                    using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_MIXRESOURCE.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                    {
                        while (ACRM_SQLREADER.Read())
                        {
                            DB_MIXRESOURCE DB_MIX_ENTRY = new DB_MIXRESOURCE();
                            DB_MIX_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                            this.Invoke((MethodInvoker)delegate { ACRM_MIX_LIST.Add(DB_MIX_ENTRY); });
                        }

                        this.Invoke((MethodInvoker)delegate
                        {
                            ACRM_TAB_WORKING = false;
                            ACRM_RDB_DGV.DataSource = ACRM_MIX_LIST;
                        });
                    }
                }
                #endregion

                //EffectResource
                #region
                if (table_name.Contains("_effectresource"))
                {
                    using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_EFFECTRESOURCE.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                    {
                        while (ACRM_SQLREADER.Read())
                        {
                            DB_EFFECTRESOURCE DB_EFFECT_ENTRY = new DB_EFFECTRESOURCE();
                            DB_EFFECT_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                            this.Invoke((MethodInvoker)delegate { ACRM_EFFECT_LIST.Add(DB_EFFECT_ENTRY); });
                        }

                        this.Invoke((MethodInvoker)delegate
                        {
                            ACRM_TAB_WORKING = false;
                            ACRM_RDB_DGV.DataSource = ACRM_EFFECT_LIST;
                        });
                    }
                }
                #endregion

                //EnhanceResource
                #region
                if (table_name.Contains("_enhance"))
                {
                    using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_ENHANCERESOURCE.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                    {
                        while (ACRM_SQLREADER.Read())
                        {
                            DB_ENHANCERESOURCE DB_ENHANCE_ENTRY = new DB_ENHANCERESOURCE();
                            DB_ENHANCE_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                            this.Invoke((MethodInvoker)delegate { ACRM_ENHANCE_LIST.Add(DB_ENHANCE_ENTRY); });
                        }
                        this.Invoke((MethodInvoker)delegate
                        {
                            ACRM_TAB_WORKING = false;
                            ACRM_RDB_DGV.DataSource = ACRM_ENHANCE_LIST;
                        });
                    }
                }
                #endregion

                //FieldPropResource
                #region
                if (table_name.Contains("_fieldprop"))
                {
                    using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_FIELDPROPRESOURCE_73.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                    {
                        while (ACRM_SQLREADER.Read())
                        {
                            DB_FIELDPROPRESOURCE_62 DB_FIELDPROP_ENTRY = new DB_FIELDPROPRESOURCE_62();
                            DB_FIELDPROP_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                            this.Invoke((MethodInvoker)delegate { ACRM_FIELDPROP_62_LIST.Add(DB_FIELDPROP_ENTRY); });
                        }
                        this.Invoke((MethodInvoker)delegate
                        {
                            ACRM_TAB_WORKING = false;
                            ACRM_RDB_DGV.DataSource = ACRM_FIELDPROP_62_LIST;
                        });
                    }
                }
                #endregion

                //ItemResource
                #region
                if (table_name.Contains("_item"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_ITEMRESOURCE_62.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_ITEMRESOURCE_62 DB_ITEM_ENTRY = new DB_ITEMRESOURCE_62();
                                DB_ITEM_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_ITEM_62_LIST.Add(DB_ITEM_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_ITEM_62_LIST;
                            });
                        }
                    }
                    catch(Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //ModelEffectResource
                #region
                if (table_name.Contains("_modeleffect"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_MODELEFFECTRESOURCE.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_MODELEFFECTRESOURCE DB_MODELEFFECT_ENTRY = new DB_MODELEFFECTRESOURCE();
                                DB_MODELEFFECT_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_MODELEFFECT_LIST.Add(DB_MODELEFFECT_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_MODELEFFECT_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //MonsterMotionSet
                #region
                if (table_name.Contains("_monstermotion"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_MONSTERMOTIONSET_62.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_MONSTERMOTIONSET_62 DB_MONSTERMOTION_ENTRY = new DB_MONSTERMOTIONSET_62();
                                DB_MONSTERMOTION_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_MONSTERMOTION_62_LIST.Add(DB_MONSTERMOTION_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_MONSTERMOTION_62_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //SkillStage
                #region
                if (table_name.Contains("stage"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_SKILLSTAGE.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_SKILLSTAGE DB_SKILLSTAGE_ENTRY = new DB_SKILLSTAGE();
                                DB_SKILLSTAGE_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_SKILLSTAGE_LIST.Add(DB_SKILLSTAGE_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_SKILLSTAGE_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //SkillTreeResource
                #region
                if (table_name.Contains("skilltreeres"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_SKILLTREERESOURCE_62.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_SKILLTREERESOURCE_62 DB_SKILLTREE_ENTRY = new DB_SKILLTREERESOURCE_62();
                                DB_SKILLTREE_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_SKILLTREE_RESOURCE_62_LIST.Add(DB_SKILLTREE_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_SKILLTREE_RESOURCE_62_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //StatResource
                #region
                if (table_name.Contains("stat"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_STATRESOURCE.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_STATRESOURCE DB_STAT_ENTRY = new DB_STATRESOURCE();
                                DB_STAT_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_STAT_LIST.Add(DB_STAT_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_STAT_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //StringResource
                #region
                if (table_name.Contains("string"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_STRING.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_STRING DB_STRING_ENTRY = new DB_STRING();
                                DB_STRING_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_STRING_LIST.Add(DB_STRING_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_STRING_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //WorldLocation
                #region
                if (table_name.Contains("location"))
                {
                    try
                    {
                        using (SqlDataReader ACRM_SQLREADER = new SqlCommand(DB_WORLDLOCATIONRESOURCE_62.FromDatabase(), ACRM_SQLCON).ExecuteReader())
                        {
                            while (ACRM_SQLREADER.Read())
                            {
                                DB_WORLDLOCATIONRESOURCE_62 DB_ITEM_ENTRY = new DB_WORLDLOCATIONRESOURCE_62();
                                DB_ITEM_ENTRY.FromDatabaseExecute(ACRM_SQLREADER);
                                this.Invoke((MethodInvoker)delegate { ACRM_WORLD_62_LIST.Add(DB_ITEM_ENTRY); });
                            }
                            this.Invoke((MethodInvoker)delegate
                            {
                                ACRM_TAB_WORKING = false;
                                ACRM_RDB_DGV.DataSource = ACRM_WORLD_62_LIST;
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        ACRM_TAB_WORKING = false;
                        MessageBox.Show(ex.Message);
                    }
                }

                ACRM_CHANGE_ACTIVITY_STATUS(false);
                ACRM_LOG_HANDLER(2, "Loading Complete!");
            }
            catch (SqlException sqlex)
            {
                this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, sqlex.Message); }));
            }
                #endregion

        }

        #endregion

        //Tab Functions:
        #region

        //Handle Dynamic Tab adding
        public void ACRM_TAB_MANAGER_PREP_TAB(string rdb)
        {
            //Check to make sure file is an rdb
            if (ACRM_PREP_RDB(rdb) == true)
            {
                //If the Tab Manager only contains the Launcher Tab
                if (ACRM_TAB_MANAGER.TabCount == 1)
                {
                    ACRM_TAB_MANAGER_ADD(rdb);
                    ACRM_READ_RDB(rdb);
                }

                //If the Tab Manager contains more than just the Launcher Tab
                else if (ACRM_TAB_MANAGER.TabCount > 1)
                {
                    //Set a flag to be modified
                    bool EXISTS = false;

                    //For each Tab Page in the Manager
                    foreach(TabPage ACRM_TAB in ACRM_TAB_MANAGER.TabPages)
                    {
                        //If the Tabs Name is the same as the RDB then
                        if (ACRM_TAB.Text == Path.GetFileNameWithoutExtension(rdb))
                        {
                            //Set the flag that this tab already exists
                            EXISTS = true;
                        }
                    }
                    //If the tab pending already exists
                    if(EXISTS)
                    {
                        ACRM_CHANGE_ACTIVITY_STATUS(false);
                        //Send error to log
                        this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, "The RDB you are trying to open is already open!"); }));
                    }
                    else
                    {
                        //Else Add the tab
                        ACRM_TAB_MANAGER_ADD(rdb);
                        //Read the rdb
                        ACRM_READ_RDB(rdb);
                    }
                }
            }
            //The user tried to load a non-rdb 
            else
            {
                ACRM_CHANGE_ACTIVITY_STATUS(false);
                this.Invoke(new MethodInvoker(delegate { ACRM_LOG_HANDLER(2, "The requested file is NOT an rdb!"); }));
            }
        }
        
        //Execute Tab Adds
        public void ACRM_TAB_MANAGER_ADD(string rdb)
        {
            //Add new tab
            this.Invoke(new MethodInvoker(delegate
            {
                ACRM_RDB_TEMP_TAB = new TabPage(Path.GetFileNameWithoutExtension(rdb));
                ACRM_RDB_DGV = new DataGridView();
                ACRM_RDB_DGV.Dock = DockStyle.Fill;
                ACRM_RDB_DGV.RowHeadersVisible = false;
                ACRM_RDB_TEMP_TAB.Controls.Add(ACRM_RDB_DGV);
                ACRM_TAB_MANAGER.TabPages.Add(ACRM_RDB_TEMP_TAB);
            }));
        }

        #endregion

        //Misc Functions:
        #region

        public void ACRM_CHANGE_ACTIVITY_STATUS(bool working)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                if (working)
                {
                    ACRM_ACTIVE_LIGHT.Visible = true;
                    ACRM_IDLE_LIGHT.Visible = false;
                }
                else
                {
                    ACRM_ACTIVE_LIGHT.Visible = false;
                    ACRM_IDLE_LIGHT.Visible = true;
                }
            }));
        }

        public void ACRM_RESOURCE_MONITOR()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                ACRM_CPU_BAR.Value = (int)ACRM_CPU_MONITOR.NextValue();
                ACRM_RAM_BAR.Value = (int)ACRM_RAM_MONITOR.NextValue();
            }));
        }

        #endregion
    }
}
