using Domain.Entity;
using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class AssignTask : Form
    {
        private EmployeeManager _employeeManager;
        private TaskManager taskManager;

        public AssignTask()
        {
            InitializeComponent();
            lbEmployees.SelectionMode = SelectionMode.MultiExtended;
            _employeeManager = new EmployeeManager();
            taskManager = new TaskManager();
            _employeeManager.LoadEmployees();

            PopulateEmployeesListBox();
            InitializeJobTitleComboBox();

            List<string> categoryList = new List<string> { "Animal Care", "Administration", "Maintenance", "Other" };
            categoryComboBox.DataSource = categoryList;


            List<string> locationList = new List<string> { "Savanna Zone", "Rainforest Zone", "Aquatic Zone", "Arctic Zone", "Desert Zone" };
            locationComboBox.DataSource = locationList;
        }

        private void PopulateEmployeesListBox(string jobTitleFilter = null)
        {
            lbEmployees.Items.Clear();
            IEnumerable<Employee> filteredEmployees = _employeeManager.Employees.Where(emp => emp.Contract != null);

            if (!string.IsNullOrEmpty(jobTitleFilter) && jobTitleFilter != "All")
            {
                filteredEmployees = filteredEmployees.Where(emp => emp.Contract.JobTitle == jobTitleFilter);
            }

            foreach (var employee in filteredEmployees)
            {
                string displayText = $"{employee.Id} - {employee.FirstName} {employee.LastName} - {employee.Contract.JobTitle}";
                lbEmployees.Items.Add(displayText);
            }
        }

        private void InitializeJobTitleComboBox()
        {
            List<string> jobTitles = _employeeManager.Employees
            .Where(emp => emp.Contract != null)
            .Select(emp => emp.Contract.JobTitle)
            .Distinct()
            .ToList();
            jobTitles.Insert(0, "All"); // Add "All" option

            jobTitleComboBox.DataSource = jobTitles;
            jobTitleComboBox.SelectedIndexChanged += (sender, e) =>
            {
                string selectedJobTitle = jobTitleComboBox.SelectedItem.ToString();
                PopulateEmployeesListBox(selectedJobTitle);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = taskTitleTextBox.Text;
            string description = contextTextBox.Text;
            string category = categoryComboBox.SelectedItem.ToString();
            string location = locationComboBox.SelectedItem.ToString();  
            DateTime deadline = DateTime.Parse(doneByTextBox.Text);

            List<int> selectedEmployeeIds = new List<int>();
            foreach (var item in lbEmployees.SelectedItems)
            {
                string displayText = item.ToString();
                int id = int.Parse(displayText.Split(new[] { " - " }, StringSplitOptions.None)[0]);
                selectedEmployeeIds.Add(id);
            }

            if (selectedEmployeeIds.Count > 0)
            {
                taskManager.CreateTask(title, description, category, location, deadline, selectedEmployeeIds);
                MessageBox.Show("Task assigned successfully!");
            }
            else
            {
                MessageBox.Show("Please select at least one employee to assign the task.");
            }
        }
    }
}
