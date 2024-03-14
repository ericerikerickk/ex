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
    public partial class Documents : Form
    {
        DateTime dateTimeNow = DateTime.Now;
        private int userID;
        public Documents(int userID)
        {
            this.userID = userID;
            InitializeComponent();
            loadDataGrid();
            lblHello.Text = Convert.ToString(userID);
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btnSubmitdocs_Click(object sender, EventArgs e)
        {
            if(txtProjectNo.Text.Contains(" ") && txtProjectName.Text.Contains(" ") && txtProjectDescription.Text.Contains(" "))
            {
                MessageBox.Show("Please enter the complete details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                con.Open();
                SqlCommand submitcmd = new SqlCommand("INSERT INTO documentTable (projectNo, projectTitle, projectDescription, dateCreated, userID) VALUES (@ProjectNo, @ProjectTitle, @ProjectDescription, @DateCreated, @userID)", con);

                // Add parameters
                submitcmd.Parameters.AddWithValue("@ProjectNo", txtProjectNo.Text);
                submitcmd.Parameters.AddWithValue("@ProjectTitle", txtProjectName.Text);
                submitcmd.Parameters.AddWithValue("@ProjectDescription", txtProjectDescription.Text);
                submitcmd.Parameters.AddWithValue("@DateCreated", dateTimeNow);
                submitcmd.Parameters.AddWithValue("@userID", userID);


                // Execute the query
                submitcmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGrid();
                reset();
            }

        }
        private void reset()
        {
            txtProjectNo.Text = "";
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtProjectNo.Focus();
        }
        private void loadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.projectNo, documentTable.projectTitle, documentTable.projectDescription, documentTable.dateCreated, documentTable.userID, step1Table.step1Status FROM documentTable FULL OUTER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step1Table ON documentTable.step1ID = step1Table.step1ID", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridViewDocs.DataSource = tab;
            con.Close();
        }
        private void resetFocus()
        {
            txtProjectNo.Text = "";
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtProjectNo.Focus();
        }
        private void dataGridViewDocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid cell is clicked
            {
                
            }
        }
    }
}
