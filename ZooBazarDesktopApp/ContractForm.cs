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
    public partial class ContractForm : Form
    {
        Employee employee;
        string jobPosition;
        double salary;
        string startDate;
        string endDate;
        EmployeeManager employeeManager;
        ViewDetails employeeDetailsForm;
        public ContractForm(Employee emp, ViewDetails form)
        {
            employeeDetailsForm = form;
            employeeManager = new EmployeeManager();
            employee = emp;
            InitializeComponent();
            PopulateJobComboBox();
        }

        public void PopulateJobComboBox()
        {
            JobTitles[] jobTitles = (JobTitles[])Enum.GetValues(typeof(JobTitles));
            cbJob.DataSource = jobTitles;
            cbJob.DisplayMember = "ToString";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jobPosition = cbJob.Text;
            salary = Convert.ToDouble(txtSalary.Text);
            startDate = txtStart.Text;
            endDate = txtEnd.Text;
            employeeManager.AddContract(employee.Id,  startDate, "", endDate, salary, jobPosition);
            employeeDetailsForm.SetForm();
            this.Hide();
            this.Close();
        }
    }
}
