using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ex
{
    public partial class DocumentForm : Form
    {
        public DocumentForm()
        {
            InitializeComponent();
            loadDataGrid();
            dataGridViewDocs.CellClick += dataGridViewDocs_CellClick;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void loadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.docID AS [Document ID], documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], documentTable.userID AS [User ID], step1Table.step1Status AS [Step 1 Status], step2Table.step2Status AS [Step 2 Status], step3Table.step3Status AS [Step 3 Status], step4Table.step4Status AS [Step 4 Status] FROM documentTable FULL OUTER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step1Table ON documentTable.step1ID = step1Table.step1ID FULL OUTER JOIN step2Table ON documentTable.step2ID = step2Table.step2ID FULL OUTER JOIN step3Table ON documentTable.step3ID = step3Table.step3ID FULL OUTER JOIN step4Table ON documentTable.step4ID = step4Table.step4ID", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridViewDocs.DataSource = tab;
            var userIDColumn = dataGridViewDocs.Columns["Document ID"];
            userIDColumn.Visible = false;
            con.Close();
        }

        private void dataGridViewDocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid cell is clicked
            {
                resetFocus();
                DataGridViewRow selectedRow = dataGridViewDocs.Rows[e.RowIndex];
                txtProjectNo.Text = selectedRow.Cells["Project No."].Value.ToString();
                txtProjectName.Text = selectedRow.Cells["Project Title"].Value.ToString();
                txtProjectDescription.Text = selectedRow.Cells["Project Description"].Value.ToString();
                lblDocID.Text = selectedRow.Cells["Document ID"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand searchcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], documentTable.userID AS [User ID], step1Table.step1Status AS [Step 1 Status], step2Table.step2Status AS [Step 2 Status], step3Table.step3Status AS [Step 3 Status], step4Table.step4Status AS [Step 4 Status] FROM documentTable FULL OUTER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step1Table ON documentTable.step1ID = step1Table.step1ID FULL OUTER JOIN step2Table ON documentTable.step2ID = step2Table.step2ID FULL OUTER JOIN step3Table ON documentTable.step3ID = step3Table.step3ID FULL OUTER JOIN step4Table ON documentTable.step4ID = step4Table.step4ID WHERE projectNo like '%" + txtSearch.Text + "%'", con);
            searchcmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(searchcmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridViewDocs.DataSource = tab;

            con.Close();
        }


        private void reset()
        {
            txtProjectNo.Text = "";
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtProjectNo.Focus();
        }
        private void resetFocus()
        {
            txtProjectNo.Text = "";
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtProjectNo.Focus();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            loadDataGrid();

        }

        private void btnUpdateButton_Click(object sender, EventArgs e)
        {
            if (txtProjectNo.Text.Contains(" ") && txtProjectName.Text.Contains(" ") && txtProjectDescription.Text.Contains(" "))
            {
                MessageBox.Show("Please enter the complete details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand updatecmd = new SqlCommand("UPDATE documentTable SET projectNo = '" + txtProjectNo.Text + "', projectTitle = '" + txtProjectName.Text + "', projectDescription= '" + txtProjectDescription.Text + "' WHERE docID='" + Convert.ToInt32(lblDocID.Text) + "'", con);

                updatecmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGrid();
                reset();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand deletecmd = new SqlCommand("Delete from documentTable where projectNo= '" + txtProjectNo.Text + "'", con);
                deletecmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetFocus();
            }
            else
            {
                MessageBox.Show("Cancelled!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            resetFocus();
            loadDataGrid();
        }
    }
}
