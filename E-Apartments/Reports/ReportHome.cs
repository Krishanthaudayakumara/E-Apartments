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
using System.Xml.Linq;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using E_Apartments.Leasing;
using E_Apartments.Customer;
using E_Apartments.AdminDashboard;
using E_Apartments.Apartment;

namespace E_Apartments.Reports
{
    public partial class ReportHome : Form
    {

        readonly string connectionString = dbConnection.connectionString;
        string User;
        bool IsAdmin, IsClerk;
        public ReportHome(string user, bool isAdmin, bool isClerk)
        {
            InitializeComponent();
            this.IsAdmin = isAdmin;
            this.IsClerk = isClerk;
            this.User = user;
            sysUser.Text = user;
            timer1.Start();

            


        }

        private void allApartmentReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the available apartments from the database
            SqlCommand command = new SqlCommand("SELECT * FROM apartments", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable availableApartments = new DataTable();
            adapter.Fill(availableApartments);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("AllApartments.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Create a table for the available apartments
            PdfPTable table = new PdfPTable(9);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2, 4, 2, 2, 2, 2, 2, 2, 2 });
            table.AddCell("Building ID");
            table.AddCell("Apartment Number");
            table.AddCell("Class");
            table.AddCell("Floor Number");
            table.AddCell("No. of Rooms");
            table.AddCell("Floor Area");
            table.AddCell("Rent");
            table.AddCell("Deposit");
            table.AddCell("Maximum Occupants");

            // Add the available apartments data to the table
            for (int i = 0; i < availableApartments.Rows.Count; i++)
            {
                table.AddCell(availableApartments.Rows[i]["building_id"].ToString());
                table.AddCell(availableApartments.Rows[i]["apt_no"].ToString());
                table.AddCell(availableApartments.Rows[i]["class"].ToString());
                table.AddCell(availableApartments.Rows[i]["floor_number"].ToString());
                table.AddCell(availableApartments.Rows[i]["no_of_rooms"].ToString());
                table.AddCell(availableApartments.Rows[i]["floor_area"].ToString());
                table.AddCell(availableApartments.Rows[i]["rent"].ToString());
                table.AddCell(availableApartments.Rows[i]["deposit"].ToString());
                table.AddCell(availableApartments.Rows[i]["max_occupants"].ToString());
            }
            // Add the table to the PDF document
            pdf.Add(new Paragraph("All Apartments Report"));
            pdf.Add(new Paragraph(" "));
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("AllApartments.pdf");

        }





        private void ReportHome_Load(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {

                
                MessageBox.Show("Only Admin Can Access");
                ApartmentHome apartmentHome = new ApartmentHome(User, IsAdmin, IsClerk);
                apartmentHome.Show();
                this.Hide();

            }
        }

        private void availableApartmentReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the available apartments from the database
            SqlCommand command = new SqlCommand("SELECT a.* FROM apartments a LEFT JOIN reservations r ON a.id = r.apartment_id WHERE r.status = 0 OR r.status IS NULL", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable availableApartments = new DataTable();
            adapter.Fill(availableApartments);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("AvailableApartments.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Create a table for the available apartments
            PdfPTable table = new PdfPTable(9);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2, 4, 2, 2, 2, 2, 2, 2, 2 });
            table.AddCell("Building ID");
            table.AddCell("Apartment Number");
            table.AddCell("Class");
            table.AddCell("Floor Number");
            table.AddCell("No. of Rooms");
            table.AddCell("Floor Area");
            table.AddCell("Rent");
            table.AddCell("Deposit");
            table.AddCell("Maximum Occupants");

            // Add the available apartments data to the table
            for (int i = 0; i < availableApartments.Rows.Count; i++)
            {
                table.AddCell(availableApartments.Rows[i]["building_id"].ToString());
                table.AddCell(availableApartments.Rows[i]["apt_no"].ToString());
                table.AddCell(availableApartments.Rows[i]["class"].ToString());
                table.AddCell(availableApartments.Rows[i]["floor_number"].ToString());
                table.AddCell(availableApartments.Rows[i]["no_of_rooms"].ToString());
                table.AddCell(availableApartments.Rows[i]["floor_area"].ToString());
                table.AddCell(availableApartments.Rows[i]["rent"].ToString());
                table.AddCell(availableApartments.Rows[i]["deposit"].ToString());
                table.AddCell(availableApartments.Rows[i]["max_occupants"].ToString());
            }

