using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Customer
{
    public partial class CustomerDash : Form
    {

        readonly string connectionString = dbConnection.connectionString;

        string User;
        bool IsAdmin, IsClerk;
        public CustomerDash(string user, bool isAdmin, bool isClerk)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin;
            this.IsClerk = isClerk;
            this.User = user;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            // Get the current logged in user
            string username = User;
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Verify the old password
            SqlCommand command = new SqlCommand("SELECT password FROM users WHERE username = @username", connection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader["password"].ToString() == oldPasswordTxt.Text)
                {
                    reader.Close();
                    // Update the password
                    command = new SqlCommand("UPDATE users SET password = @newPassword WHERE username = @username", connection);
                    command.Parameters.AddWithValue("@newPassword", newPasswordTxt.Text);
                    command.Parameters.AddWithValue("@username", username);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully!");
                }
                else
                {
                    MessageBox.Show("Incorrect old password!");
                }
            }
            else
            {
                MessageBox.Show("An error occurred!");
            }
            connection.Close();

        }

    private void logout(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sysDate.Text = DateTime.Now.ToLongDateString();
            sysTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void CustomerDash_Load(object sender, EventArgs e)
        {
            timer1.Start();

            sysUser.Text = User;

            // Get the current logged in user
            string username = User;
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the customer information
            SqlCommand command = new SqlCommand("SELECT c.name, c.nic_or_passport, c.alternative_address, c.contact_no, a.apt_no, b.location, b.address, l.rent FROM customer c LEFT JOIN lease_agreements l ON c.id = l.customer_id LEFT JOIN apartments a ON l.apartment_id = a.id LEFT JOIN buildings b ON a.building_id = b.id WHERE c.user_id = (SELECT id FROM users WHERE username = @username)", connection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataReader reader = command.ExecuteReader();

            // Display the customer information in the labels
            if (reader.Read())
            {
                customerName.Text = reader["name"].ToString();
                nameLabel.Text = reader["name"].ToString();
                nicLabel.Text = reader["nic_or_passport"].ToString();
                altAddressLabel.Text = reader["alternative_address"].ToString();
                contactNoLabel.Text = reader["contact_no"].ToString();
                aptNoLabel.Text = reader["apt_no"] != DBNull.Value ? reader["apt_no"].ToString() : "";
                locationLabel.Text = reader["location"] != DBNull.Value ? reader["location"].ToString() : "";
                aptAddressLabel.Text = reader["address"] != DBNull.Value ? reader["location"].ToString() : "";
                rentLabel.Text = reader["rent"] != DBNull.Value ? reader["rent"].ToString() : "";
            }

            reader.Close();

            // Retrieve the dependants information
            command = new SqlCommand("SELECT name, age, relation FROM dependants WHERE customer_id = (SELECT id FROM customer WHERE user_id = (SELECT id FROM users WHERE username = @username))", connection);
            command.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dependants = new DataTable();
            adapter.Fill(dependants);

            // Display the dependants information in the data grid view
            dataGridView1.DataSource = dependants;

            connection.Close();
        }

    }
}
