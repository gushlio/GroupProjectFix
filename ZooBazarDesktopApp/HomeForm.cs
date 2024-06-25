using DataAccessLayer;
using Domain.Entity;
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
    public partial class HomeForm : Form
    {
        Employee loggedEmployee;
        private List<Report> reports;
        private ReportsDataAccess reportsDataAccess;
        public HomeForm(Employee currentUser)
        {
            InitializeComponent();
            loggedEmployee = currentUser;
            reportsDataAccess = new ReportsDataAccess();

            // Load reports initially
            LoadReportsData();


            UpdateListBox();
        }

        private void LoadReportsData()
        {
            reportsDataAccess.LoadReportsData(); // Ensure reportsDataAccess loads data into reportsData

            // Populate reports list based on reportsData
            reports = new List<Report>();
            foreach (var reportData in reportsDataAccess.reportsData)
            {
                int id = Convert.ToInt32(reportData[0]);
                int employeeId = Convert.ToInt32(reportData[1]);
                string title = reportData[2];
                string description = reportData[3]; // Assuming index 3 is Description
                string dateCreated = reportData[4];
                string category = reportData[5]; // Assuming index 5 is Category

                // Create Report object and add to reports list
                Report report = new Report(id, employeeId, title, description, dateCreated, category);
                reports.Add(report);
            }
        }

        private void UpdateListBox()
        {
            listBoxReports.Items.Clear();
            foreach (var reportData in reportsDataAccess.reportsData)
            {
                string title = reportData[2]; // Index 2 is Title
                string dateCreated = reportData[4]; // Index 4 is DateCreated
                string category = reportData[5]; // Index 5 is Category
                listBoxReports.Items.Add($"{title} - {dateCreated} ({category})");
            }
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            AddReportForm addReportForm = new AddReportForm(loggedEmployee);
            DialogResult result = addReportForm.ShowDialog();

            // If the user adds a report successfully, refresh the list
            if (result == DialogResult.OK)
            {
                string title = addReportForm.CreatedReport.Title;
                string description = addReportForm.CreatedReport.Content; // Assuming Content is used as Description
                string category = addReportForm.CreatedReport.Category;

                reportsDataAccess.AddReportData(loggedEmployee.Id, title, description, category);
                LoadReportsData(); // Reload reports from the database
                UpdateListBox();
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (listBoxReports.SelectedIndex != -1)
            {
                int selectedIndex = listBoxReports.SelectedIndex;

                // Ensure reports list is not null and has items
                if (reports != null && reports.Count > selectedIndex)
                {
                    Report selectedReport = reports[selectedIndex];

                    // Show details form or dialog with selectedReport
                    ShowReportDetailsForm(selectedReport);
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
            // Extract details from the Report object
            int id = report.Id;
            int employeeId = report.AuthorID;
            string title = report.Title;
            string description = report.Content; // Assuming Content is used as Description
            string dateCreated = report.DateCreated;
            string category = report.Category;

            // Display details in a dialog or form
            MessageBox.Show($"Title: {title}\nAuthor ID: {employeeId}\nDescription: {description}\nDate Created: {dateCreated}\nCategory: {category}",
                            "Report Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
