using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace ex
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            txtConfirmpass.BackColor = SystemColors.Control;
            panelConfirmpass.BackColor = SystemColors.Control;
        }

        private void txtConfirmpass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            txtConfirmpass.BackColor = Color.White;
            panelConfirmpass.BackColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
            txtConfirmpass.BackColor = SystemColors.Control;
            panelConfirmpass.BackColor = SystemColors.Control;

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

        private void txtPass_Leave(object sender, EventArgs e)
        {
            string password = txtPass.Text;

            if (IsValidPassword(password))
            {
                MessageBox.Show("Password is valid.");
            }
            else
            {
                MessageBox.Show("Password does not meet the requirements. The Password should have atleast one special character, one upper and lower key, and atleast 8 characters.");
            }
        }
        private bool IsValidPassword(string password)
        {
            // Regular expression to enforce password rules
            string pattern = @"^(?=.*[-!@#$%^&*()_+={}|;':""?,<.>])(?=.*[a-z])(?=.*[A-Z]).{8,}$";

            // Validate password using regular expression
            return Regex.IsMatch(password, pattern);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            con.Open();

        }
    }
}
