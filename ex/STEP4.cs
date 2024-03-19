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
//using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace ex
{
    public partial class STEP4 : Form
    {
        private int step4User;
        public STEP4(int step4User)
        {
            InitializeComponent();
            LoadDataGrid();
            lblHello.Text = "Hello " + step4User;
            this.step4User = step4User;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void LoadDataGrid()
        {
            con.Open();
            SqlCommand loadcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], step4Table.step4Status AS [Step 4 Status], userTable.userName AS [User Name] FROM documentTable INNER JOIN userTable ON documentTable.userID = userTable.userID LEFT JOIN step1Table ON documentTable.step1ID = step1Table.step1ID LEFT JOIN step2Table ON documentTable.step2ID = step2Table.step2ID LEFT JOIN step3Table ON documentTable.step3ID = step3Table.step3ID LEFT JOIN step4Table ON documentTable.step4ID = step4Table.step4ID WHERE step1Table.step1Status = 1 AND step2Table.step2Status = 1 AND step3Table.step3Status = 1 AND (step4Table.step4Status = 0 AND step4Table.step4Denied = 0)", con);
            loadcmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(loadcmd);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridSTEP4.DataSource = tab;
            con.Close();
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
            LoadDataGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand searchcmd = new SqlCommand("SELECT documentTable.projectNo AS [Project No.], documentTable.projectTitle AS [Project Title], documentTable.projectDescription AS [Project Description], documentTable.dateCreated AS [Date Created], step4Table.step4Status AS [Step 4 Status], userTable.firstName AS [Requestor] FROM documentTable INNER JOIN userTable ON documentTable.userID = userTable.userID FULL OUTER JOIN step4Table ON documentTable.step4ID = step4Table.step4ID WHERE projectNo like '%" + txtSearch.Text + "%'", con);
            searchcmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(searchcmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridSTEP4.DataSource = tab;

            con.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SqlCommand submitcmd = new SqlCommand("UPDATE step4Table SET step4Status = 1, step4dateUpdated = @datetime " +
                                                   "FROM step4Table INNER JOIN documentTable " +
                                                   "ON step4Table.step4ID = documentTable.step4ID " +
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
                MessageBox.Show("Successfully Approved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                  "Congratulaions, your Document got approved in Step 4.";
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
        private void emailNotifDeny()
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
                                  "Unfortunately, your Document got declined in Step 4.";
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
        private void btnDeny_Click(object sender, EventArgs e)
        {
            string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SqlCommand submitcmd = new SqlCommand("UPDATE step4Table SET step4Denied = 1, step4dateUpdated = @datetime " +
                                                   "FROM step4Table INNER JOIN documentTable " +
                                                   "ON step4Table.step4ID = documentTable.step4ID " +
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
                emailNotifDeny(); // Send email notification
                MessageBox.Show("Successfully Declined", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No recipient email address found for the project.", "Error");
            }

            con.Close(); // Close the connection after all operations are done
            LoadDataGrid();
            resetFocus();
        }

        private void dataGridSTEP4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridSTEP4.Rows[e.RowIndex].Cells["Project No."].Value != null && dataGridSTEP4.Rows[e.RowIndex].Cells["Project Title"].Value != null && dataGridSTEP4.Rows[e.RowIndex].Cells["Project Description"].Value != null)
            {
                resetFocus();
                DataGridViewRow selectedRow = dataGridSTEP4.Rows[e.RowIndex];
                txtProjectNo.Text = selectedRow.Cells["Project No."].Value?.ToString();
                txtProjectName.Text = selectedRow.Cells["Project Title"].Value?.ToString();
                txtProjectDescription.Text = selectedRow.Cells["Project Description"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("No value to be shown", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
