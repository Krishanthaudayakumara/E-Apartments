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

namespace E_Apartments.Apartment
{
    public partial class EditApt : Form
    {
        byte[] imageBytes;
        public int Id, BuildingId, FloorNumber, no_rooms, floor_area , applicableRent, deposit_amount, maxOc;
        string AptNo, AptClass;
        Image Image;

       

      //  bool LivingDiningArea, KitchenPantry, LaundryArea, Balcony, TelephoneConnection, BroadbandConnection, TvConnection, ParkingSpace;

        private void building_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        readonly string connectionString = dbConnection.connectionString;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public EditApt(int aptId)
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the apartment data
                SqlCommand command = new SqlCommand("SELECT * FROM apartments WHERE id = @aptId", connection);
                command.Parameters.AddWithValue("@aptId", aptId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = (int)reader["id"];
                    int buildingId = (int)reader["building_id"];
                    string aptNo = (string)reader["apt_no"];
                    string aptClass = (string)reader["class"];
                    int floorNumber = (int)reader["floor_number"];
                    object image = reader["image"];
                    imageBytes = (byte[])reader["image"];
                    this.no_rooms = (int)reader["no_of_rooms"];
                    this.floor_area = (int)reader["floor_area"];
                    this.applicableRent = (int)reader["rent"];
                    this.deposit_amount = (int)reader["deposit"];
                    this.maxOc = (int)reader["max_occupants"];

                    // Store the apartment data in variables or properties of the form
                    this.Id = id;
                    this.BuildingId = buildingId;
                    this.AptNo = aptNo;
                    this.AptClass = aptClass;
                    this.FloorNumber = floorNumber;

                    using (var stream = new MemoryStream(imageBytes))
    {
        this.Image = Image.FromStream(stream);
    }
                
                }
            }