            // Add the table to the PDF document
            pdf.Add(new Paragraph("Available Apartments Report"));
            pdf.Add(new Paragraph(" "));
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("AvailableApartments.pdf");
        }

        private void occupiedApartmentReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the occupied apartments from the database
            SqlCommand command = new SqlCommand("SELECT a.* FROM apartments a JOIN reservations r ON a.id = r.apartment_id WHERE r.status = 1", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable occupiedApartments = new DataTable();
            adapter.Fill(occupiedApartments);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("OccupiedApartments.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Create a table for the occupied apartments
            PdfPTable table = new PdfPTable(9);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2, 4, 2, 2, 2, 2, 2, 2, 2 });
            table.AddCell("Building ID");
            table.AddCell("Apartment Number");
            table.AddCell("Class");
            table.AddCell("Floor Number");
            table.AddCell("No. of Rooms");
            table.AddCell("Floor Area");
            table.AddCell("Rent");
            table.AddCell("Deposit");
            table.AddCell("Maximum Occupants");

            // Add the occupied apartments data to the table
            for (int i = 0; i < occupiedApartments.Rows.Count; i++)
            {
                table.AddCell(occupiedApartments.Rows[i]["building_id"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["apt_no"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["class"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["floor_number"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["no_of_rooms"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["floor_area"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["rent"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["deposit"].ToString());
                table.AddCell(occupiedApartments.Rows[i]["max_occupants"].ToString());
            }

            // Add the table to the PDF document
            pdf.Add(new Paragraph("Occupied Apartments Report"));
            pdf.Add(new Paragraph(" "));
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("OccupiedApartments.pdf");
        }

        private void leaseExpReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the lease expiration data from the database
            SqlCommand command = new SqlCommand("SELECT b.location, a.class, c.name, l.end_date FROM lease_agreements l JOIN apartments a ON l.apartment_id = a.id JOIN customer c ON l.customer_id = c.id JOIN buildings b ON a.building_id = b.id WHERE l.end_date <= DATEADD(month, 2, GETDATE())", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable leaseExpirationData = new DataTable();
            adapter.Fill(leaseExpirationData);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("LeaseExpirationReport.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Create a table for the lease expiration data
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 4, 4, 4, 4 });
            table.AddCell("Apartment Location");
            table.AddCell("Class");
            table.AddCell("Chief Occupant's Name");
            table.AddCell("Lease Expiration Date");

            // Add thelease expiration data to the table
            for (int i = 0; i < leaseExpirationData.Rows.Count; i++)
            {
                table.AddCell(leaseExpirationData.Rows[i]["location"].ToString());
                table.AddCell(leaseExpirationData.Rows[i]["class"].ToString());
                table.AddCell(leaseExpirationData.Rows[i]["name"].ToString());
                table.AddCell(leaseExpirationData.Rows[i]["end_date"].ToString());
            }

            // Add the table to the PDF document
            pdf.Add(new Paragraph("Lease Expiration Report"));
            pdf.Add(new Paragraph(" "));
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("LeaseExpirationReport.pdf");
        }

        private void leaseExtReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the lease extension requests data from the database
            SqlCommand command = new SqlCommand("SELECT b.location, a.class, c.name, la.end_date, l.lease_end_date, l.deposit, l.rent FROM lease_extensions l JOIN customer c ON l.customer_id = c.id JOIN lease_agreements la ON la.customer_id = c.id JOIN apartments a ON la.apartment_id = a.id JOIN buildings b ON a.building_id = b.id", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable leaseExtensionsData = new DataTable();
            adapter.Fill(leaseExtensionsData);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("LeaseExtensionsReport.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Create a table to display the lease extension requests data
            PdfPTable table = new PdfPTable(7);
            table.AddCell("Apartment Location");
            table.AddCell("Apartment Class");
            table.AddCell("Chief Occupant's Name");
            table.AddCell("Current Lease Expiration Date");
            table.AddCell("New Lease Expiration Date");
            table.AddCell("Deposit Amount");
            table.AddCell("Rent Amount");
            // Add the lease extension requests data to the table
            for (int i = 0; i < leaseExtensionsData.Rows.Count; i++)
            {
                table.AddCell(leaseExtensionsData.Rows[i]["location"].ToString());
                table.AddCell(leaseExtensionsData.Rows[i]["class"].ToString());
                table.AddCell(leaseExtensionsData.Rows[i]["name"].ToString());
                table.AddCell(leaseExtensionsData.Rows[i]["end_date"].ToString());
                table.AddCell(leaseExtensionsData.Rows[i]["lease_end_date"].ToString());
                table.AddCell(leaseExtensionsData.Rows[i]["deposit"].ToString());
                table.AddCell(leaseExtensionsData.Rows[i]["rent"].ToString());
            }

            // Add the table to the PDF document
            pdf.Add(new Paragraph("Lease Extension Requests Report"));
            pdf.Add(new Paragraph(" "));
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("LeaseExtensionsReport.pdf");
        }

        private void incomeReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Retrieve the income from the database
            SqlCommand command = new SqlCommand("SELECT SUM(rent) as 'Total Rent Income', SUM(deposit) as 'Total Deposit Income' FROM lease_agreements WHERE start_date >= @startDate AND end_date <= @endDate", connection);
            command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value.Date);
            command.Parameters.AddWithValue("@endDate", dateTimePicker2.Value.Date);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable incomeData = new DataTable();
            adapter.Fill(incomeData);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("IncomeReport.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Add the income data to the PDF
            pdf.Add(new Paragraph("Income Report"));
            pdf.Add(new Paragraph(" "));
            pdf.Add(new Paragraph("Period: " + dateTimePicker1.Value.Date + " to " + dateTimePicker2.Value.Date));
            pdf.Add(new Paragraph(" "));
            pdf.Add(new Paragraph("Total Rent Income: " + incomeData.Rows[0]["Total Rent Income"]));
            pdf.Add(new Paragraph("Total Deposit Income: " + incomeData.Rows[0]["Total Deposit Income"]));

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("IncomeReport.pdf");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reservationReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Retrieve the reservations from the database
            SqlCommand command = new SqlCommand("SELECT r.date, b.location, a.class, c.name, r.reservation_fee FROM reservations r JOIN apartments a ON r.apartment_id = a.id JOIN customer c ON r.customer_id = c.id JOIN buildings b ON a.building_id = b.id", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable reservations = new DataTable();
            adapter.Fill(reservations);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("Reservations.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Add the reservations to the PDF as a table
            pdf.Add(new Paragraph("Reservations Report"));
            pdf.Add(new Paragraph(" "));
            PdfPTable table = new PdfPTable(5);
            table.AddCell("Date of Reservation");
            table.AddCell("Apartment Location");
            table.AddCell("Apartment Class");
            table.AddCell("Customer Name");
            table.AddCell("Reservation Fee");
            for (int i = 0; i < reservations.Rows.Count; i++)
            {
                table.AddCell(reservations.Rows[i]["date"].ToString());
                table.AddCell(reservations.Rows[i]["location"].ToString());
                table.AddCell(reservations.Rows[i]["class"].ToString());
                table.AddCell(reservations.Rows[i]["name"].ToString());
                table.AddCell(reservations.Rows[i]["reservation_fee"].ToString());
            }
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("Reservations.pdf");
        }

        private void regCustomerReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Retrieve the customer data from the database
            SqlCommand command = new SqlCommand("SELECT name, alternative_address, nic_or_passport, contact_no FROM customer", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable customerData = new DataTable();
            adapter.Fill(customerData);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("CustomerList.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Add the customer data to the PDF
            pdf.Add(new Paragraph("Customer List Report"));
            pdf.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(4);

            // Add the table headers
            table.AddCell("Name");
            table.AddCell("Alternative Address");
            table.AddCell("NIC/Passport");
            table.AddCell("Contact Number");

            // Add the customer data to the table
            for (int i = 0; i < customerData.Rows.Count; i++)
            {
                table.AddCell(customerData.Rows[i]["name"].ToString());
                table.AddCell(customerData.Rows[i]["alternative_address"].ToString());
                table.AddCell(customerData.Rows[i]["nic_or_passport"].ToString());
                table.AddCell(customerData.Rows[i]["contact_no"].ToString());
            }

            // Add the table to the PDF
            pdf.Add(table);

            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("CustomerList.pdf");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void dependantReport(object sender, EventArgs e)
        {
            // Connect to the SQL database
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Retrieve the dependants information from the database
            SqlCommand command = new SqlCommand("SELECT d.name, d.age, d.relation, c.name as 'Customer Name' FROM dependants d JOIN customer c ON d.customer_id = c.id", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dependants = new DataTable();
            adapter.Fill(dependants);

            // Create a PDF document
            Document pdf = new Document();
            PdfWriter.GetInstance(pdf, new System.IO.FileStream("Dependants.pdf", System.IO.FileMode.Create));
            pdf.Open();

            // Add the dependants information to the PDF
            pdf.Add(new Paragraph("Dependants Report"));
            pdf.Add(new Paragraph(" "));
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.AddCell("Name");
            table.AddCell("Age");
            table.AddCell("Relation");
            table.AddCell("Customer Name");

            for (int i = 0; i < dependants.Rows.Count; i++)
            {
                table.AddCell(dependants.Rows[i]["name"].ToString());
                table.AddCell(dependants.Rows[i]["age"].ToString());
                table.AddCell(dependants.Rows[i]["relation"].ToString());
                table.AddCell(dependants.Rows[i]["Customer Name"].ToString());
            }
            pdf.Add(table);
            pdf.Close();
            connection.Close();

            // Open the PDF document
            System.Diagnostics.Process.Start("Dependants.pdf");
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sysDate.Text = DateTime.Now.ToLongDateString();
            sysTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void leaseBtn_Click(object sender, EventArgs e)
        {
            LeasingHome leasingHome = new LeasingHome(User, IsAdmin, IsClerk);
            this.Hide();
            leasingHome.Show();
        }

        private void apartmentBtn_Click(object sender, EventArgs e)
        {
            ApartmentHome apartmentHome = new ApartmentHome(User, IsAdmin, IsClerk);
            this.Hide();
            apartmentHome.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            AdminDash adminDash = new AdminDash(User, IsAdmin, IsClerk);
            adminDash.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome(User, IsAdmin, IsClerk);
            customerHome.Show();
            this.Hide();
        }
    }


}
    