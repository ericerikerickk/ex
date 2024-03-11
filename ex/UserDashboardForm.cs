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
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
            loadDataGrid();
            dataGridView3.CellClick += dataGridView3_CellClick;
        }
        public void resetFocus()
        {
            panelFname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            panelAddress.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            txtUserFname.BackColor = SystemColors.ButtonFace;
            txtUserLname.BackColor = SystemColors.ButtonFace;
            txtUserEmail.BackColor = SystemColors.ButtonFace;
            txtUserContact.BackColor = SystemColors.ButtonFace;
            txtUserAddress.BackColor = SystemColors.ButtonFace;
            txtGender.BackColor = SystemColors.ButtonFace;
            txtUserSearch.BackColor = SystemColors.ButtonFace;

        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void loadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT userID as [userID], firstName as [First Name], lastName as [Last Name], gender as [Gender], contact as [Contact], address as [Address], email as [Email] FROM userTable WHERE stepDepartment = '0'", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridView3.DataSource = tab;
            var userIDColumn = dataGridView3.Columns["userID"];
            userIDColumn.Visible = false;
            con.Close();
        }
        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            txtUserFname.Focus();
        }

        private void txtUserFname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
        }

        private void txtUserLname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
        }

        private void txtUserEmail_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelEmail.Focus();
        }

        private void txtUserContact_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
        }

        private void txtUserAddress_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelAddress.BackColor = Color.White;
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
        }

        private void txtUserSearch_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
        }

        private void txtUserLname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
            txtUserLname.BackColor = Color.White;
        }

        private void txtUserFname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
            txtUserFname.BackColor = Color.White;
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

        private void txtUserAddress_Enter(object sender, EventArgs e)
        {

            resetFocus();
            panelAddress.BackColor = Color.White;
            txtUserAddress.BackColor = Color.White;
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
            txtGender.BackColor = Color.White;
        }

        private void txtUserSearch_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
            txtUserSearch.BackColor = Color.White;
            if(txtUserSearch.Text == "Search by Last Name")
            {
                txtUserSearch.Text = "";
            }
            loadDataGrid();
        }

        private void button9_Enter(object sender, EventArgs e)
        {
            resetFocus();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid cell is clicked
            {
                resetFocus();
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                userID.Text = selectedRow.Cells["userID"].Value.ToString();
                txtUserFname.Text = selectedRow.Cells["First Name"].Value.ToString();
                txtUserLname.Text = selectedRow.Cells["Last Name"].Value.ToString();
                txtUserEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtUserContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtUserAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtGender.Text = selectedRow.Cells["Gender"].Value.ToString();
            }
        }
        private void resetAll()
        {
            userID.Text = "";
            txtUserFname.Text = "";
            txtUserLname.Text = "";
            txtUserContact.Text = "";
            txtUserEmail.Text = "";
            txtUserAddress.Text = "";
            txtGender.Text = "";
            txtUserSearch.Text = "";
            userID.Text = "";
            txtUserFname.Focus();
            panelFname.BackColor = Color.White;
            txtUserFname.BackColor = Color.White;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand updatecmd = new SqlCommand("UPDATE userTable SET firstName='" + txtUserFname.Text + "', lastName='" + txtUserLname.Text + "', contact='" + txtUserContact.Text + "', address='" + txtUserAddress.Text + "', gender='" + txtGender.Text + "' where userID='" + userID.Text + "'", con);
            updatecmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            resetFocus();
            resetAll();
            loadDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand deletecmd = new SqlCommand("Delete from userTable where userID= '" + userID.Text + "'", con);
                deletecmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFocus();
                resetAll();

            }
            else
            {
                MessageBox.Show("Cancelled!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            resetFocus();
            resetAll();
            loadDataGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFocus();
            resetAll();
        }

        private void txtUserSearch_Leave(object sender, EventArgs e)
        {
            if(txtUserSearch.Text == "")
            {
                txtUserSearch.Text = "Search by Last Name";
            }
            loadDataGrid();
        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT userID as [userID], firstName as [First Name], lastName as [Last Name], gender as [Gender], contact as [Contact], address as [Address], email as [Email] FROM userTable where lastName like '%" + txtUserSearch.Text + "%'", con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView3.DataSource = tab;

            con.Close();
        }
    }
}
