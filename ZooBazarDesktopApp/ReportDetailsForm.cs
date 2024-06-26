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
    public partial class ReportDetailsForm : Form
    {
        private Report report;
        private Employee author;
        public ReportDetailsForm(Report report)
        {
            InitializeComponent();

            this.report = report;
            LoadReportDetails();
            LoadEmployeeDetails();
        }

        private void LoadReportDetails()
        {
            lblTitle.Text = report.Title;
            lblDescription.AutoSize = false; 
            lblDescription.MaximumSize = new Size(130, 0);
            lblDescription.AutoSize = true;
            lblDescription.Text = report.Content;
            lblDateCreated.Text = report.DateCreated.ToString(); 
            lblCategory.Text = report.Category;
        }

        private void LoadEmployeeDetails()
        {
            EmployeeManager employeeManager = new EmployeeManager(); 
            author = employeeManager.GetEmployeeById(report.AuthorID);

            if (author != null)
            {
                lblEmp.Text = $"{author.FirstName} {author.LastName} - {author.Contract.JobTitle}";
                                   
            }
            else
            {
                MessageBox.Show($"Employee with ID {report.AuthorID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
