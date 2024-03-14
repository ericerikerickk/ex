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

namespace ex
{
    public partial class STEP1 : Form
    {
        private int step1User;

        public STEP1(int step1User)
        {
            this.step1User = step1User;
            InitializeComponent();
            LoadDataGrid();
            labelStep1.Text = "Hello " + step1User;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void LoadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.projectNo, documentTable.projectTitle, documentTable.projectDescription, documentTable.dateCreated, documentTable.userID, step1Table.step1Status FROM documentTable FULL OUTER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step1Table ON documentTable.step1ID = step1Table.step1ID", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridSTEP1.DataSource = tab;
            con.Close();
        }

        private void btnReceivestep1_Click(object sender, EventArgs e)
        {

        }
    }
}
