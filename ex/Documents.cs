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
        private string userName;
        public Documents(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            loadDataGrid();
            lblHello.Text = userName;
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
                string userName = lblHello.Text;

                con.Open();
                SqlCommand submitcmd = new SqlCommand("INSERT INTO documentTable (projectNo, projectTitle, projectDescription, dateCreated) VALUES (@ProjectNo, @ProjectTitle, @ProjectDescription, @DateCreated)", con);

                // Add parameters
                submitcmd.Parameters.AddWithValue("@ProjectNo", txtProjectNo.Text);
                submitcmd.Parameters.AddWithValue("@ProjectTitle", txtProjectName.Text);
                submitcmd.Parameters.AddWithValue("@ProjectDescription", txtProjectDescription.Text);
                submitcmd.Parameters.AddWithValue("@DateCreated", dateTimeNow);

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
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.projectNo, documentTable.projectTitle, documentTable.projectDescription, documentTable.dateCreated, documentTable.userID FROM documentTable FULL OUTER JOIN userTable ON documentTable.userID = userTable.userID", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridViewDocs.DataSource = tab;
            var userIDColumn = dataGridViewDocs.Columns["userID"];
            userIDColumn.Visible = false;
            con.Close();
        }
    }
}
