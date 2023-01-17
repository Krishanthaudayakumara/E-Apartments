namespace E_Apartments.Apartment
{
    partial class AddApt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.address = new System.Windows.Forms.Label();
            this.locationData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.clsData = new System.Windows.Forms.Label();
            this.floorNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.ComboBox();
            this.aptClass = new System.Windows.Forms.ComboBox();
            this.aptNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.facilities = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.noOfRoomsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.floorArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.TextBox();
            this.maxOccupants = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.maxOccupants);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.deposit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rent);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.floorArea);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.noOfRoomsTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.locationData);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.selectImageBtn);
            this.groupBox1.Controls.Add(this.clsData);
            this.groupBox1.Controls.Add(this.floorNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.building);
            this.groupBox1.Controls.Add(this.aptClass);
            this.groupBox1.Controls.Add(this.aptNo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 475);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartment Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(393, 123);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(70, 13);
            this.address.TabIndex = 21;
            this.address.Text = "Auto Address";
            // 
            // locationData
            // 
            this.locationData.AutoSize = true;
            this.locationData.Location = new System.Drawing.Point(393, 94);
            this.locationData.Name = "locationData";
            this.locationData.Size = new System.Drawing.Size(81, 13);
            this.locationData.TabIndex = 20;
            this.locationData.Text = "Location details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(80, 434);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(115, 23);
            this.selectImageBtn.TabIndex = 18;
            this.selectImageBtn.Text = "Select Image";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clsData
            // 
            this.clsData.AutoSize = true;
            this.clsData.Location = new System.Drawing.Point(75, 93);
            this.clsData.Name = "clsData";
            this.clsData.Size = new System.Drawing.Size(67, 13);
            this.clsData.TabIndex = 19;
            this.clsData.Text = "Class Details";
            // 
            // floorNumber
            // 
            this.floorNumber.Location = new System.Drawing.Point(396, 26);
            this.floorNumber.Name = "floorNumber";
            this.floorNumber.Size = new System.Drawing.Size(193, 20);
            this.floorNumber.TabIndex = 16;
            this.floorNumber.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Floor No : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // building
            // 
            this.building.FormattingEnabled = true;
            this.building.Location = new System.Drawing.Point(396, 64);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(192, 21);
            this.building.TabIndex = 13;
            this.building.SelectedIndexChanged += new System.EventHandler(this.building_SelectedIndexChanged);
            // 
            // aptClass
            // 
            this.aptClass.FormattingEnabled = true;
            this.aptClass.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Suite"});
            this.aptClass.Location = new System.Drawing.Point(78, 58);
            this.aptClass.Name = "aptClass";
            this.aptClass.Size = new System.Drawing.Size(192, 21);
            this.aptClass.TabIndex = 11;
            this.aptClass.SelectedIndexChanged += new System.EventHandler(this.aptClass_SelectedIndexChanged);
            // 
            // aptNo
            // 
            this.aptNo.Location = new System.Drawing.Point(78, 26);
            this.aptNo.Name = "aptNo";
            this.aptNo.Size = new System.Drawing.Size(193, 20);
            this.aptNo.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.facilities);
            this.groupBox2.Location = new System.Drawing.Point(341, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 155);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facilities";
            // 
            // facilities
            // 
            this.facilities.FormattingEnabled = true;
            this.facilities.Items.AddRange(new object[] {
            "Living & Dining Area",
            "Kitchen/Pantry",
            "Laundry area",
            "Balcony",
            "Telephone connection",
            "Broadband connection",
            "TV connection",
            "Parking space"});
            this.facilities.Location = new System.Drawing.Point(6, 19);
            this.facilities.Name = "facilities";
            this.facilities.Size = new System.Drawing.Size(195, 124);
            this.facilities.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Class : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Building : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apt. No : ";
            // 
            // reportBtn
            // 
            this.reportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.reportBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportBtn.Image")));
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(520, 504);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.reportBtn.Size = new System.Drawing.Size(134, 51);
            this.reportBtn.TabIndex = 6;
            this.reportBtn.Text = "Save";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.addApartment);
            // 
            // noOfRoomsTxt
            // 
            this.noOfRoomsTxt.Location = new System.Drawing.Point(106, 164);
            this.noOfRoomsTxt.Name = "noOfRoomsTxt";
            this.noOfRoomsTxt.Size = new System.Drawing.Size(164, 20);
            this.noOfRoomsTxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "No. Of. Rooms : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Floor Area : ";
            // 
            // floorArea
            // 
            this.floorArea.Location = new System.Drawing.Point(394, 164);
            this.floorArea.Name = "floorArea";
            this.floorArea.Size = new System.Drawing.Size(194, 20);
            this.floorArea.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Applicable Rent : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(106, 225);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(164, 20);
            this.rent.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Deposit : ";
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(394, 225);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(194, 20);
            this.deposit.TabIndex = 29;
            // 
            // maxOccupants
            // 
            this.maxOccupants.Location = new System.Drawing.Point(106, 196);
            this.maxOccupants.Name = "maxOccupants";
            this.maxOccupants.Size = new System.Drawing.Size(164, 20);
            this.maxOccupants.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Max Occupants : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Add floor area in square feet";
            // 
            // AddApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 567);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddApt";
            this.Text = "Add Apartment";
            this.Load += new System.EventHandler(this.AddApt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.ComboBox aptClass;
        private System.Windows.Forms.TextBox aptNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox facilities;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.TextBox floorNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label locationData;
        private System.Windows.Forms.Label clsData;
        private System.Windows.Forms.TextBox rent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox floorArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noOfRoomsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deposit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox maxOccupants;
        private System.Windows.Forms.Label label11;
    }
}