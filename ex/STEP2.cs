using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class STEP2 : Form
    {
        private int step2User;

        public STEP2(int step2User)
        {
            this.step2User = step2User;
            InitializeComponent();
            LoadDataGrid();
            labelStep2.Text = "Hello " + step2User;
            dataGridSTEP2.CellClick += dataGridSTEP2_CellClick;
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
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.],\r\n       documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], step2Table.step2Status AS [Step 2 Status], userTable.userName AS [User Name] FROM documentTable INNER JOIN userTable ON documentTable.userID = userTable.userID LEFT JOIN step1Table ON documentTable.step1ID = step1Table.step1ID LEFT JOIN step2Table ON documentTable.step2ID = step2Table.step2ID WHERE step1Table.step1Status = 1 AND (step2Table.step2Status IS NULL OR step2Table.step2Status != 1)", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridSTEP2.DataSource = tab;
            con.Close();
        }
        private void dataGridSTEP2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridSTEP2.Rows[e.RowIndex].Cells["Project No."].Value != null && dataGridSTEP2.Rows[e.RowIndex].Cells["Project Title"].Value != null && dataGridSTEP2.Rows[e.RowIndex].Cells["Project Description"].Value != null)
            {
                resetFocus();
                DataGridViewRow selectedRow = dataGridSTEP2.Rows[e.RowIndex];
                txtProjectNo.Text = selectedRow.Cells["Project No."].Value?.ToString();
                txtProjectName.Text = selectedRow.Cells["Project Title"].Value?.ToString();
                txtProjectDescription.Text = selectedRow.Cells["Project Description"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("No value to be shown", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand searchcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], step2Table.step2Status AS [Step 2 Status], userTable.firstName AS [Requestor] FROM documentTable INNER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step2Table ON documentTable.step2ID = step2Table.step2ID WHERE projectNo like '%" + txtSearch.Text + "%'", con);
            searchcmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(searchcmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridSTEP2.DataSource = tab;

            con.Close();
        }

        private void btnSubmitdocs_Click(object sender, EventArgs e)
        {
            
        }
        private void emailNotif()
        {
            try
            {
                string toEmail = "";
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
                    string fromPassword = "ebeqvqxtlmfgamch";
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    string mail = $"Project No.: {txtProjectNo.Text}<br>" +
                                  $"Project Title: {txtProjectName.Text}<br><br>" +
                                  "Good Day!,<br>" +
                                  "Your Document got received in Step 2.";
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
                    MessageBox.Show("No recipient email address found for the project.", "Error");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during email sending
                MessageBox.Show("Error sending email: " + ex.Message, "Error");
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SqlCommand submitcmd = new SqlCommand("UPDATE step2Table SET step2Status = 1, step2dateUpdated = @datetime " +
                                                   "FROM step2Table INNER JOIN documentTable " +
                                                   "ON step2Table.step2ID = documentTable.step2ID " +
                                                   "WHERE documentTable.projectNo = @projectno", con);
            // Assuming you have a variable called docID to pass the value
            submitcmd.Parameters.AddWithValue("@projectno", txtProjectNo.Text);
            submitcmd.Parameters.AddWithValue("@datetime", dateTimeNow);
            con.Open();
            string toEmail = GetRecipientEmail(txtProjectNo.Text); // Retrieve recipient email
            con.Close();
            if (!string.IsNullOrEmpty(toEmail))
            {
                con.Open();
                submitcmd.ExecuteNonQuery(); // Execute the update only if recipient email is found
                emailNotif(); // Send email notification
                MessageBox.Show("Successfully Received", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No recipient email address found for the project.", "Error");
            }

            con.Close(); // Close the connection after all operations are done
            LoadDataGrid();
            resetFocus();
        }
        private string GetRecipientEmail(string projectNo)
        {
            string email = "";
            try
            {
                using (SqlCommand emailcmd = new SqlCommand("SELECT userTable.email FROM userTable INNER JOIN documentTable ON userTable.userID = documentTable.userID WHERE documentTable.projectNo = @ProjectNo", con))
                {
                    emailcmd.Parameters.AddWithValue("@ProjectNo", projectNo);
                    using (SqlDataReader sdremail = emailcmd.ExecuteReader())
                    {
                        if (sdremail.Read())
                        {
                            email = sdremail.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operation
                MessageBox.Show("Error retrieving recipient email address: " + ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
            return email;
        }
    }
}
