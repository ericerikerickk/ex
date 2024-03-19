using System;
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
    public partial class Step2Form : Form
    {
        private int userID;
        
        public Step2Form(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            HelloUser.Text = "Hello" + userID;
        }
        private void sidecomponentsInactive()
        {
            panelProfileInactiveStep2.Show();
            panelDocumentsInactiveStep2.Show();
            panelDashboardInactiveStep2.Show();
        }
        public void loadForm(object form)
        {
            if (this.panel2Step2.Controls.Count > 0)
                this.panel2Step2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2Step2.Controls.Add(f);
            this.panel2Step2.Tag = f;
            f.Show();
        }
        private void panelDashboardInactiveStep2_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactiveStep2.Hide();
            panelDashboardActiveStep2.Show();
            loadForm(new Step2Dashboard(userID));
        }

        private void panelProfileInactiveStep2_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelProfileInactiveStep2.Hide();
            panelProfileActiveStep2.Show();
            loadForm(new EditProfile(userID));
        }

        private void panelDocumentsInactiveStep2_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDocumentsInactiveStep2.Hide();
            panelDocumentsActiveStep2.Show();
            loadForm(new STEP2(userID));
        }

        private void paneLogoutActive_MouseClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Step2Form_Load(object sender, EventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactiveStep2.Hide();
            panelDashboardActiveStep2.Show();
            loadForm(new Step2Dashboard(userID));
        }

        private void paneLogoutActive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
