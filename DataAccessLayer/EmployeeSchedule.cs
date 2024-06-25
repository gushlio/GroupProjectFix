using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeSchedule
    {
        public int EmployeeId { get; set; }
        public List<string> Schedule { get; set; }
    }

    public class DaySchedule
    {
        public string Day { get; set; }
        public List<EmployeeInfo> Employees { get; set; }
    }

    public class EmployeeInfo
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
    }
}
