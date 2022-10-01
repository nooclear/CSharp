namespace SteamAccountManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gb_Settings = new System.Windows.Forms.GroupBox();
            this.txt_SteamTextLoc = new System.Windows.Forms.TextBox();
            this.btn_ChangeSteamLocation = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.gb_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Settings
            // 
            this.gb_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Settings.Controls.Add(this.btn_ChangeSteamLocation);
            this.gb_Settings.Controls.Add(this.txt_SteamTextLoc);
            this.gb_Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.gb_Settings.Location = new System.Drawing.Point(12, 41);
            this.gb_Settings.Name = "gb_Settings";
            this.gb_Settings.Size = new System.Drawing.Size(849, 547);
            this.gb_Settings.TabIndex = 0;
            this.gb_Settings.TabStop = false;
            this.gb_Settings.Text = "Settings";
            // 
            // txt_SteamTextLoc
            // 
            this.txt_SteamTextLoc.Location = new System.Drawing.Point(6, 19);
            this.txt_SteamTextLoc.Name = "txt_SteamTextLoc";
            this.txt_SteamTextLoc.ReadOnly = true;
            this.txt_SteamTextLoc.Size = new System.Drawing.Size(692, 20);
            this.txt_SteamTextLoc.TabIndex = 0;
            // 
            // btn_ChangeSteamLocation
            // 
            this.btn_ChangeSteamLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeSteamLocation.Location = new System.Drawing.Point(704, 17);
            this.btn_ChangeSteamLocation.Name = "btn_ChangeSteamLocation";
            this.btn_ChangeSteamLocation.Size = new System.Drawing.Size(139, 23);
            this.btn_ChangeSteamLocation.TabIndex = 1;
            this.btn_ChangeSteamLocation.Text = "Change Steam Location";
            this.btn_ChangeSteamLocation.UseVisualStyleBackColor = true;
            this.btn_ChangeSteamLocation.Click += new System.EventHandler(this.btn_ChangeSteamLocation_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Settings.Location = new System.Drawing.Point(795, 12);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(66, 23);
            this.btn_Settings.TabIndex = 1;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(873, 600);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.gb_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Steam Account Manager";
            this.gb_Settings.ResumeLayout(false);
            this.gb_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Settings;
        private System.Windows.Forms.Button btn_ChangeSteamLocation;
        private System.Windows.Forms.TextBox txt_SteamTextLoc;
        private System.Windows.Forms.Button btn_Settings;
    }
}

