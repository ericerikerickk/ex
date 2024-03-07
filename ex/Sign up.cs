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
            txtUsername.Select();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
            this.Hide();
            form.Show();
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
            string passwordtest = txtPass.Text;

            if (IsValidPassword(passwordtest))
            {
                con.Open();
                if (txtUsername.Text != "" && txtConfirmpass.Text != "")
                {
                    if (txtPass.Text.ToString().Trim().ToLower() == txtConfirmpass.Text.ToString().Trim().ToLower())
                    {
                        SqlCommand cmd = new SqlCommand("select * from userTable where userName='" + txtUsername.Text + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username already exist, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con.Close();
                        }
                        else
                        {
                            string userName = txtUsername.Text;
                            string password = Cryptography.Encrypt(txtConfirmpass.Text.ToString());
                            con.Close();
                            con.Open();
                            SqlCommand insertUserPass = new SqlCommand("insert into userTable (userName, password) values ('" + userName + "','" + password + "')", con);
                            insertUserPass.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password doesn't match!... Please Check...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Password does not meet the requirements. The Password should have atleast one special character, one upper and lower key, and atleast 8 characters.");
            }
            
        }

        private void btnSignup_Enter(object sender, EventArgs e)
        {
            panelConfirmpass.BackColor = SystemColors.Control;
            txtConfirmpass.BackColor = SystemColors.Control;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
        }

        private void txtConfirmpass_Enter(object sender, EventArgs e)
        {
            txtConfirmpass.BackColor = Color.White;
            panelConfirmpass.BackColor = Color.White;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
            txtPass.BackColor = Color.White; // Set password panel to white when leaving username textbox
            panelPass.BackColor = Color.White;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
        }

        private void btnClose_Enter(object sender, EventArgs e)
        {

            panelUsername.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;
            panelConfirmpass.BackColor = SystemColors.Control;
            txtConfirmpass.BackColor = SystemColors.Control;
        }

        private void txtConfirmpass_Leave(object sender, EventArgs e)
        {
            panelConfirmpass.BackColor = SystemColors.Control;
            txtConfirmpass.BackColor = SystemColors.Control;
        }
    }
}
