using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex
{
    public partial class STEP1 : Form
    {
        private string step1User;

        public STEP1(string step1User)
        {
            this.step1User = step1User;
            InitializeComponent();
            labelStep1.Text = "Hello " + step1User;
        }
    }
}
