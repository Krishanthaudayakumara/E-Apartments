using E_Apartments.AdminDashboard;
using E_Apartments.Apartment;
using E_Apartments.Leasing;
using E_Apartments.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Customer
{
    public partial class CustomerHome : Form
    {

        readonly string connectionString = dbConnection.connectionString;
        string User;
        bool IsAdmin, IsClerk;
        public CustomerHome(string user, bool isAdmin, bool isClerk)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin;
            this.IsClerk = isClerk;
            this.User = user;
            sysUser.Text = user;
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            timer1.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT TOP 10 * FROM customer";

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
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void addCustomers(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                AddCustomer add = new AddCustomer();
                add.Show();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
        }

        private void apartmentBtn_Click(object sender, EventArgs e)
        {
            ApartmentHome app = new ApartmentHome(User, IsAdmin, IsClerk);


            this.Hide();
            app.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && IsAdmin)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int customerId = Convert.ToInt32(row.Cells["id"].Value); // Get the apartment ID from the data grid

                // Show a message box with the apartment ID
                EditCustomer editCus = new EditCustomer(customerId);
                editCus.Show();

               // EditApt editApt = new EditApt(apartmentId);
                //editApt.Show();
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

        private void addUser(object sender, EventArgs e)
        {  

            if (IsAdmin)
            {
                AddUser addUser = new AddUser();
                addUser.Show();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
        }

        private void editUser(object sender, EventArgs e)
        {
            

            if (IsAdmin)
            {
                EditUser editUser = new EditUser();
                editUser.Show();
            }
            else
            {
                MessageBox.Show("Only Admin Can Access");
            }
        }

        private void browseCustomer(object sender, EventArgs e)
        {
            String nic = nicTxt.Text.ToString();
            String name = nameTxt.Text.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    if(nic.Length > 0 && name.Length >0)
                    {
                        command.CommandText = "SELECT * FROM customer WHERE nic_or_passport LIKE @nic and name LIKE @name";
                        command.Parameters.AddWithValue("@nic", "%" + nic + "%");
                        command.Parameters.AddWithValue("@name", "%" + name + "%");
                    }else if(nic.Length > 0)
                    {
                        command.CommandText = "SELECT * FROM customer WHERE nic_or_passport LIKE @nic";
                        command.Parameters.AddWithValue("@nic", "%" + nic + "%");
                    }else if(name.Length > 0)
                    {
                        command.CommandText = "SELECT * FROM customer WHERE name LIKE @name";
                        command.Parameters.AddWithValue("@name", "%" + name + "%");
                    }

                    try
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    } catch(Exception error)
                    {
                        DialogResult dialogResult = MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            LeasingHome leasingHome = new LeasingHome(User, IsAdmin, IsClerk);
            leasingHome.Show();
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(User, IsAdmin, IsClerk);
            adminDash.Show();
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

        private void customerBtn_Click(object sender, EventArgs e)
        {

        }

        private void addDependants(object sender, EventArgs e)
        {
            AddDependant addDependant = new AddDependant();
            addDependant.Show();
        }
    }
}
