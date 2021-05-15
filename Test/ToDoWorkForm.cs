using MongoDB.Bson;
using MongoDB_Learning.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ToDoWorkForm : Form
    {
        private Dictionary<ObjectId, int> rows = new Dictionary<ObjectId, int>();
        ObjectId nowSelected;
        public ToDoWorkForm()
        {
            InitializeComponent();
        }

        private void ToDoWorkForm_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            IToDoRepository repo = new ToDoRepository(Properties.Resources.DbName);
            var id = repo.InsertTo(new MongoDB_Learning.Entities.ToDoList()
            {
                ToDolistText = ToDoNameTextbox.Text,
                CompletedCount = 0,
                CreateTime = DateTime.Now,
                UserId = HelperId.UserId.ToString()
            });
            TodoListLabel.Text = "لیست جدید ساخته شد";
            TodoListLabel.Visible = true;
            dataGridView1.Rows.Add(ToDoNameTextbox.Text, 0, 0, DateTime.Now);
            rows.Add(id, rows.Count);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0)
                return;
            var row = selectedRows[0].Index;
            nowSelected = rows.FirstOrDefault(c => c.Value == row).Key;
            IToDoRepository repo = new ToDoRepository(Properties.Resources.DbName);
            var todos = repo.GetAllTasks(nowSelected);
            if (todos == null)
                return;
            foreach (var item in todos)
            {
                dataGridView2.Rows.Add(item.Text,
                    item.DeadLine,
                    item.Complete,
                    item.CreateDate);
            }
        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            IToDoRepository repo = new ToDoRepository(Properties.Resources.DbName);
            repo.InsertTask(nowSelected, new MongoDB_Learning.Entities.ToDo()
            {
                Complete = false,
                CreateDate = DateTime.Now,
                DeadLine = DeadLineTimePicker.Value,
                Text = TaskNameTextbox.Text
            });
            dataGridView2.Rows.Add(TaskNameTextbox.Text,
                DeadLineTimePicker.Value,
                false,
               DateTime.Now);
        }


        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;
            var taskRowNumber = e.RowIndex;
            IToDoRepository repo = new ToDoRepository(Properties.Resources.DbName);
            var status = repo.ChangeTaskStatus(nowSelected, taskRowNumber);
            dataGridView2[2, taskRowNumber].Value = status;
            RefreshItems(false);
        }

        private void RefreshItems(bool isDefault=true)
        {
            rows.Clear();
            dataGridView1.Rows.Clear();
            IToDoRepository repo = new ToDoRepository(Properties.Resources.DbName);
            var todos = repo.GetAllToDoLists();
            int i = 0;
            foreach (var item in todos)
            {
                rows.Add(item.Id, i);
                i++;
                dataGridView1.Rows.Add(item.ToDolistText,
                    item.ToDo != null ? item.ToDo.Count(c => c.Complete) : 0,
                    item.ToDo != null ? item.ToDo.Count : 0,
                    item.CreateTime);
            }
            if (isDefault == true)
                nowSelected = rows.FirstOrDefault().Key;
            else
            {
                var tasks = repo.GetAllTasks(nowSelected);

                foreach (var item in tasks)
                {
                    dataGridView2.Rows.Add(item.Text,
                        item.DeadLine,
                        item.Complete,
                        item.CreateDate);
                }
            }
        }

       
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var rowId = rows.First(c => c.Value == e.Row.Index).Key;
            IToDoRepository repo = new ToDoRepository(Properties.Resources.DbName);
            repo.Delete(rowId);
        }
    }
}
