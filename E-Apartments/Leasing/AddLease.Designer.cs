namespace E_Apartments.Leasing
{
    partial class AddLease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLease));
            this.addBtn = new System.Windows.Forms.Button();
            this.nicTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.building = new System.Windows.Forms.ComboBox();
            this.aptNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aptId = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.rentTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.feeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(520, 385);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.addBtn.Size = new System.Drawing.Size(134, 51);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addLeaseAgreement);
            // 
            // nicTxt
            // 
            this.nicTxt.Location = new System.Drawing.Point(95, 52);
            this.nicTxt.Name = "nicTxt";
            this.nicTxt.Size = new System.Drawing.Size(167, 20);
            this.nicTxt.TabIndex = 16;
            this.nicTxt.TextChanged += new System.EventHandler(this.nicTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIC/ Passport :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.nicTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fetchCustomer);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 100);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(70, 26);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(193, 20);
            this.nameTxt.TabIndex = 10;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.building);
            this.groupBox2.Controls.Add(this.aptNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 122);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apartment Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Apt. No : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // building
            // 
            this.building.FormattingEnabled = true;
            this.building.Location = new System.Drawing.Point(70, 52);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(192, 21);
            this.building.TabIndex = 22;
            this.building.SelectedIndexChanged += new System.EventHandler(this.building_SelectedIndexChanged);
            // 
            // aptNo
            // 
            this.aptNo.Location = new System.Drawing.Point(70, 20);
            this.aptNo.Name = "aptNo";
            this.aptNo.Size = new System.Drawing.Size(193, 20);
            this.aptNo.TabIndex = 21;
            this.aptNo.TextChanged += new System.EventHandler(this.aptNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Building : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.fetchApartment);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(272, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(364, 99);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Customer ID : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.Location = new System.Drawing.Point(104, 276);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(50, 13);
            this.customerId.TabIndex = 21;
            this.customerId.Text = "customer";
            this.customerId.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Apt. ID : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // aptId
            // 
            this.aptId.AutoSize = true;
            this.aptId.Location = new System.Drawing.Point(403, 276);
            this.aptId.Name = "aptId";
            this.aptId.Size = new System.Drawing.Size(38, 13);
            this.aptId.TabIndex = 23;
            this.aptId.Text = "Apt. Id";
            this.aptId.Click += new System.EventHandler(this.aptId_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(94, 304);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 24;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Start Date : ";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "End Date : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(406, 304);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 27;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Deposit : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Rent : ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(94, 340);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(193, 20);
            this.depositTxt.TabIndex = 23;
            this.depositTxt.TextChanged += new System.EventHandler(this.depositTxt_TextChanged);
            // 
            // rentTxt
            // 
            this.rentTxt.Location = new System.Drawing.Point(406, 340);
            this.rentTxt.Name = "rentTxt";
            this.rentTxt.Size = new System.Drawing.Size(193, 20);
            this.rentTxt.TabIndex = 30;
            this.rentTxt.TextChanged += new System.EventHandler(this.rentTxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Paid Fee : ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // feeTxt
            // 
            this.feeTxt.Location = new System.Drawing.Point(94, 373);
            this.feeTxt.Name = "feeTxt";
            this.feeTxt.Size = new System.Drawing.Size(193, 20);
            this.feeTxt.TabIndex = 32;
            this.feeTxt.TextChanged += new System.EventHandler(this.feeTxt_TextChanged);
            // 
            // AddLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.feeTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rentTxt);
            this.Controls.Add(this.depositTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.aptId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddLease";
            this.Text = "AddLease";
            this.Load += new System.EventHandler(this.AddLease_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nicTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox building;
        private System.Windows.Forms.TextBox aptNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customerId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label aptId;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.TextBox rentTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox feeTxt;
    }
}