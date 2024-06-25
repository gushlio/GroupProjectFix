using DTOs;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWebApp.Pages
{
    [Authorize(Policy = "ManagerOnly")]
    public class AssignWorkModel : PageModel
    {
        // private fields
        private EmployeeManager employeeManager;
        private ShiftManager shiftManager;

        // constructor
        public AssignWorkModel()
        {
            employeeManager = new EmployeeManager();
            employeeManager.LoadEmployees();
            shiftManager = new ShiftManager();
        }

        // properties
        public List<Employee> Employees { get; set; }
         
        [BindProperty]
        public string EmployeeName { get; set; }

        // methods
        public void OnGet()
        {
            Employees = employeeManager.employees;
        }
    }
}
