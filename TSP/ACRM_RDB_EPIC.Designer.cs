namespace ACRM
{
    partial class ACRM_RDB_EPIC
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
            this.SELECTED_RDB_EPIC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SELECTED_RDB_EPIC
            // 
            this.SELECTED_RDB_EPIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SELECTED_RDB_EPIC.FormattingEnabled = true;
            this.SELECTED_RDB_EPIC.Items.AddRange(new object[] {
            "4",
            "5",
            "6.2",
            "7.3",
            "7.4",
            "8.1",
            "8.2"});
            this.SELECTED_RDB_EPIC.Location = new System.Drawing.Point(35, 37);
            this.SELECTED_RDB_EPIC.Name = "SELECTED_RDB_EPIC";
            this.SELECTED_RDB_EPIC.Size = new System.Drawing.Size(121, 21);
            this.SELECTED_RDB_EPIC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select the RDB Epic below:";
            // 
            // ACRM_RDB_EPIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 69);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SELECTED_RDB_EPIC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ACRM_RDB_EPIC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RDB Epic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SELECTED_RDB_EPIC;
        private System.Windows.Forms.Label label1;
    }
}