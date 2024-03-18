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
    public partial class AdminDashboard : Form
    {
        private int adminUser;
        public AdminDashboard(int adminUser)
        {
            InitializeComponent();
            this.adminUser = adminUser;
            labelHello.Text = Convert.ToString(adminUser);
        }
        private void sidecomponentsInactive()
        {
            //nonEmployeesPanelInactive.Show();
            panelDashboardInactive.Show();
            panelEmployeesInactive.Show();
            panelUserInactive.Show();
            panelDocumentsInactive.Show();
        }
        public void loadForm(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            sidecomponentsInactive();
            panelDashboardInactive.Hide();
            panelDashboardActive.Show();
            loadForm(new AdminForm());
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
        }
        private void panelDashboardInactive_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDashboardInactive.Hide();
            panelDashboardActive.Show();
            loadForm(new AdminForm());
        }
       /* private void label13_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            nonEmployeesPanelInactive.Hide();
            nonEmployeesPanelactive.Show();
            loadForm(new NonEmployeeDashboardForm());
        }*/

        private void panelEmployeesInactive_MouseClick_1(object sender, MouseEventArgs e)
        {

            sidecomponentsInactive();
            panelEmployeesInactive.Hide();
            panelEmployee.Show();
            loadForm(new EmployeesDashboardForm());
        }

        private void panelUserInactive_MouseClick_1(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelUserInactive.Hide();
            panelUserActive.Show();
            loadForm(new UserDashboardForm());
        }
        private Point _mouseLoc;

        private void mainpanel_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void mainpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panelLogoutInactive.Show();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panelLogoutInactive.Hide();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelDocumentsInactive_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDocumentsInactive.Hide();
            panelDocumentsActive.Show();
            loadForm(new DocumentForm());
        }
    }
}
