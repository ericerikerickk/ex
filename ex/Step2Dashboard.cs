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
    public partial class Step2Dashboard : Form
    {
        public Step2Dashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            labelPending();
            labelReceived();
            labelDocuments();
            timer1.Start();
        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private int userID;
        private void labelPending()
        {
            con.Open();
            SqlCommand pendingcmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step2Table ON step2Table.step2ID = documentTable.step2ID WHERE step2Table.step2Status = 0", con);
            Int32 resultPending = Convert.ToInt32(pendingcmd.ExecuteScalar());
            con.Close();
            lblPending.Text = resultPending.ToString();
        }
        private void labelReceived()
        {
            con.Open();
            SqlCommand receivecmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step2Table ON step2Table.step2ID = documentTable.step2ID WHERE step2Table.step2Status = 1", con);
            Int32 receiveresult = Convert.ToInt32(receivecmd.ExecuteScalar());
            con.Close();
            lblReceived.Text = receiveresult.ToString();
        }
        private void labelDocuments()
        {
            con.Open();
            SqlCommand documentscmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step2Table ON step2Table.step2ID = documentTable.step2ID WHERE step2Table.step2Status = 1 OR step2Table.step2Status = 0", con);
            Int32 documentsResult = Convert.ToInt32(documentscmd.ExecuteScalar());
            con.Close();
            lblDocuments.Text = documentsResult.ToString();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