            // Retrieve the facility data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM facilities WHERE apartment_id = @aptId", connection);
                command.Parameters.AddWithValue("@aptId", aptId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bool livingDiningArea = (bool)reader["living_dining_area"];
                    bool kitchenPantry = (bool)reader["kitchen_pantry"];
                    bool laundryArea = (bool)reader["laundry_area"];
                    bool balcony = (bool)reader["balcony"];
                    bool telephoneConnection = (bool)reader["telephone_connection"];
                    bool broadbandConnection = (bool)reader["broadband_connection"];
                    bool tvConnection = (bool)reader["tv_connection"];
                    bool parkingSpace = (bool)reader["parking_space"];

                    facilities.SetItemCheckState(0, livingDiningArea ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(1, kitchenPantry ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(2, laundryArea ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(3, balcony ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(4, telephoneConnection ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(5, broadbandConnection ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(6, tvConnection ? CheckState.Checked : CheckState.Unchecked);
                    facilities.SetItemCheckState(7, parkingSpace ? CheckState.Checked : CheckState.Unchecked);
                   
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM buildings WHERE id = @buildingId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@buildingId", BuildingId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            building.Text = "Building " + BuildingId.ToString() + " - " + reader["address"];
                            Console.Write("Building " + BuildingId.ToString() + " - " + reader["address"]);
                        }
                        else
                        {
                            MessageBox.Show("Building Read Error");
                        }
                    }
                }
            }


            aptIdLabel.Text = Id.ToString();
            aptNo.Text = AptNo.ToString();
            floorNumber.Text = FloorNumber.ToString();
            aptClass.SelectedItem = AptClass;
            noOfRoomsTxt.Text = no_rooms.ToString();
            floorArea.Text = floor_area.ToString();
            maxOccupants.Text = maxOc.ToString();
            rent.Text = applicableRent.ToString();
            deposit.Text = deposit_amount.ToString();


            pictureBox1.Image = (Image)Image;








        }

        private void editApartment(object sender, EventArgs e)
        {
            String aptId = aptIdLabel.Text.ToString();
            String apt_no = aptNo.Text.ToString();
            String apt_class = aptClass.Text.ToString();
            String floor_no = floorNumber.Text.ToString();
            String building_data = building.Text.ToString();
            String no_rooms = noOfRoomsTxt.Text.ToString();
            String floor_area = floorArea.Text.ToString();
            String applicableRent = rent.Text.ToString();
            String deposit_amount = deposit.Text.ToString();
            String maxOc = maxOccupants.Text.ToString();

            // Extract the building number from the text
            var match = Regex.Match(building_data, @"Building\s(\d+)");
            int buildingNumber = 0;
            if (match.Success)
            {
                buildingNumber = int.Parse(match.Groups[1].Value);
            }

            //update the data in the apartments table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE apartments SET building_id = @building_id, apt_no = @apt_no, class = @class, floor_number = @floor_number, image = @image, no_of_rooms = @no_of_rooms, floor_area = @floor_area, rent = @rent, deposit = @deposit, max_occupants = @max_occupants WHERE id = @id";
                    command.Parameters.AddWithValue("@id", aptId);
                    command.Parameters.AddWithValue("@building_id", buildingNumber);
                    command.Parameters.AddWithValue("@apt_no", apt_no);
                    command.Parameters.AddWithValue("@class", apt_class);
                    command.Parameters.AddWithValue("@floor_number", floor_no);

                    command.Parameters.AddWithValue("@no_of_rooms", no_rooms);
                    command.Parameters.AddWithValue("@floor_area", floor_area);
                    command.Parameters.AddWithValue("@rent", applicableRent);
                    command.Parameters.AddWithValue("@deposit", deposit_amount);
                    command.Parameters.AddWithValue("@max_occupants", maxOc);

                    command.Parameters.AddWithValue("@image", imageBytes);
                    int i = command.ExecuteNonQuery();

                    using (command)
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "UPDATE facilities SET living_dining_area = @living_dining_area, kitchen_pantry = @kitchen_pantry, laundry_area = @laundry_area, balcony = @balcony, telephone_connection = @telephone_connection, broadband_connection = @broadband_connection, tv_connection = @tv_connection, parking_space = @parking_space WHERE apartment_id = @apartment_id";
                        command.Parameters.AddWithValue("@apartment_id", aptId); // Replace apartmentId with the ID of the inserted apartment
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
                            MessageBox.Show("Data updated Successfully " + aptId.ToString());
                            aptNo.Clear();
                            aptClass.ResetText();
                            floorNumber.Clear();
                            building.ResetText();
                            pictureBox1.Image = null;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error Occured");

                        }

                    }
                }
            }
        }

        private void aptClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (aptClass.SelectedItem)
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

        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
        {
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        }

        private void deleteApartment(object sender, EventArgs e)
        {
            // Get the ID of the apartment to delete
            int aptId = int.Parse(aptIdLabel.Text);

            // Delete the apartment
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    

                    // Delete the associated facility records
                    command.CommandText = "DELETE FROM facilities WHERE apartment_id = @aptId";
                    command.Parameters.AddWithValue("@aptId", aptId);

                    int j = command.ExecuteNonQuery();

                    command.CommandText = "DELETE FROM apartments WHERE id = @aptId";
                    int i = command.ExecuteNonQuery();

                    if (i > 0 && j > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully!");
                        this.Hide();


                    }
                    else if (i > 0)
                    {
                        MessageBox.Show("Apt Data Deleted Successfully!");
                        this.Hide();
                        

                    }
                    else MessageBox.Show("Data Deletion Error !");

                }
            }
        }


        private void EditApt_Load(object sender, EventArgs e)
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
                            building.Items.Add("Building " + reader["id"].ToString() + " - " + reader["address"]);
                        }
                    }
                }
            }

            var match = Regex.Match(building.Text.ToString(), @"Building\s\d+\s-\s(.+)");
            if (match.Success)
            {
                string adr = match.Groups[1].Value;
                locationData.Text = adr + ", Colombo";
                if (aptNo.Text.Length > 0)
                {
                    address.Text = "Apartment No: " + aptNo.Text.ToString() + ",\n " + locationData.Text.ToString();

                }

            }

        }
    }
}
