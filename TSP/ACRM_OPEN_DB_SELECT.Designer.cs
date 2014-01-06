namespace ACRM
{
    partial class ACRM_OPEN_DB_SELECT
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Effect");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Enhance");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("FieldProp");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Item");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("ItemEffect");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Job");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Mix");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("ModelEffect");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("MotionSet");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Pet");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Summon");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("WorldLocation");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("SkillStage");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("SkillTreeResource");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Stat");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("String");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACRM_OPEN_DB_SELECT));
            this.ACRM_SET_DB_SELECTION = new System.Windows.Forms.Button();
            this.ACRM_TABLE_COLLECTION = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ACRM_SET_DB_SELECTION
            // 
            this.ACRM_SET_DB_SELECTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_SET_DB_SELECTION.Location = new System.Drawing.Point(12, 233);
            this.ACRM_SET_DB_SELECTION.Name = "ACRM_SET_DB_SELECTION";
            this.ACRM_SET_DB_SELECTION.Size = new System.Drawing.Size(241, 37);
            this.ACRM_SET_DB_SELECTION.TabIndex = 1;
            this.ACRM_SET_DB_SELECTION.Text = "Open Database(s)";
            this.ACRM_SET_DB_SELECTION.UseVisualStyleBackColor = true;
            this.ACRM_SET_DB_SELECTION.Click += new System.EventHandler(this.ACRM_SET_DB_SELECTION_Click);
            // 
            // ACRM_TABLE_COLLECTION
            // 
            this.ACRM_TABLE_COLLECTION.BackColor = System.Drawing.SystemColors.Control;
            this.ACRM_TABLE_COLLECTION.CheckBoxes = true;
            this.ACRM_TABLE_COLLECTION.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            this.ACRM_TABLE_COLLECTION.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.ACRM_TABLE_COLLECTION.Location = new System.Drawing.Point(12, 13);
            this.ACRM_TABLE_COLLECTION.Name = "ACRM_TABLE_COLLECTION";
            this.ACRM_TABLE_COLLECTION.Size = new System.Drawing.Size(241, 214);
            this.ACRM_TABLE_COLLECTION.TabIndex = 2;
            this.ACRM_TABLE_COLLECTION.UseCompatibleStateImageBehavior = false;
            this.ACRM_TABLE_COLLECTION.View = System.Windows.Forms.View.List;
            // 
            // ACRM_OPEN_DB_SELECT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(265, 282);
            this.Controls.Add(this.ACRM_TABLE_COLLECTION);
            this.Controls.Add(this.ACRM_SET_DB_SELECTION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACRM_OPEN_DB_SELECT";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Databases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ACRM_SET_DB_SELECTION;
        private System.Windows.Forms.ListView ACRM_TABLE_COLLECTION;
    }
}