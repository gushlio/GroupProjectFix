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
    public partial class ViewDetails : Form
    {
        Employee employee;
        EmployeeManager employeeManager;
        int employeeId;
        string reasonForTermination;
        bool confirmed;
        public ViewDetails(Employee emp)
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            employeeId = emp.Id;
            employee = employeeManager.GetEmployeeById(employeeId);
            SetForm();
            txtReason.Text = "";

            reasonForTermination = "";
        }



        public void SetForm()
        {
            employeeManager.LoadEmployees();
            employee = employeeManager.GetEmployeeById(employeeId);

            lblID.Text = employee.Id.ToString();
            lblFirst.Text = employee.FirstName.ToString();
            lblLast.Text = employee.LastName.ToString();
            lblEmailAddress.Text = employee.EmailAddress.ToString();
            lblPhone.Text = employee.ContactInfo.ToString();
            lblBirthday.Text = employee.DateOfBirth.ToString();
            lblBSN.Text = employee.Bsn.ToString();
            lblAddress.Text = employee.Address.ToString();

            if (employee.Contract != null)
            {

                lblJob.Text = employee.Contract.JobTitle.ToString();
                lblSalary.Text = employee.Contract.Salary.ToString();
                lblStart.Text = employee.Contract.ContractStart.ToString();
                if (employee.Contract.ContractEnd != "")
                {
                    lblEnd.Text = employee.Contract.ContractEnd.ToString();

                }
                else
                {
                    lblEnd.Text = "No end date specified";
                }
                if (employee.Contract.EndMessage != "")
                {
                    lblReason.Text = employee.Contract.EndMessage.ToString();
                    reasonForTermination = lblReason.Text;
                }
                else
                {
                    lblReason.Text = "Contract isn't terminated";
                    reasonForTermination = "";
                }


                lblJob.Visible = true;
                lblSalary.Visible = true;
                lblStart.Visible = true;
                lblEnd.Visible = true;
                lblReason.Visible = true;
                btnModify.Visible = true;

                btnAssign.Visible = false;

                label11.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
            }
            else
            {
                lblJob.Visible = false;
                lblSalary.Visible = false;
                lblStart.Visible = false;
                lblEnd.Visible = false;
                lblReason.Visible = false;
                btnModify.Visible = false;

                btnAssign.Visible = true;

                label11.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            ContractForm form = new ContractForm(employee, this);
            form.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lblJob.Visible)
            {
                lblJob.Visible = false;
                lblSalary.Visible = false;
                lblStart.Visible = false;
                lblEnd.Visible = false;
                lblReason.Visible = false;

                txtJob.Text = lblJob.Text;
                txtSalary.Text = lblSalary.Text;
                txtStart.Text = lblStart.Text;
                txtEnd.Text = lblEnd.Text;
                txtReason.Text = "";

                txtJob.Visible = true;
                txtSalary.Visible = true;
                txtStart.Visible = true;
                txtEnd.Visible = true;
                txtReason.Visible = true;
            }

            else
            {
                string jobPosition = txtJob.Text;
                double Salary = Convert.ToDouble(txtSalary.Text);
                string startDate = txtStart.Text;
                string endDate = txtEnd.Text;

                if (reasonForTermination == null || reasonForTermination == "Contract isn't terminated")
                {
                    
                    string reasonForTermination = txtReason.Text;
                    employeeManager.UpdateContract(employee.Contract.Id, startDate, endDate, reasonForTermination, Salary, jobPosition);

                    MessageBox.Show("Data modified successfully!");

                    txtJob.Visible = false;
                    txtSalary.Visible = false;
                    txtStart.Visible = false;
                    txtEnd.Visible = false;
                    txtReason.Visible = false;
                    SetForm();


                }
                else if(reasonForTermination != null && reasonForTermination != "Contract isn't terminated")
                {
                    ConfirmationFormcs confirmationForm = new ConfirmationFormcs(this);
                    confirmationForm.ShowDialog();
                }
            }
        }

        public void TerminationConfirmed()
        {
            string jobPosition = txtJob.Text;
            double Salary = Convert.ToDouble(txtSalary.Text);
            string startDate = txtStart.Text;
            string endDate = txtEnd.Text;
            if (string.IsNullOrEmpty(endDate))
            {
                endDate = DateTime.Now.ToString("dd-MM-yyyy");
            }
            string reasonForTermination = txtReason.Text;


            employeeManager.UpdateContract(employee.Contract.Id, startDate, endDate, reasonForTermination, Salary, jobPosition);
            employeeManager.AddContractToHistory(employee.Id, employee.Contract.Id);
            employeeManager.TerminateContract(employeeId, reasonForTermination);
            employeeManager.LoadEmployees();
            employee = employeeManager.GetEmployeeById(employee.Id);
            txtJob.Visible = false;
            txtSalary.Visible = false;
            txtStart.Visible = false;
            txtEnd.Visible = false;
            txtReason.Visible = false;
            SetForm();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ContractHistoryForm contractHistoryForm = new ContractHistoryForm(employee);
            contractHistoryForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm(employee, this);
            delete.ShowDialog();
        }

        public void EmployeeDeleted()
        {
            this.Close();
        }
    }
}
