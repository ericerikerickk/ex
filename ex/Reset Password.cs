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
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.eye__2_;
            txtNew.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.hidden__1_;
            txtNew.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtNew_Click(object sender, EventArgs e)
        {
            txtNew.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtConfirm.BackColor = SystemColors.Control;
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            txtConfirm.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtNew.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == txtConfirm.Text)
            {
                MessageBox.Show("Information", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
