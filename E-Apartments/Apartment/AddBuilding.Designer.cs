namespace E_Apartments.Apartment
{
    partial class AddBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBuilding));
            this.reportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.noOfApt = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.reportBtn.Location = new System.Drawing.Point(520, 333);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.reportBtn.Size = new System.Drawing.Size(134, 51);
            this.reportBtn.TabIndex = 8;
            this.reportBtn.Text = "Save";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.addBuilding);
            // 
            // groupBox1
            // 
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
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.noOfApt.Location = new System.Drawing.Point(387, 26);
            this.noOfApt.Name = "noOfApt";
            this.noOfApt.Size = new System.Drawing.Size(202, 20);
            this.noOfApt.TabIndex = 16;
            this.noOfApt.TextChanged += new System.EventHandler(this.floorNumber_TextChanged);
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(78, 26);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(193, 20);
            this.location.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 29);
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
            this.label4.Location = new System.Drawing.Point(20, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location : ";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(78, 63);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(511, 20);
            this.address.TabIndex = 20;
            // 
            // AddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 398);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBuilding";
            this.Text = "AddBuilding";
            this.Load += new System.EventHandler(this.AddBuilding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.TextBox noOfApt;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
    }
}