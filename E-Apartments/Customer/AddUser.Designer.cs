namespace E_Apartments.Customer
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.reportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isClerk = new System.Windows.Forms.CheckBox();
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
            this.reportBtn.Location = new System.Drawing.Point(141, 221);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.reportBtn.Size = new System.Drawing.Size(134, 51);
            this.reportBtn.TabIndex = 10;
            this.reportBtn.Text = "Add";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.addUser);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add System User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isClerk);
            this.groupBox2.Controls.Add(this.isAdmin);
            this.groupBox2.Controls.Add(this.passwordTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.userNameTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 166);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Login";
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(73, 113);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(55, 17);
            this.isAdmin.TabIndex = 10;
            this.isAdmin.Text = "Admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(73, 73);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(170, 20);
            this.passwordTxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password :";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(73, 30);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(170, 20);
            this.userNameTxt.TabIndex = 25;
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
            // isClerk
            // 
            this.isClerk.AutoSize = true;
            this.isClerk.Location = new System.Drawing.Point(134, 113);
            this.isClerk.Name = "isClerk";
            this.isClerk.Size = new System.Drawing.Size(50, 17);
            this.isClerk.TabIndex = 28;
            this.isClerk.Text = "Clerk";
            this.isClerk.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 285);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.CheckBox isClerk;
    }
}