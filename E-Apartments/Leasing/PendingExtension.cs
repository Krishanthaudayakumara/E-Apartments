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

namespace E_Apartments.Leasing
{
    public partial class PendingExtension : Form
    {
        readonly string connectionString = dbConnection.connectionString;

        public PendingExtension()
        {
            InitializeComponent();
        }

        private void PendingExtension_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a new DataTable to store the lease extensions
                DataTable leaseExtensions = new DataTable();

                // Create a new SqlDataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // Set the SELECT command for the SqlDataAdapter to retrieve the pending lease extensions
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM lease_extensions WHERE status = 'pending'", connection);

                    // Fill the DataTable with the lease extensions
                    adapter.Fill(leaseExtensions);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = leaseExtensions;

                }

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

                dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check that the clicked cell is in the accept column (column 0)
            if (e.ColumnIndex == 9)
            {
                // Get the lease extension id from the selected row
                int leaseExtensionId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the status of the lease extension to "Accepted"
                    SqlCommand command = new SqlCommand("UPDATE lease_extensions SET manager_approval = 'Accepted', status = 'completed' WHERE id = @leaseExtensionId", connection);
                    command.Parameters.AddWithValue("@leaseExtensionId", leaseExtensionId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Lease Extension Request Accepted");
                }

                // Refresh the DataGridView to show the updated status
                dataGridView1.Refresh();
            }

            // Check that the clicked cell is in the decline column (column 1)
            if (e.ColumnIndex == 10)
            {
                // Get the lease extension id from the selected row
                int leaseExtensionId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the status of the lease extension to "Declined"
                    SqlCommand command = new SqlCommand("UPDATE lease_extensions SET manager_approval = 'Declined', status = 'completed' WHERE id = @leaseExtensionId", connection);
                    command.Parameters.AddWithValue("@leaseExtensionId", leaseExtensionId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Lease Extension Request Declined");
                }

                // Refresh the DataGridView to show the updated status
                dataGridView1.Refresh();
            }
        }

        private void browsePendingExtensions(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a new DataTable to store the extension requests
                DataTable extensionRequests = new DataTable();

                // Create a new SqlDataAdapter
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    // Set the SELECT command for the SqlDataAdapter
                    string sql = "SELECT * FROM lease_extensions WHERE";
                    if (!string.IsNullOrEmpty(nameTxt.Text))
                    {
                        sql += " customer_id IN (SELECT id FROM customer WHERE name LIKE '%" + nameTxt.Text + "%')";
                    }
                    if (!string.IsNullOrEmpty(nicTxt.Text))
                    {
                        sql += " customer_id IN (SELECT id FROM customer WHERE nic_or_passport LIKE '%" + nicTxt.Text + "%')";
                    }
                    adapter.SelectCommand = new SqlCommand(sql, connection);

                    // Fill the DataTable with the extension requests
                    adapter.Fill(extensionRequests);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = extensionRequests;
                }

                dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);

            }
        }
    }
}
