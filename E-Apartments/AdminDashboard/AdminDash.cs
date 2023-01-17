using E_Apartments.Customer;
using E_Apartments.Leasing;
using E_Apartments.Reports;
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

namespace E_Apartments.AdminDashboard
{
    public partial class AdminDash : Form
    {

        readonly string connectionString = dbConnection.connectionString;
        string User;
        bool IsAdmin, IsClerk;

        public AdminDash(string user, bool isAdmin, bool isClerk)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin;
            this.IsClerk = isClerk;
            this.User = user;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sysDate.Text = DateTime.Now.ToLongDateString();
            sysTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome(User, IsAdmin, IsClerk);
            customerHome.Show();
            this.Hide();
        }

       
        private void leaseBtn_Click(object sender, EventArgs e)
        {
            LeasingHome leasingHome = new LeasingHome(User, IsAdmin, IsClerk);
            leasingHome.Show();
            this.Hide();
        }

    
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void apartmentBtn_Click(object sender, EventArgs e)
        {

            ApartmentHome apartmentHome = new ApartmentHome(User, IsAdmin, IsClerk);
            apartmentHome.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                ReportHome report = new ReportHome(User, IsAdmin, IsClerk);
                report.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");

            }
        }

        private void AdminDash_Load(object sender, EventArgs e)
        {
            timer1.Start();

            sysUser.Text = User;

            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the total number of apartments
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM apartments", connection);
            apartmentCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the number of available apartments
            command = new SqlCommand("SELECT COUNT(*) FROM apartments a WHERE a.id NOT IN (SELECT apartment_id FROM reservations WHERE status = 1)", connection);
            availableApartmentCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the total number of customers
            command = new SqlCommand("SELECT COUNT(*) FROM customer", connection);
            customerCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the total number of dependants
            command = new SqlCommand("SELECT COUNT(*) FROM dependants", connection);
            totalDependantCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the total number of lease agreements
            command = new SqlCommand("SELECT COUNT(*) FROM lease_agreements", connection);
            allLeasingCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the number of pending lease agreements
            command = new SqlCommand("SELECT COUNT(*) FROM lease_agreements WHERE status = 0", connection);
            pendingLeasingCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the count of pending lease extension requests
            command = new SqlCommand("SELECT COUNT(*) FROM lease_extensions WHERE status = 'pending'", connection);
            pendingExtensionCount.Text = command.ExecuteScalar().ToString();

            // Retrieve the total income from rent
            command = new SqlCommand("SELECT SUM(rent) FROM lease_agreements", connection);
            totalRentIncome.Text = command.ExecuteScalar().ToString();

            // Retrieve the total income from deposit
            command = new SqlCommand("SELECT SUM(deposit) FROM lease_agreements", connection);
            totalDepositIncome.Text = command.ExecuteScalar().ToString();

            connection.Close();

        }
    }
}
