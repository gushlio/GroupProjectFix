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
using System.Xml.Linq;

namespace ZooBazarDesktopApp
{
    public partial class EmployeeForm : Form
    {
        List<string> employeeInfos;
        EmployeeManager employeeManager;
        public EmployeeForm(Employee loggedUser)
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            try
            {

                employeeInfos = employeeManager.GetEmployeesInfo();
                lbEmployees.DataSource = employeeInfos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PopulateJobComboBox();
        }

        public void PopulateJobComboBox()
        {
            List<string> jobTitles = new List<string>();
            jobTitles.Add("All Job Titles");
            jobTitles.AddRange(Enum.GetNames(typeof(JobTitles)));
            jobTitles.Add("Not Working");

            comboBoxJobTItle.DataSource = jobTitles;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> filteredEmployees = SearchEmployees(txtName.Text, comboBoxJobTItle.SelectedItem.ToString());
            lbEmployees.DataSource = null; 
            lbEmployees.DataSource = filteredEmployees; 
        }

        private List<string> SearchEmployees(string name, string jobPosition)
        {
            List<string> searchedEmployees = new List<string>();

            foreach (string employeeInfo in employeeInfos)
            {
                string[] infoParts = employeeInfo.Split(new string[] { " - " }, StringSplitOptions.None);

                string idPart = infoParts[0].Trim(); 
                string namePart = infoParts[1].Trim(); 
                string emailPart = infoParts[2].Trim(); 
                string contractPart = infoParts[3].Trim(); 

                string[] nameParts = namePart.Split(' ');
                string firstName = nameParts[1]; 
                string lastName = nameParts[2]; 

                bool hasContract = !contractPart.Contains("No contract");

                bool nameMatch = string.IsNullOrEmpty(name) || firstName.ToLower().Contains(name.ToLower());
                bool jobPositionMatch = jobPosition == "All Job Titles" || (hasContract && contractPart.Contains(jobPosition));
                bool notWorkingMatch = jobPosition == "Not Working" && !hasContract;

                if (nameMatch && (jobPositionMatch || notWorkingMatch))
                {
                    searchedEmployees.Add(employeeInfo);
                }
            }

            return searchedEmployees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp(true);
            form.ShowDialog();

            lbEmployees.DataSource = employeeInfos;

            employeeInfos = employeeManager.GetEmployeesInfo();
            lbEmployees.DataSource = employeeInfos;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Employee employee = employeeManager.GetEmployeeByInfo(lbEmployees.SelectedItem.ToString());
            ViewDetails form = new ViewDetails(employee);
            form.ShowDialog();

            lbEmployees.DataSource = employeeInfos;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
