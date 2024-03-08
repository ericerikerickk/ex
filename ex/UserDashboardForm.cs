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
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
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
            txtUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
            comboBox3.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;

        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            txtUserFname.Focus();
        }

        private void txtUserFname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
        }

        private void txtUserLname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
        }

        private void txtUserEmail_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelEmail.Focus();
        }

        private void txtUserContact_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
        }

        private void txtUserAddress_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelAddress.BackColor = Color.White;
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
        }

        private void txtUserSearch_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
        }

        private void txtUserLname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
            txtUserLname.BackColor = Color.White;
        }

        private void txtUserFname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
            txtUserFname.BackColor = Color.White;
        }

        private void txtUserEmail_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
            txtUserEmail.BackColor = Color.White;
        }

        private void txtUserContact_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
            txtUserContact.BackColor = Color.White;
        }

        private void txtUserAddress_Enter(object sender, EventArgs e)
        {

            resetFocus();
            panelAddress.BackColor = Color.White;
            txtUserAddress.BackColor = Color.White;
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
        }

        private void txtUserSearch_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
            txtUserSearch.BackColor = Color.White;
        }

        private void button9_Enter(object sender, EventArgs e)
        {
            resetFocus();
        }
    }
}
