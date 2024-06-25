using DataAccessLayer.DTOs;
using Domain.Manager;
using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ZooBazarDesktopApp
{
    public partial class EditShiftsForm : Form
    {
        // private fields
        private string _day;
        private string _time;
        private EmployeeManager _employeeManager;
        private ShiftManager _shiftManager;
        private List<int> _employeeIdsToBeSaved;
        private bool _forceClose;
        public event EventHandler ShiftUpdated;
        public EditShiftsForm(string day, string time)
        {
            InitializeComponent();
            _day = day;
            _time = time;
            _forceClose = false;
            _employeeManager = new EmployeeManager();
            _shiftManager = new ShiftManager();
            _employeeIdsToBeSaved = new List<int>();
            _employeeManager.LoadEmployees();
            _shiftManager.LoadShifts();
            LoadDayAndTime();
            PopulateEmployees();
        }

        private void LoadDayAndTime()
        {
            lblDayTime.Text = $"{_day} | {_time}";
        }

        private void PopulateEmployees()
        {
            cmbEmployee.Items.Clear();

            try
            {
                foreach (var employee in _employeeManager.Employees)
                {
                    var jobPosition = employee.Contract != null ? employee.Contract.JobTitle : "No Position";
                    cmbEmployee.Items.Add($"{employee.Id} - {employee.FirstName} {employee.LastName} ({jobPosition})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lbxWorkingEmployees.Items.Clear();

            if (_shiftManager.shifts.Count > 0)
            {
                foreach (var shift in _shiftManager.shifts)
                {
                    if (shift["DayOfWeek"].ToString() == _day && shift["ShiftTime"].ToString() == _time)
                    {
                        int employeeId = (int)shift["EmployeeID"];
                        var employee = _employeeManager.Employees.FirstOrDefault(e => e.Id == employeeId);

                        if (employee != null)
                        {
                            var jobPosition = employee.Contract != null ? employee.Contract.JobTitle : "No Position";
                            lbxWorkingEmployees.Items.Add($"{employee.Id} - {employee.FirstName} {employee.LastName} ({jobPosition})");
                        }
                    }
                }
            }
        }

        private static int GetIdFromString(string input)
        {
            string pattern = @"^\d+";
            Match match = Regex.Match(input, pattern);

            // If a match is found, parse it to an integer and return
            if (match.Success)
            {
                return int.Parse(match.Value);
            }
            else
            {
                return 0;
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (lbxWorkingEmployees.SelectedIndex >= 0)
            {
                int idToBeRemoved = GetIdFromString(lbxWorkingEmployees.SelectedItem.ToString());

                if (!_employeeIdsToBeSaved.Contains(idToBeRemoved))
                {
                    _shiftManager.DeleteShift(_day, _time, idToBeRemoved);
                }
                else
                {
                    _employeeIdsToBeSaved.Remove(idToBeRemoved);
                }
                lbxWorkingEmployees.Items.Remove(lbxWorkingEmployees.Items[lbxWorkingEmployees.SelectedIndex]);
            }
            else
            {
                MessageBox.Show("Please select an employee and try again.", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.Text != "")
            {
                int id = GetIdFromString(cmbEmployee.Text);

                if (_employeeIdsToBeSaved.Count <= 10)
                {
                    bool employeeAlreadyAdded = lbxWorkingEmployees.Items.Cast<string>().Any(item => GetIdFromString(item) == id);

                    if (!employeeAlreadyAdded)
                    {
                        _employeeIdsToBeSaved.Add(id);
                        lbxWorkingEmployees.Items.Add(cmbEmployee.Text);
                    }
                    else
                    {
                        MessageBox.Show("Can not add the same employee twice in one shift.", "Employee Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Can not add more than 10 employees in one shift.", "Employee Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee and try again.", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void OnShiftUpdated(EventArgs e)
        {
            ShiftUpdated?.Invoke(this, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to save these changes?", "Saving Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_employeeIdsToBeSaved.Count > 0)
                {
                    foreach (int id in _employeeIdsToBeSaved)
                    {
                        try
                        {
                            _shiftManager.AddShift(_day, _time, id);
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Saved successfully!", "Saving Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _forceClose = true;
                this.Close();

                OnShiftUpdated(EventArgs.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void EditShiftsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_forceClose != true)
            {
                var result = MessageBox.Show("Are you sure you want to close?", "Closing Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
