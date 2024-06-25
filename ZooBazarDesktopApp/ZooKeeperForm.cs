using DataAccessLayer;
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
    public partial class ZooKeeperForm : Form
    {
        private HomeForm homeForm;
        Employee loggedEmployee;
        public ZooKeeperForm(Employee currentUser)
        {
            InitializeComponent();
            loggedEmployee = currentUser;

        }

        private void ShowForm(Form form)
        {
            panel3.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Size = panel3.Size;
            panel3.Controls.Add(form);
            form.Show();
        }



        private void pictureBoxAnimals_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract.JobTitle == "Manager" || loggedEmployee.Contract.JobTitle == "Caretaker")
            {
                ShowForm(new AnimalForm(loggedEmployee));
            }
            else
            {
                MessageBox.Show("This form can only be accessed my Managers and Caretakers");
            }
        }

        private void pictureBoxEmployees_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract.JobTitle == "Manager")
            {
                ShowForm(new EmployeeForm(loggedEmployee));
            }
            else
            {
                MessageBox.Show("This form can only be accessed my Managers");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowForm(new FeedingTimeTable());
        }

        private void pictureBoxStatistics_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract.JobTitle == "Manager")
            {
                ShowForm(new StatisticsForm());
            }
            else
            {
                MessageBox.Show("This form can only be accessed my Managers");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract.JobTitle == "TicketBooth" || loggedEmployee.Contract.JobTitle == "Manager")
            {
                ShowForm(new TicketBooth());
            }
            else
            {
                MessageBox.Show("This form can only be accessed by Employees working at the Ticket Booth.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract.JobTitle == "Manager")
            {
                ShowForm(new ScheduleForm());
            }
            else
            {
                MessageBox.Show("This form can only be accessed my Managers");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract.JobTitle != "Cleaner" || loggedEmployee.Contract.JobTitle != "TicketBooth" || loggedEmployee.Contract.JobTitle != "Security Guard")
            {
                ShowForm(new VetForm());
            }
            else
            {
                MessageBox.Show("You do not have the permission to access this form");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void ZooKeeperForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowForm(new HomeForm(loggedEmployee));
        }
    }

}
