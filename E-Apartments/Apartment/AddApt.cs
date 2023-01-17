using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace E_Apartments.Apartment
{
    public partial class AddApt : Form
    {
        readonly string connectionString = dbConnection.connectionString;

        public AddApt()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the picture box
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void AddApt_Load(object sender, EventArgs e)
        {
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
                            building.Items.Add("Building "+reader["id"].ToString()+" - "+ reader["address"]);
                        }
                    }
                }
            }
        }

        private void addApartment(object sender, EventArgs e)
        {
            String apt_no = aptNo.Text.ToString();
            String apt_class = aptClass.Text.ToString();
            String floor_no = floorNumber.Text.ToString();
            String building_data = building.Text.ToString();
            String no_rooms = noOfRoomsTxt.Text.ToString();
            String floor_area = floorArea.Text.ToString();
            String applicableRent = rent.Text.ToString();
            String deposit_amount = deposit.Text.ToString();
            string maxOc = maxOccupants.Text.ToString();

            // Extract the building number from the text
            var match = Regex.Match(building_data, @"Building\s(\d+)");
            int buildingNumber = 0;
            if (match.Success)
            {
                buildingNumber = int.Parse(match.Groups[1].Value);
            }

            // Insert the data into the apartments table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO apartments (apt_no, class, floor_number, building_id, no_of_rooms, floor_area,  rent, deposit, max_occupants, image) VALUES (@apt_no, @apt_class, @floor_no, @building, @no_rooms, @floor_area, @applicable_rent, @deposit_amount, @max_occupants, @image)";
                    command.Parameters.AddWithValue("@apt_no", apt_no);
                    command.Parameters.AddWithValue("@apt_class", apt_class);
                    command.Parameters.AddWithValue("@floor_no", floor_no);
                    command.Parameters.AddWithValue("@building", buildingNumber);
                    command.Parameters.AddWithValue("@no_rooms", no_rooms);
                    command.Parameters.AddWithValue("@floor_area", floor_area);
                    command.Parameters.AddWithValue("@applicable_rent", applicableRent);
                    command.Parameters.AddWithValue("@deposit_amount", deposit_amount);
                    command.Parameters.AddWithValue("@max_occupants", maxOc);
                    command.Parameters.AddWithValue("@image", getImage());
                    int i = command.ExecuteNonQuery();

                    // Get the ID of the newly inserted apartment
                    command.CommandText = "SELECT @@IDENTITY";
                    int apartmentId = Convert.ToInt32(command.ExecuteScalar());

                    using (command)
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO facilities (apartment_id, living_dining_area, kitchen_pantry, laundry_area, balcony, telephone_connection, broadband_connection, tv_connection, parking_space) VALUES (@apartment_id, @living_dining_area, @kitchen_pantry, @laundry_area, @balcony, @telephone_connection, @broadband_connection, @tv_connection, @parking_space)";
                        command.Parameters.AddWithValue("@apartment_id", apartmentId); // Replace apartmentId with the ID of the inserted apartment
                        command.Parameters.AddWithValue("@living_dining_area", facilities.GetItemChecked(0));
                        command.Parameters.AddWithValue("@kitchen_pantry", facilities.GetItemChecked(1));
                        command.Parameters.AddWithValue("@laundry_area", facilities.GetItemChecked(2));
                        command.Parameters.AddWithValue("@balcony", facilities.GetItemChecked(3));
                        command.Parameters.AddWithValue("@telephone_connection", facilities.GetItemChecked(4));
                        command.Parameters.AddWithValue("@broadband_connection", facilities.GetItemChecked(5));
                        command.Parameters.AddWithValue("@tv_connection", facilities.GetItemChecked(6));
                        command.Parameters.AddWithValue("@parking_space", facilities.GetItemChecked(7));
                        int j = command.ExecuteNonQuery();
                        if (i > 0 && j > 0)
                        {
                            MessageBox.Show("Data Inserted Successfully " + apartmentId.ToString());
                            aptNo.Clear();
                            aptClass.ResetText();
                            floorNumber.Clear();
                            building.ResetText();
                            noOfRoomsTxt.Clear();
                            floorArea.Clear();
                            rent.Clear();
                            deposit.Clear();
                            maxOccupants.Clear();
                            pictureBox1.Image = null;
                        }
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

        private void aptClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(aptClass.SelectedItem)
            {
                case "Class 1":
                    clsData.Text = "Class1 :\n one bedroomed apartment,\n one common bathroom";
                    break;
                case "Class 2":
                    clsData.Text = "Class2 :\n two bedroomed apartment,\n one attached bathroom,\n common bathroom";
                    break;
                case "Class 3":
                    clsData.Text = "Class 3 :\n three bed-roomed apartment,\n two attached bathrooms,\n common bathroom";
                    break;
                case "Suite":
                    clsData.Text = "Suite :\n apartment with 4 bedrooms and a servants’ room,\n 3 attached bathrooms,\n one common bathroom and a servants’ toilet";
                    break;

                default:
                    clsData.Text = "";
                    break;


            }
        }

        private void building_SelectedIndexChanged(object sender, EventArgs e)
        {
            var match = Regex.Match(building.Text.ToString(), @"Building\s\d+\s-\s(.+)");
            if (match.Success)
            {
                string adr = match.Groups[1].Value;
                locationData.Text = adr + ", Colombo";
                if (aptNo.Text.Length > 0)
                {
                    address.Text = "Apartment No: "+aptNo.Text.ToString() + ",\n " + locationData.Text.ToString();

                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
