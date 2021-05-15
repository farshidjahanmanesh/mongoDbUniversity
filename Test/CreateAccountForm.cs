using MongoDB_Learning.Entities;
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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FirstNameTextbox.Text)||
                string.IsNullOrEmpty(LastNameTextbox.Text) ||
                string.IsNullOrEmpty(UsernameTextbox.Text) ||
                BirthDayPicker.Value == default(DateTime)||
                BirthDayPicker.Value ==DateTime.Now)
            {
                CreateAccountErrorLabel.Text = "fill inputs";
                CreateAccountErrorLabel.Visible = true;
                return;
            }

            IUserRepository repo = new UserRepository(Properties.Resources.DbName);
            User user = null;
            try
            {
                user = repo.GetBy(UsernameTextbox.Text);
                if (user != null)
                {
                    CreateAccountErrorLabel.Text = "this username is duplicate";
                    CreateAccountErrorLabel.Visible = true;
                    return;
                }
                repo.InsertTo(new User()
                {
                    BirthDay=BirthDayPicker.Value,
                    LastName=LastNameTextbox.Text,
                    Name=FirstNameTextbox.Text,
                    UserName=UsernameTextbox.Text
                });
                CreateAccountErrorLabel.Text = "your account created successfully";
                CreateAccountErrorLabel.ForeColor = Color.Green;
                CreateAccountErrorLabel.Visible = true;
            }
            catch (Exception ex)
            {
                CreateAccountErrorLabel.Text = ex.Message;
            }

          
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.Cast<MainForm>()
                .FirstOrDefault(c => c is MainForm);
            if(mainForm !=null)
            {
                this.Close();
                mainForm.Show();
            }
        }
    }
}
