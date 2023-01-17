using E_Apartments.AdminDashboard;
using E_Apartments.Apartment;
using E_Apartments.Customer;
using E_Apartments.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace E_Apartments.Leasing
{

    public partial class LeasingHome : Form
    {

        readonly string connectionString = dbConnection.connectionString;
        string User;
        bool IsAdmin, IsClerk;
        public LeasingHome(string user, bool isAdmin, bool isClerk)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin;
            this.IsClerk = isClerk;
            this.User = user;
        }

        private void addAgreement(object sender, EventArgs e)
        {
            AddLease addLease = new AddLease();
            addLease.Show();
        }

        private void browseLeasing(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a new DataTable to store the lease agreements
                DataTable leaseAgreements = new DataTable();

                // Create a new SqlDataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // Set the SELECT command for the SqlDataAdapter to retrieve the lease agreements based on the inputted NIC or name
                    adapter.SelectCommand = new SqlCommand("SELECT lease_agreements.*, customer.name, customer.nic_or_passport FROM lease_agreements INNER JOIN customer ON lease_agreements.customer_id = customer.id WHERE customer.nic_or_passport = @nic OR customer.name = @name", connection);

                    // Add the parameters for the NIC and name
                    adapter.SelectCommand.Parameters.AddWithValue("@nic", nicTxt.Text);
                    adapter.SelectCommand.Parameters.AddWithValue("@name", nameTxt.Text);

                    // Fill the DataTable with the lease agreements
                    adapter.Fill(leaseAgreements);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = leaseAgreements;
                    dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LeasingHome_Load(object sender, EventArgs e)
        {
            timer1.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                // Create a new DataTable to store the lease agreements
                DataTable leaseAgreements = new DataTable();

                // Create a new SqlDataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // Set the SELECT command for the SqlDataAdapter to retrieve the lease agreements with a status of 0
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM lease_agreements WHERE accepted = 0 and status = 1", connection);

                    // Fill the DataTable with the lease agreements
                    adapter.Fill(leaseAgreements);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = leaseAgreements;
                }

                if (IsAdmin)
                {
                    // Add accept and decline buttons to the DataGridView
                    DataGridViewButtonColumn acceptButton = new DataGridViewButtonColumn();
                    acceptButton.HeaderText = "Accept";
                    acceptButton.Text = "Accept";
                    acceptButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(acceptButton);

                    DataGridViewButtonColumn declineButton = new DataGridViewButtonColumn();
                    declineButton.HeaderText = "Decline";
                    declineButton.Text = "Decline";
                    declineButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(declineButton);
                }

                dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

                DataTable reservations = new DataTable();

                // Create a new SqlDataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // Set the SELECT command for the SqlDataAdapter to retrieve the reservations
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM reservations", connection);

                    // Fill the DataTable with the reservations
                    adapter.Fill(reservations);

                    // Bind the DataTable to the DataGridView
                    dataGridView2.DataSource = reservations;
                }
            



            }
    }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && IsAdmin)
            {
                // Get the lease agreement id from the selected row
                int leaseAgreementId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the status of the lease agreement to 1
                    SqlCommand command = new SqlCommand("UPDATE lease_agreements SET accepted = 1 WHERE id = @leaseAgreementId", connection);
                    command.Parameters.AddWithValue("@leaseAgreementId", leaseAgreementId);
                    command.ExecuteNonQuery();

                    // Insert data into the 'reservations' table
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO reservations (date, apartment_id, customer_id, lease_agreement_id, reservation_fee, status) VALUES (@date, @apartmentId, @customerId, @leaseAgreementId, @reservationFee, @status)", connection);
                    insertCommand.Parameters.AddWithValue("@date", DateTime.Now); // Insert the current date
                    insertCommand.Parameters.AddWithValue("@apartmentId", dataGridView1.Rows[e.RowIndex].Cells["apartment_id"].Value); // Insert the apartment id from the selected row
                    insertCommand.Parameters.AddWithValue("@customerId", dataGridView1.Rows[e.RowIndex].Cells["customer_id"].Value); // Insert the customer id from the selected row
                    insertCommand.Parameters.AddWithValue("@leaseAgreementId", leaseAgreementId); // Insert the lease agreement id from the selected row
                    insertCommand.Parameters.AddWithValue("@reservationFee", dataGridView1.Rows[e.RowIndex].Cells["fee"].Value); // Insert the fee from the selected row
                    insertCommand.Parameters.AddWithValue("@status", 1); // Insert the status of 1 for the reservation
                    insertCommand.ExecuteNonQuery();



                    MessageBox.Show("Lease Agreement Accepted");
                }

                // Refresh the DataGridView to show the updated status
                dataGridView1.Refresh();
            }

            if (e.ColumnIndex == 11 && IsAdmin )
            {
                // Get the lease agreement id from the selected row
                int leaseAgreementId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the status of the lease agreement to 0
                    SqlCommand command = new SqlCommand("UPDATE lease_agreements SET status = 0 WHERE id = @leaseAgreementId", connection);
                    command.Parameters.AddWithValue("@leaseAgreementId", leaseAgreementId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Lease Agreement Declined");
                }

                // Refresh the DataGridView to show the updated status
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addExtRequest(object sender, EventArgs e)
        {
            AddExtensionReq addExtensionReq = new AddExtensionReq();
            addExtensionReq.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerHome cus = new CustomerHome(User, IsAdmin, IsClerk);
            this.Hide();
            cus.Show();

        }



        private void apartmentBtn_Click(object sender, EventArgs e)
        {
            ApartmentHome apartmentHome = new ApartmentHome(User, IsAdmin, IsClerk);
            apartmentHome.Show();
            this.Hide();
        }

        private void customerBtn_Click_1(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome(User, IsAdmin, IsClerk);
            customerHome.Show();
            this.Hide();
        }

      

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sysDate.Text = DateTime.Now.ToLongDateString();
            sysTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void pendingExtension(object sender, EventArgs e)
        {
           
            if (IsAdmin)
            {
                PendingExtension pendingExtension = new PendingExtension();
                pendingExtension.Show();

            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                ReportHome report = new ReportHome(User, IsAdmin, IsClerk);
                report.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Only Admin Can Access");

            }


        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(User, IsAdmin, IsClerk);
            adminDash.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 10; // Set the radius of the rounded corners
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Panel panel = (Panel)sender; // Get a reference to the panel
            GraphicsPath path = new GraphicsPath(); // Create a new GraphicsPath object
            path.StartFigure(); // Start a new figure
            path.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90); // Add an arc for the top-left corner
            path.AddLine(cornerRadius, 0, panel.Width - cornerRadius, 0); // Add a line for the top edge
            path.AddArc(new Rectangle(panel.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90); // Add an arc for the top-right corner
            path.AddLine(panel.Width, cornerRadius, panel.Width, panel.Height - cornerRadius); // Add a line for the right edge
            path.AddArc(new Rectangle(panel.Width - cornerRadius * 2, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90); // Add an arc for the bottom-right corner
            path.AddLine(panel.Width - cornerRadius, panel.Height, cornerRadius, panel.Height); // Add a line for the bottom edge
            path.AddArc(new Rectangle(0, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90); // Add an arc for the bottom-left corner
            path.AddLine(0, panel.Height - cornerRadius, 0, cornerRadius); // Add a line for the left edge
            path.CloseFigure(); // Close the figure
            panel.Region = new Region(path);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
