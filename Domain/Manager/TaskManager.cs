using DataAccessLayer;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Domain.Entity.Task;

namespace Domain.Manager
{
    public class TaskManager
    {
        private TaskDB taskDataAccess;

        public TaskManager()
        {
            taskDataAccess = new TaskDB();
        }

        public Task CreateTask(string title, string description, string category, string location, DateTime deadline, List<int> employeeIds)
        {
            int taskId = taskDataAccess.CreateTask(title, description, category, location, deadline, false);
            taskDataAccess.AssignTaskToEmployees(taskId, employeeIds);

            return new Task(taskId, title, description, category, location, deadline);
        }

        public List<Task> GetTasksByEmployeeId(int employeeId)
        {
            DataTable dataTable = taskDataAccess.GetTasksByEmployeeId(employeeId);
            List<Task> tasks = new List<Task>();

            foreach (DataRow row in dataTable.Rows)
            {
                Task task = new Task(
                    (int)row["Id"],
                    row["Title"].ToString(),
                    row["Description"].ToString(),
                    row["Category"].ToString(),
                    row["Location"].ToString(),
                    (DateTime)row["Deadline"]
                );
                task.IsDone = (bool)row["IsDone"];
                tasks.Add(task);
            }

            return tasks;
        }

    }
}
