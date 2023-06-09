﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyApp.Services.Factories.Interfaces;

namespace MyApp.WinForm
{
    public partial class ViewUser : Form
    {
        protected readonly int UserId;
        protected readonly Main Main;
        protected readonly IServiceFactory ServiceFactory;

        // This form relies upon the 'Main', the DataAccess, and the UserId in order to work
        public ViewUser(Main main, IServiceFactory serviceFactory, int userId)
        {
            UserId = userId;
            Main = main;
            ServiceFactory = serviceFactory;

            InitializeComponent();
        }

        // Load the user for the display
        private void ViewUser_Load(object sender, System.EventArgs e)
        {
            // Get the user by the ID
            var user = ServiceFactory.UserService.GetById(UserId);

            if (user != null) // If we have a user then show their details
            {
                lblForename.Text = user.Forename;
                lblSurname.Text = user.Surname;
                lblIsActive.Text = (user.IsActive ? "Yes" : "No");
                lblDateOfBirth.Text = user.DateOfBirth.ToShortDateString();

                List<string> Logs = user.Logs;

                for (int i = 0; i < Logs.Count; i++)
                {
                    logs.Items.Add(Logs[i]);
                }
            }
        }

        // A back button to go back to the main list view
        private void btnBack_Click(object sender, EventArgs e)
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
