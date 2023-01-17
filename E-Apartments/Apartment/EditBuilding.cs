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

namespace E_Apartments.Apartment
{
    public partial class EditBuilding : Form
    {
        byte[] imageBytes;
        Image Image;
        readonly string connectionString = dbConnection.connectionString;
        bool imgSel = false;
        public EditBuilding(int id)
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve the apartment data
                SqlCommand command = new SqlCommand("SELECT * FROM buildings WHERE id = @buildingId", connection);
                command.Parameters.AddWithValue("@buildingId", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int buildingId = (int)reader["id"];
                    string Location = (string)reader["location"];
                    string Address = (string)reader["address"];
                    int Num_apartments = (int)reader["num_apartments"];
                    object image = reader["image"];
                    imageBytes = (byte[])reader["image"];

                   

                    using (var stream = new MemoryStream(imageBytes))
                    {
                        this.Image = Image.FromStream(stream);
                    }
                    ID.Text = buildingId.ToString();
                    location.Text = Location;
                    address.Text = Address;
                    noOfApt.Text = Num_apartments.ToString();
                    pictureBox1.Image = (Image)Image;


                }
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

                imgSel = true;
            }
        }

        private void editBuilding(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);
            int numApartments = Convert.ToInt32(noOfApt.Text);
            string locationText = location.Text;
            string addressText = address.Text;
            Image image = pictureBox1.Image;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE buildings SET location=@location, address=@address, num_apartments=@num_apartments, image=@image WHERE id=@id";
                    command.Parameters.AddWithValue("@location", locationText);
                    command.Parameters.AddWithValue("@address", addressText);
                    command.Parameters.AddWithValue("@num_apartments", numApartments);
                    command.Parameters.AddWithValue("@image", imgSel ?  getImage() : imageBytes);
                    command.Parameters.AddWithValue("@id", id);
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Building updated successfully.");
                        Close();
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

        private void EditBuilding_Load(object sender, EventArgs e)
        {

        }

        private void deleteBuilding(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM buildings WHERE id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this building?", "Delete Building", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Building deleted successfully.");
                            Close();
                        }
                    }
                }
            }
        }

    }
}
