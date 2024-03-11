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
    public partial class AdminDashboardForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AdminDashboardForm()
        {
            InitializeComponent();
   
        }
        private void countUserFunction()
        {
            con.Open();
            SqlCommand countcmd = new SqlCommand("select count(userID) from userTable where stepDepartment = '0'", con);
            Int32 resultuser = Convert.ToInt32(countcmd.ExecuteScalar());
            con.Close();
            countUserlbl.Text = resultuser.ToString();

        }
        private void countEmployeeFunction()
        {
            con.Open();
            SqlCommand countcmd = new SqlCommand("select count(userID) from userTable where stepDepartment != '0'", con);
            Int32 resultEmp = Convert.ToInt32(countcmd.ExecuteScalar());
            con.Close();
            countEmpLbl.Text = resultEmp.ToString();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            countUserFunction();
            countEmployeeFunction();
        }
    }
}
