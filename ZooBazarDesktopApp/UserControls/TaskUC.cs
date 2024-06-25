using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Domain.Entity;
using Domain.Manager;
using DataAccessLayer.Repository;
using System.Xml.Linq;
using DataAccessLayer;

namespace ZooBazarDesktopApp.UserControls
{
    public partial class TaskUC : UserControl
    {
        TaskManager taskManager = new TaskManager();
        public TaskUC()
        {
            InitializeComponent();
            PopulateLocationComboBox();
            RefreshDataGridView();
            PopulateTasksForUpdateComboBox();
        }
        private void PopulateTasksForUpdateComboBox()
        {
            // Clear existing items
            cbbSelectTaskForUpdate.Items.Clear();

            // Retrieve all tasks from the database
            List<Domain.Entity.Task> tasks = taskManager.GetAllTasks();

            // Populate the ComboBox with tasks in the format: id - name
            foreach (var task in tasks)
            {
                cbbSelectTaskForUpdate.Items.Add($"{task.TaskId} - {task.Name}");
            }
        }
        private void PopulateLocationComboBox()
        {
            
            cbbSelectArea.Items.Clear();

           
            List<string> locations = new AnimalRepository().GetAllLocations();

            
            foreach (var location in locations)
            {
                cbbSelectArea.Items.Add(location);
            }
        }


        private void TaskUC_Load(object sender, EventArgs e)
        {

        }

        private void gbAddBook_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonAddTask_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddTask.Checked)
            {

                txtAddTask.Visible = true;
                
                btnAddTask.Visible = true;
                labelAddTask.Visible = true;


            }
            else
            {
                txtAddTask.Visible = false;
           
                btnAddTask.Visible = false;
                labelAddTask.Visible = false;

            }
        }

        private void radioButtonpdateTask_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonpdateTask.Checked)
            {
                labelSelectTaskUpdate.Visible = true;
                labelShowArea.Visible = true;
                btnUpdateTask.Visible = true;
                displaycurrentfreq.Visible = true;
                labelCurrentFrequency.Visible = true;
                labelcurrenttime.Visible = true;
                labelUpdateTask.Visible = true;
                cbbSelectTaskForUpdate.Visible = true;
                labelcurrentlocation.Visible = true;
            }
            else
            {
                labelSelectTaskUpdate.Visible = false;
                labelShowArea.Visible = false;
                btnUpdateTask.Visible = false;
                displaycurrentfreq.Visible = false;
                labelCurrentFrequency.Visible = false;
                labelcurrenttime.Visible = false;
                labelUpdateTask.Visible = false;
                cbbSelectTaskForUpdate.Visible = false;
                labelcurrentlocation.Visible= false;
            }



        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string name = txtAddTask.Text;
            string description = textBoxDescriprion.Text;
            string location = cbbSelectArea.SelectedItem.ToString(); 
            DateTime time = setTimeForTheTask.Value;

            List<string> frequency = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    frequency.Add(checkedListBox1.Items[i].ToString());
                }
            }

            // Create a Task object
            Domain.Entity.Task task = new Domain.Entity.Task(0, name, description, location, time, string.Join(",", frequency));

            // Add the task using TaskManager
            taskManager.AddTask(task);

            // Refresh DataGridView to reflect the updated task list
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
           
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

           
            dataGridView1.Columns.Add("TaskId", "Task ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Frequency", "Frequency");

            // Retrieve all tasks from the database
            List<Domain.Entity.Task> tasks = taskManager.GetAllTasks();

            // Populate the DataGridView with the tasks
            foreach (var task in tasks)
            {
                dataGridView1.Rows.Add(task.TaskId, task.Name, task.Description, task.Location, task.Time, task.Frequency);
            }
        }


        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if (cbbSelectTaskForUpdate.SelectedIndex >= 0)
            {
                string selectedItem = cbbSelectTaskForUpdate.SelectedItem.ToString();
                int taskId = int.Parse(selectedItem.Split('-')[0].Trim());

                // Retrieve the selected task from the database
                Domain.Entity.Task selectedTask = taskManager.GetTaskById(taskId);

                // Ensure that a location is selected
                if (cbbSelectArea.SelectedItem == null)
                {
                    MessageBox.Show("Please select a location.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create a new task object with updated information
                Domain.Entity.Task updatedTask = new Domain.Entity.Task(
                    selectedTask.TaskId,
                    selectedTask.Name,
                    selectedTask.Description,
                    cbbSelectArea.SelectedItem.ToString(), // Use selected location as string
                    setTimeForTheTask.Value,
                    selectedTask.Frequency
                );

                // Update the task in the database
                taskManager.UpdateTask(updatedTask);

                // Refresh DataGridView to reflect the updated task list
                RefreshDataGridView();

                MessageBox.Show("Task updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a task to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the TaskId of the selected task
                int selectedTaskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TaskId"].Value);

                // Remove the task from the database
                taskManager.DeleteTask(selectedTaskId);

                // Refresh DataGridView to reflect the updated task list
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbbSelectTaskForUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSelectTaskForUpdate.SelectedIndex >= 0)
            {
                string selectedItem = cbbSelectTaskForUpdate.SelectedItem.ToString();
                int taskId = int.Parse(selectedItem.Split('-')[0].Trim());


                Domain.Entity.Task selectedTask = taskManager.GetTaskById(taskId);


                labelShowArea.Text = selectedTask.Location.ToString();
                labelcurrenttime.Text = selectedTask.Time.ToString();
                displaycurrentfreq.Text = selectedTask.Frequency;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar calendarUC = new Calendar();
            
        }
    }
}
