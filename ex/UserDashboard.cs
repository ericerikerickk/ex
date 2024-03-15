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
    public partial class UserDashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private int userID;
        public UserDashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            timer1.Start();
            LabelPending();
            LabelProcess();
            LabelApproved();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
        private void LabelPending()
        {
            con.Open();
            SqlCommand pendingcmd = new SqlCommand("SELECT COUNT(docID) FROM documentTable INNER JOIN userTable ON userTable.userID = documentTable.userID INNER JOIN step1Table ON step1Table.step1ID = documentTable.step1ID INNER JOIN step2Table ON step2Table.step2ID = documentTable.step2ID INNER JOIN step3Table ON step3Table.step3ID = documentTable.step3ID INNER JOIN step4Table ON step4Table.step4ID = documentTable.step4ID WHERE step1Table.step1Status = 0 AND step2Table.step2Status = 0 AND step3Table.step3Status = 0 AND step4Table.step4Status = 0 AND documentTable.userID = '" + Convert.ToInt32(userID) + "'", con);
            Int32 resultPending = Convert.ToInt32(pendingcmd.ExecuteScalar());
            con.Close();
            lblPending.Text = resultPending.ToString();
        }
        private void LabelProcess()
        {
            con.Open();
            SqlCommand processcmd = new SqlCommand("SELECT count(projectTitle) FROM documentTable INNER JOIN userTable ON userTable.userID = documentTable.userID FULL OUTER JOIN step1Table ON step1Table.step1ID = documentTable.step1ID FULL OUTER JOIN step2Table ON step2Table.step2ID = documentTable.step2ID FULL OUTER JOIN step3Table ON step3Table.step3ID = documentTable.step3ID FULL OUTER JOIN step4Table ON step4Table.step4ID = documentTable.step4ID WHERE step1Table.step1Status = 1 AND documentTable.userID = '" + Convert.ToInt32(userID) + "'", con);
            Int32 resultProcess = Convert.ToInt32(processcmd.ExecuteScalar());
            con.Close();
            lblProcess.Text = resultProcess.ToString();
        }
        private void LabelApproved()
        {
            con.Open();
            SqlCommand approvedcmd = new SqlCommand("SELECT COUNT(docID) FROM documentTable INNER JOIN userTable ON userTable.userID = documentTable.userID INNER JOIN step1Table ON step1Table.step1ID = documentTable.step1ID INNER JOIN step2Table ON step2Table.step2ID = documentTable.step2ID INNER JOIN step3Table ON step3Table.step3ID = documentTable.step3ID INNER JOIN step4Table ON step4Table.step4ID = documentTable.step4ID WHERE step1Table.step1Status = 1 AND step2Table.step2Status = 1 AND step3Table.step3Status = 1 AND step4Table.step4Status = 1 AND documentTable.userID = '" + Convert.ToInt32(userID) + "'", con);
            Int32 resultApproved = Convert.ToInt32(approvedcmd.ExecuteScalar());
            con.Close();
            lblApproved.Text = resultApproved.ToString();
        }
    }
}
