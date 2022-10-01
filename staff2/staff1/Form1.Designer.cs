namespace staff1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.new_inc = new System.Windows.Forms.Button();
            this.new_sub = new System.Windows.Forms.Button();
            this.new_total = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staffing_display = new System.Windows.Forms.TextBox();
            this.list_view = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.area = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time_in = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time_out = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.search_box = new System.Windows.Forms.TextBox();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.staffing_left = new System.Windows.Forms.TextBox();
            this.add_left = new System.Windows.Forms.Button();
            this.sub_left = new System.Windows.Forms.Button();
            this.sub_current = new System.Windows.Forms.Button();
            this.add_current = new System.Windows.Forms.Button();
            this.filterByList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSortsAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_inc
            // 
            this.new_inc.BackColor = System.Drawing.Color.Transparent;
            this.new_inc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_inc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_inc.ForeColor = System.Drawing.Color.Cyan;
            this.new_inc.Location = new System.Drawing.Point(6, 19);
            this.new_inc.Name = "new_inc";
            this.new_inc.Size = new System.Drawing.Size(40, 46);
            this.new_inc.TabIndex = 1;
            this.new_inc.Text = "+";
            this.new_inc.UseVisualStyleBackColor = false;
            this.new_inc.Click += new System.EventHandler(this.new_inc_Click);
            // 
            // new_sub
            // 
            this.new_sub.BackColor = System.Drawing.Color.Transparent;
            this.new_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_sub.ForeColor = System.Drawing.Color.Cyan;
            this.new_sub.Location = new System.Drawing.Point(280, 19);
            this.new_sub.Name = "new_sub";
            this.new_sub.Size = new System.Drawing.Size(40, 46);
            this.new_sub.TabIndex = 2;
            this.new_sub.Text = "-";
            this.new_sub.UseVisualStyleBackColor = false;
            this.new_sub.Click += new System.EventHandler(this.new_sub_Click);
            // 
            // new_total
            // 
            this.new_total.BackColor = System.Drawing.Color.Black;
            this.new_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_total.ForeColor = System.Drawing.Color.Cyan;
            this.new_total.Location = new System.Drawing.Point(113, 11);
            this.new_total.Name = "new_total";
            this.new_total.ReadOnly = true;
            this.new_total.Size = new System.Drawing.Size(100, 55);
            this.new_total.TabIndex = 3;
            this.new_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.new_inc);
            this.groupBox1.Controls.Add(this.new_sub);
            this.groupBox1.Controls.Add(this.new_total);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(149, 706);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Hires";
            // 
            // staffing_display
            // 
            this.staffing_display.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffing_display.BackColor = System.Drawing.Color.Black;
            this.staffing_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffing_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffing_display.ForeColor = System.Drawing.Color.Lime;
            this.staffing_display.Location = new System.Drawing.Point(511, 718);
            this.staffing_display.Name = "staffing_display";
            this.staffing_display.ReadOnly = true;
            this.staffing_display.Size = new System.Drawing.Size(100, 55);
            this.staffing_display.TabIndex = 5;
            this.staffing_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_view
            // 
            this.list_view.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.list_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.list_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.sort,
            this.area,
            this.time_in,
            this.time_out});
            this.list_view.ContextMenuStrip = this.contextMenuStrip1;
            this.list_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_view.ForeColor = System.Drawing.Color.White;
            this.list_view.FullRowSelect = true;
            this.list_view.HideSelection = false;
            this.list_view.Location = new System.Drawing.Point(12, 73);
            this.list_view.MultiSelect = false;
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(599, 403);
            this.list_view.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_view.TabIndex = 6;
            this.list_view.UseCompatibleStateImageBehavior = false;
            this.list_view.View = System.Windows.Forms.View.Details;
            this.list_view.DoubleClick += new System.EventHandler(this.list_view_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 225;
            // 
            // sort
            // 
            this.sort.Text = "Sort";
            this.sort.Width = 88;
            // 
            // area
            // 
            this.area.Text = "Area";
            this.area.Width = 97;
            // 
            // time_in
            // 
            this.time_in.Text = "Time In";
            this.time_in.Width = 85;
            // 
            // time_out
            // 
            this.time_out.Text = "Time Out";
            this.time_out.Width = 87;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.editToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.logToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oldToolStripMenuItem,
            this.currentToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // oldToolStripMenuItem
            // 
            this.oldToolStripMenuItem.Name = "oldToolStripMenuItem";
            this.oldToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.oldToolStripMenuItem.Text = "Old";
            this.oldToolStripMenuItem.Click += new System.EventHandler(this.oldToolStripMenuItem_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItem.Text = "Edit Employees";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.multipleToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.addToolStripMenuItem.Text = "Add Employee(s)";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // multipleToolStripMenuItem
            // 
            this.multipleToolStripMenuItem.Name = "multipleToolStripMenuItem";
            this.multipleToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.multipleToolStripMenuItem.Text = "Multiple";
            this.multipleToolStripMenuItem.Click += new System.EventHandler(this.multipleToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.editToolStripMenuItem1.Text = "Edit Selected Employee";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.removeToolStripMenuItem.Text = "Remove Selected Employee";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem1
            // 
            this.logToolStripMenuItem1.Checked = true;
            this.logToolStripMenuItem1.CheckOnClick = true;
            this.logToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logToolStripMenuItem1.Name = "logToolStripMenuItem1";
            this.logToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.logToolStripMenuItem1.Text = "Log";
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.White;
            this.search_box.Location = new System.Drawing.Point(75, 43);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(536, 29);
            this.search_box.TabIndex = 7;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(553, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.TabIndex = 8;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(585, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // staffing_left
            // 
            this.staffing_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffing_left.BackColor = System.Drawing.Color.Black;
            this.staffing_left.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffing_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffing_left.ForeColor = System.Drawing.Color.Red;
            this.staffing_left.Location = new System.Drawing.Point(12, 718);
            this.staffing_left.Name = "staffing_left";
            this.staffing_left.ReadOnly = true;
            this.staffing_left.Size = new System.Drawing.Size(100, 55);
            this.staffing_left.TabIndex = 17;
            this.staffing_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_left
            // 
            this.add_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_left.BackColor = System.Drawing.Color.Transparent;
            this.add_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_left.ForeColor = System.Drawing.Color.White;
            this.add_left.Location = new System.Drawing.Point(118, 718);
            this.add_left.Name = "add_left";
            this.add_left.Size = new System.Drawing.Size(25, 20);
            this.add_left.TabIndex = 18;
            this.add_left.Text = "+";
            this.add_left.UseVisualStyleBackColor = false;
            this.add_left.Click += new System.EventHandler(this.add_left_Click);
            // 
            // sub_left
            // 
            this.sub_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sub_left.BackColor = System.Drawing.Color.Transparent;
            this.sub_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub_left.ForeColor = System.Drawing.Color.White;
            this.sub_left.Location = new System.Drawing.Point(118, 751);
            this.sub_left.Name = "sub_left";
            this.sub_left.Size = new System.Drawing.Size(25, 20);
            this.sub_left.TabIndex = 19;
            this.sub_left.Text = "-";
            this.sub_left.UseVisualStyleBackColor = false;
            this.sub_left.Click += new System.EventHandler(this.sub_left_Click);
            // 
            // sub_current
            // 
            this.sub_current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sub_current.BackColor = System.Drawing.Color.Transparent;
            this.sub_current.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub_current.ForeColor = System.Drawing.Color.White;
            this.sub_current.Location = new System.Drawing.Point(482, 753);
            this.sub_current.Name = "sub_current";
            this.sub_current.Size = new System.Drawing.Size(23, 20);
            this.sub_current.TabIndex = 21;
            this.sub_current.Text = "-";
            this.sub_current.UseVisualStyleBackColor = false;
            this.sub_current.Click += new System.EventHandler(this.sub_current_Click);
            // 
            // add_current
            // 
            this.add_current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_current.BackColor = System.Drawing.Color.Transparent;
            this.add_current.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_current.ForeColor = System.Drawing.Color.White;
            this.add_current.Location = new System.Drawing.Point(482, 718);
            this.add_current.Name = "add_current";
            this.add_current.Size = new System.Drawing.Size(23, 20);
            this.add_current.TabIndex = 20;
            this.add_current.Text = "+";
            this.add_current.UseVisualStyleBackColor = false;
            this.add_current.Click += new System.EventHandler(this.add_current_Click);
            // 
            // filterByList
            // 
            this.filterByList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.filterByList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterByList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.filterByList.ContextMenuStrip = this.contextMenuStrip2;
            this.filterByList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterByList.ForeColor = System.Drawing.Color.White;
            this.filterByList.FullRowSelect = true;
            this.filterByList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.filterByList.HideSelection = false;
            this.filterByList.Location = new System.Drawing.Point(6, 21);
            this.filterByList.MultiSelect = false;
            this.filterByList.Name = "filterByList";
            this.filterByList.Size = new System.Drawing.Size(587, 191);
            this.filterByList.TabIndex = 22;
            this.filterByList.UseCompatibleStateImageBehavior = false;
            this.filterByList.View = System.Windows.Forms.View.Details;
            this.filterByList.DoubleClick += new System.EventHandler(this.FilterByList_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 561;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSortsAreasToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(158, 48);
            // 
            // editSortsAreasToolStripMenuItem
            // 
            this.editSortsAreasToolStripMenuItem.Name = "editSortsAreasToolStripMenuItem";
            this.editSortsAreasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editSortsAreasToolStripMenuItem.Text = "Edit Sorts/Areas";
            this.editSortsAreasToolStripMenuItem.Click += new System.EventHandler(this.EditSortsAreasToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.groupBox2.Controls.Add(this.filterByList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 218);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 785);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.list_view);
            this.Controls.Add(this.sub_current);
            this.Controls.Add(this.add_current);
            this.Controls.Add(this.sub_left);
            this.Controls.Add(this.add_left);
            this.Controls.Add(this.staffing_left);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.staffing_display);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Staffing Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button new_inc;
        private System.Windows.Forms.Button new_sub;
        private System.Windows.Forms.TextBox new_total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox staffing_display;
        private System.Windows.Forms.ListView list_view;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader sort;
        private System.Windows.Forms.ColumnHeader time_in;
        private System.Windows.Forms.ColumnHeader time_out;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox staffing_left;
        private System.Windows.Forms.Button add_left;
        private System.Windows.Forms.Button sub_left;
        private System.Windows.Forms.Button sub_current;
        private System.Windows.Forms.Button add_current;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader area;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem1;
        private System.Windows.Forms.ListView filterByList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editSortsAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

