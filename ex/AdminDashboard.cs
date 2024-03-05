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
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panelDashboardInactive.Visible = false;
            panelDashboardActive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = true;
            panelnonemployee.Visible = false;
            panelAdmin.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void panelDashboardInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = false;
            panelDashboardActive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = true;
            panelnonemployee.Visible = false;
            panelAdmin.Visible = true;
        }

        private void nonEmployeesPanelInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = true;
            nonEmployeesPanelInactive.Visible = false;
            nonEmployeesPanelactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = true;
            panelnonemployee.Visible = true;
            panelEmployeesDashboard.Visible = false;
            txtFname.Focus();
        }

        private void panelEmployeesInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = false;
            panelEmployee.Visible = true;
            panelUserInactive.Visible = true;
            panelEmployeesDashboard.Visible = true;
            PanelUserDashboard.Visible = false;
            txtEmpFname.Focus();
        }

        private void panelUserInactive_MouseClick(object sender, MouseEventArgs e)
        {
            panelDashboardInactive.Visible = true;
            nonEmployeesPanelInactive.Visible = true;
            panelEmployeesInactive.Visible = true;
            panelUserInactive.Visible = false;
            panelUserActive.Visible = true;
            PanelUserDashboard.Visible = true;
        }
       
    }
}
