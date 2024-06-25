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
    public partial class DeleteForm : Form
    {
        Employee employee;
        EmployeeManager employeeManager;
        ViewDetails employeeDetailsForm;
        public DeleteForm(Employee emp, ViewDetails form)
        {
            InitializeComponent();
            employeeDetailsForm = form;
            employeeManager = new EmployeeManager();
            employee = emp;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeManager.DeleteEmployee(employee);
            employeeDetailsForm.EmployeeDeleted();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
