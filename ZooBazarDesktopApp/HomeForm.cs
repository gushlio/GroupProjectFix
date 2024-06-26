using DataAccessLayer;
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
using Task = Domain.Entity.Task;

namespace ZooBazarDesktopApp
{
    public partial class HomeForm : Form
    {
        Employee loggedEmployee;
        private List<Report> reports;
        private ReportsDataAccess reportsDataAccess;
        private TaskManager taskManager;
        private string selectedCategory;
        public HomeForm(Employee currentUser)
        {
            InitializeComponent();
            loggedEmployee = currentUser;
            reportsDataAccess = new ReportsDataAccess();
            taskManager = new TaskManager();

            InitializeCategoryComboBox();
            LoadReportsData();
            LoadEmployeeTasks();
            LoadAllTasksForAdmin();
            UpdateListBox();

            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle != "Manager" && loggedEmployee.Contract.JobTitle != "Administrator")
                {
                    flowLayoutPanelAdminTasks.Visible = false;
                    btnAssignTask.Visible = false;
                    adminComboBox.Visible = false;
                }
                else
                {
                    adminComboBox.Visible = true;
                    InitializeAdminComboBox();
                }
            }
            else
            {
                flowLayoutPanelAdminTasks.Visible = false;
                btnAssignTask.Visible = false;
                adminComboBox.Visible = false;
                btnAddReport.Visible = false;
                groupBox2.Visible = false;

            }

        }

        private void InitializeAdminComboBox()
        {
            List<string> adminFilters = new List<string> { "All", "Done", "Not Done" };
            adminComboBox.DataSource = adminFilters;
            adminComboBox.SelectedIndexChanged += (sender, e) =>
            {
                string selectedFilter = adminComboBox.SelectedItem.ToString();

                if (selectedFilter == "Done")
                {
                    LoadAllTasksForAdmin(true); 
                }
                else if (selectedFilter == "Not Done")
                {
                    LoadAllTasksForAdmin(false); 
                }
                else
                {
                    LoadAllTasksForAdmin(); 
                }
            };
        }

        private void InitializeCategoryComboBox()
        {
            List<string> categories = new List<string> { "All", "Animal Care", "Maintenance", "Administration", "Other" };
            categoryComboBox.DataSource = categories;
            categoryComboBox.SelectedIndexChanged += (sender, e) =>
            {
                selectedCategory = categoryComboBox.SelectedItem.ToString();
                LoadEmployeeTasks();
                LoadAllTasksForAdmin();
            };
        }


        private void LoadEmployeeTasks()
        {
            flowLayoutPanelTasks.Controls.Clear();
            List<Task> tasks = taskManager.GetTasksByEmployeeId(loggedEmployee.Id, selectedCategory == "All" ? null : selectedCategory);

            foreach (Task task in tasks)
            {
                Button taskButton = new Button();
                taskButton.Text = task.Title;
                taskButton.Tag = task;
                taskButton.Click += TaskButton_Click;
                taskButton.Size = new Size(440, 50);

                if (task.IsDone)
                {
                    taskButton.BackColor = Color.Green;
                }
                else if (task.Deadline < DateTime.Now)
                {
                    taskButton.BackColor = Color.Red;
                }
                else
                {
                    taskButton.BackColor = Color.Yellow;
                }

                flowLayoutPanelTasks.Controls.Add(taskButton);
            }

        }

        private void LoadAllTasksForAdmin(bool? isDoneFilter = null)
        {
            flowLayoutPanelAdminTasks.Controls.Clear();
            List<Task> allTasks = taskManager.GetAllTasks(); 

            string filterCategory = selectedCategory == "All" ? null : selectedCategory;
            List<Task> tasks = filterCategory != null ? allTasks.Where(t => t.Category == filterCategory).ToList() : allTasks;

            if (isDoneFilter.HasValue)
            {
                tasks = tasks.Where(t => t.IsDone == isDoneFilter.Value).ToList();
            }

            foreach (Task task in tasks)
            {
                Button taskButton = new Button();
                taskButton.Text = task.Title;
                taskButton.Tag = task;
                taskButton.Click += TaskButton_Click;
                taskButton.Size = new Size(440, 50);

                if (task.IsDone)
                {
                    taskButton.BackColor = Color.Green;
                }
                else if (task.Deadline < DateTime.Now)
                {
                    taskButton.BackColor = Color.Red;
                }
                else
                {
                    taskButton.BackColor = Color.Yellow;
                }

                flowLayoutPanelAdminTasks.Controls.Add(taskButton);
            }
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            Button taskButton = sender as Button;
            Domain.Entity.Task task = taskButton.Tag as Domain.Entity.Task;

            TaskDetailsForm taskDetailsForm = new TaskDetailsForm(task, loggedEmployee);
            taskDetailsForm.ShowDialog();
        }

        private void LoadReportsData()
        {
            reportsDataAccess.LoadReportsData();

            reports = new List<Report>();
            foreach (var reportData in reportsDataAccess.reportsData)
            {
                int id = Convert.ToInt32(reportData[0]);
                int employeeId = Convert.ToInt32(reportData[1]);
                string title = reportData[2];
                string description = reportData[3];
                string dateCreated = reportData[4];
                string category = reportData[5];

                Report report = new Report(id, employeeId, title, description, dateCreated, category);
                reports.Add(report);
            }
        }

        private void UpdateListBox()
        {
            listBoxReports.Items.Clear();
            foreach (var reportData in reportsDataAccess.reportsData)
            {
                string title = reportData[2];
                string dateCreated = reportData[4];
                string category = reportData[5];
                listBoxReports.Items.Add($"{title} - {dateCreated} ({category})");
            }
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            AddReportForm addReportForm = new AddReportForm(loggedEmployee);
            DialogResult result = addReportForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string title = addReportForm.CreatedReport.Title;
                string description = addReportForm.CreatedReport.Content;
                string category = addReportForm.CreatedReport.Category;

                reportsDataAccess.AddReportData(loggedEmployee.Id, title, description, category);
                LoadReportsData();
                UpdateListBox();
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (listBoxReports.SelectedIndex != -1)
            {
                int selectedIndex = listBoxReports.SelectedIndex;

                if (reports != null && reports.Count > selectedIndex)
                {
                    Report selectedReport = reports[selectedIndex];

                    using (ReportDetailsForm detailsForm = new ReportDetailsForm(selectedReport))
                    {
                        detailsForm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Selected report could not be found in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please select a report to view details.");
            }
        }

        private void ShowReportDetailsForm(Report report)
        {
            int id = report.Id;
            int employeeId = report.AuthorID;
            string title = report.Title;
            string description = report.Content;
            string dateCreated = report.DateCreated;
            string category = report.Category;

            MessageBox.Show($"Title: {title}\nAuthor ID: {employeeId}\nDescription: {description}\nDate Created: {dateCreated}\nCategory: {category}",
                            "Report Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            AssignTask assignTaskForm = new AssignTask();
            assignTaskForm.ShowDialog();
        }
    }
}
