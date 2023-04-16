using MyApp.Models;
using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.WinForm
{
    public partial class EditUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        public EditUser(Main main, IServiceFactory serviceFactory, int userId)
        {
            this.UserId = userId;
            this.ServiceFactory = serviceFactory;
            this.Main = main;
            InitializeComponent();
        }

        private void EditUser_Load(object sender, System.EventArgs e)
        {
            // Get the user by the ID
            var user = ServiceFactory.UserService.GetById(UserId);

            if (user != null) // If we have a user then show their details
            {
                textBoxForname.Text = user.Forename;
                textBoxSurname.Text = user.Surname;
                if (user.IsActive)
                {
                    comboBoxIsActive.SelectedIndex = 0;
                }
                else
                {
                    comboBoxIsActive.SelectedIndex = 1;
                }
                dateTimePicker.Value = user.DateOfBirth;
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            var forename = textBoxForname.Text;
            var surname = textBoxSurname.Text;
            bool isactive = true;
            if (Convert.ToString(comboBoxIsActive.SelectedItem) == "true")
            {
                isactive = true;
            }
            else if (Convert.ToString(comboBoxIsActive.SelectedItem) == "false")
            {
                isactive = false;
            }
            else
            {
                MessageBox.Show("Select a valid option.");
            }
            string date = dateTimePicker.Value.Date.ToString();
            string dateShort = date.Split(' ')[0];
            string year = dateShort.Split("/")[2];
            string month = dateShort.Split("/")[0];
            string day = dateShort.Split("/")[1];


            if (System.Text.RegularExpressions.Regex.Match(forename, @"\d+").Success)
            {
                MessageBox.Show("Forname cannot contain numbers.");
            }
            if (System.Text.RegularExpressions.Regex.Match(surname, @"\d+").Success)
            {
                MessageBox.Show("Surname cannot contain numbers.");
            }
            if (forename.Equals(""))
            {
                MessageBox.Show("Please enter a forname.");
            }
            if (surname.Equals(""))
            {
                MessageBox.Show("Please enter a surname.");
            }

            DateTime dateTime = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));

            User oldUser = ServiceFactory.UserService.GetById(UserId);

            string logMessage = DateTime.Now.ToString() +  " ~ User has been updated, ";

            User user = new User { Id = UserId, Forename = forename, Surname = surname, IsActive = isactive, DateOfBirth = dateTime, Logs = oldUser.Logs };

            if(!oldUser.Surname.Equals(surname))
            {
                logMessage += "old surname: " + oldUser.Surname + ", new surname: " + surname + " ";
            }

            if (!oldUser.Forename.Equals(forename))
            {
                logMessage += "old forename: " + oldUser.Forename + ", new forename: " + forename + " ";
            }

            if (!(oldUser.IsActive == isactive))
            {
                logMessage += "old status: " + oldUser.IsActive + ", new status: " + isactive + " ";
            }

            if (!(oldUser.DateOfBirth == dateTime))
            {
                logMessage += "old date of birth: " + oldUser.DateOfBirth.ToString() + ", new date of birth: " + dateTime.ToString() + " ";
            }

            logMessage += ".";

            System.Diagnostics.Debug.WriteLine(logMessage);

            

            user.Logs.Add(logMessage);

            ServiceFactory.UserService.Update(user);

            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Override the closing event to show the Main form again
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Main.Show();
        }
    }
}
