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
using System.Drawing.Drawing2D;
namespace ex
{
    public partial class Sign_up : Form
    {
        private Point _mouseLoc;

        public Sign_up()
        {
            InitializeComponent();
            txtUsername.Select();
            this.KeyPreview = true;
            this.KeyDown += btnSignup_KeyDown;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;
            resetFocus();


        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            resetFocus();


            txtPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;

        }

        private void txtConfirmpass_Click(object sender, EventArgs e)
        {
            resetFocus();


            txtConfirmpass.BackColor = Color.White;
            panelConfirmpass.BackColor = Color.White;

        }
        private void picturePass_MouseUp(object sender, MouseEventArgs e)
        {
            picturePass.Image = Properties.Resources.hidden__1_;
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureConfirmpass_MouseUp(object sender, MouseEventArgs e)
        {
            pictureConfirmpass.Image = Properties.Resources.hidden__1_;
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
            bool isExist = false;
            con.Open();
            SqlCommand cmdEmail = new SqlCommand("select email from userTable where email='" + txtGmail.Text + "'", con) ;
            SqlDataReader sdrEmail = cmdEmail.ExecuteReader();
            if(sdrEmail.Read())
            {
                isExist = true;
            }
            con.Close();
            if(isExist)
            {
                MessageBox.Show("Email that you've enered is already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Regex mRegxExpression;
                if (txtGmail.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@gmail\.com$");

                    if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                    {
                        MessageBox.Show("E-mail address must end with @gmail.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string passwordtest = txtPass.Text;

                        if (IsValidPassword(passwordtest))
                        {
                            con.Open();
                            if (txtUsername.Text != "" && txtConfirmpass.Text != "" && txtGmail.Text != "")
                            {
                                if (txtPass.Text.Trim().ToLower() == txtConfirmpass.Text.Trim().ToLower())
                                {
                                    // Convert the username to lower case for comparison
                                    string username = txtUsername.Text;
                                    SqlCommand cmd = new SqlCommand("SELECT * FROM userTable WHERE LOWER(userName) = @Username", con);
                                    cmd.Parameters.AddWithValue("@Username", username);
                                    SqlDataReader dr = cmd.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        dr.Close();
                                        MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        con.Close();
                                    }
                                    else
                                    {
                                        string email = txtGmail.Text;
                                        string password = Cryptography.Encrypt(txtConfirmpass.Text);
                                        con.Close();
                                        con.Open();
                                        SqlCommand insertUserPass = new SqlCommand("INSERT INTO userTable (userName, password, email) VALUES (@UserName, @Password, @Email)", con);
                                        insertUserPass.Parameters.AddWithValue("@UserName", username);
                                        insertUserPass.Parameters.AddWithValue("@Password", password);
                                        insertUserPass.Parameters.AddWithValue("@Email", email);
                                        insertUserPass.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                        Login login = new Login();
                                        login.ShowDialog();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password and Confirm Password don't match! Please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password does not meet the requirements. The password should have at least one special character, one upper and lower case letter, and at least 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please input email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }


        private void btnSignup_Enter(object sender, EventArgs e)
        {
            resetFocus();

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            resetFocus();
            txtUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            resetFocus();
            txtPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
        }

        private void txtConfirmpass_Enter(object sender, EventArgs e)
        {
            resetFocus();
            txtConfirmpass.BackColor = Color.White;
            panelConfirmpass.BackColor = Color.White;
        }
        private void btnClose_Enter(object sender, EventArgs e)
        {
            resetFocus();
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            panelGmail.BackColor = SystemColors.Control;
            txtGmail.BackColor = SystemColors.Control;
            Regex mRegxExpression;
            if (txtGmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@gmail\.com$");

                if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address must end with @gmail.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtGmail_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGmail.BackColor = Color.White;
            txtGmail.BackColor = Color.White;
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

        private void picturePass_MouseDown_1(object sender, MouseEventArgs e)
        {
            picturePass.Image = Properties.Resources.hidden__1_;
            txtPass.UseSystemPasswordChar = true;
        }

        private void pictureConfirmpass_MouseDown(object sender, MouseEventArgs e)
        {
            pictureConfirmpass.Image = Properties.Resources.eye__2_;
            txtConfirmpass.UseSystemPasswordChar = true;
        }
        public void resetFocus()
        {
            panelUsername.BackColor = SystemColors.ButtonFace;
            panelPass.BackColor = SystemColors.ButtonFace;
            panelConfirmpass.BackColor = SystemColors.ButtonFace;
            panelGmail.BackColor = SystemColors.ButtonFace;
            txtUsername.BackColor = SystemColors.ButtonFace;
            txtGmail.BackColor = SystemColors.ButtonFace;
            txtPass.BackColor = SystemColors.ButtonFace;
            txtConfirmpass.BackColor = SystemColors.ButtonFace;

        }

        private void btnSignup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the click event of the login button
                btnSignup.PerformClick();
            }
        }
    }
}
