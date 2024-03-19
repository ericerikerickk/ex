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
    public partial class Step4Form : Form
    {
        private int userID;
        public Step4Form(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            HelloUser.Text = "Hello" + userID;
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

        private void Step4Form_Load(object sender, EventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactive.Hide();
            panelDashboardActive.Show();
            loadForm(new Step3Dashboard(userID));
        }

        private void panelDashboardInactive_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactive.Hide();
            panelDashboardActive.Show();
            loadForm(new step4Dashboard(userID));
        }

        private void labelprofile_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelProfileInactive.Hide();
            panelProfileActive.Show();
            loadForm(new EditProfile(userID));
        }

        private void panelDocumentsInactive_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDocumentsInactive.Hide();
            panelDocumentsActive.Show();
            loadForm(new STEP4(userID));
        }

        private void paneLogoutActive_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
