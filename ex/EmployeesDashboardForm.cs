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
    public partial class EmployeesDashboardForm : Form
    {
        public EmployeesDashboardForm()
        {
            InitializeComponent();
            loadDataGrid();
            dataGridView2.CellClick += dataGridView2_CellClick;

        }
        public void resetFocus()
        {
            panelFname.BackColor = SystemColors.ButtonFace;
            panelLname.BackColor = SystemColors.ButtonFace;
            panelEmail.BackColor = SystemColors.ButtonFace;
            panelContact.BackColor = SystemColors.ButtonFace;
            PanelAddress.BackColor = SystemColors.ButtonFace;
            panelGender.BackColor = SystemColors.ButtonFace;
            panelSearch.BackColor = SystemColors.ButtonFace;
            panelSteps.BackColor = SystemColors.ButtonFace;
            txtEmpFname.BackColor = SystemColors.ButtonFace;
            txtEmpLname.BackColor = SystemColors.ButtonFace;
            txtempEmail.BackColor = SystemColors.ButtonFace;
            txtEmpContact.BackColor = SystemColors.ButtonFace;
            txtEmpAddress.BackColor = SystemColors.ButtonFace;
            txtGender.BackColor = SystemColors.ButtonFace;
            txtSteps.BackColor = SystemColors.ButtonFace;
            txtEmpSearch.BackColor = SystemColors.ButtonFace;


        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void loadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT userID as [userID], firstName as [First Name], lastName as [Last Name], gender as [Gender], contact as [Contact], address as [Address], email as [Email], stepDepartment as [Step Department] FROM userTable WHERE stepDepartment = 'Step 1' OR stepDepartment = 'Step 2' OR stepDepartment = 'Step 3' OR stepDepartment = 'Step 4'", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridView2.DataSource = tab;
            var userIDColumn = dataGridView2.Columns["userID"];
            userIDColumn.Visible = false;
            con.Close();
        }
        private void txtEmpFname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
            txtEmpFname.BackColor = Color.White;
        }

        private void EmployeesDashboardForm_Load(object sender, EventArgs e)
        {
            txtEmpFname.Focus();
        }

        private void txtEmpLname_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
            txtEmpLname.BackColor = Color.White;
        }

        private void txtempEmail_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
            txtempEmail.BackColor = Color.White;
        }

        private void txtEmpContact_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
            txtEmpContact.BackColor = Color.White;
        }

        private void txtEmpAddress_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            PanelAddress.BackColor = Color.White;
            txtEmpAddress.BackColor = Color.White;
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
            txtGender.BackColor = Color.White;
        }

        private void txtEmpSearch_MouseClick(object sender, MouseEventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
            txtEmpSearch.BackColor = Color.White;
        }

        private void txtEmpLname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelLname.BackColor = Color.White;
            txtEmpLname.BackColor = Color.White;
        }

        private void txtEmpFname_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelFname.BackColor = Color.White;
            txtEmpFname.BackColor = Color.White;
        }

        private void txtempEmail_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelEmail.BackColor = Color.White;
            txtempEmail.BackColor = Color.White;
        }

        private void txtEmpContact_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelContact.BackColor = Color.White;
            txtEmpContact.BackColor = Color.White;
        }

        private void txtEmpAddress_Enter(object sender, EventArgs e)
        {
            resetFocus();
            PanelAddress.BackColor = Color.White;
            txtEmpAddress.BackColor = Color.White;
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelGender.BackColor = Color.White;
            txtGender.BackColor = Color.White;
        }

        private void comboSteps_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSteps.BackColor = Color.White;
            txtSteps.BackColor = Color.White;
        }

        private void txtEmpSearch_Enter(object sender, EventArgs e)
        {
            resetFocus();
            panelSearch.BackColor = Color.White;
            txtEmpSearch.BackColor = Color.White;
            if (txtEmpSearch.Text == "Search by Last Name")
            {
                txtEmpSearch.Text = "";
            }
            loadDataGrid();
        }

        private void button6_Enter(object sender, EventArgs e)
        {
            resetFocus();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid cell is clicked
            {
                resetFocus();
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                userID.Text = selectedRow.Cells["userID"].Value.ToString();
                txtEmpFname.Text = selectedRow.Cells["First Name"].Value.ToString();
                txtEmpLname.Text = selectedRow.Cells["Last Name"].Value.ToString();
                txtempEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtEmpContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtEmpAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                txtSteps.Text = selectedRow.Cells["Step Department"].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand updatecmd = new SqlCommand("UPDATE userTable SET firstName='" + txtEmpFname.Text + "', lastName='" + txtEmpLname.Text + "', contact='" + txtEmpContact.Text + "', address='" + txtEmpAddress.Text + "', gender='" + txtGender.Text + "', stepDepartment='" + txtSteps.Text + "' where userID='" + userID.Text + "'", con);
            updatecmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            loadDataGrid();
            resetFocus();
            resetAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFocus();
            resetAll();
        }
        private void resetAll()
        {
            txtEmpFname.Text = "";
            txtEmpLname.Text = "";
            txtempEmail.Text = "";
            txtEmpContact.Text = "";
            txtEmpAddress.Text = "";
            txtGender.Text = "";
            txtSteps.Text = "";
            txtEmpSearch.Text = "";
            userID.Text = "";
            txtEmpFname.Focus();
            panelFname.BackColor = Color.White;
            txtEmpFname.BackColor = Color.White;
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

        private void txtEmpSearch_Leave(object sender, EventArgs e)
        {
            if (txtEmpSearch.Text == "")
            {
                txtEmpSearch.Text = "Search by Last Name";
            }
            loadDataGrid();
        }

        private void txtEmpSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT userID as [userID], firstName as [First Name], lastName as [Last Name], gender as [Gender], contact as [Contact], address as [Address], email as [Email], stepDepartment as [Step Department] FROM userTable where lastName like '%" + txtEmpSearch.Text + "%'", con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView2.DataSource = tab;

            con.Close();
        }
    }
}
