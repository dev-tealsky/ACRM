namespace ACRM
{
    partial class ACRM_SAVE_TAB_SELECT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACRM_SAVE_TAB_SELECT));
            this.ACRM_ACTIVE_TAB_COLLECTION = new System.Windows.Forms.ListView();
            this.ACRM_SAVE_TAB_SELECTION = new System.Windows.Forms.Button();
            this.ACRM_SELECT_ALL_TABS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ACRM_ACTIVE_TAB_COLLECTION
            // 
            this.ACRM_ACTIVE_TAB_COLLECTION.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ACRM_ACTIVE_TAB_COLLECTION.BackColor = System.Drawing.SystemColors.Control;
            this.ACRM_ACTIVE_TAB_COLLECTION.CheckBoxes = true;
            this.ACRM_ACTIVE_TAB_COLLECTION.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ACRM_ACTIVE_TAB_COLLECTION.Location = new System.Drawing.Point(12, 41);
            this.ACRM_ACTIVE_TAB_COLLECTION.Name = "ACRM_ACTIVE_TAB_COLLECTION";
            this.ACRM_ACTIVE_TAB_COLLECTION.Size = new System.Drawing.Size(260, 228);
            this.ACRM_ACTIVE_TAB_COLLECTION.TabIndex = 0;
            this.ACRM_ACTIVE_TAB_COLLECTION.UseCompatibleStateImageBehavior = false;
            this.ACRM_ACTIVE_TAB_COLLECTION.View = System.Windows.Forms.View.List;
            // 
            // ACRM_SAVE_TAB_SELECTION
            // 
            this.ACRM_SAVE_TAB_SELECTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_SAVE_TAB_SELECTION.Location = new System.Drawing.Point(12, 275);
            this.ACRM_SAVE_TAB_SELECTION.Name = "ACRM_SAVE_TAB_SELECTION";
            this.ACRM_SAVE_TAB_SELECTION.Size = new System.Drawing.Size(260, 23);
            this.ACRM_SAVE_TAB_SELECTION.TabIndex = 1;
            this.ACRM_SAVE_TAB_SELECTION.Text = "Save selected tabs";
            this.ACRM_SAVE_TAB_SELECTION.UseVisualStyleBackColor = true;
            this.ACRM_SAVE_TAB_SELECTION.Click += new System.EventHandler(this.ACRM_SAVE_TAB_SELECTION_Click);
            // 
            // ACRM_SELECT_ALL_TABS
            // 
            this.ACRM_SELECT_ALL_TABS.BackColor = System.Drawing.SystemColors.Window;
            this.ACRM_SELECT_ALL_TABS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_SELECT_ALL_TABS.Location = new System.Drawing.Point(12, 12);
            this.ACRM_SELECT_ALL_TABS.Name = "ACRM_SELECT_ALL_TABS";
            this.ACRM_SELECT_ALL_TABS.Size = new System.Drawing.Size(260, 23);
            this.ACRM_SELECT_ALL_TABS.TabIndex = 2;
            this.ACRM_SELECT_ALL_TABS.Text = "Select ALL tabs";
            this.ACRM_SELECT_ALL_TABS.UseVisualStyleBackColor = false;
            this.ACRM_SELECT_ALL_TABS.Click += new System.EventHandler(this.ACRM_SELECT_ALL_TABS_Click);
            // 
            // ACRM_SAVE_TAB_SELECT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 307);
            this.Controls.Add(this.ACRM_SELECT_ALL_TABS);
            this.Controls.Add(this.ACRM_SAVE_TAB_SELECTION);
            this.Controls.Add(this.ACRM_ACTIVE_TAB_COLLECTION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACRM_SAVE_TAB_SELECT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select tabs to save";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ACRM_SAVE_TAB_SELECTION;
        public System.Windows.Forms.ListView ACRM_ACTIVE_TAB_COLLECTION;
        private System.Windows.Forms.Button ACRM_SELECT_ALL_TABS;
    }
}