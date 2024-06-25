using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ShiftDataAccess : DatabaseConnection
    {
        public void SaveShift(string dayOfWeek, string shiftTime, DateTime date, List<int> employeeIds)
        {
            string assignedEmployees = string.Join(",", employeeIds);

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                using (SqlCommand checkCommand = new SqlCommand("SELECT Id FROM Shifts WHERE DayOfWeek = @DayOfWeek AND ShiftTime = @ShiftTime AND Date = @Date", connection))
                {
                    checkCommand.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                    checkCommand.Parameters.AddWithValue("@ShiftTime", shiftTime);
                    checkCommand.Parameters.AddWithValue("@Date", date);

                    object result = checkCommand.ExecuteScalar();
                    if (result != null)
                    {
                        int shiftId = Convert.ToInt32(result);
                        using (SqlCommand updateCommand = new SqlCommand("UPDATE Shifts SET AssignedEmployees = @AssignedEmployees WHERE Id = @ShiftId", connection))
                        {
                            updateCommand.Parameters.AddWithValue("@AssignedEmployees", assignedEmployees);
                            updateCommand.Parameters.AddWithValue("@ShiftId", shiftId);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Shifts (DayOfWeek, ShiftTime, Date, AssignedEmployees) VALUES (@DayOfWeek, @ShiftTime, @Date, @AssignedEmployees)", connection))
                        {
                            insertCommand.Parameters.AddWithValue("@DayOfWeek", dayOfWeek);
                            insertCommand.Parameters.AddWithValue("@ShiftTime", shiftTime);
                            insertCommand.Parameters.AddWithValue("@Date", date);
                            insertCommand.Parameters.AddWithValue("@AssignedEmployees", assignedEmployees);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public Dictionary<string, List<int>> LoadShifts()
        {
            Dictionary<string, List<int>> shifts = new Dictionary<string, List<int>>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DayOfWeek, ShiftTime, Date, AssignedEmployees FROM Shifts", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string key = $"{reader["DayOfWeek"]} {reader["Date"]:dd} {reader["ShiftTime"]}";
                            string assignedEmployeesStr = reader["AssignedEmployees"] as string;
                            List<int> assignedEmployees = assignedEmployeesStr?.Split(',').Select(int.Parse).ToList() ?? new List<int>();

                            shifts[key] = assignedEmployees;
                        }
                    }
                }
            }

            return shifts;
        }

        public Dictionary<string, List<int>> LoadShiftsForWeek(DateTime startDate)
        {
            Dictionary<string, List<int>> shiftsForWeek = new Dictionary<string, List<int>>();
            DateTime endDate = startDate.AddDays(6);

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT DayOfWeek, ShiftTime, Date, AssignedEmployees FROM Shifts " +
                               "WHERE Date >= @StartDate AND Date <= @EndDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate.Date);
                    command.Parameters.AddWithValue("@EndDate", endDate.Date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string key = $"{reader["DayOfWeek"]} {((DateTime)reader["Date"]).ToString("dd")} {reader["ShiftTime"]}";
                            string assignedEmployeesStr = reader["AssignedEmployees"] as string;
                            List<int> assignedEmployees = assignedEmployeesStr?.Split(',').Select(int.Parse).ToList() ?? new List<int>();

                            if (shiftsForWeek.ContainsKey(key))
                            {
                                shiftsForWeek[key].AddRange(assignedEmployees);
                            }
                            else
                            {
                                shiftsForWeek[key] = assignedEmployees;
                            }
                        }
                    }
                }
            }

            return shiftsForWeek;
        }


        public List<string> GetEmployeeShifts(int employeeId)
        {
            List<string> employeeShifts = new List<string>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT DayOfWeek, ShiftTime, Date FROM Shifts WHERE CHARINDEX(',' + @EmployeeId + ',', ',' + AssignedEmployees + ',') > 0", connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string shift = $"{reader["DayOfWeek"]} {reader["Date"]:dd} {reader["ShiftTime"]}";
                            employeeShifts.Add(shift);
                        }
                    }
                }
            }

            return employeeShifts;
        }
    }
}
