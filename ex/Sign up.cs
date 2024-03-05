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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;
            panelPass.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;

            txtConfirmpass.BackColor = SystemColors.Control;
            panelConfirmpass.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txtEmail.BackColor = SystemColors.Control;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            txtConfirmpass.BackColor = SystemColors.Control;
            panelConfirmpass.BackColor = SystemColors.Control;
            panelEmail.BackColor = SystemColors.Control;
            txtEmail.BackColor = SystemColors.Control;
        }

        private void txtConfirmpass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            txtConfirmpass.BackColor = Color.White;
            panelConfirmpass.BackColor = Color.White;
            panelEmail.BackColor = SystemColors.Control;
            txtEmail.BackColor = SystemColors.Control;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            txtConfirmpass.BackColor = SystemColors.Control;
            panelConfirmpass.BackColor = SystemColors.Control;
            panelEmail.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
        }

        private void picturePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void picturePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureConfirmpass_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmpass.UseSystemPasswordChar = false;
        }

        private void pictureConfirmpass_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmpass.UseSystemPasswordChar = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }
    }
}
