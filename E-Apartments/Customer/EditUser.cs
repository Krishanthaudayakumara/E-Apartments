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
    public partial class EditUser : Form
    {
        readonly string connectionString = dbConnection.connectionString;

        public EditUser()
        {
            InitializeComponent();
        }

        private void editUser(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            string newPassword = passwordTxt.Text;
            bool isAdmin = this.isAdmin.Checked;
            bool isClerk = this.isClerk.Checked;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    command.CommandText = "UPDATE users SET password = @password, is_admin = @is_admin, is_clerk = @is_clerk WHERE username = @username";
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", newPassword);
                    command.Parameters.AddWithValue("@is_admin", isAdmin);
                    command.Parameters.AddWithValue("@is_clerk", isClerk);


                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

        private void deleteUser(object sender, EventArgs e)
        {
            string username = userNameTxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM users WHERE username = @username";
                    command.Parameters.AddWithValue("@username", username);

                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("User deleted successfully.");
                        userNameTxt.Clear();
                        passwordTxt.Clear();
                        isAdmin.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

    }
}
