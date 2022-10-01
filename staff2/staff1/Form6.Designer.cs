namespace staff1
{
    partial class Form6
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
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.hourSelect = new System.Windows.Forms.ComboBox();
            this.minSelect = new System.Windows.Forms.ComboBox();
            this.shiftSelect = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Staffing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_LastWeekTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_KeyEntered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BagsKeyed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BagsCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BagsLinked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BagsReproduced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Exceptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PackageOverride = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MissedBags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PackagesMissedBags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_NumofDuplicates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_NumofUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ScannedFlowperHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ScannedFlowperQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_TotalDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_QuarterSmalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Smalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_LastWeekLoads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Processed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ProcessRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(762, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.TabIndex = 13;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(730, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 26);
            this.minimize.TabIndex = 12;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_StartTime,
            this.dgv_Staffing,
            this.dgv_LastWeekTotal,
            this.dgv_Total,
            this.dgv_KeyEntered,
            this.dgv_BagsKeyed,
            this.dgv_BagsCreated,
            this.dgv_BagsLinked,
            this.dgv_BagsReproduced,
            this.dgv_Exceptions,
            this.dgv_PackageOverride,
            this.dgv_MissedBags,
            this.dgv_PackagesMissedBags,
            this.dgv_NumofDuplicates,
            this.dgv_NumofUsers,
            this.dgv_ScannedFlowperHour,
            this.dgv_ScannedFlowperQuarter,
            this.dgv_TotalDifference,
            this.dgv_QuarterSmalls,
            this.dgv_Smalls,
            this.dgv_LastWeekLoads,
            this.dgv_Processed,
            this.dgv_ProcessRate});
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // hourSelect
            // 
            this.hourSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hourSelect.FormattingEnabled = true;
            this.hourSelect.Location = new System.Drawing.Point(682, 417);
            this.hourSelect.Name = "hourSelect";
            this.hourSelect.Size = new System.Drawing.Size(50, 21);
            this.hourSelect.TabIndex = 16;
            // 
            // minSelect
            // 
            this.minSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minSelect.FormattingEnabled = true;
            this.minSelect.Location = new System.Drawing.Point(738, 417);
            this.minSelect.Name = "minSelect";
            this.minSelect.Size = new System.Drawing.Size(50, 21);
            this.minSelect.TabIndex = 17;
            // 
            // shiftSelect
            // 
            this.shiftSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shiftSelect.FormattingEnabled = true;
            this.shiftSelect.Items.AddRange(new object[] {
            "Sunrise",
            "Morning",
            "Day",
            "Twilight",
            "Night"});
            this.shiftSelect.Location = new System.Drawing.Point(682, 390);
            this.shiftSelect.Name = "shiftSelect";
            this.shiftSelect.Size = new System.Drawing.Size(106, 21);
            this.shiftSelect.TabIndex = 18;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(69, 352);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 85);
            this.textBox1.TabIndex = 19;
            // 
            // dgv_StartTime
            // 
            this.dgv_StartTime.HeaderText = "Start Time";
            this.dgv_StartTime.Name = "dgv_StartTime";
            this.dgv_StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_Staffing
            // 
            this.dgv_Staffing.HeaderText = "Staffing";
            this.dgv_Staffing.Name = "dgv_Staffing";
            this.dgv_Staffing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_Staffing.Width = 50;
            // 
            // dgv_LastWeekTotal
            // 
            this.dgv_LastWeekTotal.HeaderText = "Last Week Total";
            this.dgv_LastWeekTotal.Name = "dgv_LastWeekTotal";
            this.dgv_LastWeekTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_Total
            // 
            this.dgv_Total.HeaderText = "Total";
            this.dgv_Total.Name = "dgv_Total";
            this.dgv_Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_KeyEntered
            // 
            this.dgv_KeyEntered.HeaderText = "Key Entered";
            this.dgv_KeyEntered.Name = "dgv_KeyEntered";
            this.dgv_KeyEntered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_KeyEntered.Width = 25;
            // 
            // dgv_BagsKeyed
            // 
            this.dgv_BagsKeyed.HeaderText = "Bags Keyed";
            this.dgv_BagsKeyed.Name = "dgv_BagsKeyed";
            this.dgv_BagsKeyed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_BagsKeyed.Width = 25;
            // 
            // dgv_BagsCreated
            // 
            this.dgv_BagsCreated.HeaderText = "Bags Created";
            this.dgv_BagsCreated.Name = "dgv_BagsCreated";
            this.dgv_BagsCreated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_BagsCreated.Width = 75;
            // 
            // dgv_BagsLinked
            // 
            this.dgv_BagsLinked.HeaderText = "Bags Linked";
            this.dgv_BagsLinked.Name = "dgv_BagsLinked";
            // 
            // dgv_BagsReproduced
            // 
            this.dgv_BagsReproduced.HeaderText = "Bags Reproduced";
            this.dgv_BagsReproduced.Name = "dgv_BagsReproduced";
            this.dgv_BagsReproduced.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_BagsReproduced.Width = 25;
            // 
            // dgv_Exceptions
            // 
            this.dgv_Exceptions.HeaderText = "Exceptions";
            this.dgv_Exceptions.Name = "dgv_Exceptions";
            this.dgv_Exceptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_Exceptions.Width = 25;
            // 
            // dgv_PackageOverride
            // 
            this.dgv_PackageOverride.HeaderText = "Pkg Override";
            this.dgv_PackageOverride.Name = "dgv_PackageOverride";
            this.dgv_PackageOverride.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_PackageOverride.Width = 25;
            // 
            // dgv_MissedBags
            // 
            this.dgv_MissedBags.HeaderText = "Missed Bags";
            this.dgv_MissedBags.Name = "dgv_MissedBags";
            this.dgv_MissedBags.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_MissedBags.Width = 75;
            // 
            // dgv_PackagesMissedBags
            // 
            this.dgv_PackagesMissedBags.HeaderText = "Pkgs in Missed Bags";
            this.dgv_PackagesMissedBags.Name = "dgv_PackagesMissedBags";
            this.dgv_PackagesMissedBags.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_PackagesMissedBags.Width = 75;
            // 
            // dgv_NumofDuplicates
            // 
            this.dgv_NumofDuplicates.HeaderText = "# of Duplicates";
            this.dgv_NumofDuplicates.Name = "dgv_NumofDuplicates";
            this.dgv_NumofDuplicates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_NumofDuplicates.Width = 75;
            // 
            // dgv_NumofUsers
            // 
            this.dgv_NumofUsers.HeaderText = "# of Users";
            this.dgv_NumofUsers.Name = "dgv_NumofUsers";
            this.dgv_NumofUsers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_NumofUsers.Width = 50;
            // 
            // dgv_ScannedFlowperHour
            // 
            this.dgv_ScannedFlowperHour.HeaderText = "Scanned Flow/Hour";
            this.dgv_ScannedFlowperHour.Name = "dgv_ScannedFlowperHour";
            this.dgv_ScannedFlowperHour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_ScannedFlowperHour.Width = 80;
            // 
            // dgv_ScannedFlowperQuarter
            // 
            this.dgv_ScannedFlowperQuarter.HeaderText = "Scanned Flow/15";
            this.dgv_ScannedFlowperQuarter.Name = "dgv_ScannedFlowperQuarter";
            this.dgv_ScannedFlowperQuarter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_ScannedFlowperQuarter.Width = 80;
            // 
            // dgv_TotalDifference
            // 
            this.dgv_TotalDifference.HeaderText = "Difference Now/LastWeek";
            this.dgv_TotalDifference.Name = "dgv_TotalDifference";
            this.dgv_TotalDifference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_QuarterSmalls
            // 
            this.dgv_QuarterSmalls.HeaderText = "15 Min Smalls";
            this.dgv_QuarterSmalls.Name = "dgv_QuarterSmalls";
            this.dgv_QuarterSmalls.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_QuarterSmalls.Width = 75;
            // 
            // dgv_Smalls
            // 
            this.dgv_Smalls.HeaderText = "Smalls";
            this.dgv_Smalls.Name = "dgv_Smalls";
            // 
            // dgv_LastWeekLoads
            // 
            this.dgv_LastWeekLoads.HeaderText = "Last Week Loads";
            this.dgv_LastWeekLoads.Name = "dgv_LastWeekLoads";
            this.dgv_LastWeekLoads.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_LastWeekLoads.Width = 50;
            // 
            // dgv_Processed
            // 
            this.dgv_Processed.HeaderText = "Processed";
            this.dgv_Processed.Name = "dgv_Processed";
            this.dgv_Processed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_Processed.Width = 50;
            // 
            // dgv_ProcessRate
            // 
            this.dgv_ProcessRate.HeaderText = "Process Rate";
            this.dgv_ProcessRate.Name = "dgv_ProcessRate";
            this.dgv_ProcessRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_ProcessRate.Width = 75;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shiftSelect);
            this.Controls.Add(this.minSelect);
            this.Controls.Add(this.hourSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hourSelect;
        private System.Windows.Forms.ComboBox minSelect;
        private System.Windows.Forms.ComboBox shiftSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Staffing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_LastWeekTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_KeyEntered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BagsKeyed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BagsCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BagsLinked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BagsReproduced;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Exceptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_PackageOverride;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MissedBags;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_PackagesMissedBags;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_NumofDuplicates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_NumofUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ScannedFlowperHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ScannedFlowperQuarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_TotalDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_QuarterSmalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Smalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_LastWeekLoads;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Processed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ProcessRate;
    }
}