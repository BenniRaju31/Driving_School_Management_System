// Form1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITDrivingSchoolManagementSystem
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            ConfigureStyles();
        }

        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "ITDrivingSchool";
            string uid = "root";
            string password = "";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void ConfigureStyles()
        {
            // Configure overall form appearance
            this.BackColor = System.Drawing.Color.FromArgb(232, 241, 212); // Light green background color

            // Configure label styles
            labelTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitle.ForeColor = System.Drawing.Color.Black; // Black title text color

            labelSubtitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelSubtitle.ForeColor = System.Drawing.Color.Black; // Black subtitle text color

            // Configure button styles
            buttonInstructors.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light blue button color
            buttonInstructors.ForeColor = System.Drawing.Color.Black; // Black button text color
            buttonInstructors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonStudents.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light blue button color
            buttonStudents.ForeColor = System.Drawing.Color.Black; // Black button text color
            buttonStudents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonLessons.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light blue button color
            buttonLessons.ForeColor = System.Drawing.Color.Black; // Black button text color
            buttonLessons.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonReports.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light blue button color
            buttonReports.ForeColor = System.Drawing.Color.Black; // Black button text color
            buttonReports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            buttonGenerateInstructorReport.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light blue button color
            buttonGenerateInstructorReport.ForeColor = System.Drawing.Color.Black; // Black button text color
            buttonGenerateInstructorReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Configure Add Instructor button
            buttonAddInstructor.BackColor = System.Drawing.Color.FromArgb(173, 216, 230); // Light blue button color
            buttonAddInstructor.ForeColor = System.Drawing.Color.Black; // Black button text color
            buttonAddInstructor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private void RetrieveData(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);

            if (OpenConnection())
            {
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;

                CloseConnection();
            }
        }

        private void GenerateRevenueReport()
        {
            string query = "SELECT LessonType, COUNT(*) AS NumberOfLessons, SUM(DurationHours) AS TotalHours FROM Lessons GROUP BY LessonType";
            RetrieveData(query);
        }

        private void GenerateInstructorReport()
        {
            string query = "SELECT CONCAT(FirstName, ' ', LastName) AS InstructorName, COUNT(*) AS NumberOfLessons FROM Instructors INNER JOIN Lessons ON Instructors.InstructorID = Lessons.InstructorID GROUP BY InstructorName";
            RetrieveData(query);
        }

        private void buttonInstructors_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Instructors";
            RetrieveData(query);
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Students";
            RetrieveData(query);
        }

        private void buttonLessons_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Lessons";
            RetrieveData(query);
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            GenerateRevenueReport();
        }

        private void buttonGenerateInstructorReport_Click(object sender, EventArgs e)
        {
            GenerateInstructorReport();
        }

        private void buttonAddInstructor_Click(object sender, EventArgs e)
        {
            // Instantiate the Form2 (previously AddInstructorForm)
            Form2 addInstructorForm = new Form2();
            // Show the form as a modal dialog
            addInstructorForm.ShowDialog();
            // Reload instructors data after closing the add instructor form
            string query = "SELECT * FROM Instructors";
            RetrieveData(query);
        }


        private void buttonDeleteInstructor_Click(object sender, EventArgs e)
        {
            // Delete instructor logic here
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected instructor's ID
                int instructorId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["InstructorID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this instructor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the instructor from the database
                    string query = "DELETE FROM Instructors WHERE InstructorID = @InstructorID";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@InstructorID", instructorId);
                        try
                        {
                            OpenConnection();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Instructor deleted successfully!");
                                // Reload instructors data after deletion
                                string reloadQuery = "SELECT * FROM Instructors";
                                RetrieveData(reloadQuery);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete instructor.");
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
            else
            {
                MessageBox.Show("Please select an instructor to delete.");
            }
        }
    }
}
