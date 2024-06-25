using Domain.Entity;
using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class SignUp : Form
    {
        string firstName;
        string lastName;
        string password;
        string email;
        string bsn;
        string phoneNumber;
        string address;
        string dateOfBirth;
        private bool isOpenedFromAddEmployeeButton;
        RegularExpression regex;
        EmployeeManager em;

        public SignUp(bool isOpenedFromAddEmployeeButton)
        {
            this.isOpenedFromAddEmployeeButton = isOpenedFromAddEmployeeButton;
            regex = new RegularExpression();
            em = new EmployeeManager();
            InitializeComponent();
        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (!regex.regexBirthday.IsMatch(txtDateOfBirth.Text))
            {
                lblErrorBirth.Text = "*Please enter a valid date of birth.";
            }
            else { lblErrorBirth.Text = string.Empty; }

            if (txtDateOfBirth.Text == string.Empty)
            {
                lblErrorBirth.Text = string.Empty;
            }
        }

        private void txtBSN_TextChanged(object sender, EventArgs e)
        {
            if (!regex.regexBsn.IsMatch(txtBSN.Text))
            {
                lblErrorBSN.Text = "*Please enter a valid BSN number.";
            }
            else { lblErrorBSN.Text = string.Empty; }

            if (txtBSN.Text == string.Empty)
            {
                lblErrorBSN.Text = string.Empty;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length > 15)
            {
                lblErrorPhone.Text = "*Please enter less than 15 characters.";
            }
            else if (!regex.regexPhone.IsMatch(txtPhoneNumber.Text))
            {
                lblErrorPhone.Text = "*Please enter a valid phone number.";
            }
            else { lblErrorPhone.Text = string.Empty; }

            if (txtPhoneNumber.Text == string.Empty)
            {
                lblErrorPhone.Text = string.Empty;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!regex.regexEmail.IsMatch(txtEmail.Text))
            {
                lblErrorEmail.Text = "*Please enter a valid email address.";
            }
            else { lblErrorEmail.Text = string.Empty; }

            if (txtEmail.Text == string.Empty)
            {
                lblErrorEmail.Text = string.Empty;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                lblErrorPassword.Text = "*Please enter at least 8 or more characters.";
            }
            else { lblErrorPassword.Text = string.Empty; }

            if (txtPassword.Text == string.Empty)
            {
                lblErrorPassword.Text = string.Empty;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            password = txtPassword.Text;
            email = txtEmail.Text;
            phoneNumber = txtPhoneNumber.Text;
            address = txtAddress.Text;
            dateOfBirth = txtDateOfBirth.Text;
            bsn = txtBSN.Text;
            if (firstName != "" && lastName != "" && password != "" && email != "" && phoneNumber != "" && address != ""  && bsn != "")
            {
                if (regex.regexEmail.IsMatch(email))
                {
                    if (phoneNumber.Length <= 15 && regex.regexPhone.IsMatch(phoneNumber))
                    {
                        if (password.Length >= 8)
                        {
                            if (regex.regexBirthday.IsMatch(dateOfBirth))
                            {
                                if (regex.regexBsn.IsMatch(bsn))
                                {
                                    em.AddEmployee(firstName, lastName, email, password, dateOfBirth, phoneNumber, bsn, address);

                                    Employee newEmployee = em.GetEmployeeByEmail(email);

                                    if (!isOpenedFromAddEmployeeButton)
                                    {
                                        ZooKeeperForm mainForm = new ZooKeeperForm(newEmployee);
                                        this.Hide();
                                        mainForm.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("BSN is inputted incorrectly.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Date of birth is inputted incorrectly.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 8 characters long.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number is inputted incorrectly.");
                    }
                }
                else
                {
                    MessageBox.Show("Email is inputted incorrectly.");
                }

            }
            else
            {
                MessageBox.Show("Some of the required fields are empty.");
            }
        }
    }
}
