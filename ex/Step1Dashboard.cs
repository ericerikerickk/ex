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
    public partial class Step1Dashboard : Form
    {
        private int userID;
        public Step1Dashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
    }
}
