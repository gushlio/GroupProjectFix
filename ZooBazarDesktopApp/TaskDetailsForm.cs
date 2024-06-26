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
    public partial class TaskDetailsForm : Form
    {
        private Domain.Entity.Task task;
        private TaskManager taskManager;
        Employee loggedEmployee;
        List<string> locations;
       
        public TaskDetailsForm(Domain.Entity.Task task, Employee currentUser)
        {
            InitializeComponent();
            this.task = task;
            taskManager = new TaskManager();

            DisplayTaskDetails();
            DisplayAssignedEmployees();
            ConfigureForManagerOrAdmin();
            loggedEmployee = currentUser;
            buttonSave.Visible = false;
            buttonDelete.Visible = false;

            List<string> categoryList = new List<string> { "Animal Care", "Administration", "Maintenance", "Other" };
            cmbCategory.DataSource = categoryList;

            locations = new List<string>
            {
                "Savanna",
                "Rainforest",
                "Aquatic Zone",
                "Arctic Zone",
                "Desert"
            };

            cmbLocation.DataSource = locations;
        }

        private void ConfigureForManagerOrAdmin()
        {
            if(loggedEmployee.Contract.JobTitle == "Manageer" || loggedEmployee.Contract.JobTitle != "Administrator")
            {
                buttonSave.Visible = true;
                buttonDelete.Visible = true;
            }

            lblTitle.Visible = true;
            lblDescription.Visible = true;
            lblCategory.Visible = true;
            lblLocation.Visible = true;
            lblDeadline.Visible = true;
            btnMarkAsDone.Visible = true;

            txtTitle.Visible = false;
            txtDescription.Visible = false;
            cmbCategory.Visible = false;
            cmbLocation.Visible = false;
            doneByTextBox.Visible = false;

            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            cmbCategory.Text = task.Category;
            cmbLocation.Text = task.Location;
            doneByTextBox.Text = task.Deadline.ToString();

            btnMarkAsDone.Visible = true;
        }

        private void DisplayTaskDetails()
        {
            lblTitle.Text = task.Title;
            lblDescription.Text = task.Description;
            lblCategory.Text = task.Category;
            lblLocation.Text = task.Location;
            lblDeadline.Text = task.Deadline.ToString();
            btnMarkAsDone.Visible = !task.IsDone;
        }

        private void DisplayAssignedEmployees()
        {
            List<Employee> assignedEmployees = taskManager.GetAssignedEmployees(task.Id);
            foreach (var employee in assignedEmployees)
            {
                lbAssignedEmployees.Items.Add($"{employee.FirstName} {employee.LastName} ({employee.Contract.JobTitle})");
            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            taskManager.UpdateTaskStatus(task.Id, true);
            MessageBox.Show("Task marked as done.", "Task Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            taskManager.DeleteTask(task.Id);
            MessageBox.Show("Task deleted.", "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!txtTitle.Visible)
            {
                lblTitle.Visible = false;
                lblDescription.Visible = false;
                lblCategory.Visible = false;
                lblLocation.Visible = false;
                lblDeadline.Visible = false;
                btnMarkAsDone.Visible = false;

                txtTitle.Visible = true;
                txtDescription.Visible = true;
                cmbCategory.Visible = true;
                cmbLocation.Visible = true;
                doneByTextBox.Visible = true;
            }
            else
            {
                // Update task details
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string category = cmbCategory.SelectedItem?.ToString();
                string location = cmbLocation.SelectedItem?.ToString();
                DateTime deadline;
                if (!DateTime.TryParse(doneByTextBox.Text, out deadline))
                {
                    MessageBox.Show("Invalid deadline format. Please enter a valid date.", "Update Task", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Assuming you have a taskId variable that holds the ID of the task being updated
                // Replace taskId with your actual task ID variable
                taskManager.UpdateTask(task.Id, title, description, category, location, deadline);

                MessageBox.Show("Task details updated.", "Update Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfigureForManagerOrAdmin();
            }
        }
    }
}
