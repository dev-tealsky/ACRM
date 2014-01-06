namespace ACRM
{
    partial class ACRM_DB_SETTINGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACRM_DB_SETTINGS));
            this.label1 = new System.Windows.Forms.Label();
            this.ACRM_HOST_IP_INPUT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ACRM_HOST_PORT_INPUT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ACRM_TABLE_NAME_INPUT = new System.Windows.Forms.TextBox();
            this.ACRM_TABLE_USER_INPUT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ACRM_TABLE_PASS_INPUT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ACRM_SAVE_DB_SETTINGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host (IP):";
            // 
            // ACRM_HOST_IP_INPUT
            // 
            this.ACRM_HOST_IP_INPUT.Location = new System.Drawing.Point(69, 6);
            this.ACRM_HOST_IP_INPUT.Name = "ACRM_HOST_IP_INPUT";
            this.ACRM_HOST_IP_INPUT.Size = new System.Drawing.Size(100, 20);
            this.ACRM_HOST_IP_INPUT.TabIndex = 1;
            this.ACRM_HOST_IP_INPUT.Text = "127.0.0.1";
            this.ACRM_HOST_IP_INPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host (Port):";
            // 
            // ACRM_HOST_PORT_INPUT
            // 
            this.ACRM_HOST_PORT_INPUT.Location = new System.Drawing.Point(259, 6);
            this.ACRM_HOST_PORT_INPUT.Name = "ACRM_HOST_PORT_INPUT";
            this.ACRM_HOST_PORT_INPUT.Size = new System.Drawing.Size(55, 20);
            this.ACRM_HOST_PORT_INPUT.TabIndex = 3;
            this.ACRM_HOST_PORT_INPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arcadia Table Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "*If you use 1433 leave blank";
            // 
            // ACRM_TABLE_NAME_INPUT
            // 
            this.ACRM_TABLE_NAME_INPUT.Location = new System.Drawing.Point(125, 55);
            this.ACRM_TABLE_NAME_INPUT.Name = "ACRM_TABLE_NAME_INPUT";
            this.ACRM_TABLE_NAME_INPUT.Size = new System.Drawing.Size(189, 20);
            this.ACRM_TABLE_NAME_INPUT.TabIndex = 6;
            this.ACRM_TABLE_NAME_INPUT.Text = "e.g. Arcadia";
            this.ACRM_TABLE_NAME_INPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ACRM_TABLE_USER_INPUT
            // 
            this.ACRM_TABLE_USER_INPUT.Location = new System.Drawing.Point(125, 81);
            this.ACRM_TABLE_USER_INPUT.Name = "ACRM_TABLE_USER_INPUT";
            this.ACRM_TABLE_USER_INPUT.Size = new System.Drawing.Size(189, 20);
            this.ACRM_TABLE_USER_INPUT.TabIndex = 8;
            this.ACRM_TABLE_USER_INPUT.Text = "e.g. SA";
            this.ACRM_TABLE_USER_INPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Arcadia Table User:";
            // 
            // ACRM_TABLE_PASS_INPUT
            // 
            this.ACRM_TABLE_PASS_INPUT.Location = new System.Drawing.Point(125, 107);
            this.ACRM_TABLE_PASS_INPUT.Name = "ACRM_TABLE_PASS_INPUT";
            this.ACRM_TABLE_PASS_INPUT.Size = new System.Drawing.Size(189, 20);
            this.ACRM_TABLE_PASS_INPUT.TabIndex = 10;
            this.ACRM_TABLE_PASS_INPUT.Text = "e.g. arcadia_db_pass";
            this.ACRM_TABLE_PASS_INPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arcadia Table Pass:";
            // 
            // ACRM_SAVE_DB_SETTINGS
            // 
            this.ACRM_SAVE_DB_SETTINGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACRM_SAVE_DB_SETTINGS.Location = new System.Drawing.Point(239, 144);
            this.ACRM_SAVE_DB_SETTINGS.Name = "ACRM_SAVE_DB_SETTINGS";
            this.ACRM_SAVE_DB_SETTINGS.Size = new System.Drawing.Size(75, 23);
            this.ACRM_SAVE_DB_SETTINGS.TabIndex = 11;
            this.ACRM_SAVE_DB_SETTINGS.Text = "Save";
            this.ACRM_SAVE_DB_SETTINGS.UseVisualStyleBackColor = true;
            this.ACRM_SAVE_DB_SETTINGS.Click += new System.EventHandler(this.ACRM_SAVE_DB_SETTINGS_Click);
            // 
            // ACRM_DB_SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(331, 179);
            this.Controls.Add(this.ACRM_SAVE_DB_SETTINGS);
            this.Controls.Add(this.ACRM_TABLE_PASS_INPUT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ACRM_TABLE_USER_INPUT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ACRM_TABLE_NAME_INPUT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ACRM_HOST_PORT_INPUT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ACRM_HOST_IP_INPUT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACRM_DB_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Settings";
            this.Load += new System.EventHandler(this.ACRM_DB_SETTINGS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ACRM_HOST_IP_INPUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ACRM_HOST_PORT_INPUT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ACRM_TABLE_NAME_INPUT;
        private System.Windows.Forms.TextBox ACRM_TABLE_USER_INPUT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ACRM_TABLE_PASS_INPUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ACRM_SAVE_DB_SETTINGS;
    }
}