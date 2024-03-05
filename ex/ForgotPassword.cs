    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Mail;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace ex
{
    public partial class ForgotPassword : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ForgotPassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(-50, 0, panel1.Width, panel1.Height, 30, 30));
            sendbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sendbtn.Width, sendbtn.Height, 35, 35));
            btnConfirm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirm.Width, btnConfirm.Height, 35, 35));
        }

        private void txtGmail_Click(object sender, EventArgs e)
        {
            txtGmail.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtConfirm.BackColor = SystemColors.Control;
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            txtConfirm.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtGmail.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
        private Point _mouseLoc;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        int vCode = 1000;

        private void sendbtn_Click(object sender, EventArgs e)
        {
            timvcode.Stop();
            string fromMail = "ericpoblete123@gmail.com";
            string fromPassword = "chjdfpxspusofohl";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            string mail = vCode.ToString();
            message.Subject = "Test Subject";
            message.To.Add(new MailAddress(txtGmail.Text));
            message.Body = mail;
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Verification code sent successfully! Go to Gmail and get the code.", "Information", MessageBoxButtons.OK);
                txtConfirm.Enabled = true;
                btnConfirm.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timvcode_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == vCode.ToString())
            {
                Reset_Password reset = new Reset_Password();
                reset.Show();
            }
            else
            {
                MessageBox.Show("Verification Code Does Not Matched.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtGmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@gmail\.com$");

                if (!mRegxExpression.IsMatch(txtGmail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address must end with @gmail.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
