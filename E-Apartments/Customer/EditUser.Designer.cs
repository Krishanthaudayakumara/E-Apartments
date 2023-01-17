namespace E_Apartments.Customer
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.isClerk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 203);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit System User";
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
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 221);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 12;
            this.button2.Text = "Edit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editUser);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(147, 221);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button3.Size = new System.Drawing.Size(134, 51);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteUser);
            // 
            // isClerk
            // 
            this.isClerk.AutoSize = true;
            this.isClerk.Location = new System.Drawing.Point(129, 113);
            this.isClerk.Name = "isClerk";
            this.isClerk.Size = new System.Drawing.Size(55, 17);
            this.isClerk.TabIndex = 28;
            this.isClerk.Text = "Admin";
            this.isClerk.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox isClerk;
    }
}