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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void sidecomponentsInactive()
        {
            panelProfileInactive.Show();
            panelDocumentsInactive.Show();
        }
        public void loadForm(object form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            sidecomponentsInactive();
            panelProfileInactive.Hide();
            panelProfileActive.Show();
            loadForm(new EditProfile());
        }

        private void panelProfileInactive_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelProfileInactive.Hide();
            panelProfileActive.Show();
            loadForm(new EditProfile());
        }
        private void panelDocumentsInactive_MouseClick(object sender, MouseEventArgs e)
        {
            sidecomponentsInactive();
            panelDocumentsInactive.Hide();
            panelDocumentsActive.Show();
            loadForm(new Documents());
        }
    }
}
