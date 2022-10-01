namespace staff1
{
    partial class Form5
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
            this.sort_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sort_add = new System.Windows.Forms.Button();
            this.sort_remove = new System.Windows.Forms.Button();
            this.sort_selected = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.area_selected = new System.Windows.Forms.TextBox();
            this.area_remove = new System.Windows.Forms.Button();
            this.area_add = new System.Windows.Forms.Button();
            this.area_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sort_listbox
            // 
            this.sort_listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sort_listbox.ForeColor = System.Drawing.Color.White;
            this.sort_listbox.FormattingEnabled = true;
            this.sort_listbox.ItemHeight = 16;
            this.sort_listbox.Location = new System.Drawing.Point(6, 21);
            this.sort_listbox.Name = "sort_listbox";
            this.sort_listbox.Size = new System.Drawing.Size(261, 292);
            this.sort_listbox.TabIndex = 0;
            this.sort_listbox.SelectedIndexChanged += new System.EventHandler(this.Sort_listbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sort_selected);
            this.groupBox1.Controls.Add(this.sort_remove);
            this.groupBox1.Controls.Add(this.sort_add);
            this.groupBox1.Controls.Add(this.sort_listbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 381);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Information";
            // 
            // sort_add
            // 
            this.sort_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_add.Location = new System.Drawing.Point(6, 345);
            this.sort_add.Name = "sort_add";
            this.sort_add.Size = new System.Drawing.Size(104, 23);
            this.sort_add.TabIndex = 1;
            this.sort_add.Text = "Add";
            this.sort_add.UseVisualStyleBackColor = true;
            this.sort_add.Click += new System.EventHandler(this.Sort_add_Click);
            // 
            // sort_remove
            // 
            this.sort_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sort_remove.Location = new System.Drawing.Point(163, 345);
            this.sort_remove.Name = "sort_remove";
            this.sort_remove.Size = new System.Drawing.Size(104, 23);
            this.sort_remove.TabIndex = 2;
            this.sort_remove.Text = "Remove";
            this.sort_remove.UseVisualStyleBackColor = true;
            this.sort_remove.Click += new System.EventHandler(this.Sort_remove_Click);
            // 
            // sort_selected
            // 
            this.sort_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sort_selected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sort_selected.ForeColor = System.Drawing.Color.White;
            this.sort_selected.Location = new System.Drawing.Point(6, 317);
            this.sort_selected.Name = "sort_selected";
            this.sort_selected.Size = new System.Drawing.Size(261, 22);
            this.sort_selected.TabIndex = 3;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(565, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.TabIndex = 11;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(533, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.area_selected);
            this.groupBox2.Controls.Add(this.area_remove);
            this.groupBox2.Controls.Add(this.area_add);
            this.groupBox2.Controls.Add(this.area_listbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(318, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 381);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Area Information";
            // 
            // area_selected
            // 
            this.area_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.area_selected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.area_selected.ForeColor = System.Drawing.Color.White;
            this.area_selected.Location = new System.Drawing.Point(6, 317);
            this.area_selected.Name = "area_selected";
            this.area_selected.Size = new System.Drawing.Size(261, 22);
            this.area_selected.TabIndex = 3;
            // 
            // area_remove
            // 
            this.area_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area_remove.Location = new System.Drawing.Point(163, 345);
            this.area_remove.Name = "area_remove";
            this.area_remove.Size = new System.Drawing.Size(104, 23);
            this.area_remove.TabIndex = 2;
            this.area_remove.Text = "Remove";
            this.area_remove.UseVisualStyleBackColor = true;
            this.area_remove.Click += new System.EventHandler(this.Area_remove_Click);
            // 
            // area_add
            // 
            this.area_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area_add.Location = new System.Drawing.Point(6, 345);
            this.area_add.Name = "area_add";
            this.area_add.Size = new System.Drawing.Size(104, 23);
            this.area_add.TabIndex = 1;
            this.area_add.Text = "Add";
            this.area_add.UseVisualStyleBackColor = true;
            this.area_add.Click += new System.EventHandler(this.Area_add_Click);
            // 
            // area_listbox
            // 
            this.area_listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.area_listbox.ForeColor = System.Drawing.Color.White;
            this.area_listbox.FormattingEnabled = true;
            this.area_listbox.ItemHeight = 16;
            this.area_listbox.Location = new System.Drawing.Point(6, 21);
            this.area_listbox.Name = "area_listbox";
            this.area_listbox.Size = new System.Drawing.Size(261, 292);
            this.area_listbox.TabIndex = 0;
            this.area_listbox.SelectedIndexChanged += new System.EventHandler(this.Area_listbox_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(603, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form5_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox sort_listbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sort_selected;
        private System.Windows.Forms.Button sort_remove;
        private System.Windows.Forms.Button sort_add;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox area_selected;
        private System.Windows.Forms.Button area_remove;
        private System.Windows.Forms.Button area_add;
        private System.Windows.Forms.ListBox area_listbox;
    }
}