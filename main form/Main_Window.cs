using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;


namespace main_form
{
    public partial class form1 : Form
    {
        Controller x;
        int ID;
        private static bool MAXIMIZED = false;

        public form1(int y)
        {
            InitializeComponent();
            ID = y;

            x = new Controller();
        }
        
        private void form1_Load(object sender, EventArgs e)
        {
            //connect to outlook mailbox
            Microsoft.Office.Interop.Outlook.Application app = null;
            Microsoft.Office.Interop.Outlook._NameSpace ns = null;
            Microsoft.Office.Interop.Outlook.MailItem item = null;
            Microsoft.Office.Interop.Outlook.MAPIFolder inboxFolder = null;
            Microsoft.Office.Interop.Outlook.MAPIFolder subFolder = null;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Hide();

            try
            {
                app = new Microsoft.Office.Interop.Outlook.Application();
                ns = app.GetNamespace("MAPI");
                ns.Logon(null, null, false, false);

                inboxFolder = ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);
                subFolder = inboxFolder;//.Folders["MySubFolderName"]; //folder.Folders[1]; also works
                //Console.WriteLine("Folder Name: {0}, EntryId: {1}", subFolder.Name, subFolder.EntryID);
                //Console.WriteLine("Num Items: {0}", subFolder.Items.Count.ToString());
               
                foreach (Object _obj in subFolder.Items)
                {
                    if (_obj is MailItem)
                    {
                        item = (Microsoft.Office.Interop.Outlook.MailItem)_obj;
                        string h,s,b;
                        int a;
                        if (item.CC == null)
                        {
                            h = " ";
                        }
                        else h = item.CC.ToString();

                        if (item.Subject == null)
                        {
                            s = " ";
                        }
                        else s = item.Subject.ToString();

                        if (item.Body == null)
                        {
                            b = " ";
                        }
                        else b = item.Body.ToString();

                        if (item.Attachments.Count > 0)
                        {
                            a = item.Attachments.Count;                        
                          x.addticket(item.EntryID.ToString(), ID, b
                          , s, item.SenderEmailAddress.ToString(), h, item.SentOn.ToLongDateString(),a);
                        }
                        else
                        {
                            x.addticket(item.EntryID.ToString(), ID, b, s, item.SenderEmailAddress.ToString(), h, item.SentOn.ToLongDateString(),0);
                        }
                    }
                }
            }
            catch (System.Runtime.InteropServices.COMException ex )
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                ns = null;
                app = null;
                inboxFolder = null;
            }

            //user assgin
            user.Items.Add("--Select--");
            foreach (DataRow row in x.getusernames().Rows)
            {
                user.Items.Add(row["UName"]);

            }
            user.SelectedIndex = 0;

            //company search
            company.Items.Add("--Select--");
            foreach (DataRow row in x.GetCompanyNames().Rows)
            {
                company.Items.Add(row["CName"]);

            }
            company.SelectedIndex = 0;

            //company assgin
            company1.Items.Add("--Select--");
            foreach (DataRow row in x.GetCompanyNames().Rows)
            {
                company1.Items.Add(row["CName"]);

            }
            company1.SelectedIndex = 0;

            //system search
            system.Items.Add("--Select--");
            foreach (DataRow row in x.getsysnames().Rows)
            {
                system.Items.Add(row["SYSNames"]);

            }
            system.SelectedIndex = 0;

            //system assgin
            system1.Items.Add("--Select--");
            foreach (DataRow row in x.getsysnames().Rows)
            {
                system1.Items.Add(row["SYSNames"]);

            }
            system1.SelectedIndex = 0;

            //severity search
            severity.Items.Add("--Select--");
            foreach (DataRow row in x.getsevnames().Rows)
            {
                severity.Items.Add(row["SevName"]);

            }
            severity.SelectedIndex = 0;
            
            //severity assgin
            severity1.Items.Add("--Select--");
            foreach (DataRow row in x.getsevnames().Rows)
            {
                severity1.Items.Add(row["SevName"]);

            }
            severity1.SelectedIndex = 0;

            //status search
            statusSearch.Items.Add("--Select--");
            foreach (DataRow row in x.getstatnames().Rows)
            {
                statusSearch.Items.Add(row["TicketStatName"]);

            }
            statusSearch.SelectedIndex = 0;

