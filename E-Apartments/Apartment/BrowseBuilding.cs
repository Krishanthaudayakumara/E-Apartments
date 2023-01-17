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

namespace E_Apartments.Apartment
{
    public partial class BrowseBuilding : Form
    {

        readonly string connectionString = dbConnection.connectionString;

        public BrowseBuilding()
        {
            InitializeComponent();
            LoadBuildings();

        }

        private void BrowseBuilding_Load(object sender, EventArgs e)
        {

        }

        private void LoadBuildings()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM buildings";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.RowTemplate.Height = 100;

                    // Set the width and image layout of the image column
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
                    imageColumn.Width = 100;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Height = 100;
                    }


                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    // Add the update button column
                    DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
                    updateButtonColumn.HeaderText = "Change";
                    updateButtonColumn.Text = "Change";
                    updateButtonColumn.UseColumnTextForButtonValue = true;
                    updateButtonColumn.Width = 70;
                    dataGridView1.Columns.Add(updateButtonColumn);

                    // Add the delete button column



                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int buildingId = Convert.ToInt32(row.Cells["id"].Value); // Get the apartment ID from the data grid

                // Show a message box with the apartment ID
                EditBuilding eb  = new EditBuilding(buildingId);
                eb.Show();

            }
        }
    }
}

