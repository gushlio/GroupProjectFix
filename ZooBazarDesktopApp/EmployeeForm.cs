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

            JobTitles[] jobTitles = (JobTitles[])Enum.GetValues(typeof(JobTitles));
            comboBoxJobTItle.DataSource = jobTitles;
            comboBoxJobTItle.DisplayMember = "ToString";
        }

        private void RefreshEmployeeListBox(List<Employee> filteredEmployees)
        {
            lbEmployees.Items.Clear();

            foreach (Employee employee in filteredEmployees)
            {
                lbEmployees.Items.Add(employee.Info);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbEmployees.DataSource = null;
            lbEmployees.DataSource = employeeManager.SearchEmployee(txtName.Text, comboBoxJobTItle.Text, cmbLocation.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp(true);
            form.ShowDialog();

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