            //status assgin
            status1.Items.Add("--Select--");
            foreach (DataRow row in x.getstatnames().Rows)
            {
                status1.Items.Add(row["TicketStatName"]);

            }
            status1.SelectedIndex = 0;

        }

        private void save_the_selected(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows.OfType<DataGridViewRow>().Where(row => !row.IsNewRow).ToArray();

            foreach (var row in selectedRows)
            {
                if (user.SelectedIndex != 0) x.changeuser(user.SelectedIndex, row.Cells[0].Value.ToString());
                if (company1.SelectedIndex != 0) x.changecompany(company1.SelectedIndex, row.Cells[0].Value.ToString());
                if (severity1.SelectedIndex != 0) x.changesev(severity1.SelectedIndex, row.Cells[0].Value.ToString());
                if (system1.SelectedIndex != 0) x.changesys(system1.SelectedIndex, row.Cells[0].Value.ToString());
                if (status1.SelectedIndex != 0) x.changestatus(status1.SelectedIndex, row.Cells[0].Value.ToString());

            }
            dataGridView1.Show();
            dataGridView1.Refresh();
        }

        private void search(object sender, EventArgs e)
        {
            if (allTickets.Checked == true)
            {
                dataGridView1.DataSource = x.ShowAllTick();

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = null;
                dataGridView1.Refresh();
                dataGridView1.Show();
            }
            else if (myTickets.Checked == true)
            {
                dataGridView1.DataSource = x.ShowAllTick();

                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("UserID = {0}", ID);

                dataGridView1.Refresh();
                dataGridView1.Show();
            }
        }

        private void advanced_search(object sender, EventArgs e)
        {
            int co = company.SelectedIndex;
            int sy = system.SelectedIndex;
            int se = severity.SelectedIndex;
            int st = statusSearch.SelectedIndex;

            if (allTickets.Checked == true || myTickets.Checked)
            {
                //if for status
                if (co == 0 && sy == 0 && se == 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowAllTickstat(st);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for company
                if (co > 0 && sy == 0 && se == 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTickcomp(co);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for system
                if (co == 0 && sy > 0 && se == 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTicksys(sy);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for severity
                if (co == 0 && sy == 0 && se > 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTicksev(se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                // if for company and status
                if (co > 0 && sy == 0 && se == 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickByCompStat(st, co);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for system and status
                if (co == 0 && sy > 0 && se == 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickBySysStat(st, sy);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for severity and status
                if (co == 0 && sy == 0 && se > 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickBySevStat(st, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for company and system
                if (co > 0 && sy > 0 && se == 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTickCompSys(co, sy);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for company and severity
                if (co > 0 && sy == 0 && se > 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTickCompSev(co, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for system and severity
                if (co == 0 && sy > 0 && se > 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTickSevSys(sy, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for company and system and status
                if (co > 0 && sy > 0 && se == 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickBycompSysStat(st, co, sy);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for company and severity and status
                if (co > 0 && sy == 0 && se > 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickBycompSevStat(st, co, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for system and severity and status
                if (co == 0 && sy > 0 && se > 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickBysevSysStat(st, sy, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for system and severity and company
                if (co > 0 && sy > 0 && se > 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowTickBycompSysSev(co, sy, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                //if for all
                if (co > 0 && sy > 0 && se > 0 && st > 0)
                {
                    dataGridView1.DataSource = x.ShowTickByAll(st, co, sy, se);
                    if (dataGridView1.DataSource == null)
                    {
                        MessageBox.Show("NOT Exist");
                    }
                    else
                    {
                        dataGridView1.Show();
                        dataGridView1.Refresh();
                    }
                }

                // if nothing
                if (co == 0 && sy == 0 && se == 0 && st == 0)
                {
                    dataGridView1.DataSource = x.ShowAllTick();
                }


                if (myTickets.Checked == true)

                {
                    try
                    {
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("UserID = {0}", ID);
                    }
                    catch (NullReferenceException) { MessageBox.Show("Not Exist"); }

                    dataGridView1.Refresh();
                    dataGridView1.Show();
                    //if for all
                }
                else
                {
                    dataGridView1.Refresh();
                    dataGridView1.Show();
                }
            }
        }

        private void advanced(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (allTickets.Checked == true || myTickets.Checked == true)
            { searchby.Enabled = true; }
            else
                MessageBox.Show("Please choose All or My Ticket First");
        }

        private void edit_ticket(object sender, EventArgs e)
        {
            int stat = int.Parse(dataGridView1.CurrentRow.Cells[14].Value.ToString());
            int se = int.Parse(dataGridView1.CurrentRow.Cells[15].Value.ToString());
            int user = int.Parse(dataGridView1.CurrentRow.Cells[16].Value.ToString());
            int comp = int.Parse(dataGridView1.CurrentRow.Cells[17].Value.ToString());
            int sys = int.Parse(dataGridView1.CurrentRow.Cells[18].Value.ToString());

            Form2 myform = new Form2(this, comp, user, se, stat, sys);

            myform.id1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myform.from.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myform.cc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myform.subject.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myform.body.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myform.opendate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            myform.comment.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            myform.attachment.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            myform.Show();
            WindowState = FormWindowState.Minimized;

           
            
        }

        private void refresh_gradeview(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Hide();

        }
        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void max()
        {
            
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;         

        }

    }
}
    

