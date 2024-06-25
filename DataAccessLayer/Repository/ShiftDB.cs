using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ShiftDB : DatabaseConnection
    {
        public List<Dictionary<string, object>> shiftsData { get; set; }

        public ShiftDB()
        {
            shiftsData = new List<Dictionary<string, object>>();
        }

        public List<Dictionary<string, object>> LoadShiftsData()
        {
            shiftsData.Clear();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM [Shift]";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Dictionary<string, object> shiftData = new Dictionary<string, object>();
                                shiftData["Id"] = reader["Id"];
                                shiftData["DayOfWeek"] = reader["DayOfWeek"].ToString();
                                shiftData["ShiftTime"] = reader["ShiftTime"].ToString();
                                shiftData["EmployeeID"] = reader["EmployeeID"];

                                shiftsData.Add(shiftData);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found for shifts.");
                        }
                    }
                }
                connection.Close();
            }
            return shiftsData;
        }

        public void AddShiftData(string dayOfWeek, string shiftTime, int employeeID)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO [Shift] (DayOfWeek, ShiftTime, EmployeeID) VALUES (@DayOfWeek, @ShiftTime, @EmployeeID)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    command.Parameters.AddWithValue("@ShiftTime", shiftTime);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public int GetTotalShiftsForEmployeeInDay(string dayOfWeek, int employeeID)
        {
            int totalShifts = 0;

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string countQuery = "SELECT COUNT(*) FROM [Shift] WHERE EmployeeID = @EmployeeID AND DayOfWeek = @DayOfWeek";

                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);

                    totalShifts = (int)command.ExecuteScalar();
                }

                connection.Close();
            }

            return totalShifts;
        }

        public void DeleteShiftData(string dayOfWeek, string shiftTime, int employeeID)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string deleteQuery = "DELETE FROM [Shift] WHERE DayOfWeek = @DayOfWeek AND ShiftTime = @ShiftTime AND EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    command.Parameters.AddWithValue("@ShiftTime", shiftTime);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
