﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class UserForm : Form
    {
        public int userName;
        public UserForm(int userName)
        {
            InitializeComponent();
            this.userName = userName;
            HelloUser.Text = "Hello" + userName;
            EditProfile edit = new EditProfile(userName);
        }
        private void sidecomponentsInactive()
        {
            panelProfileInactive.Show();
            panelDocumentsInactive.Show();
            panelDashboardInactive.Show();
        }
        public void loadForm(object form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactive.Hide();
            panelDashboardActive.Show();
            loadForm(new UserDashboard(userName));
        }


        private void labeldocs_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDocumentsInactive.Hide();
            panelDocumentsActive.Show();
            loadForm(new Documents(userName));
        }

        private void labelprofile_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelProfileInactive.Hide();
            panelProfileActive.Show();
            loadForm(new EditProfile(userName));

        }

        private void label14_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactive.Hide();
            panelDashboardActive.Show();
            loadForm(new UserDashboard(userName));
        }

        private void paneLogoutActive_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void paneLogoutActive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
