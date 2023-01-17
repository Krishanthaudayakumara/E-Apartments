using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using E_Apartments.Apartment;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using E_Apartments.Customer;
using E_Apartments.Leasing;
using E_Apartments.AdminDashboard;
using E_Apartments.Reports;

namespace E_Apartments
{

    public partial class ApartmentHome : Form
    {
        readonly string connectionString = dbConnection.connectionString;
        string User;
        bool IsAdmin, IsClerk;
        public ApartmentHome(string user, bool isAdmin, bool isClerk)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin;
            this.IsClerk = isClerk;
            this.User = user;
            sysUser.Text = User;

           
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(User, IsAdmin, IsClerk);
            adminDash.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            panel.Region = new Region(path); // Set the panel's Region property to the GraphicsPath object
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Apartment_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT TOP 10 id, building_id, apt_no, class, floor_number, image FROM apartments";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.RowTemplate.Height = 100;

                    // Set the width and image layout of the image column
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[5];
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

        private void updateGrid(String query)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.RowTemplate.Height = 100;

                    // Set the width and image layout of the image column
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[5];
                    imageColumn.Width = 100;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Height = 100;
                    }


                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                    if (IsAdmin)
                    {
                        // Add the update button column
                        DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
                        updateButtonColumn.HeaderText = "Change";
                        updateButtonColumn.Text = "Change";
                        updateButtonColumn.UseColumnTextForButtonValue = true;
                        updateButtonColumn.Width = 70;
                        dataGridView1.Columns.Add(updateButtonColumn);
                    }

                    // Add the delete button column



                }

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            sysDate.Text = DateTime.Now.ToLongDateString();
            sysTime.Text = DateTime.Now.ToLongTimeString();
        }

       

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

      

        private void AddApartment(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                AddApt addApt = new AddApt();
                addApt.Show();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && IsAdmin)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int apartmentId = Convert.ToInt32(row.Cells["id"].Value); // Get the apartment ID from the data grid

                // Show a message box with the apartment ID
                EditApt editApt = new EditApt(apartmentId);
                editApt.Show();
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aptNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseApartment(object sender, EventArgs e)
        {
            String apt_no = aptNo.Text.ToString();
            String building_data = building.Text.ToString();

            var match = Regex.Match(building_data, @"Building\s(\d+)");
            int buildingNumber = 0;
            if (match.Success)
            {
                buildingNumber = int.Parse(match.Groups[1].Value);
            }
            // Extract the building number from the text

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM apartments", connection);

                if (aptNo.Text.Length > 0 && building.Text.Length > 0)
                {
                    command = new SqlCommand("SELECT * FROM apartments WHERE building_id = @building AND apt_no = @apt_no", connection);
                    command.Parameters.AddWithValue("@building", buildingNumber);
                    command.Parameters.AddWithValue("@apt_no", apt_no);
                } else if(aptNo.Text.Length > 0 && !(building.Text.Length > 0))
                {
                    command = new SqlCommand("SELECT * FROM apartments WHERE apt_no = @apt_no", connection);
                    command.Parameters.AddWithValue("@apt_no", apt_no);
                }
                else if(!(aptNo.Text.Length > 0) && (building.Text.Length > 0))
                {
                    command = new SqlCommand("SELECT * FROM apartments WHERE building_id = @building", connection);
                    command.Parameters.AddWithValue("@building", buildingNumber);
                } else
                {
                    MessageBox.Show("Enter Building number | Apartment No");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.Columns["id"].Visible = false; // Hide the ID column
            }
        }

        private void addBuilding(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                AddBuilding addBuilding = new AddBuilding();
                addBuilding.Show();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
        }

        private void browseBuildings(object sender, EventArgs e)
        {
            
            if (IsAdmin)
            {
                BrowseBuilding bb = new BrowseBuilding();
                bb.Show();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
        }

        private void sysTime_Click(object sender, EventArgs e)
        {
                
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerHome cus = new CustomerHome(User,IsAdmin,IsClerk);
            this.Hide();
            cus.Show();

        }

        private void building_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void logo(object sender, EventArgs e)
        {

        }

       

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            LeasingHome leasingHome = new LeasingHome(User, IsAdmin, IsClerk);
            leasingHome.Show();
            this.Hide();
        }
    }
}
