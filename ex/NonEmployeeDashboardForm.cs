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
    public partial class NonEmployeeDashboardForm : Form
    {
        public NonEmployeeDashboardForm()
        {
            InitializeComponent();
        }
        public void resetFocus()
        {
            panelFname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
        }

        private void NonEmployeeDashboardForm_Load(object sender, EventArgs e)
        {
            txtFname.Focus();
        }

        private void txtFname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
        }

        private void txtLname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
        }

        private void txtContact_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelAddress.BackColor = Color.White;
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
        }
    }
}
