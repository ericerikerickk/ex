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
    }
}
