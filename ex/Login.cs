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
            string Step1 = "";
            string Step2 = "";
            string Step3 = "";
            string Step4 = "";
            bool IsExistPassword = false;
            int userID = -1;
            con.Open();
            SqlCommand cmdPassword = new SqlCommand("SELECT * FROM userTable WHERE userName = '" + txtUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            SqlDataReader sdrPassword = cmdPassword.ExecuteReader();
            if (sdrPassword.Read())
            {
                Password = sdrPassword.GetString(2);
                userID = sdrPassword.GetInt32(0);
               // Step1 = sdrPassword.GetString(4);
                Step1 = sdrPassword.GetString(4);
                Step2 = sdrPassword.GetString(4);
                Step3 = sdrPassword.GetString(4);
                Step4 = sdrPassword.GetString(4);
                IsExistPassword = true;
                
            }
            con.Close();
            if (IsExistPassword)
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
                        AdminDashboard adminform = new AdminDashboard(userID);
                        this.Hide();
                        adminform.ShowDialog();
                    }
                    else if(Step1 == "Step 1")
                    {
                        Step1Form step1Form = new Step1Form(userID);
                        this.Hide();
                        step1Form.ShowDialog();
                    }
                    else if (Step2 == "Step 2")
                    {
                        Step2Form step2Form = new Step2Form(userID);
                        this.Hide();
                        step2Form.ShowDialog();
                    }
                    else if (Step3 == "Step 3")
                    {
                        Step3Form step3Form = new Step3Form(userID);
                        this.Hide();
                        step3Form.ShowDialog();
                    }
                    else if (Step4 == "Step 4")
                    {
                        Step4Form step4 = new Step4Form(userID);
                        this.Hide();
                        step4.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Successfully Logging in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserForm userform = new UserForm(userID);
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

        private void pictureBox3_MouseDown_1(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.eye__2_;
            txtPass.UseSystemPasswordChar = false;
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            txtUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignupEmployeesForm signemp = new SignupEmployeesForm();
            signemp.ShowDialog();
        }
    }
}
