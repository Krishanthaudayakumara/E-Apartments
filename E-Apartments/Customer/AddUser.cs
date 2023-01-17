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
    public partial class AddUser : Form
    {

        readonly string connectionString = dbConnection.connectionString;

        public AddUser()
        {
            InitializeComponent();
        }

        private void addUser(object sender, EventArgs e)
        {
            String uName = userNameTxt.Text.ToString();
            String password = passwordTxt.Text.ToString();
            int admin = isAdmin.Checked ? 1 : 0;
            int clerk = isClerk.Checked ? 1 : 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO users (username, password, is_admin, is_clerk) VALUES (@username, @password, @is_admin, @is_clerk)";
                    command.Parameters.AddWithValue("@username", uName);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@is_admin", admin);
                    command.Parameters.AddWithValue("@is_clerk", clerk);

                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        userNameTxt.Clear();
                        passwordTxt.Clear();
                        isAdmin.Checked = false;
                    }
                }
            }
        }
    }

}

