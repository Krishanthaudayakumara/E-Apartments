using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Customer
{
    public partial class AddCustomer : Form
    {
        readonly string connectionString = dbConnection.connectionString;

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void clsData_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImage = openFileDialog.FileName;
                Image image = Image.FromFile(selectedImage);
                pictureBox1.Image = image;
            }
        }

        private void addCustomer(object sender, EventArgs e)
        {
           

            String customerName = nameTxt.Text;
            String NIC = nicTxt.Text;
            String altAddress = addressTxt.Text;
            String contactNo = contactTxt.Text;

            String uName = userName.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO customer (name, nic_or_passport, alternative_address, contact_no, image, user_id) VALUES (@name, @nic_or_passport, @alternative_address, @contact_no, @image, @user_id)";
                        command.Parameters.AddWithValue("@name", customerName);
                        command.Parameters.AddWithValue("@nic_or_passport", NIC);
                        command.Parameters.AddWithValue("@alternative_address", altAddress);
                        command.Parameters.AddWithValue("@contact_no", contactNo);
                        command.Parameters.AddWithValue("@image", getImage());
                        int user_id = 0;
                        if (uName != "")
                        {
                            command.CommandText = "INSERT INTO users (username, password, is_admin) VALUES (@username, @password, @is_admin) SELECT SCOPE_IDENTITY()";
                            command.Parameters.AddWithValue("@username", uName);
                            command.Parameters.AddWithValue("@password", "epartment");
                            command.Parameters.AddWithValue("@is_admin", 0);

                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                user_id = Convert.ToInt32(result);
                            }

                            if (user_id > 0)
                            {
                                command.CommandText = "INSERT INTO customer (name, nic_or_passport, alternative_address, contact_no, image, user_id) VALUES (@name, @nic_or_passport, @alternative_address, @contact_no, @image, @user_id)";
                                command.Parameters.AddWithValue("@user_id", user_id);
                                int i = command.ExecuteNonQuery();
                                if (i > 0)
                                {
                                    MessageBox.Show("Customer added successfully. A default username and password 'epartment' created.");
                                }
                            }
                        }
                        else
                        {
                            int i = command.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Customer added successfully.");
                            }
                        }
                        nameTxt.Clear();
                        nicTxt.Clear();
                        nicTxt.Clear();
                        contactTxt.Clear();
                        addressTxt.Clear();
                        userName.Clear();
                        pictureBox1.Image = null;
                    } catch (Exception ext)
                    {
                        MessageBox.Show("Error on inserting");
                    }
                }


            }
        }

        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}