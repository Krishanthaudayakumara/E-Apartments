namespace E_Apartments.Apartment
{
    partial class EditBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBuilding));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.noOfApt = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.selectImageBtn);
            this.groupBox1.Controls.Add(this.noOfApt);
            this.groupBox1.Controls.Add(this.location);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 315);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Details";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(78, 63);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(511, 20);
            this.address.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(78, 276);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(115, 23);
            this.selectImageBtn.TabIndex = 18;
            this.selectImageBtn.Text = "Select Image";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // noOfApt
            // 
            this.noOfApt.Location = new System.Drawing.Point(474, 28);
            this.noOfApt.Name = "noOfApt";
            this.noOfApt.Size = new System.Drawing.Size(115, 20);
            this.noOfApt.TabIndex = 16;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(165, 28);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(193, 20);
            this.location.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. of Apt. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location : ";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(380, 335);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editBuilding);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(520, 335);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button3.Size = new System.Drawing.Size(134, 51);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteBuilding);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID : ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(47, 31);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(27, 13);
            this.ID.TabIndex = 22;
            this.ID.Text = "ID : ";
            // 
            // EditBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditBuilding";
            this.Text = "EditBuilding";
            this.Load += new System.EventHandler(this.EditBuilding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.TextBox noOfApt;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
    }
}