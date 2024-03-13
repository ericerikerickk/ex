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
    public partial class EditProfile : Form
    {
        private string user;
        public EditProfile(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(txtUserFname.Text == " " && txtUserLname.Text == " " && txtUserEmail.Text == "" && txtUserContact.Text == "" && txtUserAddress.Text == "" && txtGender.Text == "")
            {
                con.Open();
                SqlCommand cmdEdit = new SqlCommand("UPDATE userTable SET firstName='" + txtUserFname.Text + "', lastName ='" + txtUserLname.Text + "', email='" + txtUserEmail.Text + "', contact='" + txtUserContact.Text + "', address='" + txtUserAddress.Text + "', gender='" + txtGender.Text + "' where userName ='" + user + "'", con);
                cmdEdit.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                editBtn.Show();
                applyBtn.Hide();
                txtUserFname.Visible = false;
                txtUserLname.Visible = false;
                txtUserEmail.Visible = false;
                txtUserContact.Visible = false;
                txtUserAddress.Visible = false;
                txtGender.Visible = false;
                lblFname.Visible = true;
                lblLastName.Visible = true;
                lblEmail.Visible = true;
                lblContact.Visible = true;
                lblAddress.Visible = true;
                lblGender.Visible = true;
                CancelBtn.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter the complete details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        
        private void editBtn_Click(object sender, EventArgs e)
        {
            CancelBtn.Visible = true;
            txtUserFname.Visible = true;
            txtUserLname.Visible = true;
            txtUserEmail.Visible = true;
            txtUserContact.Visible = true;
            txtUserAddress.Visible = true;
            txtGender.Visible = true;
            lblFname.Visible = false;
            lblLastName.Visible = false;
            lblEmail.Visible = false;
            lblContact.Visible = false;
            lblAddress.Visible = false;
            lblGender.Visible = false;
            panelFname.BackColor = Color.White;
            txtUserFname.BackColor = Color.White;
            txtUserFname.Focus();
            editBtn.Hide();
            applyBtn.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            editBtn.Show();
            applyBtn.Hide();
            txtUserFname.Visible = false;
            txtUserLname.Visible = false;
            txtUserEmail.Visible = false;
            txtUserContact.Visible = false;
            txtUserAddress.Visible = false;
            txtGender.Visible = false;
            lblFname.Visible = true;
            lblLastName.Visible = true;
            lblEmail.Visible = true;
            lblContact.Visible = true;
            lblAddress.Visible = true;
            lblGender.Visible = true;
            CancelBtn.Visible = false;
        }
    }
}
