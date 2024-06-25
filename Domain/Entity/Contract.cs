using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Contract
    {
        public int Id { get; set; }
        public string ContractStart { get; set; }
        public string EndMessage { get; set; }
        public string ContractEnd { get; set; }
        public double Salary { get; set; }
        public string JobTitle { get; set; }

        public Contract(int id, string contractStart, string contractEnd, string endMessage, double salary, string jobTitle)
        {
            Id = id;
            ContractStart = contractStart;
            EndMessage = endMessage;
            ContractEnd = contractEnd;
            Salary = salary;
            JobTitle = jobTitle;
        }

        public Contract()
        {
            Id = 0;
            ContractStart = "";
            EndMessage = "";
            ContractEnd = "";
            Salary = 0;
            JobTitle = "";
        }
        public void TerminateContract(string contractEnd, string endMessage)
        {
            ContractEnd = contractEnd;
            EndMessage = endMessage;
        }
    }
}
