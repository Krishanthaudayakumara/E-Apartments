namespace E_Apartments.Customer
{
    partial class CustomerHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nicTxt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sysUser = new System.Windows.Forms.Label();
            this.sysTime = new System.Windows.Forms.Label();
            this.sysDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.leaseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nicTxt);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 61);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(346, 22);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(193, 20);
            this.nameTxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NIC / Passport : ";
            // 
            // nicTxt
            // 
            this.nicTxt.Location = new System.Drawing.Point(94, 22);
            this.nicTxt.Name = "nicTxt";
            this.nicTxt.Size = new System.Drawing.Size(193, 20);
            this.nicTxt.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(593, 8);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button4.Size = new System.Drawing.Size(134, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "Browse";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.browseCustomer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 384);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // sysUser
            // 
            this.sysUser.AutoSize = true;
            this.sysUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sysUser.Location = new System.Drawing.Point(50, 361);
            this.sysUser.Name = "sysUser";
            this.sysUser.Size = new System.Drawing.Size(51, 13);
            this.sysUser.TabIndex = 6;
            this.sysUser.Text = "sysUser";
            // 
            // sysTime
            // 
            this.sysTime.AutoSize = true;
            this.sysTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sysTime.Location = new System.Drawing.Point(47, 292);
            this.sysTime.Name = "sysTime";
            this.sysTime.Size = new System.Drawing.Size(42, 16);
            this.sysTime.TabIndex = 5;
            this.sysTime.Text = "Time";
            // 
            // sysDate
            // 
            this.sysDate.AutoSize = true;
            this.sysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sysDate.Location = new System.Drawing.Point(13, 318);
            this.sysDate.Name = "sysDate";
            this.sysDate.Size = new System.Drawing.Size(34, 13);
            this.sysDate.TabIndex = 4;
            this.sysDate.Text = "Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(13, 391);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button5.Size = new System.Drawing.Size(137, 43);
            this.button5.TabIndex = 8;
            this.button5.Text = "Logout";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.sysUser);
            this.panel2.Controls.Add(this.sysTime);
            this.panel2.Controls.Add(this.sysDate);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(741, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 452);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.AddBtn);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.editUserBtn);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(154, 233);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.AddBtn.Size = new System.Drawing.Size(134, 51);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add Customer";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.addCustomers);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 60);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Dependant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addDependants);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 117);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button6.Size = new System.Drawing.Size(134, 51);
            this.button6.TabIndex = 9;
            this.button6.Text = "Add User";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addUser);
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.editUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUserBtn.Location = new System.Drawing.Point(3, 174);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.editUserBtn.Size = new System.Drawing.Size(134, 51);
            this.editUserBtn.TabIndex = 10;
            this.editUserBtn.Text = "Edit Users";
            this.editUserBtn.UseVisualStyleBackColor = true;
            this.editUserBtn.Click += new System.EventHandler(this.editUser);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-10, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 92);
            this.panel1.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.dashboardBtn);
            this.flowLayoutPanel1.Controls.Add(this.customerBtn);
            this.flowLayoutPanel1.Controls.Add(this.dashBtn);
            this.flowLayoutPanel1.Controls.Add(this.leaseBtn);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(3, 3);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.dashboardBtn.Size = new System.Drawing.Size(137, 51);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.customerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.Image = ((System.Drawing.Image)(resources.GetObject("customerBtn.Image")));
            this.customerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.Location = new System.Drawing.Point(146, 3);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.customerBtn.Size = new System.Drawing.Size(137, 51);
            this.customerBtn.TabIndex = 2;
            this.customerBtn.Text = "Customers";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashBtn.Image")));
            this.dashBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashBtn.Location = new System.Drawing.Point(289, 3);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.dashBtn.Size = new System.Drawing.Size(137, 51);
            this.dashBtn.TabIndex = 1;
            this.dashBtn.Text = "Apartments";
            this.dashBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashBtn.UseVisualStyleBackColor = false;
            this.dashBtn.Click += new System.EventHandler(this.apartmentBtn_Click);
            // 
            // leaseBtn
            // 
            this.leaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaseBtn.Image = ((System.Drawing.Image)(resources.GetObject("leaseBtn.Image")));
            this.leaseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leaseBtn.Location = new System.Drawing.Point(432, 3);
            this.leaseBtn.Name = "leaseBtn";
            this.leaseBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.leaseBtn.Size = new System.Drawing.Size(137, 51);
            this.leaseBtn.TabIndex = 3;
            this.leaseBtn.Text = "Leasings";
            this.leaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leaseBtn.UseVisualStyleBackColor = true;
            this.leaseBtn.Click += new System.EventHandler(this.leaseBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(575, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reports";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerHome";
            this.Text = "CustomerHome";
            this.Load += new System.EventHandler(this.CustomerHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nicTxt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label sysUser;
        private System.Windows.Forms.Label sysTime;
        private System.Windows.Forms.Label sysDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Button leaseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button button2;
    }
}