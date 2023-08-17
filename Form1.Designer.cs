namespace Task_Management_Tool_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgTaskData = new DataGridView();
            btnShowPendingTasks = new Button();
            btnShowCompleted = new Button();
            btnCompleteTask = new Button();
            btnAddTask = new Button();
            lblEnterTaskTitle = new Label();
            lblDueDate = new Label();
            lblStatus = new Label();
            txtTitle = new TextBox();
            dtpDueDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnShowAll = new Button();
            lblKeyWord = new Label();
            txtKeyword = new TextBox();
            btnKeywordFilter = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblDateFilter = new Label();
            btnDateRangeFilter = new Button();
            btnCountCompleted = new Button();
            btnCountPending = new Button();
            btnGroupTasks = new Button();
            btnDisplayTaskStatus = new Button();
            btnSortByDate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgTaskData).BeginInit();
            SuspendLayout();
            // 
            // dtgTaskData
            // 
            dtgTaskData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTaskData.Location = new Point(0, 0);
            dtgTaskData.Name = "dtgTaskData";
            dtgTaskData.RowHeadersWidth = 51;
            dtgTaskData.RowTemplate.Height = 29;
            dtgTaskData.Size = new Size(484, 188);
            dtgTaskData.TabIndex = 0;
            // 
            // btnShowPendingTasks
            // 
            btnShowPendingTasks.Location = new Point(12, 238);
            btnShowPendingTasks.Name = "btnShowPendingTasks";
            btnShowPendingTasks.Size = new Size(191, 29);
            btnShowPendingTasks.TabIndex = 1;
            btnShowPendingTasks.Text = "Show pending tasks";
            btnShowPendingTasks.UseVisualStyleBackColor = true;
            btnShowPendingTasks.Click += button1_Click;
            // 
            // btnShowCompleted
            // 
            btnShowCompleted.Location = new Point(12, 273);
            btnShowCompleted.Name = "btnShowCompleted";
            btnShowCompleted.Size = new Size(191, 29);
            btnShowCompleted.TabIndex = 2;
            btnShowCompleted.Text = "Show completed tasks";
            btnShowCompleted.UseVisualStyleBackColor = true;
            btnShowCompleted.Click += button2_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(12, 203);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(191, 29);
            btnCompleteTask.TabIndex = 3;
            btnCompleteTask.Text = "Complete task";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += button3_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(297, 318);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(117, 29);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += button4_Click;
            // 
            // lblEnterTaskTitle
            // 
            lblEnterTaskTitle.AutoSize = true;
            lblEnterTaskTitle.Location = new Point(223, 203);
            lblEnterTaskTitle.Name = "lblEnterTaskTitle";
            lblEnterTaskTitle.Size = new Size(103, 20);
            lblEnterTaskTitle.TabIndex = 5;
            lblEnterTaskTitle.Text = "Enter task title";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(223, 240);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(112, 20);
            lblDueDate.TabIndex = 6;
            lblDueDate.Text = "Select due date";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(223, 277);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(355, 200);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 8;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(355, 237);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Done" });
            cmbStatus.Location = new Point(297, 274);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 10;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(12, 308);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(191, 29);
            btnShowAll.TabIndex = 11;
            btnShowAll.Text = "Show all tasks";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += button5_Click;
            // 
            // lblKeyWord
            // 
            lblKeyWord.AutoSize = true;
            lblKeyWord.Location = new Point(12, 409);
            lblKeyWord.Name = "lblKeyWord";
            lblKeyWord.Size = new Size(125, 20);
            lblKeyWord.TabIndex = 12;
            lblKeyWord.Text = "Filter by keyword:";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(156, 402);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(151, 27);
            txtKeyword.TabIndex = 13;
            // 
            // btnKeywordFilter
            // 
            btnKeywordFilter.Location = new Point(156, 437);
            btnKeywordFilter.Name = "btnKeywordFilter";
            btnKeywordFilter.Size = new Size(94, 29);
            btnKeywordFilter.TabIndex = 14;
            btnKeywordFilter.Text = "Filter";
            btnKeywordFilter.UseVisualStyleBackColor = true;
            btnKeywordFilter.Click += button6_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(521, 368);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 15;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(521, 404);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 16;
            // 
            // lblDateFilter
            // 
            lblDateFilter.AutoSize = true;
            lblDateFilter.Location = new Point(521, 345);
            lblDateFilter.Name = "lblDateFilter";
            lblDateFilter.Size = new Size(141, 20);
            lblDateFilter.TabIndex = 17;
            lblDateFilter.Text = "Filter by date range:";
            // 
            // btnDateRangeFilter
            // 
            btnDateRangeFilter.Location = new Point(521, 437);
            btnDateRangeFilter.Name = "btnDateRangeFilter";
            btnDateRangeFilter.Size = new Size(94, 29);
            btnDateRangeFilter.TabIndex = 18;
            btnDateRangeFilter.Text = "Filter";
            btnDateRangeFilter.UseVisualStyleBackColor = true;
            btnDateRangeFilter.Click += button7_Click;
            // 
            // btnCountCompleted
            // 
            btnCountCompleted.Location = new Point(508, 12);
            btnCountCompleted.Name = "btnCountCompleted";
            btnCountCompleted.Size = new Size(222, 29);
            btnCountCompleted.TabIndex = 19;
            btnCountCompleted.Text = "Count completed tasks";
            btnCountCompleted.UseVisualStyleBackColor = true;
            btnCountCompleted.Click += button8_Click;
            // 
            // btnCountPending
            // 
            btnCountPending.Location = new Point(508, 47);
            btnCountPending.Name = "btnCountPending";
            btnCountPending.Size = new Size(222, 29);
            btnCountPending.TabIndex = 20;
            btnCountPending.Text = "Count pending tasks";
            btnCountPending.UseVisualStyleBackColor = true;
            btnCountPending.Click += button9_Click;
            // 
            // btnGroupTasks
            // 
            btnGroupTasks.Location = new Point(511, 82);
            btnGroupTasks.Name = "btnGroupTasks";
            btnGroupTasks.Size = new Size(219, 29);
            btnGroupTasks.TabIndex = 21;
            btnGroupTasks.Text = "Group tasks";
            btnGroupTasks.UseVisualStyleBackColor = true;
            btnGroupTasks.Click += button10_Click;
            // 
            // btnDisplayTaskStatus
            // 
            btnDisplayTaskStatus.Location = new Point(508, 117);
            btnDisplayTaskStatus.Name = "btnDisplayTaskStatus";
            btnDisplayTaskStatus.Size = new Size(222, 29);
            btnDisplayTaskStatus.TabIndex = 22;
            btnDisplayTaskStatus.Text = "Display task and status only";
            btnDisplayTaskStatus.UseVisualStyleBackColor = true;
            btnDisplayTaskStatus.Click += button11_Click;
            // 
            // btnSortByDate
            // 
            btnSortByDate.Location = new Point(508, 152);
            btnSortByDate.Name = "btnSortByDate";
            btnSortByDate.Size = new Size(222, 29);
            btnSortByDate.TabIndex = 23;
            btnSortByDate.Text = "Sort based on due date";
            btnSortByDate.UseVisualStyleBackColor = true;
            btnSortByDate.Click += button12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 516);
            Controls.Add(btnSortByDate);
            Controls.Add(btnDisplayTaskStatus);
            Controls.Add(btnGroupTasks);
            Controls.Add(btnCountPending);
            Controls.Add(btnCountCompleted);
            Controls.Add(btnDateRangeFilter);
            Controls.Add(lblDateFilter);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnKeywordFilter);
            Controls.Add(txtKeyword);
            Controls.Add(lblKeyWord);
            Controls.Add(btnShowAll);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDueDate);
            Controls.Add(txtTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblDueDate);
            Controls.Add(lblEnterTaskTitle);
            Controls.Add(btnAddTask);
            Controls.Add(btnCompleteTask);
            Controls.Add(btnShowCompleted);
            Controls.Add(btnShowPendingTasks);
            Controls.Add(dtgTaskData);
            Name = "Form1";
            Text = "Task Management Tool";
            ((System.ComponentModel.ISupportInitialize)dtgTaskData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgTaskData;
        private Button btnShowPendingTasks;
        private Button btnShowCompleted;
        private Button btnCompleteTask;
        private Button btnAddTask;
        private Label lblEnterTaskTitle;
        private Label lblDueDate;
        private Label lblStatus;
        private TextBox txtTitle;
        private DateTimePicker dtpDueDate;
        private ComboBox cmbStatus;
        private Button btnShowAll;
        private Label lblKeyWord;
        private TextBox txtKeyword;
        private Button btnKeywordFilter;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblDateFilter;
        private Button btnDateRangeFilter;
        private Button btnCountCompleted;
        private Button btnCountPending;
        private Button btnGroupTasks;
        private Button btnDisplayTaskStatus;
        private Button btnSortByDate;
    }
}