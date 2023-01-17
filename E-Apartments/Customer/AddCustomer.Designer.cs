namespace E_Apartments.Customer
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.reportBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.clsData = new System.Windows.Forms.Label();
            this.nicTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportBtn
            // 
            this.reportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reportBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportBtn.Image")));
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(520, 375);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.reportBtn.Size = new System.Drawing.Size(134, 51);
            this.reportBtn.TabIndex = 8;
            this.reportBtn.Text = "Save";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.addCustomer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(78, 323);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(115, 23);
            this.selectImageBtn.TabIndex = 18;
            this.selectImageBtn.Text = "Select Image";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // clsData
            // 
            this.clsData.AutoSize = true;
            this.clsData.Location = new System.Drawing.Point(18, 94);
            this.clsData.Name = "clsData";
            this.clsData.Size = new System.Drawing.Size(70, 13);
            this.clsData.TabIndex = 19;
            this.clsData.Text = "Contact No. :";
            this.clsData.Click += new System.EventHandler(this.clsData_Click);
            // 
            // nicTxt
            // 
            this.nicTxt.Location = new System.Drawing.Point(396, 26);
            this.nicTxt.Name = "nicTxt";
            this.nicTxt.Size = new System.Drawing.Size(193, 20);
            this.nicTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIC/ Passport :";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(87, 26);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(193, 20);
            this.nameTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alt. Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.contactTxt);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.selectImageBtn);
            this.groupBox1.Controls.Add(this.clsData);
            this.groupBox1.Controls.Add(this.nicTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 357);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Enter the username if he/she should be allowed access";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contactTxt
            // 
            this.contactTxt.Location = new System.Drawing.Point(87, 91);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(193, 20);
            this.contactTxt.TabIndex = 23;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(87, 58);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(502, 20);
            this.addressTxt.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(321, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 61);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Login";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(73, 30);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(170, 20);
            this.userName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "User Name :";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.Label clsData;
        private System.Windows.Forms.TextBox nicTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
    }
}