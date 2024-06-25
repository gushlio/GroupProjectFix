using DataAccessLayer;
using DataAccessLayer.DTOs;
using Domain.Entity;
using System.Diagnostics.Contracts;

namespace Domain.Manager
{
    public class EmployeeManager
    {
        public EmployeeDatabase employeeDatabase { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Entity.Contract> Contracts { get; set; }
        public List<int> HistoryInts { get; set; }


        public EmployeeManager()
        {
            employeeDatabase = new EmployeeDatabase();
            Employees = new List<Employee>();
            Contracts = new List<Entity.Contract>();
        }

        public void AddEmployee(string firstName, string lastName, string emailAddress, string password, string dateOfBirth, string contactInfo, string bsn, string address)
        {
            employeeDatabase.AddEmployee(firstName, lastName, emailAddress, password, dateOfBirth, contactInfo, bsn, address);
            LoadEmployees();
        }
         
        public void LoadEmployees()
        {
            Employees.Clear();
            HistoryInts = new List<int>();
            employeeDatabase.LoadEmployees();
            foreach (List<string> employeeData in employeeDatabase.EmployeeData)
            {
                Entity.Contract contract = null;
                if (!string.IsNullOrEmpty(employeeData[13])) // Check if ContractId is not null or empty
                {
                    contract = new Entity.Contract(
                        Convert.ToInt32(employeeData[13]),    // ContractId
                        employeeData[14],                     // ContractStart
                        employeeData[15],                     // EndMessage
                        employeeData[16],                     // ContractEnd
                        string.IsNullOrEmpty(employeeData[17]) ? 0 : Convert.ToDouble(employeeData[17]), // Salary
                        employeeData[18]                      // JobTitle
                    );
                }

                Employee employee = new Employee(
                   Convert.ToInt32(employeeData[0]),  // Employee ID
                   employeeData[1],  // First Name
                   employeeData[2],  // Last Name
                   employeeData[3],  // Email Address
                   employeeData[4],  // Password
                   employeeData[6], // Date of Birth
                   employeeData[7],  // Contact Info
                   employeeData[10], // bsn
                   employeeData[9] // address
                );

                employee.Salt = employeeData[5];
                if (employeeData[12] == "1")
                {
                    employee.FirstLogin = true;
                }
                else
                {
                    employee.FirstLogin = false;
                }

                // Determine if the employee is logging in for the first time
                // Assuming you have some logic to determine the first login if needed

                // Add the contract to the employee
                if (contract != null)
                {
                    if (string.IsNullOrEmpty(contract.EndMessage) || contract.EndMessage == "Contract isn't terminated")
                    {
                        if (!HistoryInts.Contains(contract.Id))
                        {
                            employee.SetContract(contract);
                        }
                    }
                }

                // Ensure employee contract is set to null if it has been terminated
                if (contract == null || (!string.IsNullOrEmpty(contract.EndMessage) && contract.EndMessage != "Contract isn't terminated"))
                {
                    employee.SetContract(null);
                }

                // Add the employee to the list
                Employees.Add(employee);
            }
        }

        public void LoadContracts()
        {
            Contracts.Clear();
            employeeDatabase.LoadContracts();
            foreach (List<string> contractData in employeeDatabase.ContractData)
            {
                int contractId = Convert.ToInt32(contractData[0]);
                string contractStart = contractData.Count > 1 ? contractData[1] : null;
                string contractEnd = contractData.Count > 2 ? contractData[2] : null;
                string endMessage = contractData.Count > 3 ? contractData[3] : null;
                double salary = contractData.Count > 4 ? Convert.ToDouble(contractData[4]) : 0.0; // Adjust index as necessary
                string jobTitle = contractData.Count > 5 ? contractData[5] : null; // Adjust index as necessary

                Entity.Contract contract = new Entity.Contract(contractId, contractStart, contractEnd, endMessage, salary, jobTitle);
                Contracts.Add(contract);
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            employeeDatabase.DeleteEmployee(employee.Id);
            LoadEmployees();
        }

        

        public void AddContract(int employeeId, string ContractStart, string EndMessage, string ContractEnd, double Salary, string JobTitle)
        {
            employeeDatabase.AddContract( employeeId,  ContractStart,  EndMessage,  ContractEnd,  Salary,  JobTitle);
            LoadEmployees();
        }
        public void GetNewContract(int id)
        {
            employeeDatabase.GetNewContract(id);

        }

        public List<string> GetEmployeesInfo()
        {
            LoadEmployees();
            List<string> infos = new List<string>();
            foreach (Employee employee in Employees)
            {
                infos.Add(employee.Info);
            }
            return infos;
        }

        public Employee GetEmployeeByInfo(string employeeInfo)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (employee.Info == employeeInfo)
                {
                    return employee;

                }
            }
            return null;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (employee.Id == employeeId)
                {
                    return employee;

                }
            }
            return null;
        }

