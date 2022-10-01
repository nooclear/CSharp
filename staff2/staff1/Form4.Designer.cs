namespace staff1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.lB1 = new System.Windows.Forms.ListBox();
            this.cmt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_name_txtbox = new System.Windows.Forms.TextBox();
            this.add_to_lB1 = new System.Windows.Forms.Button();
            this.remove_from_lB1 = new System.Windows.Forms.Button();
            this.add_all = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.areas = new System.Windows.Forms.ListBox();
            this.sorts = new System.Windows.Forms.ListBox();
            this.cmt.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(368, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.TabIndex = 11;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(336, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // lB1
            // 
            this.lB1.AllowDrop = true;
            this.lB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lB1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lB1.ContextMenuStrip = this.cmt;
            this.lB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB1.ForeColor = System.Drawing.Color.White;
            this.lB1.FormattingEnabled = true;
            this.lB1.ItemHeight = 16;
            this.lB1.Location = new System.Drawing.Point(12, 111);
            this.lB1.Name = "lB1";
            this.lB1.Size = new System.Drawing.Size(382, 304);
            this.lB1.TabIndex = 12;
            this.lB1.SelectedIndexChanged += new System.EventHandler(this.lB1_SelectedIndexChanged);
            // 
            // cmt
            // 
            this.cmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem});
            this.cmt.Name = "cmt";
            this.cmt.Size = new System.Drawing.Size(103, 26);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // employee_name_txtbox
            // 
            this.employee_name_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employee_name_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.employee_name_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_name_txtbox.ForeColor = System.Drawing.Color.White;
            this.employee_name_txtbox.Location = new System.Drawing.Point(12, 44);
            this.employee_name_txtbox.Name = "employee_name_txtbox";
            this.employee_name_txtbox.Size = new System.Drawing.Size(382, 29);
            this.employee_name_txtbox.TabIndex = 13;
            // 
            // add_to_lB1
            // 
            this.add_to_lB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_to_lB1.BackColor = System.Drawing.Color.Transparent;
            this.add_to_lB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_to_lB1.ForeColor = System.Drawing.Color.White;
            this.add_to_lB1.Location = new System.Drawing.Point(12, 79);
            this.add_to_lB1.Name = "add_to_lB1";
            this.add_to_lB1.Size = new System.Drawing.Size(112, 26);
            this.add_to_lB1.TabIndex = 14;
            this.add_to_lB1.Text = "Add";
            this.add_to_lB1.UseVisualStyleBackColor = false;
            this.add_to_lB1.Click += new System.EventHandler(this.add_to_lB1_Click);
            // 
            // remove_from_lB1
            // 
            this.remove_from_lB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove_from_lB1.BackColor = System.Drawing.Color.Transparent;
            this.remove_from_lB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove_from_lB1.ForeColor = System.Drawing.Color.White;
            this.remove_from_lB1.Location = new System.Drawing.Point(282, 79);
            this.remove_from_lB1.Name = "remove_from_lB1";
            this.remove_from_lB1.Size = new System.Drawing.Size(112, 26);
            this.remove_from_lB1.TabIndex = 15;
            this.remove_from_lB1.Text = "Remove";
            this.remove_from_lB1.UseVisualStyleBackColor = false;
            this.remove_from_lB1.Click += new System.EventHandler(this.remove_from_lB1_Click);
            // 
            // add_all
            // 
            this.add_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_all.BackColor = System.Drawing.Color.Transparent;
            this.add_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_all.ForeColor = System.Drawing.Color.White;
            this.add_all.Location = new System.Drawing.Point(282, 608);
            this.add_all.Name = "add_all";
            this.add_all.Size = new System.Drawing.Size(112, 26);
            this.add_all.TabIndex = 19;
            this.add_all.Text = "Add Employees";
            this.add_all.UseVisualStyleBackColor = false;
            this.add_all.Click += new System.EventHandler(this.add_all_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(12, 608);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 26);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // areas
            // 
            this.areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.areas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areas.ForeColor = System.Drawing.Color.White;
            this.areas.FormattingEnabled = true;
            this.areas.ItemHeight = 16;
            this.areas.Location = new System.Drawing.Point(213, 424);
            this.areas.Name = "areas";
            this.areas.Size = new System.Drawing.Size(181, 178);
            this.areas.TabIndex = 29;
            this.areas.SelectedIndexChanged += new System.EventHandler(this.Areas_SelectedIndexChanged);
            // 
            // sorts
            // 
            this.sorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sorts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorts.ForeColor = System.Drawing.Color.White;
            this.sorts.FormattingEnabled = true;
            this.sorts.ItemHeight = 16;
            this.sorts.Location = new System.Drawing.Point(12, 424);
            this.sorts.Name = "sorts";
            this.sorts.Size = new System.Drawing.Size(181, 178);
            this.sorts.TabIndex = 28;
            this.sorts.SelectedIndexChanged += new System.EventHandler(this.Sorts_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 646);
            this.Controls.Add(this.areas);
            this.Controls.Add(this.sorts);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add_all);
            this.Controls.Add(this.remove_from_lB1);
            this.Controls.Add(this.add_to_lB1);
            this.Controls.Add(this.employee_name_txtbox);
            this.Controls.Add(this.lB1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Add Multiple";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.cmt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.ListBox lB1;
        private System.Windows.Forms.TextBox employee_name_txtbox;
        private System.Windows.Forms.Button add_to_lB1;
        private System.Windows.Forms.Button remove_from_lB1;
        private System.Windows.Forms.Button add_all;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ContextMenuStrip cmt;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ListBox areas;
        private System.Windows.Forms.ListBox sorts;
    }
}