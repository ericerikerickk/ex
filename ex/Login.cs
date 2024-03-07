﻿using System;
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
        private Point _mouseLoc;

        public Login()
        {
            InitializeComponent();
            btnLogin.Enter += btnLogin_Enter;
            txtUsername.Enter += txtUsername_Enter;
            this.KeyPreview = true; 
            this.KeyDown += btnLogin_KeyDown;

        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

       

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up form = new Sign_up();
            this.Hide();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnForgotpass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Password = "";
            bool IsExist = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userTable where userName='" + txtUsername.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(2);

                IsExist = true;
            }
            con.Close();
            if (IsExist)
            {
                // Check if the username contains spaces
                if (txtUsername.Text.Contains(" "))
                {
                    MessageBox.Show("Username cannot contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Cryptography.Decrypt(Password).Equals(txtPass.Text))
                {
                    if (txtUsername.Text.Trim().Equals("admin", StringComparison.OrdinalIgnoreCase))
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
                MessageBox.Show("Please enter valid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
            txtPass.BackColor = Color.White; // Set to white on Leave
            panelPass.BackColor = Color.White;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = SystemColors.Control; // Set to light gray on Leave
            panelPass.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control; // Ensure username background color remains unchanged

        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            panelUsername.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            panelUsername.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the click event of the login button
                btnLogin.PerformClick();
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.eye__2_;
            txtPass.UseSystemPasswordChar = false;
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.hidden__1_;
            txtPass.UseSystemPasswordChar = true;
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
        }

        private void btnClose_Enter(object sender, EventArgs e)
        {
            panelUsername.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;

        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            panelPass.BackColor = Color.White;
            txtPass.BackColor = Color.White;
        }

        private void btnForgotpass_Enter(object sender, EventArgs e)
        {
            panelPass.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}
