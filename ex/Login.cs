using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ex
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;
            panelPass.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up form = new Sign_up();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnForgotpass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Password = "";
            bool IsExist = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userTable where userName='" + txtUsername.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                Password = sdr.GetString(2);
                IsExist = true;
            }
            con.Close();
            if(IsExist)
            {
                if(Cryptography.Decrypt(Password).Equals(txtPass.Text))
                {
                    if(txtUsername.Text == "admin")
                    {
                        AdminDashboard adminform = new AdminDashboard();
                        this.Hide();
                        adminform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Successfully Logging in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserForm userform = new UserForm();
                        this.Hide();
                        userform.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please eneter the valid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
