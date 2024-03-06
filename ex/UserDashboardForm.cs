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
    }
}
