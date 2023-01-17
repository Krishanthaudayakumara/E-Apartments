namespace E_Apartments.AdminDashboard
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.leaseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sysTime = new System.Windows.Forms.Label();
            this.sysDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sysUser = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.apartmentCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerCount = new System.Windows.Forms.Label();
            this.allLeasingCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.availableApartmentCount = new System.Windows.Forms.Label();
            this.totalDependantCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pendingLeasingCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pendingExtensionCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.totalRentIncome = new System.Windows.Forms.Label();
            this.totalDepositIncome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
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
            this.dashboardBtn.BackColor = System.Drawing.Color.PaleTurquoise;
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
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // customerBtn
            // 
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
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // sysTime
            // 
            this.sysTime.AutoSize = true;
            this.sysTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sysTime.Location = new System.Drawing.Point(66, 26);
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
            this.sysDate.Location = new System.Drawing.Point(32, 52);
            this.sysDate.Name = "sysDate";
            this.sysDate.Size = new System.Drawing.Size(34, 13);
            this.sysDate.TabIndex = 4;
            this.sysDate.Text = "Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(-2, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 85);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(669, 27);
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
            this.sysUser.Location = new System.Drawing.Point(703, 38);
            this.sysUser.Name = "sysUser";
            this.sysUser.Size = new System.Drawing.Size(51, 13);
            this.sysUser.TabIndex = 6;
            this.sysUser.Text = "sysUser";
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(767, 19);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button5.Size = new System.Drawing.Size(137, 43);
            this.button5.TabIndex = 8;
            this.button5.Text = "Logout";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 152);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label1.Size = new System.Drawing.Size(187, 56);
            this.label1.TabIndex = 32;
            this.label1.Text = "Apartments";
            // 
            // apartmentCount
            // 
            this.apartmentCount.AutoSize = true;
            this.apartmentCount.BackColor = System.Drawing.Color.Cornsilk;
            this.apartmentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apartmentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.apartmentCount.Location = new System.Drawing.Point(215, 152);
            this.apartmentCount.Name = "apartmentCount";
            this.apartmentCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.apartmentCount.Size = new System.Drawing.Size(82, 56);
            this.apartmentCount.TabIndex = 33;
            this.apartmentCount.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(321, 152);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label3.Size = new System.Drawing.Size(181, 56);
            this.label3.TabIndex = 34;
            this.label3.Text = "Customers";
            // 
            // customerCount
            // 
            this.customerCount.AutoSize = true;
            this.customerCount.BackColor = System.Drawing.Color.Cornsilk;
            this.customerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerCount.Location = new System.Drawing.Point(508, 152);
            this.customerCount.Name = "customerCount";
            this.customerCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.customerCount.Size = new System.Drawing.Size(82, 56);
            this.customerCount.TabIndex = 35;
            this.customerCount.Text = "5";
            // 
            // allLeasingCount
            // 
            this.allLeasingCount.AutoSize = true;
            this.allLeasingCount.BackColor = System.Drawing.Color.Cornsilk;
            this.allLeasingCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allLeasingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allLeasingCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allLeasingCount.Location = new System.Drawing.Point(818, 152);
            this.allLeasingCount.Name = "allLeasingCount";
            this.allLeasingCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.allLeasingCount.Size = new System.Drawing.Size(82, 56);
            this.allLeasingCount.TabIndex = 37;
            this.allLeasingCount.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(617, 152);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label6.Size = new System.Drawing.Size(195, 56);
            this.label6.TabIndex = 36;
            this.label6.Text = "All Leasings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(22, 238);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label7.Size = new System.Drawing.Size(174, 72);
            this.label7.TabIndex = 38;
            this.label7.Text = "Available \r\nApartments";
            // 
            // availableApartmentCount
            // 
            this.availableApartmentCount.AutoSize = true;
            this.availableApartmentCount.BackColor = System.Drawing.Color.Cornsilk;
            this.availableApartmentCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableApartmentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableApartmentCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.availableApartmentCount.Location = new System.Drawing.Point(215, 254);
            this.availableApartmentCount.Name = "availableApartmentCount";
            this.availableApartmentCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.availableApartmentCount.Size = new System.Drawing.Size(82, 56);
            this.availableApartmentCount.TabIndex = 39;
            this.availableApartmentCount.Text = "5";
            // 
            // totalDependantCount
            // 
            this.totalDependantCount.AutoSize = true;
            this.totalDependantCount.BackColor = System.Drawing.Color.Cornsilk;
            this.totalDependantCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDependantCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDependantCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalDependantCount.Location = new System.Drawing.Point(508, 250);
            this.totalDependantCount.Name = "totalDependantCount";
            this.totalDependantCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.totalDependantCount.Size = new System.Drawing.Size(82, 56);
            this.totalDependantCount.TabIndex = 41;
            this.totalDependantCount.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(321, 254);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label10.Size = new System.Drawing.Size(179, 52);
            this.label10.TabIndex = 40;
            this.label10.Text = "Dependants";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(614, 238);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label11.Size = new System.Drawing.Size(198, 72);
            this.label11.TabIndex = 42;
            this.label11.Text = "Pending \r\nL. Agreements\r\n";
            // 
            // pendingLeasingCount
            // 
            this.pendingLeasingCount.AutoSize = true;
            this.pendingLeasingCount.BackColor = System.Drawing.Color.Cornsilk;
            this.pendingLeasingCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendingLeasingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingLeasingCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pendingLeasingCount.Location = new System.Drawing.Point(818, 254);
            this.pendingLeasingCount.Name = "pendingLeasingCount";
            this.pendingLeasingCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.pendingLeasingCount.Size = new System.Drawing.Size(82, 56);
            this.pendingLeasingCount.TabIndex = 43;
            this.pendingLeasingCount.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Navy;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(617, 336);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(35, 15, 35, 15);
            this.label13.Size = new System.Drawing.Size(189, 72);
            this.label13.TabIndex = 44;
            this.label13.Text = "Pending \r\nL. Extensions";
            // 
            // pendingExtensionCount
            // 
            this.pendingExtensionCount.AutoSize = true;
            this.pendingExtensionCount.BackColor = System.Drawing.Color.Cornsilk;
            this.pendingExtensionCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pendingExtensionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingExtensionCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pendingExtensionCount.Location = new System.Drawing.Point(818, 352);
            this.pendingExtensionCount.Name = "pendingExtensionCount";
            this.pendingExtensionCount.Padding = new System.Windows.Forms.Padding(25, 13, 25, 10);
            this.pendingExtensionCount.Size = new System.Drawing.Size(82, 56);
            this.pendingExtensionCount.TabIndex = 45;
            this.pendingExtensionCount.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 359);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 24);
            this.label15.TabIndex = 46;
            this.label15.Text = "Total Rent Income";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(317, 359);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 24);
            this.label16.TabIndex = 47;
            this.label16.Text = "Total Deposit Income";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.ForestGreen;
            this.label17.Location = new System.Drawing.Point(18, 398);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 24);
            this.label17.TabIndex = 48;
            this.label17.Text = "Rs .";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.ForestGreen;
            this.label18.Location = new System.Drawing.Point(317, 398);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 24);
            this.label18.TabIndex = 49;
            this.label18.Text = "Rs .";
            // 
            // totalRentIncome
            // 
            this.totalRentIncome.AutoSize = true;
            this.totalRentIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRentIncome.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalRentIncome.Location = new System.Drawing.Point(70, 398);
            this.totalRentIncome.Name = "totalRentIncome";
            this.totalRentIncome.Size = new System.Drawing.Size(54, 24);
            this.totalRentIncome.TabIndex = 50;
            this.totalRentIncome.Text = "0000";
            // 
            // totalDepositIncome
            // 
            this.totalDepositIncome.AutoSize = true;
            this.totalDepositIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDepositIncome.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalDepositIncome.Location = new System.Drawing.Point(369, 398);
            this.totalDepositIncome.Name = "totalDepositIncome";
            this.totalDepositIncome.Size = new System.Drawing.Size(54, 24);
            this.totalDepositIncome.TabIndex = 51;
            this.totalDepositIncome.Text = "0000";
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 566);
            this.Controls.Add(this.totalDepositIncome);
            this.Controls.Add(this.totalRentIncome);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pendingExtensionCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pendingLeasingCount);
            this.Controls.Add(this.totalDependantCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.availableApartmentCount);
            this.Controls.Add(this.allLeasingCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.apartmentCount);
            this.Name = "AdminDash";
            this.Text = "AdminDash";
            this.Load += new System.EventHandler(this.AdminDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Button leaseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sysTime;
        private System.Windows.Forms.Label sysDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label sysUser;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label apartmentCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label customerCount;
        private System.Windows.Forms.Label allLeasingCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label availableApartmentCount;
        private System.Windows.Forms.Label totalDependantCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label pendingLeasingCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label pendingExtensionCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label totalRentIncome;
        private System.Windows.Forms.Label totalDepositIncome;
    }
}