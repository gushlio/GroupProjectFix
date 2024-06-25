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
    public partial class AddReportForm : Form
    {
        public Report CreatedReport { get; private set; }
        private Employee loggedEmployee;
        public AddReportForm(Employee currentUser)
        {
            InitializeComponent();
            loggedEmployee = currentUser;

            comboBoxCategory.Items.AddRange(new object[] {
            "Animal problems",
            "Employee problems",
            "Schedule problems",
            "Visitors problems",
            "Staff Concern",
            "Other"
        });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
            string.IsNullOrWhiteSpace(txtContent.Text) ||
            comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Report object
            string title = txtTitle.Text;
            string description = txtContent.Text;
            string category = comboBoxCategory.SelectedItem.ToString();
            string dateCreated = DateTime.Now.ToString();

            CreatedReport = new Report(0, loggedEmployee.Id, title, description, dateCreated, category);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
