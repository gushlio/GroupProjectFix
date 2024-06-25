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

        public DataTable GetTasksByEmployeeId(int employeeId)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT t.* FROM Tasks t " +
                               "INNER JOIN EmployeeTasks et ON t.Id = et.TaskId " +
                               "WHERE et.EmployeeId = @EmployeeId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employeeId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
    }
}
