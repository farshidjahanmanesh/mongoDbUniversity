using MongoDB_Learning.Entities;
using MongoDB_Learning.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MainForm : Form
    {

       

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTextbox.Text))
            {
                LoginErrorLabel.Text = "please fill input";
                LoginErrorLabel.Visible = true;
                return;
            }
            IUserRepository repo = new UserRepository(Properties.Resources.DbName);
            User user = null;
            try
            {
                 user = repo.GetBy(UserNameTextbox.Text);
            }
            catch (Exception ex)
            {
                LoginErrorLabel.Text = ex.Message;
            }
           
            if (user == null)
            {
                LoginErrorLabel.Text = "username is incorrect";
                LoginErrorLabel.Visible = true;
                return;
            }
            HelperId.UserId = user.Id;
            this.Hide();
            ToDoWorkForm todo = new ToDoWorkForm();
            todo.Show();
            
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            this.Hide();
            createAccount.ShowDialog();
        }
    }
}
