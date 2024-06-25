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
using DataAccessLayer;
using Domain.Manager;

namespace ZooBazarDesktopApp
{
    public partial class Login : Form
    {
        public EmployeeManager EmployeeManager;

        public Login()
        {
            EmployeeManager = new EmployeeManager();
            EmployeeManager.LoadEmployees();
            InitializeComponent();
            txtPassword.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            Employee loggedUser;

            if ((email == "admin@gmail.com" && password == "admin") || (EmployeeManager.EmployeeExists(email) && EmployeeManager.GetEmployeeByEmail(email).PasswordConfirmation(password)))
            {
                loggedUser = EmployeeManager.GetEmployeeByEmail(email);

                ZooKeeperForm mainForm = new ZooKeeperForm(loggedUser);
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong email or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp registrationForm = new SignUp(false);
            this.Hide();
            registrationForm.ShowDialog();
            this.Close();
        }
    }
}
