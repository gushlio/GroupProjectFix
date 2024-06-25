using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Entity;
using Domain.Manager;

namespace ZooBazaarWebApp.Pages
{
    public class DetailsModel : PageModel
    {
        EmployeeManager employeeManager;

        public DetailsModel()
        {
            
        }

        public Employee employee { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            employeeManager = new EmployeeManager();
            employeeManager.LoadEmployees();
            employee = employeeManager.GetEmployeeById(Convert.ToInt32(User.Identity.Name));
            //User = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            //if (User == null)
            //{
            //    return NotFound();
            //}
            return Page();
        }
    }
}
