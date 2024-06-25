using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class ContractDTO
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ReasonForTermination { get; set; }
        public string JobPosition { get; set; }
        public string ContractType { get; set; }
        public bool Active { get; set; }
    }
}
