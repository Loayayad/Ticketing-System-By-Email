namespace main_form
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allTickets = new System.Windows.Forms.RadioButton();
            this.myTickets = new System.Windows.Forms.RadioButton();
            this.tickets = new System.Windows.Forms.GroupBox();
            this.search1 = new System.Windows.Forms.Button();
            this.company = new System.Windows.Forms.ComboBox();
            this.system = new System.Windows.Forms.ComboBox();
            this.severity = new System.Windows.Forms.ComboBox();
            this.searchby = new System.Windows.Forms.GroupBox();
            this.statusSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.severity1 = new System.Windows.Forms.ComboBox();
            this.status1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.ComboBox();
            this.system1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.company1 = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.advancedsearch = new System.Windows.Forms.LinkLabel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maximize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tickets.SuspendLayout();
            this.searchby.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 26;
            // 
            // allTickets
            // 
            resources.ApplyResources(this.allTickets, "allTickets");
            this.allTickets.Name = "allTickets";
            this.allTickets.UseVisualStyleBackColor = true;
            // 
            // myTickets
            // 
            resources.ApplyResources(this.myTickets, "myTickets");
            this.myTickets.Name = "myTickets";
            this.myTickets.UseVisualStyleBackColor = true;
            // 
            // tickets
            // 
            this.tickets.BackColor = System.Drawing.Color.Transparent;
            this.tickets.Controls.Add(this.search1);
            this.tickets.Controls.Add(this.allTickets);
            this.tickets.Controls.Add(this.myTickets);
            resources.ApplyResources(this.tickets, "tickets");
            this.tickets.Name = "tickets";
            this.tickets.TabStop = false;
            // 
            // search1
            // 
            this.search1.BackgroundImage = global::main_form.Properties.Resources._164908400_612x612;
            resources.ApplyResources(this.search1, "search1");
            this.search1.Name = "search1";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.search);
            // 
            // company
            // 
            resources.ApplyResources(this.company, "company");
            this.company.FormattingEnabled = true;
            this.company.Name = "company";
            // 
            // system
            // 
            resources.ApplyResources(this.system, "system");
            this.system.FormattingEnabled = true;
            this.system.Name = "system";
            // 
            // severity
            // 
            resources.ApplyResources(this.severity, "severity");
            this.severity.FormattingEnabled = true;
            this.severity.Name = "severity";
            // 
            // searchby
            // 
            this.searchby.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            resources.ApplyResources(this.searchby, "searchby");
            this.searchby.BackColor = System.Drawing.Color.Transparent;
            this.searchby.Controls.Add(this.statusSearch);
            this.searchby.Controls.Add(this.label6);
            this.searchby.Controls.Add(this.label4);
            this.searchby.Controls.Add(this.label2);
            this.searchby.Controls.Add(this.label3);
            this.searchby.Controls.Add(this.search2);
            this.searchby.Controls.Add(this.severity);
            this.searchby.Controls.Add(this.label1);
            this.searchby.Controls.Add(this.company);
            this.searchby.Controls.Add(this.system);
            this.searchby.Name = "searchby";
            this.searchby.TabStop = false;
            // 
            // statusSearch
            // 
            this.statusSearch.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.statusSearch, "statusSearch");
            this.statusSearch.FormattingEnabled = true;
            this.statusSearch.Name = "statusSearch";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // search2
            // 
            this.search2.BackgroundImage = global::main_form.Properties.Resources._164908400_612x612;
            resources.ApplyResources(this.search2, "search2");
            this.search2.Name = "search2";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.advanced_search);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.severity1);
            this.groupBox2.Controls.Add(this.status1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.user);
            this.groupBox2.Controls.Add(this.system1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.company1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // severity1
            // 
            this.severity1.FormattingEnabled = true;
            resources.ApplyResources(this.severity1, "severity1");
            this.severity1.Name = "severity1";
            // 
            // status1
            // 
            this.status1.FormattingEnabled = true;
            resources.ApplyResources(this.status1, "status1");
            this.status1.Name = "status1";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.save_the_selected);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // user
            // 
            this.user.FormattingEnabled = true;
            resources.ApplyResources(this.user, "user");
            this.user.Name = "user";
            // 
            // system1
            // 
            this.system1.FormattingEnabled = true;
            resources.ApplyResources(this.system1, "system1");
            this.system1.Name = "system1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // company1
            // 
            this.company1.FormattingEnabled = true;
            resources.ApplyResources(this.company1, "company1");
            this.company1.Name = "company1";
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::main_form.Properties.Resources._164908400_612x612;
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_gradeview);
            // 
            // edit
            // 
            this.edit.BackgroundImage = global::main_form.Properties.Resources._164908400_612x612;
            resources.ApplyResources(this.edit, "edit");
            this.edit.Name = "edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_ticket);
            // 
            // advancedsearch
            // 
            resources.ApplyResources(this.advancedsearch, "advancedsearch");
            this.advancedsearch.BackColor = System.Drawing.Color.Transparent;
            this.advancedsearch.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.advancedsearch.Name = "advancedsearch";
            this.advancedsearch.TabStop = true;
            this.advancedsearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.advanced);
            // 
            // minimize
            // 
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::main_form.Properties.Resources.mini111;
            this.minimize.Name = "minimize";
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click_1);
            // 
            // maximize
            // 
            resources.ApplyResources(this.maximize, "maximize");
            this.maximize.BackColor = System.Drawing.Color.Transparent;
            this.maximize.Image = global::main_form.Properties.Resources.max122;
            this.maximize.Name = "maximize";
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::main_form.Properties.Resources.lose;
            this.close.Name = "close";
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::main_form.Properties.Resources.ma;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.advancedsearch);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.searchby);
            this.Controls.Add(this.tickets);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tickets.ResumeLayout(false);
            this.tickets.PerformLayout();
            this.searchby.ResumeLayout(false);
            this.searchby.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox tickets;
        public System.Windows.Forms.RadioButton allTickets;
        public System.Windows.Forms.RadioButton myTickets;
        private System.Windows.Forms.ComboBox system;
        private System.Windows.Forms.ComboBox severity;
        private System.Windows.Forms.GroupBox searchby;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox severity1;
        public System.Windows.Forms.ComboBox status1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox user;
        public System.Windows.Forms.ComboBox system1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox company1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button edit;
        public System.Windows.Forms.ComboBox statusSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel advancedsearch;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.PictureBox maximize;
        private System.Windows.Forms.PictureBox close;
        public System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

