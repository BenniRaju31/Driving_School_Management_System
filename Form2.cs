// Form2.cs
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITDrivingSchoolManagementSystem
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection;

        public Form2()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "ITDrivingSchool";
            string uid = "root";
            string password = "root";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Add instructor to the database
            if (OpenConnection())
            {
                string query = "INSERT INTO Instructors (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Instructor added successfully!");
                            this.Close(); // Close the form after successful addition
                        }
                        else
                        {
                            MessageBox.Show("Failed to add instructor.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        CloseConnection();
                    }
                }
            }
        }
    }
}