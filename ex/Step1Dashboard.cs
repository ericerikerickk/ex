﻿using System;
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
    public partial class Step1Dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private int userID;
        public Step1Dashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            labelPending();
            labelReceived();
            labelDocuments();
            timer1.Start();
        }
        private void labelPending()
        {
            con.Open();
            SqlCommand pendingcmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step1Table ON step1Table.step1ID = documentTable.step1ID WHERE step1Table.step1Status = 0", con);
            Int32 resultPending = Convert.ToInt32(pendingcmd.ExecuteScalar());
            con.Close();
            lblPending.Text = resultPending.ToString();
        }
        private void labelReceived()
        {
            con.Open();
            SqlCommand receivecmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step1Table ON step1Table.step1ID = documentTable.step1ID WHERE step1Table.step1Status = 1", con);
            Int32 receiveresult = Convert.ToInt32(receivecmd.ExecuteScalar());
            con.Close();
            lblReceived.Text = receiveresult.ToString();
        }
        private void labelDocuments()
        {
            con.Open();
            SqlCommand documentscmd = new SqlCommand("SELECT COUNT(projectTitle) FROM documentTable INNER JOIN step1Table ON step1Table.step1ID = documentTable.step1ID WHERE step1Table.step1Status = 1 OR step1Table.step1Status = 0", con);
            Int32 documentsResult = Convert.ToInt32(documentscmd.ExecuteScalar());
            con.Close();
            lblDocuments.Text = documentsResult.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
