using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ReportsDataAccess : DatabaseConnection
    {
        public List<List<string>> reportsData { get; set; }

        public ReportsDataAccess()
        {
            reportsData = new List<List<string>>();
        }

        public void LoadReportsData()
        {
            reportsData.Clear();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT Id, EmployeeID, Title, Description, DateCreated, Category FROM [Report]";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                List<string> reportData = new List<string>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    reportData.Add(reader[i].ToString());
                                }
                                reportsData.Add(reportData);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found for the specified ID.");
                        }
                    }
                }

                connection.Close();
            }
        }

        public void AddReportData(int employeeId, string title, string description, string category)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO [Report] (EmployeeID, Title, Description, DateCreated, Category) VALUES (@EmployeeID, @Title, @Description, @DateCreated, @Category)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                    command.Parameters.AddWithValue("@Category", category);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void DeleteReportData(int reportId)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM [Report] WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", reportId);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
