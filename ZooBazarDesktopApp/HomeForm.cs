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

            LoadReportsData();
            UpdateListBox();
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
    }
}
