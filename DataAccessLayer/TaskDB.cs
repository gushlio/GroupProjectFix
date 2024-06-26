using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TaskDB : DatabaseConnection
    {
        public int CreateTask(string title, string description, string category, string location, DateTime deadline, bool isDone)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string insertTaskQuery = "INSERT INTO Tasks (Title, Description, Category, Location, Deadline, IsDone) " +
                                         "OUTPUT INSERTED.Id VALUES (@Title, @Description, @Category, @Location, @Deadline, @IsDone)";

                SqlCommand insertTaskCommand = new SqlCommand(insertTaskQuery, connection);
                insertTaskCommand.Parameters.AddWithValue("@Title", title);
                insertTaskCommand.Parameters.AddWithValue("@Description", description);
                insertTaskCommand.Parameters.AddWithValue("@Category", category);
                insertTaskCommand.Parameters.AddWithValue("@Location", location);
                insertTaskCommand.Parameters.AddWithValue("@Deadline", deadline);
                insertTaskCommand.Parameters.AddWithValue("@IsDone", isDone);

                return (int)insertTaskCommand.ExecuteScalar();
            }
        }

        public void UpdateTask(int taskId, string title, string description, string category, string location, DateTime deadline)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateTaskQuery = @"UPDATE Tasks SET 
                                        Title = @Title,
                                        Description = @Description,
                                        Category = @Category,
                                        Location = @Location,
                                        Deadline = @Deadline
                                      WHERE Id = @TaskId";

                SqlCommand updateTaskCommand = new SqlCommand(updateTaskQuery, connection);
                updateTaskCommand.Parameters.AddWithValue("@TaskId", taskId);
                updateTaskCommand.Parameters.AddWithValue("@Title", title);
                updateTaskCommand.Parameters.AddWithValue("@Description", description);
                updateTaskCommand.Parameters.AddWithValue("@Category", category);
                updateTaskCommand.Parameters.AddWithValue("@Location", location);
                updateTaskCommand.Parameters.AddWithValue("@Deadline", deadline);

                updateTaskCommand.ExecuteNonQuery();
            }
        }

        public void DeleteTask(int taskId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "DELETE FROM Tasks WHERE Id = @TaskId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TaskId", taskId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AssignTaskToEmployees(int taskId, List<int> employeeIds)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                foreach (int employeeId in employeeIds)
                {
                    string insertEmployeeTaskQuery = "INSERT INTO EmployeeTasks (EmployeeId, TaskId) VALUES (@EmployeeId, @TaskId)";

                    SqlCommand insertEmployeeTaskCommand = new SqlCommand(insertEmployeeTaskQuery, connection);
                    insertEmployeeTaskCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                    insertEmployeeTaskCommand.Parameters.AddWithValue("@TaskId", taskId);

                    insertEmployeeTaskCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllTasks()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Tasks";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable GetTasksByEmployeeId(int employeeId, string category = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT t.Id, t.Title, t.Description, t.Category, t.Location, t.Deadline, t.IsDone FROM Tasks t " +
                               "INNER JOIN EmployeeTasks et ON t.Id = et.TaskId " +
                               "WHERE et.EmployeeId = @EmployeeId AND t.IsDone = 0";

                if (!string.IsNullOrEmpty(category))
                {
                    query += " AND t.Category = @Category";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                if (!string.IsNullOrEmpty(category))
                {
                    command.Parameters.AddWithValue("@Category", category);
                }

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable GetAssignedEmployeesData(int taskId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT e.EmployeeId, e.FirstName, e.LastName, c.JobTitle FROM NewEmployee e " +
                               "INNER JOIN EmployeeTasks et ON e.EmployeeId = et.EmployeeId " +
                               "INNER JOIN Contracts c ON e.ContractId = c.ContractId " +
                               "WHERE et.TaskId = @TaskId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TaskId", taskId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public void UpdateTaskStatus(int taskId, bool isDone)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "UPDATE Tasks SET IsDone = @IsDone WHERE Id = @TaskId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IsDone", isDone);
                command.Parameters.AddWithValue("@TaskId", taskId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
