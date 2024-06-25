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
    public partial class ShiftAssignmentForm : Form
    {
        private string shiftKey;
        private Dictionary<string, List<int>> shiftAssignments;
        private ListBox assignedEmployeesListBox;
        private ListBox availableEmployeesListBox;
        private List<Employee> employees;
        private Button addButton;
        private Button removeButton;
        private Button saveButton;
        public ShiftAssignmentForm(string shiftKey, Dictionary<string, List<int>> shiftAssignments, List<Employee> employees)
        {
            this.shiftKey = shiftKey;
            this.shiftAssignments = shiftAssignments;
            this.employees = employees;
            InitializeComponent();
            Initialize();

            LoadEmployees();
        }

        private void Initialize()
        {
            this.Text = "Shift Assignment";
            this.Width = 400;
            this.Height = 300;

            Label assignedLabel = new Label { Text = "Assigned Employees", Top = 10, Left = 10, Width = 150 };
            assignedEmployeesListBox = new ListBox { Top = 30, Left = 10, Width = 150, Height = 200 };

            Label availableLabel = new Label { Text = "Available Employees", Top = 10, Left = 200, Width = 150 };
            availableEmployeesListBox = new ListBox { Top = 30, Left = 200, Width = 150, Height = 200 };

            addButton = new Button { Text = "Add", Top = 240, Left = 200 };
            addButton.Click += AddButton_Click;

            removeButton = new Button { Text = "Remove", Top = 240, Left = 10 };
            removeButton.Click += RemoveButton_Click;

            saveButton = new Button { Text = "Save", Top = 240, Left = 300 };
            saveButton.Click += SaveButton_Click;

            this.Controls.Add(assignedLabel);
            this.Controls.Add(assignedEmployeesListBox);
            this.Controls.Add(availableLabel);
            this.Controls.Add(availableEmployeesListBox);
            this.Controls.Add(addButton);
            this.Controls.Add(removeButton);
            this.Controls.Add(saveButton);
        }

        private void LoadEmployees()
        {
            if (!shiftAssignments.ContainsKey(shiftKey))
            {
                shiftAssignments[shiftKey] = new List<int>();
            }

            var assignedEmployees = shiftAssignments[shiftKey];

            assignedEmployeesListBox.Items.AddRange(employees.Where(e => assignedEmployees.Contains(e.Id)).Select(e => $"{e.FirstName} {e.LastName} - {e.Contract.JobTitle}").ToArray());

            var availableEmployees = employees
                .Where(e => e.Contract != null && !assignedEmployees.Contains(e.Id))
                .Select(e => $"{e.FirstName} {e.LastName} - {e.Contract.JobTitle}")
                .ToArray();
            availableEmployeesListBox.Items.AddRange(availableEmployees);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (availableEmployeesListBox.SelectedItem != null && assignedEmployeesListBox.Items.Count < 8)
            {
                string employeeName = availableEmployeesListBox.SelectedItem.ToString();
                Employee employee = employees.First(e => $"{e.FirstName} {e.LastName} - {e.Contract.JobTitle}" == employeeName);

                // Check if the employee is already in more than 2 shifts
                int shiftCount = shiftAssignments.Values.Count(list => list.Contains(employee.Id));
                if (shiftCount >= 2)
                {
                    var result = MessageBox.Show($"{employee.FirstName} {employee.LastName} is already assigned to {shiftCount} shifts. Are you sure you want to assign them to another shift?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                assignedEmployeesListBox.Items.Add(employeeName);
                availableEmployeesListBox.Items.Remove(employeeName);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (assignedEmployeesListBox.SelectedItem != null)
            {
                string employeeName = assignedEmployeesListBox.SelectedItem.ToString();
                assignedEmployeesListBox.Items.Remove(employeeName);
                availableEmployeesListBox.Items.Add(employeeName);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                shiftAssignments[shiftKey] = assignedEmployeesListBox.Items.Cast<string>()
                    .Select(name => employees.First(e => $"{e.FirstName} {e.LastName} - {e.Contract.JobTitle}" == name).Id)
                    .ToList();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("An error occurred while saving shift assignments. Please check the employee list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }
    }
}
