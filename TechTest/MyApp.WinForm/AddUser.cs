using Microsoft.VisualBasic.ApplicationServices;
using MyApp.Models;
using MyApp.Services.Factories.Implementations;
using MyApp.Services.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.WinForm
{
    public partial class AddUser : Form
    {
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;
        public AddUser(Main main, IServiceFactory serviceFactory)
        {
            InitializeComponent();
            Main = main;
            this.ServiceFactory = serviceFactory;
        }

        private void AddUser_Load(object sender, System.EventArgs e)
        {
            comboBoxIsActive.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var forname = textBoxForname.Text;
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


            if (System.Text.RegularExpressions.Regex.Match(forname, @"\d+").Success)
            {
                MessageBox.Show("Forname cannot contain numbers.");
            }
            if (System.Text.RegularExpressions.Regex.Match(surname, @"\d+").Success)
            {
                MessageBox.Show("Surname cannot contain numbers.");
            }
            if (forname.Equals(""))
            {
                MessageBox.Show("Please enter a forname.");
            }
            if (surname.Equals(""))
            {
                MessageBox.Show("Please enter a surname.");
            }

            DateTime dateTime = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));

            Models.User user = new Models.User { Forename = forname, Surname = surname, IsActive = isactive, DateOfBirth = dateTime };

            string logMessage = DateTime.Now.ToString() + " ~ User has been created.";

            user.Logs.Add(logMessage);

            ServiceFactory.UserService.Create(user);

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
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
