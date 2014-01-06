namespace ACRM
{
    partial class ACRM_LOG_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACRM_LOG_MENU));
            this.ACRM_LOG_WINDOW = new System.Windows.Forms.RichTextBox();
            this.ACRM_CLEAR_LOGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ACRM_LOG_WINDOW
            // 
            this.ACRM_LOG_WINDOW.Location = new System.Drawing.Point(12, 12);
            this.ACRM_LOG_WINDOW.Name = "ACRM_LOG_WINDOW";
            this.ACRM_LOG_WINDOW.ReadOnly = true;
            this.ACRM_LOG_WINDOW.Size = new System.Drawing.Size(447, 232);
            this.ACRM_LOG_WINDOW.TabIndex = 1;
            this.ACRM_LOG_WINDOW.Text = "";
            // 
            // ACRM_CLEAR_LOGS
            // 
            this.ACRM_CLEAR_LOGS.Location = new System.Drawing.Point(384, 250);
            this.ACRM_CLEAR_LOGS.Name = "ACRM_CLEAR_LOGS";
            this.ACRM_CLEAR_LOGS.Size = new System.Drawing.Size(75, 23);
            this.ACRM_CLEAR_LOGS.TabIndex = 2;
            this.ACRM_CLEAR_LOGS.Text = "Clear";
            this.ACRM_CLEAR_LOGS.UseVisualStyleBackColor = true;
            this.ACRM_CLEAR_LOGS.Click += new System.EventHandler(this.ACRM_CLEAR_LOGS_Click);
            // 
            // ACRM_LOG_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 283);
            this.ControlBox = false;
            this.Controls.Add(this.ACRM_CLEAR_LOGS);
            this.Controls.Add(this.ACRM_LOG_WINDOW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACRM_LOG_MENU";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.ACRM_LOG_MENU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ACRM_LOG_WINDOW;
        private System.Windows.Forms.Button ACRM_CLEAR_LOGS;

    }
}