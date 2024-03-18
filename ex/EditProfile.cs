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
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmdEdit = new SqlCommand("UPDATE userTable SET firstName='" + txtUserFname.Text + "',lastName ='" + txtUserLname.Text + "',email='" + txtUserEmail.Text + "',contact='" + txtUserContact.Text + "',address='" + txtUserAddress.Text + "',gender='" + txtGender.Text + "' where userID ='" + user + "'", con);
                cmdEdit.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Call getData() again to update the labels with the new data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                getData();
            }
        }
        private void getData()
        {
            try
            {
                string firstName = "";
                string lastName = "";
                string contact = "";
                string email = "";
                string gender = "";
                string address = "";
                con.Open();
                SqlCommand readcmd = new SqlCommand("SELECT * FROM userTable WHERE userID = @UserID", con);
                readcmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(user));
                SqlDataReader sdrRead = readcmd.ExecuteReader();
                if (sdrRead.Read())
                {
                    // Check if the fields are null before retrieving their values
                    if (!sdrRead.IsDBNull(5))
                        firstName = sdrRead.GetString(5);
                    if (!sdrRead.IsDBNull(6))
                        lastName = sdrRead.GetString(6);
                    if (!sdrRead.IsDBNull(3))
                        email = sdrRead.GetString(3);
                    if (!sdrRead.IsDBNull(7))
                        contact = sdrRead.GetString(7);
                    if (!sdrRead.IsDBNull(8))
                        address = sdrRead.GetString(8);
                    if (!sdrRead.IsDBNull(9))
                        gender = sdrRead.GetString(9);
                }
                else
                {
                    MessageBox.Show("User not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sdrRead.Close();
                con.Close();
                lblLastName.Text = lastName;
                lblFname.Text = firstName;
                lblEmail.Text = email;
                lblContact.Text = contact;
                lblAddress.Text = address;
                lblGender.Text = gender;
                txtUserFname.Text = firstName;
                txtUserLname.Text = lastName;
                txtUserEmail.Text = email;
                txtUserContact.Text = contact;
                txtUserAddress.Text = address;
                txtGender.Text = gender;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            getData();
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

        private void txtUserFname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
            txtUserFname.BackColor = Color.White;
        }
        private void resetFocus()
        {
            panelFname.BackColor = SystemColors.ButtonFace;
            txtUserFname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            txtGender.BackColor = SystemColors.ButtonFace;
        }

        private void txtUserLname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
            txtUserLname.BackColor = Color.White;
        }

        private void txtUserEmail_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
            txtUserEmail.BackColor = Color.White;
        }

        private void txtUserContact_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
            txtUserContact.BackColor = Color.White;
        }

       

        private void applyBtn_Enter(object sender, EventArgs e)
        {
            resetFocus();
        }

        private void CancelBtn_Enter(object sender, EventArgs e)
        {
            resetFocus();
        }

        private void txtUserAddress_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelAddress.BackColor = Color.White;
            txtUserAddress.BackColor = Color.White;
        }

        private void txtGender_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
            txtGender.BackColor = Color.White;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            getData();

        }
    }
}
