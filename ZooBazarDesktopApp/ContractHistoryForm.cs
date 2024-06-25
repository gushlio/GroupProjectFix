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
    public partial class ContractHistoryForm : Form
    {
        Employee Employee;
        EmployeeManager Manager;
        public ContractHistoryForm(Employee e)
        {
            Manager = new EmployeeManager();

            Manager.LoadEmployees();
            Employee = Manager.GetEmployeeById(e.Id);
            Employee.SetContractHistory(Manager.GetContractHistory(Employee.Id));
            InitializeComponent();
            ShowLabels();
        }

        public void ShowLabels()
        {
            flpHistory.Controls.Clear();

            foreach (Contract contract in Employee.contractHistory)
            {
                string text = $"ID: {contract.Id}\nJob position: {contract.JobTitle}\nContract type: {contract.Salary}\nStart date: {contract.ContractStart}\nEnd date: {contract.ContractEnd}\nReason for termination: {contract.EndMessage}";
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new Font("Arial", 12, FontStyle.Regular);
                label.BackColor = Color.LightGray;
                label.Text = text;
                // Add the button to the FlowLayoutPanel
                flpHistory.Controls.Add(label);
            }
        }
    }
}
