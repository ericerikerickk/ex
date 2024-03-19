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
    public partial class step4Dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private int userID;
        public step4Dashboard(int userID)
        {
            InitializeComponent();
            labelPending();
            labelApproved();
            labelDocuments();
            timer1.Start();
            this.userID = userID;
        }
        private void labelPending()
        {
            con.Open();
            SqlCommand pendingcmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step4Table ON step4Table.step4ID = documentTable.step4ID WHERE step4Table.step4Status = 0", con);
            Int32 resultPending = Convert.ToInt32(pendingcmd.ExecuteScalar());
            con.Close();
            lblPending.Text = resultPending.ToString();
        }
        private void labelApproved()
        {
            con.Open();
            SqlCommand approvecmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step4Table ON step4Table.step3ID = documentTable.step4ID WHERE step4Table.step4Status = 1", con);
            Int32 approveresult = Convert.ToInt32(approvecmd.ExecuteScalar());
            con.Close();
            lblApproved.Text = approveresult.ToString();
        }
        private void labelDocuments()
        {
            con.Open();
            SqlCommand documentscmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step3Table ON step4Table.step4ID = documentTable.step4ID WHERE step4Table.step4Status = 1 OR step4Table.step4Status = 0", con);
            Int32 documentsResult = Convert.ToInt32(documentscmd.ExecuteScalar());
            con.Close();
            lblDocuments.Text = documentsResult.ToString();
        }
    }
}
