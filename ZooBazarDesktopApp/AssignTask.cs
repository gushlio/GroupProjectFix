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

            foreach (var employee in _employeeManager.Employees)
            {
                string displayText = $"ID:{employee.Id}-{employee.FirstName} {employee.LastName} - {employee.Contract.JobTitle} ";
                lbEmployees.Items.Add(displayText);
            }

            List<string> categoryList = new List<string> { "Animal Care", "Administration", "Maintenance", "Maintenance" };
            categoryComboBox.DataSource = categoryList;


            List<string> locationList = new List<string> { "Location1", "Location2", "Location3" };
            locationComboBox.DataSource = locationList;
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
