using main_form.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form
{
    public partial class login : Form
    {
        Controller l;
        form1 x;
        public login()
        {
            InitializeComponent();
            l = new Controller();
           
        }
        
        private void login_button(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("please fill the boxes");
                return;
            }
            if (l.CheckPassword(username.Text.ToString(), password.Text.ToString()))
            {

                //MessageBox.Show("Welcome");
                
                x = new form1(l.RetrievetlID(username.Text.ToString(), password.Text.ToString()));
                x.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Try Again");

        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
