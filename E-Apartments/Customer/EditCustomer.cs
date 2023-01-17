using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Customer
{
    public partial class EditCustomer : Form
    {
        readonly string connectionString = dbConnection.connectionString;
        byte[] imageBytes;
        bool imgSel=false;

        public EditCustomer(int id)
        {
            InitializeComponent();
            customerId.Text = id.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve customer data
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT name, alternative_address, nic_or_passport, contact_no, image FROM customer WHERE id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nameTxt.Text = reader["name"].ToString();
                        addressTxt.Text = reader["alternative_address"].ToString();
                        nicTxt.Text = reader["nic_or_passport"].ToString();
                        contactTxt.Text = reader["contact_no"].ToString();
                        imageBytes = (byte[])reader["image"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    reader.Close();
                }
            }
        }

        private void editCustomer(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customerId.Text); // Get the ID of the customer from the textbox
            String customerName = nameTxt.Text;
            String NIC = nicTxt.Text;
            String altAddress = addressTxt.Text;
            String contactNo = contactTxt.Text;

            if(customerName.Length > 0 && NIC.Length > 0 && altAddress.Length > 0 && contactNo.Length > 0)
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            command.CommandText = "UPDATE customer SET name = @name, nic_or_passport = @nic_or_passport, alternative_address = @alternative_address, contact_no = @contact_no, image = @image WHERE id = @id";
                            command.Parameters.AddWithValue("@name", customerName);
                            command.Parameters.AddWithValue("@nic_or_passport", NIC);
                            command.Parameters.AddWithValue("@alternative_address", altAddress);
                            command.Parameters.AddWithValue("@contact_no", contactNo);
                            command.Parameters.AddWithValue("@image", imgSel ? getImage() : imageBytes);
                            command.Parameters.AddWithValue("@id", id);

                            int i = command.ExecuteNonQuery();

                            if (i > 0)
                            {
                                MessageBox.Show("Customer details updated successfully.");
                                nameTxt.Clear();
                                nicTxt.Clear();
                                contactTxt.Clear();
                                addressTxt.Clear();
                                pictureBox1.Image = null;
                                this.Hide();
                            }
                        }
                    } catch {
                        MessageBox.Show("Error on database function");
                    }
                }
            } else
            {
                MessageBox.Show("Don't leave empty fields");
            }
        }

        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }

                imgSel = true;
            }
        }

        private void deleteCustomer(object sender, EventArgs e)
        {
            int ID = int.Parse(customerId.Text); // Assumes that customerIdTxt is a TextBox that contains the ID of the customer to delete

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM customer WHERE id = @customerId";
                    command.Parameters.AddWithValue("@customerId", ID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer deleted successfully.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting customer. Make sure the customer ID is correct.");
                    }
                }
            }
        }

    }
}
