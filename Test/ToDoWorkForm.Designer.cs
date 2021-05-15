
namespace Test
{
    partial class ToDoWorkForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDoNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateListButton = new System.Windows.Forms.Button();
            this.TodoListLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TextData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeadLineTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameList,
            this.CompletedCount,
            this.TaskCount,
            this.CreateTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(601, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // NameList
            // 
            this.NameList.HeaderText = "NameList";
            this.NameList.MinimumWidth = 6;
            this.NameList.Name = "NameList";
            this.NameList.ReadOnly = true;
            this.NameList.Width = 125;
            // 
            // CompletedCount
            // 
            this.CompletedCount.HeaderText = "CompletedCount";
            this.CompletedCount.MinimumWidth = 6;
            this.CompletedCount.Name = "CompletedCount";
            this.CompletedCount.ReadOnly = true;
            this.CompletedCount.Width = 125;
            // 
            // TaskCount
            // 
            this.TaskCount.HeaderText = "TaskCount";
            this.TaskCount.MinimumWidth = 6;
            this.TaskCount.Name = "TaskCount";
            this.TaskCount.ReadOnly = true;
            this.TaskCount.Width = 125;
            // 
            // CreateTime
            // 
            this.CreateTime.HeaderText = "CreateTime";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 125;
            // 
            // ToDoNameTextbox
            // 
            this.ToDoNameTextbox.Location = new System.Drawing.Point(276, 453);
            this.ToDoNameTextbox.Name = "ToDoNameTextbox";
            this.ToDoNameTextbox.Size = new System.Drawing.Size(182, 27);
            this.ToDoNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Do Name";
            // 
            // CreateListButton
            // 
            this.CreateListButton.Location = new System.Drawing.Point(151, 528);
            this.CreateListButton.Name = "CreateListButton";
            this.CreateListButton.Size = new System.Drawing.Size(193, 29);
            this.CreateListButton.TabIndex = 3;
            this.CreateListButton.Text = "Create New ToDo list";
            this.CreateListButton.UseVisualStyleBackColor = true;
            this.CreateListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // TodoListLabel
            // 
            this.TodoListLabel.AutoSize = true;
            this.TodoListLabel.Location = new System.Drawing.Point(201, 505);
            this.TodoListLabel.Name = "TodoListLabel";
            this.TodoListLabel.Size = new System.Drawing.Size(93, 20);
            this.TodoListLabel.TabIndex = 4;
            this.TodoListLabel.Text = "To Do Name";
            this.TodoListLabel.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextData,
            this.DeadLine,
            this.Completed,
            this.CreatedDate});
            this.dataGridView2.Location = new System.Drawing.Point(811, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(565, 319);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // TextData
            // 
            this.TextData.HeaderText = "TextData";
            this.TextData.MinimumWidth = 6;
            this.TextData.Name = "TextData";
            this.TextData.ReadOnly = true;
            this.TextData.Width = 125;
            // 
            // DeadLine
            // 
            this.DeadLine.HeaderText = "DeadLine";
            this.DeadLine.MinimumWidth = 6;
            this.DeadLine.Name = "DeadLine";
            this.DeadLine.ReadOnly = true;
            this.DeadLine.Width = 125;
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Completed";
            this.Completed.MaxInputLength = 1;
            this.Completed.MinimumWidth = 6;
            this.Completed.Name = "Completed";
            this.Completed.ReadOnly = true;
            this.Completed.Width = 125;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 125;
            // 
            // TaskNameTextbox
            // 
            this.TaskNameTextbox.Location = new System.Drawing.Point(1102, 337);
            this.TaskNameTextbox.Name = "TaskNameTextbox";
            this.TaskNameTextbox.Size = new System.Drawing.Size(274, 27);
            this.TaskNameTextbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(942, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Task Name";
            // 
            // DeadLineTimePicker
            // 
            this.DeadLineTimePicker.Location = new System.Drawing.Point(1102, 370);
            this.DeadLineTimePicker.Name = "DeadLineTimePicker";
            this.DeadLineTimePicker.Size = new System.Drawing.Size(274, 27);
            this.DeadLineTimePicker.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(942, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "DeadLine";
            // 
            // CreateTask
            // 
            this.CreateTask.Location = new System.Drawing.Point(1008, 427);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(187, 29);
            this.CreateTask.TabIndex = 11;
            this.CreateTask.Text = "Create Task";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // ToDoWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 569);
            this.Controls.Add(this.CreateTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeadLineTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskNameTextbox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.TodoListLabel);
            this.Controls.Add(this.CreateListButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToDoNameTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ToDoWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ToDoWorkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.TextBox ToDoNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateListButton;
        private System.Windows.Forms.Label TodoListLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox TaskNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DeadLineTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}