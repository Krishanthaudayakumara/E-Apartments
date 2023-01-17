using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Leasing
{
    public partial class AddLease : Form
    {

        readonly string connectionString = dbConnection.connectionString;
        public AddLease()
        {
            InitializeComponent();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fetchCustomer(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string name = nameTxt.Text;
            string nic = nicTxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(nic))
                    {
                        command.CommandText = "SELECT * FROM customer WHERE name = @name AND nic_or_passport = @nic";
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@nic", nic);
                    }
                    else if (!string.IsNullOrEmpty(name))
                    {
                        command.CommandText = "SELECT * FROM customer WHERE name = @name";
                        command.Parameters.AddWithValue("@name", name);
                    }
                    else if (!string.IsNullOrEmpty(nic))
                    {
                        command.CommandText = "SELECT * FROM customer WHERE nic_or_passport = @nic";
                        command.Parameters.AddWithValue("@nic", nic);
                    }
                    else
                    {
                        MessageBox.Show("Please enter either name or nic or both fields");

                    }
                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView1.DataSource = dt;



                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customerId.Text = reader["id"].ToString();
                            }

                        }


                    }
                    catch (Exception ext)
                    {
                        MessageBox.Show(ext.Message);
                    }
                }
            }

        }

        private void fetchApartment(object sender, EventArgs e)
        {
            string apt_no = aptNo.Text;
            string building_data = building.Text;
            var match = Regex.Match(building_data, @"Building\s(\d+)");
            int buildingNumber = 0;
            if (match.Success)
            {
                buildingNumber = int.Parse(match.Groups[1].Value);
            }

            string query = "SELECT * FROM apartments WHERE 1=1 ";
            if (!string.IsNullOrEmpty(apt_no))
            {
                query += " AND apt_no = @apt_no ";
            }
            if (!string.IsNullOrEmpty(building_data))
            {
                query += " AND building_id = @building ";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(apt_no))
                    {
                        command.Parameters.AddWithValue("@apt_no", apt_no);
                    }
                    if (!string.IsNullOrEmpty(building_data))
                    {
                        command.Parameters.AddWithValue("@building", buildingNumber);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        dataGridView2.DataSource = data;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                aptId.Text = reader["id"].ToString();
                            }

                        }
                    }
                }
            }
        }

        private void AddLease_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM buildings";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            building.Items.Add("Building " + reader["id"].ToString() + " - " + reader["address"]);
                        }
                    }
                }
            }
        }

        private void addLeaseAgreement(object sender, EventArgs e)
        {
          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO lease_agreements (customer_id, apartment_id, start_date, end_date, rent, deposit, fee, status) VALUES (@customer_id, @apartment_id, @start_date, @end_date, @rent, @deposit, @fee, @status)";
                    command.Parameters.AddWithValue("@customer_id", customerId.Text);
                    command.Parameters.AddWithValue("@apartment_id", aptId.Text);
                    command.Parameters.AddWithValue("@start_date", startDatePicker.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@end_date", endDatePicker.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@rent", rentTxt.Text);
                    command.Parameters.AddWithValue("@deposit", depositTxt.Text);
                    command.Parameters.AddWithValue("@fee", feeTxt.Text);
                    command.Parameters.AddWithValue("@status", 1);
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully");
                        aptId.Text = "";
                        customerId.Text = "";
                        startDatePicker.Value = DateTime.Now;
                        endDatePicker.Value = DateTime.Now;
                        rentTxt.Clear();
                        depositTxt.Clear();
                        feeTxt.Clear();



                    }
                }
            }
        }

        private void nicTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void building_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aptNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void aptId_Click(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void depositTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void feeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