        public void UpdateContract(int contractId, string ContractStart, string ContractEnd, string EndMessage, double Salary, string JobTitle)
        {
            employeeDatabase.UpdateContract(contractId, ContractStart, ContractEnd, EndMessage, Salary, JobTitle);
            LoadEmployees();
        }

        public List<Entity.Contract> GetContractHistory(int employeeId)
        {
            LoadContracts();
            List<Entity.Contract> list = new List<Entity.Contract>();
            string historyString = employeeDatabase.GetContractHistory(employeeId);
            string[] historyArray = historyString.Split(",");
            HistoryInts = new List<int>();
            foreach (string str in historyArray)
            {
                if (int.TryParse(str, out int number))
                {
                    // Add the integer to the list
                    HistoryInts.Add(number);
                    foreach (Entity.Contract contract in Contracts)
                    {
                        if (contract.Id == number)
                        {
                            list.Add(contract);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid number: {str}");
                }
            }
            return list;
        }

        public void AddContractToHistory(int employeeId, int contractId)
        {

            string historyString = employeeDatabase.GetContractHistory(employeeId);
            historyString += "," + contractId.ToString();
            employeeDatabase.UpdateContractHistory(employeeId, historyString);
            LoadContracts();
            LoadEmployees();
        }
        public List<string> SearchEmployee(string name, string jobPosition, string location)
        {
            List<string> searchedEmployees = new List<string>();

            foreach (Employee employee in Employees)
            {
                bool nameMatch = true;
                bool jobPositionMatch = true;
                bool locationMatch = true;

                if (!string.IsNullOrEmpty(name) && !employee.FirstName.Contains(name))
                {
                    nameMatch = false;
                }

                if (!string.IsNullOrEmpty(jobPosition))
                {
                    if (employee.Contract == null || !employee.Contract.JobTitle.Contains(jobPosition))
                    {
                        jobPositionMatch = false;
                    }
                }

                if (!string.IsNullOrEmpty(location))
                {
                    if (employee.Location == null || !employee.Location.Name.Contains(location))
                    {
                        locationMatch = false;
                    }
                }

                if (nameMatch && jobPositionMatch && locationMatch)
                {
                    searchedEmployees.Add(employee.Info);
                }
            }

            return searchedEmployees;
        }

        public bool EmployeeExists(string email)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (employee.EmailAddress == email)
                {
                    return true;
                }
            }
            return false;
        }
        public Employee GetEmployeeByEmail(string email)
        {
            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (email == employee.EmailAddress)
                {
                    return employee;
                }
            }
            return null;
        }

        public void EmployeeFirstLogin(int id, string password, string salt)
        {
            foreach (Employee em in Employees)
            {
                if (em.Id == id)
                {
                    em.FirstLogin = true;
                    employeeDatabase.EmployeeFirstLoginData(id, password, salt);
                }

            }
            LoadEmployees();
        }

        public Employee GetEmployeeByUsername(string username)
        {

            List<DateTime> startDates = new List<DateTime>();
            List<int> employeeCounts = new List<int>();

            LoadEmployees();
            foreach (Employee employee in Employees)
            {
                if (username == employee.Username)
                {
                    return employee;
                }
            }
            return null;
        }

        public void UpdateEmployee(int Id,string firstName, string lastName, string emailAddress, string dateOfBirth, string contactInfo, string bsn, string address)
        {

            employeeDatabase.UpdateEmployeeData( Id,  firstName,  lastName,  emailAddress,  dateOfBirth,  contactInfo,  bsn,  address);
            LoadEmployees();
        }

        public void TerminateContract(int employeeId, string endMessage)
        {
            employeeDatabase.TerminateContract(employeeId, endMessage);
        }

        public void UpdatePassword(int id, string password, string salt)
        {
            foreach (Employee em in Employees)
            {
                if (id == em.Id)
                {
                    employeeDatabase.UpdateEmployeePassword(id, password, salt);
                }
            }
        }

        public Dictionary<DateTime, double> GetEmployeeCountStatistics(DateTime startDate, DateTime endDate)
        {
            return employeeDatabase.GetEmployeeCountStatistics(startDate, endDate);
        }
    }
}