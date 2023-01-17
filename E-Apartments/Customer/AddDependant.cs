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
    public partial class AddDependant : Form
    {

        readonly string connectionString = dbConnection.connectionString;

        public AddDependant()
        {
            InitializeComponent();
        }

        private void fetchCustomer(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            string name = cusNameTxt.Text;
            string nic = cusNICTxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;

                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(nic))
                    {
                        command.CommandText = "SELECT * FROM customer WHERE name = @name AND nic_or_passport = @nic";
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@nic", nic);
                    }
                    else if (!string.IsNullOrEmpty(name))
                    {
                        command.CommandText = "SELECT * FROM customer WHERE name = @name";
                        command.Parameters.AddWithValue("@name", name);
                    }
                    else if (!string.IsNullOrEmpty(nic))
                    {
                        command.CommandText = "SELECT * FROM customer WHERE nic_or_passport = @nic";
                        command.Parameters.AddWithValue("@nic", nic);
                    }
                    else
                    {
                        MessageBox.Show("Please enter either name or nic or both fields");

                    }
                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dataGridView1.DataSource = dt;



                        using (reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customerId.Text = reader["id"].ToString();
                            }

                        }


                    }
                    catch (Exception ext)
                    {
                        MessageBox.Show(ext.Message);
                    }
                }
            }
        }

        private void addDependant(object sender, EventArgs e)
        {
            int customerIdValue = int.Parse(customerId.Text);
            string name = nameTxt.Text;
            int age = int.Parse(ageTxt.Text);
            string relation = relationTxt.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO dependants (name, age, relation, customer_id) VALUES (@name, @age, @relation, @customer_id)";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@relation", relation);
                    command.Parameters.AddWithValue("@customer_id", customerIdValue);
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Dependant added Successfully");
                        nameTxt.Clear();
                        ageTxt.Clear();
                        relationTxt.Clear();
                        customerId.Text = "";
                    }
                }
            }
        }

    }
}
