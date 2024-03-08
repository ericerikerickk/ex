using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ex
{
    public partial class SignupEmployeesForm : Form
    {
        public SignupEmployeesForm()
        {
            InitializeComponent();
            txtUsername.Select();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private Point _mouseLoc;

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        public void resetFocus()
        {
            panelUsername.BackColor = SystemColors.ButtonFace;
            panelPass.BackColor = SystemColors.ButtonFace;
            panelConfirmpass.BackColor = SystemColors.ButtonFace;
            panelGmail.BackColor = SystemColors.ButtonFace;
            panelSteps.BackColor = SystemColors.ButtonFace;
            txtUsername.BackColor = SystemColors.ButtonFace;
            txtGmail.BackColor = SystemColors.ButtonFace;
            comboSteps.BackColor = SystemColors.ButtonFace;
            txtPass.BackColor = SystemColors.ButtonFace;
            txtConfirmpass.BackColor = SystemColors.ButtonFace;

        }

        private void txtGmail_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGmail.BackColor = Color.White;
            txtGmail.BackColor = Color.White;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelUsername.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
        }

        private void comboSteps_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSteps.BackColor = Color.White;
            comboSteps.BackColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelPass.BackColor = Color.White;
            txtPass.BackColor = Color.White;
        }

        private void txtConfirmpass_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelConfirmpass.BackColor = Color.White;
            txtConfirmpass.BackColor = Color.White;
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
                            if (txtPass.Text.ToString().Trim().ToLower() == txtConfirmpass.Text.ToString().Trim().ToLower())
                            {
                                SqlCommand cmdUserName = new SqlCommand("select * from userTable where userName='" + txtUsername.Text + "'", con);
                                SqlDataReader drUserName = cmdUserName.ExecuteReader();
                                if (drUserName.Read())
                                {
                                    drUserName.Close();
                                    MessageBox.Show("Username already exist, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    con.Close();
                                    return; // Return here to exit the method
                                }
                                drUserName.Close(); // Close the DataReader here

                                SqlCommand cmdEmail = new SqlCommand("select * from userTable where email='" + txtGmail.Text + "'", con);
                                SqlDataReader drEmail = cmdEmail.ExecuteReader();
                                if (drEmail.Read())
                                {
                                    drEmail.Close();
                                    MessageBox.Show("Email already exist, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    con.Close();
                                    return; // Return here to exit the method
                                }
                                drEmail.Close(); // Close the DataReader here

                                string userName = txtUsername.Text;
                                string email = txtGmail.Text;
                                string stepDepartment = comboSteps.Text;
                                string password = Cryptography.Encrypt(txtConfirmpass.Text.ToString());
                                SqlCommand insertUserPass = new SqlCommand("insert into userTable (userName, password, email, stepDepartment) values ('" + userName + "','" + password + "','" + email + "', '" + stepDepartment + "')", con);
                                insertUserPass.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Login login = new Login();
                                login.ShowDialog();
                            }
                            else
                            {
                                con.Close();
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
            }
            else
            {
                MessageBox.Show("Please input email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void picturePass_MouseDown(object sender, MouseEventArgs e)
        {
            picturePass.Image = Properties.Resources.hidden__1_;
            txtPass.UseSystemPasswordChar = true;
        }

        private void pictureConfirmpass_MouseDown(object sender, MouseEventArgs e)
        {
            pictureConfirmpass.Image = Properties.Resources.eye__2_;
            txtConfirmpass.UseSystemPasswordChar = true;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void SignupEmployeesForm_MouseMove(object sender, MouseEventArgs e)
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
