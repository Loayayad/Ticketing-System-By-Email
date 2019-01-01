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
    public partial class Form2 : Form
    {
        
        Controller x;
        form1 n;
        int comp, userr, ser, statuss, syss;
        

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            n.max();

        }              

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public Form2(form1 d, int co, int user, int se, int status, int sys)
        {
            InitializeComponent();

            x = new Controller();
            n = d;
            comp = co;
            userr = user;
            ser = se;
            statuss = status;
            syss = sys;
            


        }
        private void save_button(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(body.Text) || string.IsNullOrWhiteSpace(subject.Text))
            {
                MessageBox.Show("please fill the boxes");
                return;
            }

            if (user.SelectedIndex == 0)
            {
                user.SelectedIndex = userr;
            }
            if (company.SelectedIndex == 0)
            {
                company.SelectedIndex = comp;
            }
            if (system.SelectedIndex == 0)
            {
                system.SelectedIndex = syss;
            }
            if (severity.SelectedIndex == 0)
            {
                severity.SelectedIndex = ser;
            }
            if (status.SelectedIndex == 0)
            {
                status.SelectedIndex = statuss;
            }


            x.EditTickets(id1.Text.ToString(), body.Text.ToString(), subject.Text.ToString(), comment.Text.ToString(), dateTimePicker1.Text.ToString()
                , user.SelectedIndex, company.SelectedIndex, system.SelectedIndex, severity.SelectedIndex, status.SelectedIndex);
            MessageBox.Show("Data Saved");
            this.Close();

            //this.Hide();
            n.dataGridView1.DataSource = x.ShowAllTick();
            n.dataGridView1.Refresh();
            n.max();
            
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // write code to retreive name of all users
            user.Items.Add("--Select--");
            foreach (DataRow row in x.getusernames().Rows)
            {
                user.Items.Add(row["UName"]);

            }
            user.SelectedIndex = userr;

            company.Items.Add("--Select--");
            foreach (DataRow row in x.GetCompanyNames().Rows)
            {
                company.Items.Add(row["CName"]);

            }
            company.SelectedIndex = comp;

            status.Items.Add("--Select--");
            foreach (DataRow row in x.getstatnames().Rows)
            {
                status.Items.Add(row["TicketStatName"]);

            }
            status.SelectedIndex = statuss;
            
            system.Items.Add("--Select--");
            foreach (DataRow row in x.getsysnames().Rows)
            {
                system.Items.Add(row["SYSNames"]);

            }
            system.SelectedIndex = syss;

            severity.Items.Add("--Select--");
            foreach (DataRow row in x.getsevnames().Rows)
            {
                severity.Items.Add(row["SevName"]);

            }
            severity.SelectedIndex = ser;
        }


    }
}


