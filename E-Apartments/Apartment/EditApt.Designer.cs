namespace E_Apartments.Apartment
{
    partial class EditApt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditApt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aptIdLabel = new System.Windows.Forms.Label();
            this.facilities = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.Label();
            this.locationData = new System.Windows.Forms.Label();
            this.clsData = new System.Windows.Forms.Label();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.floorNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.ComboBox();
            this.aptClass = new System.Windows.Forms.ComboBox();
            this.aptNo = new System.Windows.Forms.TextBox();
            this.facilityBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maxOccupants = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.floorArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.noOfRoomsTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.facilityBox.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.aptIdLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.locationData);
            this.groupBox1.Controls.Add(this.clsData);
            this.groupBox1.Controls.Add(this.selectImageBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.floorNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.building);
            this.groupBox1.Controls.Add(this.aptClass);
            this.groupBox1.Controls.Add(this.aptNo);
            this.groupBox1.Controls.Add(this.facilityBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 539);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartment Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // aptIdLabel
            // 
            this.aptIdLabel.AutoSize = true;
            this.aptIdLabel.Location = new System.Drawing.Point(75, 30);
            this.aptIdLabel.Name = "aptIdLabel";
            this.aptIdLabel.Size = new System.Drawing.Size(46, 13);
            this.aptIdLabel.TabIndex = 23;
            this.aptIdLabel.Text = "Apt. ID :";
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
            this.facilities.Location = new System.Drawing.Point(14, 19);
            this.facilities.Name = "facilities";
            this.facilities.Size = new System.Drawing.Size(195, 124);
            this.facilities.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Apt. ID :";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(362, 482);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button2.Size = new System.Drawing.Size(134, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editApartment);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(502, 482);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.button3.Size = new System.Drawing.Size(134, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.deleteApartment);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(370, 120);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(70, 13);
            this.address.TabIndex = 21;
            this.address.Text = "Auto Address";
            // 
            // locationData
            // 
            this.locationData.AutoSize = true;
            this.locationData.Location = new System.Drawing.Point(370, 91);
            this.locationData.Name = "locationData";
            this.locationData.Size = new System.Drawing.Size(81, 13);
            this.locationData.TabIndex = 20;
            this.locationData.Text = "Location details";
            // 
            // clsData
            // 
            this.clsData.AutoSize = true;
            this.clsData.Location = new System.Drawing.Point(75, 123);
            this.clsData.Name = "clsData";
            this.clsData.Size = new System.Drawing.Size(67, 13);
            this.clsData.TabIndex = 19;
            this.clsData.Text = "Class Details";
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(73, 484);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(115, 23);
            this.selectImageBtn.TabIndex = 18;
            this.selectImageBtn.Text = "Select Image";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += new System.EventHandler(this.selectImageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // floorNumber
            // 
            this.floorNumber.Location = new System.Drawing.Point(373, 23);
            this.floorNumber.Name = "floorNumber";
            this.floorNumber.Size = new System.Drawing.Size(193, 20);
            this.floorNumber.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Floor No : ";
            // 
            // building
            // 
            this.building.FormattingEnabled = true;
            this.building.Location = new System.Drawing.Point(373, 61);
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
            this.aptClass.Location = new System.Drawing.Point(78, 88);
            this.aptClass.Name = "aptClass";
            this.aptClass.Size = new System.Drawing.Size(192, 21);
            this.aptClass.TabIndex = 11;
            this.aptClass.SelectedIndexChanged += new System.EventHandler(this.aptClass_SelectedIndexChanged);
            // 
            // aptNo
            // 
            this.aptNo.Location = new System.Drawing.Point(78, 56);
            this.aptNo.Name = "aptNo";
            this.aptNo.Size = new System.Drawing.Size(193, 20);
            this.aptNo.TabIndex = 10;
            // 
            // facilityBox
            // 
            this.facilityBox.Controls.Add(this.facilities);
            this.facilityBox.Location = new System.Drawing.Point(324, 314);
            this.facilityBox.Name = "facilityBox";
            this.facilityBox.Size = new System.Drawing.Size(217, 155);
            this.facilityBox.TabIndex = 9;
            this.facilityBox.TabStop = false;
            this.facilityBox.Text = "Facilities";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Class : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Building : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apt. No : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Add floor area in square feet";
            // 
            // maxOccupants
            // 
            this.maxOccupants.Location = new System.Drawing.Point(106, 218);
            this.maxOccupants.Name = "maxOccupants";
            this.maxOccupants.Size = new System.Drawing.Size(164, 20);
            this.maxOccupants.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Max Occupants : ";
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(394, 247);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(194, 20);
            this.deposit.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Deposit : ";
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(106, 247);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(164, 20);
            this.rent.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Applicable Rent : ";
            // 
            // floorArea
            // 
            this.floorArea.Location = new System.Drawing.Point(394, 186);
            this.floorArea.Name = "floorArea";
            this.floorArea.Size = new System.Drawing.Size(194, 20);
            this.floorArea.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Floor Area : ";
            // 
            // noOfRoomsTxt
            // 
            this.noOfRoomsTxt.Location = new System.Drawing.Point(106, 186);
            this.noOfRoomsTxt.Name = "noOfRoomsTxt";
            this.noOfRoomsTxt.Size = new System.Drawing.Size(164, 20);
            this.noOfRoomsTxt.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "No. Of. Rooms : ";
            // 
            // EditApt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 563);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditApt";
            this.Text = "EditApt";
            this.Load += new System.EventHandler(this.EditApt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.facilityBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label locationData;
        private System.Windows.Forms.Label clsData;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox floorNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.ComboBox aptClass;
        private System.Windows.Forms.TextBox aptNo;
        private System.Windows.Forms.GroupBox facilityBox;
        private System.Windows.Forms.CheckedListBox facilities;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aptIdLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox maxOccupants;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox deposit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox floorArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noOfRoomsTxt;
        private System.Windows.Forms.Label label13;
    }
}