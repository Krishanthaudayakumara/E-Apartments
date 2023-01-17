using E_Apartments.AdminDashboard;
using E_Apartments.Customer;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Apartments
{
    public partial class Login : Form
    {

        readonly string connectionString = dbConnection.connectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userLogin(object sender, EventArgs e)
        {
            string uname = username.Text;
            string pwd = password.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, is_admin,is_clerk FROM users WHERE username = @username AND password = @password", connection))
                {
                    command.Parameters.AddWithValue("@username", uname);
                    command.Parameters.AddWithValue("@password", pwd);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int userId = (int)reader["id"];
                        bool isAdmin = (bool)reader["is_admin"];
                        bool isClerk = (bool)reader["is_clerk"];
                        if (isAdmin || isClerk)
                        {
                            AdminDash adminDash = new AdminDash(uname,isAdmin,isClerk);
                            this.Hide();
                            adminDash.Show();
                        }
                        else
                        {
                            CustomerDash customerDash = new CustomerDash(uname,isAdmin,isClerk);
                            this.Hide();
                            customerDash.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.");
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
