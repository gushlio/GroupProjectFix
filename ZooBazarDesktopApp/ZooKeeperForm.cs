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

            ShowForm(new HomeForm(loggedEmployee));

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
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "Manager" || loggedEmployee.Contract.JobTitle == "Caretaker" || loggedEmployee.Contract.JobTitle == "ZooKeeper")
                {
                    ShowForm(new AnimalForm(loggedEmployee));
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to caretakers and zookeepers only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEmployees_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "Manager")
                {
                    ShowForm(new EmployeeForm(loggedEmployee));
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to managers only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "Zookeeper" || loggedEmployee.Contract.JobTitle == "Caretaker" || loggedEmployee.Contract.JobTitle == "Manager")
                {
                    ShowForm(new FeedingTimeTable());
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to caretakers and zookeepeers only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxStatistics_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "Manager")
                {
                    ShowForm(new StatisticsForm());
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to managers only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "TicketBooth" || loggedEmployee.Contract.JobTitle == "Manager")
                {
                    ShowForm(new TicketBooth());
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to employees working at the ticket booth.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "Manager")
                {
                    ShowForm(new ScheduleForm());
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to managers only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (loggedEmployee.Contract != null)
            {
                if (loggedEmployee.Contract.JobTitle == "Caretaker" || loggedEmployee.Contract.JobTitle == "Zookeeper" || loggedEmployee.Contract.JobTitle == "Manager")
                {
                    ShowForm(new VetForm());
                }
                else
                {
                    MessageBox.Show("Access Denied: This form is restricted to caretakers and zookeepeers only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You currently have not signed a contract. An Admin has to grant you access after you have signed your contract.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label8_Click(object sender, EventArgs e)
        {
            ShowForm(new HomeForm(loggedEmployee));
        }
    }

}
