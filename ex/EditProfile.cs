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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace ex
{
    public partial class EditProfile : Form
    {
        private int user;
        public EditProfile(int user)
        {
            InitializeComponent();
            this.user = user;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if(txtUserFname.Text.Contains(" ") && txtUserLname.Text.Contains(" ") && txtUserEmail.Text.Contains(" ") && txtUserContact.Text.Contains(" ") && txtUserAddress.Text.Contains(" ") && txtGender.Text.Contains(" "))
            {
                MessageBox.Show("Please enter the complete details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                con.Open();
                SqlCommand cmdEdit = new SqlCommand("UPDATE userTable SET firstName='" + txtUserFname.Text + "',lastName ='" + txtUserLname.Text + "',email='" + txtUserEmail.Text + "',contact='" + txtUserContact.Text + "',address='" + txtUserAddress.Text + "',gender='" + txtGender.Text + "' where userID ='" + user + "'", con);
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
                getData();
            }

        }
        private void getData()
        {

            string firstName = "";
            string lastName = "";
            string contact = "";
            string email = "";
            string gender = "";
            string address = "";
            con.Open();
            SqlCommand readcmd = new SqlCommand("select * from userTable where userID='" + user + "'", con);
            SqlDataReader sdrRead = readcmd.ExecuteReader();
            if (sdrRead.Read())
            {
                firstName = sdrRead.GetString(5);
                lastName = sdrRead.GetString(6);
                email = sdrRead.GetString(3);
                contact = sdrRead.GetString(7);
                address = sdrRead.GetString(8);
                gender = sdrRead.GetString(9);
            }
            else
            {
                MessageBox.Show("Please edit your profile", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            lblFname.Text = firstName;
            lblLastName.Text = lastName;
            lblEmail.Text = email;
            lblContact.Text = contact;
            lblAddress.Text = address;
            lblGender.Text = gender;
        }
        private void getDataEdit()
        {
            string firstName = "";
            string lastName = "";
            string contact = "";
            string email = "";
            string gender = "";
            string address = "";
            con.Open();
            SqlCommand readcmd = new SqlCommand("select * from userTable where userName='" + user + "'", con);
            SqlDataReader sdrRead = readcmd.ExecuteReader();
            if (sdrRead.Read())
            {
                firstName = sdrRead.GetString(5);
                lastName = sdrRead.GetString(6);
                email = sdrRead.GetString(3);
                contact = sdrRead.GetString(7);
                address = sdrRead.GetString(8);
                gender = sdrRead.GetString(9);
            }
            con.Close();
            txtUserFname.Text = firstName;
            txtUserLname.Text = lastName;
            txtUserEmail.Text = email;
            txtUserContact.Text = contact;
            txtUserAddress.Text = address;
            txtGender.Text = gender;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            getDataEdit();
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
