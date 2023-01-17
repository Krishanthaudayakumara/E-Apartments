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
    public partial class AddBuilding : Form
    {
        readonly string connectionString = dbConnection.connectionString;

        public AddBuilding()
        {
            InitializeComponent();
        }

        private void floorNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBuilding(object sender, EventArgs e)
        {
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
                    command.CommandText = "INSERT INTO buildings (location, address, num_apartments, image) VALUES (@location, @address, @num_apartments, @image)";
                    command.Parameters.AddWithValue("@location", locationText);
                    command.Parameters.AddWithValue("@address", addressText);
                    command.Parameters.AddWithValue("@num_apartments", numApartments);
                    command.Parameters.AddWithValue("@image", getImage());
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Building added successfully.");
                        noOfApt.Clear();
                        location.Text = "Colombo";
                        address.Clear();
                        pictureBox1.Image = null;
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

        private void AddBuilding_Load(object sender, EventArgs e)
        {
            location.Text = "Colombo";
        }
    }
}
