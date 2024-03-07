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
    public partial class Reset_Password : Form
    {
        private string email;
        public Reset_Password(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.eye__2_;
            txtNew.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hidden__1_;
            txtNew.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtNew_Click(object sender, EventArgs e)
        {
            txtNew.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtConfirm.BackColor = SystemColors.Control;
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            txtConfirm.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtNew.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (txtNew.Text == txtConfirm.Text)
            {
                string password = Cryptography.Encrypt(txtConfirm.Text.ToString());
                SqlCommand update = new SqlCommand("Update userTable SET password = '" + password + "' where email = '" + email + "'", con);
                update.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Information", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidPassword(string password)
        {
            // Regular expression to enforce password rules
            string pattern = @"^(?=.*[-!@#$%^&*()_+={}|;':""?,<.>])(?=.*[a-z])(?=.*[A-Z]).{8,}$";

            // Validate password using regular expression
            return Regex.IsMatch(password, pattern);
        }

        private void txtNew_Leave(object sender, EventArgs e)
        {
            string password = txtNew.Text;

            if (IsValidPassword(password))
            {
                MessageBox.Show("Password is valid.");
            }
            else
            {
                MessageBox.Show("Password does not meet the requirements. The Password should have atleast one special character, one upper and lower key, and atleast 8 characters.");
            }
        }

        private void Reset_Password_Load(object sender, EventArgs e)
        {
            txtNew.Focus();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.eye__2_;
            txtConfirm.UseSystemPasswordChar = false;

        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hidden__1_;
            txtConfirm.UseSystemPasswordChar = true;

        }
        private Point _mouseLoc;

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
    }
}
