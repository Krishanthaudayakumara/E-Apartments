namespace E_Apartments.Customer
{
    partial class AddDependant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDependant));
            this.reportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.relationTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusNICTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cusNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.reportBtn.Location = new System.Drawing.Point(412, 311);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.reportBtn.Size = new System.Drawing.Size(134, 51);
            this.reportBtn.TabIndex = 10;
            this.reportBtn.Text = "Save";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.addDependant);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.relationTxt);
            this.groupBox1.Controls.Add(this.ageTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // relationTxt
            // 
            this.relationTxt.Location = new System.Drawing.Point(79, 58);
            this.relationTxt.Name = "relationTxt";
            this.relationTxt.Size = new System.Drawing.Size(153, 20);
            this.relationTxt.TabIndex = 22;
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(302, 58);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(217, 20);
            this.ageTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Age : ";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(305, 24);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(214, 20);
            this.nameTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Relation : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cusNICTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cusNameTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 167);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Relevent Customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 135);
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 68);
            this.dataGridView1.TabIndex = 17;
            // 
            // cusNICTxt
            // 
            this.cusNICTxt.Location = new System.Drawing.Point(357, 26);
            this.cusNICTxt.Name = "cusNICTxt";
            this.cusNICTxt.Size = new System.Drawing.Size(167, 20);
            this.cusNICTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "NIC/ Passport :";
            // 
            // cusNameTxt
            // 
            this.cusNameTxt.Location = new System.Drawing.Point(70, 26);
            this.cusNameTxt.Name = "cusNameTxt";
            this.cusNameTxt.Size = new System.Drawing.Size(193, 20);
            this.cusNameTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "cust. ID : ";
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.Location = new System.Drawing.Point(81, 27);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(59, 13);
            this.customerId.TabIndex = 24;
            this.customerId.Text = "customerId";
            // 
            // AddDependant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddDependant";
            this.Text = "AddDependant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox relationTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cusNICTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label customerId;
        private System.Windows.Forms.Label label4;
    }
}