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
    public partial class EmployeesDashboardForm : Form
    {
        public EmployeesDashboardForm()
        {
            InitializeComponent();
        }
        public void resetFocus()
        {
            panelFname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            PanelAddress.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelSteps.BackColor = SystemColors.ButtonFace;
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpAddress.BackColor = SystemColors.ButtonFace;
            comboBox2.BackColor = SystemColors.ButtonFace;
            comboSteps.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;


        }

        private void txtEmpFname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
        }

        private void EmployeesDashboardForm_Load(object sender, EventArgs e)
        {
            txtEmpFname.Focus();
        }

        private void txtEmpLname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
        }

        private void txtempEmail_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
        }

        private void txtEmpContact_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
        }

        private void txtEmpAddress_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            PanelAddress.BackColor = Color.White;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
        }

        private void txtEmpSearch_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
        }

        private void txtEmpLname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
            txtEmpLname.BackColor = Color.White;
        }

        private void txtEmpFname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
            txtEmpFname.BackColor = Color.White;
        }

        private void txtempEmail_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
            txtempEmail.BackColor = Color.White;
        }

        private void txtEmpContact_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
            txtEmpContact.BackColor = Color.White;
        }

        private void txtEmpAddress_Enter(object sender, EventArgs e)
        {
            resetFocus();
            PanelAddress.BackColor = Color.White;
            txtEmpAddress.BackColor = Color.White;
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
        }

        private void comboSteps_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSteps.BackColor = Color.White;
            comboSteps.BackColor = Color.White;
        }

        private void txtEmpSearch_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
            txtEmpSearch.BackColor = Color.White;
        }

        private void button6_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
            txtEmpSearch.BackColor = Color.White;
        }
    }
}
