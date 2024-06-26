using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Entity;
using Domain.Manager;

namespace ZooBazaarWebApp.Pages
{
    public class MyShiftsModel : PageModel
    {
        private ShiftManager _shiftManager;
        private EmployeeManager _employeeManager;

        public List<Shift> Shifts { get; set; }

        public void OnGet()
        {
            _shiftManager = new ShiftManager();
            _employeeManager = new EmployeeManager();
            _shiftManager.LoadShifts();
            _employeeManager.LoadEmployees();


            if (User.Identity.IsAuthenticated)
            {
                Employee employee = _employeeManager.GetEmployeeById(Convert.ToInt32(User.Identity.Name));
                Shifts = _shiftManager.GetShiftsByEmployee(employee.Id);
            }
        }
    }
}
