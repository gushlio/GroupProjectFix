using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Employee : User
    {
        public Contract Contract { get; set; }
        public List<Contract> contractHistory { get; set; }
        public string DateOfBirth { get; set; }
        public string ContactInfo { get; set; }
        public Location Location { get; set; }
        public string Bsn { get; set; }
        public string Address { get; set; }
        public string Info { get; private set; }
        public bool FirstLogin { get; set; }
        

        public Employee(int id, string firstName, string lastName, string emailAddress, string password,
                    string dateOfBirth, string contactInfo, string bsn, string address)
        : base(id, firstName, lastName, emailAddress, password)
        {
            DateOfBirth = dateOfBirth;
            ContactInfo = contactInfo;
            Bsn = bsn;
            Address = address;
            Location = null;
            contractHistory = new List<Contract>();
            Contract = new Contract();
            Info = $"ID: {id} - Name: {firstName} {lastName} - Email: {emailAddress} - No Contract";
            FirstLogin = FirstLogin;
            
        }

        public DateTime GetContractStartDate()
        {
            if (DateTime.TryParse(Contract?.ContractStart, out DateTime ContractStart))
            {
                return ContractStart;
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        public void SetContractHistory(List<Contract> history)
        {
            contractHistory = history;
        }

        public void SetLocation(Location location)
        {
            this.Location = location;
            Info = $"ID: {Id} - Name: {FirstName} {LastName} - Email: {EmailAddress} - Job Position: {Contract.JobTitle} - Location: {location.Name}";
        }
        public void SetContract(Contract contract)
        {
            this.Contract = contract;
            if (contract != null && !string.IsNullOrEmpty(contract.JobTitle))
            {
                Info = $"ID: {Id} - Name: {FirstName} {LastName} - Email: {EmailAddress} - Job Position: {contract.JobTitle}";
            }
            else
            {
                Info = $"ID: {Id} - Name: {FirstName} {LastName} - Email: {EmailAddress} - No contract";
            }
        }
        public void TerminateEmployeeContract(string endDate, string reasonForTermination)
        {
            Contract.TerminateContract(endDate, reasonForTermination);
            Info = $"ID: {Id} - Name: {FirstName} {LastName} - Email: {EmailAddress} - No contract";
        }

        public bool PasswordConfirmation(string password)
        {
            string hashedEnteredPassword = BCrypt.Net.BCrypt.HashPassword(password, Password);
            if (Password == hashedEnteredPassword)
            {
                return true;

            }
            return false;
        }
    }
}
