namespace ACRM
{
    partial class ACRM_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACRM_GUI));
            this.ACRM_HASH_OPERATION_STATUS_TIMER = new System.Windows.Forms.Timer(this.components);
            this.ACRM_HASHER_OPEN_FILE_DIALOG = new System.Windows.Forms.OpenFileDialog();
            this.ACRM_MENU = new System.Windows.Forms.MenuStrip();
            this.ACRM_VIEW_MENU = new System.Windows.Forms.ToolStripMenuItem();
            this.ACRM_LOAD_INFO = new System.Windows.Forms.ToolStripMenuItem();
            this.ACRM_OPEN_BASIC_INFO = new System.Windows.Forms.ToolStripMenuItem();
            this.appendixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ARCM_OPEN_THE_TEAM = new System.Windows.Forms.ToolStripMenuItem();
            this.ACRM_LOAD_LOGS = new System.Windows.Forms.ToolStripMenuItem();
            this.ACRM_EDIT_MENU = new System.Windows.Forms.ToolStripMenuItem();
            this.ACRM_EDIT_OPEN_DB_SETTINGS = new System.Windows.Forms.ToolStripMenuItem();
            this.ACRM_LAUNCHER_TAB = new System.Windows.Forms.TabPage();
            this.ACRM_HASHER_GROUP = new System.Windows.Forms.GroupBox();
            this.ACRM_HASH_OPERATING_STATUS = new System.Windows.Forms.Label();
            this.ACRM_HASHER_INFO = new System.Windows.Forms.Label();
            this.ACRM_LOAD_DB_BUTTON = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ACRM_SAVE_RDB_BUTTON = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ACRM_OPEN_RDB_BUTTON = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ACRM_TAB_MANAGER = new System.Windows.Forms.TabControl();
            this.ACRM_RDB_OPEN_FILE_DIALOG = new System.Windows.Forms.OpenFileDialog();
            this.ACRM_RDB_SAVE_FOLDER_DIALOG = new System.Windows.Forms.FolderBrowserDialog();
            this.ACRM_IDLE_LIGHT = new System.Windows.Forms.PictureBox();
            this.ACRM_ACTIVE_LIGHT = new System.Windows.Forms.PictureBox();
            this.ACRM_CPU_MONITOR = new System.Diagnostics.PerformanceCounter();
            this.ACRM_CPU_TIMER = new System.Windows.Forms.Timer(this.components);
            this.ACRM_CPU_LBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ACRM_RAM_MONITOR = new System.Diagnostics.PerformanceCounter();
            this.ACRM_RAM_BAR = new ACRM.CustomProgressBar();
            this.ACRM_CPU_BAR = new ACRM.CustomProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ACRM_MENU.SuspendLayout();
            this.ACRM_LAUNCHER_TAB.SuspendLayout();
            this.ACRM_HASHER_GROUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ACRM_TAB_MANAGER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_IDLE_LIGHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_ACTIVE_LIGHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_CPU_MONITOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_RAM_MONITOR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACRM_HASH_OPERATION_STATUS_TIMER
            // 
            this.ACRM_HASH_OPERATION_STATUS_TIMER.Enabled = true;
            this.ACRM_HASH_OPERATION_STATUS_TIMER.Interval = 3000;
            // 
            // ACRM_HASHER_OPEN_FILE_DIALOG
            // 
            this.ACRM_HASHER_OPEN_FILE_DIALOG.Multiselect = true;
            // 
            // ACRM_MENU
            // 
            this.ACRM_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ACRM_VIEW_MENU,
            this.ACRM_EDIT_MENU});
            this.ACRM_MENU.Location = new System.Drawing.Point(0, 0);
            this.ACRM_MENU.Name = "ACRM_MENU";
            this.ACRM_MENU.Size = new System.Drawing.Size(747, 24);
            this.ACRM_MENU.TabIndex = 1;
            this.ACRM_MENU.Text = "menuStrip1";
            this.ACRM_MENU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ACRM_MENU_KeyPress);
            // 
            // ACRM_VIEW_MENU
            // 
            this.ACRM_VIEW_MENU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ACRM_LOAD_INFO,
            this.ACRM_LOAD_LOGS});
            this.ACRM_VIEW_MENU.Name = "ACRM_VIEW_MENU";
            this.ACRM_VIEW_MENU.Size = new System.Drawing.Size(44, 20);
            this.ACRM_VIEW_MENU.Text = "View";
            // 
            // ACRM_LOAD_INFO
            // 
            this.ACRM_LOAD_INFO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ACRM_OPEN_BASIC_INFO,
            this.appendixToolStripMenuItem,
            this.ARCM_OPEN_THE_TEAM});
            this.ACRM_LOAD_INFO.Name = "ACRM_LOAD_INFO";
            this.ACRM_LOAD_INFO.Size = new System.Drawing.Size(95, 22);
            this.ACRM_LOAD_INFO.Text = "Info";
            // 
            // ACRM_OPEN_BASIC_INFO
            // 
            this.ACRM_OPEN_BASIC_INFO.Name = "ACRM_OPEN_BASIC_INFO";
            this.ACRM_OPEN_BASIC_INFO.Size = new System.Drawing.Size(127, 22);
            this.ACRM_OPEN_BASIC_INFO.Text = "Basic Info";
            this.ACRM_OPEN_BASIC_INFO.Click += new System.EventHandler(this.ACRM_OPEN_BASIC_INFO_Click);
            // 
            // appendixToolStripMenuItem
            // 
            this.appendixToolStripMenuItem.Name = "appendixToolStripMenuItem";
            this.appendixToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.appendixToolStripMenuItem.Text = "Appendix";
            // 
            // ARCM_OPEN_THE_TEAM
            // 
            this.ARCM_OPEN_THE_TEAM.Name = "ARCM_OPEN_THE_TEAM";
            this.ARCM_OPEN_THE_TEAM.Size = new System.Drawing.Size(127, 22);
            this.ARCM_OPEN_THE_TEAM.Text = "The Team";
            this.ARCM_OPEN_THE_TEAM.Click += new System.EventHandler(this.ARCM_OPEN_THE_TEAM_Click);
            // 
            // ACRM_LOAD_LOGS
            // 
            this.ACRM_LOAD_LOGS.Name = "ACRM_LOAD_LOGS";
            this.ACRM_LOAD_LOGS.Size = new System.Drawing.Size(95, 22);
            this.ACRM_LOAD_LOGS.Text = "Log";
            this.ACRM_LOAD_LOGS.Click += new System.EventHandler(this.ACRM_LOAD_LOGS_Click);
            // 
            // ACRM_EDIT_MENU
            // 
            this.ACRM_EDIT_MENU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ACRM_EDIT_OPEN_DB_SETTINGS});
            this.ACRM_EDIT_MENU.Name = "ACRM_EDIT_MENU";
            this.ACRM_EDIT_MENU.Size = new System.Drawing.Size(39, 20);
            this.ACRM_EDIT_MENU.Text = "Edit";
            // 
            // ACRM_EDIT_OPEN_DB_SETTINGS
            // 
            this.ACRM_EDIT_OPEN_DB_SETTINGS.Name = "ACRM_EDIT_OPEN_DB_SETTINGS";
            this.ACRM_EDIT_OPEN_DB_SETTINGS.Size = new System.Drawing.Size(167, 22);
            this.ACRM_EDIT_OPEN_DB_SETTINGS.Text = "Database Settings";
            this.ACRM_EDIT_OPEN_DB_SETTINGS.Click += new System.EventHandler(this.ACRM_EDIT_OPEN_DB_SETTINGS_Click);
            // 
            // ACRM_LAUNCHER_TAB
            // 
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.groupBox1);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.ACRM_HASHER_GROUP);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.ACRM_LOAD_DB_BUTTON);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.pictureBox3);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.ACRM_SAVE_RDB_BUTTON);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.pictureBox2);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.ACRM_OPEN_RDB_BUTTON);
            this.ACRM_LAUNCHER_TAB.Controls.Add(this.pictureBox1);
            this.ACRM_LAUNCHER_TAB.Location = new System.Drawing.Point(4, 22);
            this.ACRM_LAUNCHER_TAB.Name = "ACRM_LAUNCHER_TAB";
            this.ACRM_LAUNCHER_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.ACRM_LAUNCHER_TAB.Size = new System.Drawing.Size(715, 339);
            this.ACRM_LAUNCHER_TAB.TabIndex = 0;
            this.ACRM_LAUNCHER_TAB.Text = "Launcher";
            this.ACRM_LAUNCHER_TAB.ToolTipText = "ACRM Central Manager Tab";
            this.ACRM_LAUNCHER_TAB.UseVisualStyleBackColor = true;
            this.ACRM_LAUNCHER_TAB.DragDrop += new System.Windows.Forms.DragEventHandler(this.ACRM_FORM_RDB_DROP);
            this.ACRM_LAUNCHER_TAB.DragEnter += new System.Windows.Forms.DragEventHandler(this.ACRM_FORM_RDB_ENTER);
            // 
            // ACRM_HASHER_GROUP
            // 
            this.ACRM_HASHER_GROUP.Controls.Add(this.ACRM_HASH_OPERATING_STATUS);
            this.ACRM_HASHER_GROUP.Controls.Add(this.ACRM_HASHER_INFO);
            this.ACRM_HASHER_GROUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_HASHER_GROUP.Location = new System.Drawing.Point(36, 126);
            this.ACRM_HASHER_GROUP.Name = "ACRM_HASHER_GROUP";
            this.ACRM_HASHER_GROUP.Size = new System.Drawing.Size(644, 98);
            this.ACRM_HASHER_GROUP.TabIndex = 7;
            this.ACRM_HASHER_GROUP.TabStop = false;
            this.ACRM_HASHER_GROUP.Text = "Hasher";
            this.ACRM_HASHER_GROUP.DragDrop += new System.Windows.Forms.DragEventHandler(this.ACRM_HASHER_GROUP_DROP);
            this.ACRM_HASHER_GROUP.DragEnter += new System.Windows.Forms.DragEventHandler(this.ACRM_HASHER_GROUP_ENTER);
            // 
            // ACRM_HASH_OPERATING_STATUS
            // 
            this.ACRM_HASH_OPERATING_STATUS.AutoSize = true;
            this.ACRM_HASH_OPERATING_STATUS.Font = new System.Drawing.Font("CordiaUPC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACRM_HASH_OPERATING_STATUS.ForeColor = System.Drawing.Color.Green;
            this.ACRM_HASH_OPERATING_STATUS.Location = new System.Drawing.Point(222, 35);
            this.ACRM_HASH_OPERATING_STATUS.Name = "ACRM_HASH_OPERATING_STATUS";
            this.ACRM_HASH_OPERATING_STATUS.Size = new System.Drawing.Size(199, 33);
            this.ACRM_HASH_OPERATING_STATUS.TabIndex = 1;
            this.ACRM_HASH_OPERATING_STATUS.Text = "File Hashing Complete";
            this.ACRM_HASH_OPERATING_STATUS.Visible = false;
            // 
            // ACRM_HASHER_INFO
            // 
            this.ACRM_HASHER_INFO.AutoSize = true;
            this.ACRM_HASHER_INFO.Font = new System.Drawing.Font("CordiaUPC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACRM_HASHER_INFO.Location = new System.Drawing.Point(76, 31);
            this.ACRM_HASHER_INFO.Name = "ACRM_HASHER_INFO";
            this.ACRM_HASHER_INFO.Size = new System.Drawing.Size(478, 37);
            this.ACRM_HASHER_INFO.TabIndex = 0;
            this.ACRM_HASHER_INFO.Text = "Click here or drag file/folder to be hashed/unhashed here";
            // 
            // ACRM_LOAD_DB_BUTTON
            // 
            this.ACRM_LOAD_DB_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_LOAD_DB_BUTTON.Location = new System.Drawing.Point(354, 30);
            this.ACRM_LOAD_DB_BUTTON.Name = "ACRM_LOAD_DB_BUTTON";
            this.ACRM_LOAD_DB_BUTTON.Size = new System.Drawing.Size(94, 75);
            this.ACRM_LOAD_DB_BUTTON.TabIndex = 6;
            this.ACRM_LOAD_DB_BUTTON.Text = "OPEN DB";
            this.ACRM_LOAD_DB_BUTTON.UseVisualStyleBackColor = true;
            this.ACRM_LOAD_DB_BUTTON.Click += new System.EventHandler(this.ACRM_LOAD_DB_BUTTON_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(274, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // ACRM_SAVE_RDB_BUTTON
            // 
            this.ACRM_SAVE_RDB_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_SAVE_RDB_BUTTON.Location = new System.Drawing.Point(587, 30);
            this.ACRM_SAVE_RDB_BUTTON.Name = "ACRM_SAVE_RDB_BUTTON";
            this.ACRM_SAVE_RDB_BUTTON.Size = new System.Drawing.Size(94, 75);
            this.ACRM_SAVE_RDB_BUTTON.TabIndex = 3;
            this.ACRM_SAVE_RDB_BUTTON.Text = "SAVE RDB";
            this.ACRM_SAVE_RDB_BUTTON.UseVisualStyleBackColor = true;
            this.ACRM_SAVE_RDB_BUTTON.Click += new System.EventHandler(this.ACRM_SAVE_RDB_BUTTON_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(506, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ACRM_OPEN_RDB_BUTTON
            // 
            this.ACRM_OPEN_RDB_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_OPEN_RDB_BUTTON.Location = new System.Drawing.Point(119, 30);
            this.ACRM_OPEN_RDB_BUTTON.Name = "ACRM_OPEN_RDB_BUTTON";
            this.ACRM_OPEN_RDB_BUTTON.Size = new System.Drawing.Size(94, 75);
            this.ACRM_OPEN_RDB_BUTTON.TabIndex = 1;
            this.ACRM_OPEN_RDB_BUTTON.Text = "OPEN RDB";
            this.ACRM_OPEN_RDB_BUTTON.UseVisualStyleBackColor = true;
            this.ACRM_OPEN_RDB_BUTTON.Click += new System.EventHandler(this.ACRM_OPEN_RDB_BUTTON_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ACRM_TAB_MANAGER
            // 
            this.ACRM_TAB_MANAGER.Controls.Add(this.ACRM_LAUNCHER_TAB);
            this.ACRM_TAB_MANAGER.Cursor = System.Windows.Forms.Cursors.Default;
            this.ACRM_TAB_MANAGER.HotTrack = true;
            this.ACRM_TAB_MANAGER.Location = new System.Drawing.Point(12, 30);
            this.ACRM_TAB_MANAGER.Name = "ACRM_TAB_MANAGER";
            this.ACRM_TAB_MANAGER.SelectedIndex = 0;
            this.ACRM_TAB_MANAGER.Size = new System.Drawing.Size(723, 365);
            this.ACRM_TAB_MANAGER.TabIndex = 0;
            this.ACRM_TAB_MANAGER.DoubleClick += new System.EventHandler(this.ACRE_TAB_MANAGER_DoubleClick);
            // 
            // ACRM_RDB_OPEN_FILE_DIALOG
            // 
            this.ACRM_RDB_OPEN_FILE_DIALOG.Multiselect = true;
            // 
            // ACRM_IDLE_LIGHT
            // 
            this.ACRM_IDLE_LIGHT.Image = ((System.Drawing.Image)(resources.GetObject("ACRM_IDLE_LIGHT.Image")));
            this.ACRM_IDLE_LIGHT.Location = new System.Drawing.Point(712, 397);
            this.ACRM_IDLE_LIGHT.Name = "ACRM_IDLE_LIGHT";
            this.ACRM_IDLE_LIGHT.Size = new System.Drawing.Size(19, 20);
            this.ACRM_IDLE_LIGHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ACRM_IDLE_LIGHT.TabIndex = 8;
            this.ACRM_IDLE_LIGHT.TabStop = false;
            this.ACRM_IDLE_LIGHT.Visible = false;
            // 
            // ACRM_ACTIVE_LIGHT
            // 
            this.ACRM_ACTIVE_LIGHT.Image = ((System.Drawing.Image)(resources.GetObject("ACRM_ACTIVE_LIGHT.Image")));
            this.ACRM_ACTIVE_LIGHT.Location = new System.Drawing.Point(712, 397);
            this.ACRM_ACTIVE_LIGHT.Name = "ACRM_ACTIVE_LIGHT";
            this.ACRM_ACTIVE_LIGHT.Size = new System.Drawing.Size(19, 20);
            this.ACRM_ACTIVE_LIGHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ACRM_ACTIVE_LIGHT.TabIndex = 9;
            this.ACRM_ACTIVE_LIGHT.TabStop = false;
            this.ACRM_ACTIVE_LIGHT.Visible = false;
            // 
            // ACRM_CPU_MONITOR
            // 
            this.ACRM_CPU_MONITOR.CategoryName = "Processor";
            this.ACRM_CPU_MONITOR.CounterName = "% Processor Time";
            this.ACRM_CPU_MONITOR.InstanceName = "_Total";
            // 
            // ACRM_CPU_TIMER
            // 
            this.ACRM_CPU_TIMER.Enabled = true;
            this.ACRM_CPU_TIMER.Interval = 1000;
            this.ACRM_CPU_TIMER.Tick += new System.EventHandler(this.ACRM_CPU_TIMER_Tick);
            // 
            // ACRM_CPU_LBL
            // 
            this.ACRM_CPU_LBL.AutoSize = true;
            this.ACRM_CPU_LBL.Location = new System.Drawing.Point(13, 401);
            this.ACRM_CPU_LBL.Name = "ACRM_CPU_LBL";
            this.ACRM_CPU_LBL.Size = new System.Drawing.Size(32, 13);
            this.ACRM_CPU_LBL.TabIndex = 12;
            this.ACRM_CPU_LBL.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "RAM:";
            // 
            // ACRM_RAM_MONITOR
            // 
            this.ACRM_RAM_MONITOR.CategoryName = "Memory";
            this.ACRM_RAM_MONITOR.CounterName = "% Committed Bytes In Use";
            // 
            // ACRM_RAM_BAR
            // 
            this.ACRM_RAM_BAR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ACRM_RAM_BAR.Location = new System.Drawing.Point(172, 397);
            this.ACRM_RAM_BAR.Name = "ACRM_RAM_BAR";
            this.ACRM_RAM_BAR.Size = new System.Drawing.Size(68, 20);
            this.ACRM_RAM_BAR.TabIndex = 11;
            // 
            // ACRM_CPU_BAR
            // 
            this.ACRM_CPU_BAR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ACRM_CPU_BAR.Location = new System.Drawing.Point(51, 397);
            this.ACRM_CPU_BAR.Name = "ACRM_CPU_BAR";
            this.ACRM_CPU_BAR.Size = new System.Drawing.Size(68, 20);
            this.ACRM_CPU_BAR.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load RDB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Or drag .RDB here to load";
            // 
            // ACRM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(747, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ACRM_CPU_LBL);
            this.Controls.Add(this.ACRM_RAM_BAR);
            this.Controls.Add(this.ACRM_CPU_BAR);
            this.Controls.Add(this.ACRM_ACTIVE_LIGHT);
            this.Controls.Add(this.ACRM_IDLE_LIGHT);
            this.Controls.Add(this.ACRM_TAB_MANAGER);
            this.Controls.Add(this.ACRM_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ACRM_MENU;
            this.MaximizeBox = false;
            this.Name = "ACRM_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Client Resource Manager";
            this.Load += new System.EventHandler(this.ACRM_GUI_Load);
            this.ACRM_MENU.ResumeLayout(false);
            this.ACRM_MENU.PerformLayout();
            this.ACRM_LAUNCHER_TAB.ResumeLayout(false);
            this.ACRM_LAUNCHER_TAB.PerformLayout();
            this.ACRM_HASHER_GROUP.ResumeLayout(false);
            this.ACRM_HASHER_GROUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ACRM_TAB_MANAGER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_IDLE_LIGHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_ACTIVE_LIGHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_CPU_MONITOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACRM_RAM_MONITOR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ACRM_HASH_OPERATION_STATUS_TIMER;
        private System.Windows.Forms.OpenFileDialog ACRM_HASHER_OPEN_FILE_DIALOG;
        private System.Windows.Forms.MenuStrip ACRM_MENU;
        private System.Windows.Forms.ToolStripMenuItem ACRM_VIEW_MENU;
        public System.Windows.Forms.ToolStripMenuItem ACRM_LOAD_LOGS;
        private System.Windows.Forms.TabPage ACRM_LAUNCHER_TAB;
        private System.Windows.Forms.GroupBox ACRM_HASHER_GROUP;
        private System.Windows.Forms.Label ACRM_HASH_OPERATING_STATUS;
        private System.Windows.Forms.Label ACRM_HASHER_INFO;
        private System.Windows.Forms.Button ACRM_LOAD_DB_BUTTON;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ACRM_SAVE_RDB_BUTTON;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ACRM_OPEN_RDB_BUTTON;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TabControl ACRM_TAB_MANAGER;
        private System.Windows.Forms.OpenFileDialog ACRM_RDB_OPEN_FILE_DIALOG;
        private System.Windows.Forms.ToolStripMenuItem ACRM_LOAD_INFO;
        private System.Windows.Forms.ToolStripMenuItem ACRM_OPEN_BASIC_INFO;
        private System.Windows.Forms.ToolStripMenuItem appendixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ARCM_OPEN_THE_TEAM;
        private System.Windows.Forms.ToolStripMenuItem ACRM_EDIT_MENU;
        private System.Windows.Forms.ToolStripMenuItem ACRM_EDIT_OPEN_DB_SETTINGS;
        private System.Windows.Forms.FolderBrowserDialog ACRM_RDB_SAVE_FOLDER_DIALOG;
        private System.Windows.Forms.PictureBox ACRM_IDLE_LIGHT;
        private System.Windows.Forms.PictureBox ACRM_ACTIVE_LIGHT;
        private System.Diagnostics.PerformanceCounter ACRM_CPU_MONITOR;
        private System.Windows.Forms.Timer ACRM_CPU_TIMER;
        private CustomProgressBar ACRM_CPU_BAR;
        private CustomProgressBar ACRM_RAM_BAR;
        private System.Windows.Forms.Label ACRM_CPU_LBL;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.PerformanceCounter ACRM_RAM_MONITOR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

