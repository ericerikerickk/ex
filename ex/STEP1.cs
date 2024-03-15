using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms.VisualStyles;

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
            dataGridSTEP1.CellClick += dataGridSTEP1_CellClick;
            txtProjectNo.Focus();
        }
        private void resetFocus()
        {
            txtProjectNo.Text = "";
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtProjectNo.Focus();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void LoadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], step1Table.step1Status AS [Step 1 Status], userTable.userName AS [User Name] FROM documentTable INNER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step1Table ON documentTable.step1ID = step1Table.step1ID", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridSTEP1.DataSource = tab;
            con.Close();
        }

        private void dataGridSTEP1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridSTEP1.Rows[e.RowIndex].Cells["Project No."].Value != null && dataGridSTEP1.Rows[e.RowIndex].Cells["Project Title"].Value != null && dataGridSTEP1.Rows[e.RowIndex].Cells["Project Description"].Value != null)
            {
                resetFocus();
                DataGridViewRow selectedRow = dataGridSTEP1.Rows[e.RowIndex];
                txtProjectNo.Text = selectedRow.Cells["Project No."].Value?.ToString();
                txtProjectName.Text = selectedRow.Cells["Project Title"].Value?.ToString();
                txtProjectDescription.Text = selectedRow.Cells["Project Description"].Value?.ToString();
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand searchcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], step1Table.step1Status AS [Step 1 Status], userTable.firstName AS [Requestor] FROM documentTable INNER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step1Table ON documentTable.step1ID = step1Table.step1ID WHERE projectNo like '%" + txtSearch.Text + "%'", con);
            searchcmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(searchcmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridSTEP1.DataSource = tab;

            con.Close();
        }

        private void btnSubmitdocs_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand submitcmd = new SqlCommand("UPDATE step1Table SET step1Status = 1 " +
                                                   "FROM step1Table INNER JOIN documentTable " +
                                                   "ON step1Table.step1ID = documentTable.step1ID " +
                                                   "WHERE documentTable.projectNo = @projectno", con);
            // Assuming you have a variable called docID to pass the value
            submitcmd.Parameters.AddWithValue("@projectno", txtProjectNo.Text);
            submitcmd.ExecuteNonQuery();
            con.Close();
            emailNotif();
            MessageBox.Show("Successfully Received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGrid();
        }
        private void emailNotif()
        {
            string toEmail = "";
            con.Open();
            using (SqlCommand emailcmd = new SqlCommand("SELECT userTable.email FROM userTable INNER JOIN documentTable ON userTable.userID = documentTable.userID WHERE documentTable.projectNo = @ProjectNo", con))
            {
                emailcmd.Parameters.AddWithValue("@ProjectNo", txtProjectNo.Text); // Assuming txtProjectNo contains the project number
                using (SqlDataReader sdremail = emailcmd.ExecuteReader())
                {
                    if (sdremail.Read())
                    {
                        toEmail = sdremail.GetString(0);
                    }
                }
            }
            con.Close();

            if (!string.IsNullOrEmpty(toEmail))
            {
                string[] hardcodedEmails = { toEmail, "ericpoblete316@gmail.com", "kerviemille@gmail.com" };

                string fromMail = "ericpoblete123@gmail.com";
                string fromPassword = "chjdfpxspusofohl";
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                string mail = $"Project No.: {txtProjectNo.Text}<br>" +
                              $"Project Title: {txtProjectName.Text}<br><br>" +
                              "Good Day!,<br>" +
                              "Your Document got approved in Step 1.";
                string subject = $"Project No.: {txtProjectNo.Text}, Project Title: {txtProjectName.Text}";
                message.Subject = subject;

                foreach (string email in hardcodedEmails)
                {
                    if (!string.IsNullOrEmpty(email))
                    {
                        message.To.Add(new MailAddress(email));
                    }
                }

                message.Body = mail;
                message.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);


            }
            else
            {
                // Handle the case when no recipient email address is found
                Console.WriteLine("No recipient email address found for the project.");
            }
        }


    }
}
