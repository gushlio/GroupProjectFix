using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Manager;
using Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace ZooBazaarWebApp.Pages
{
    public class EditProfileModel : PageModel
    {
        int id;
        EmployeeManager employeeManager;
        public EditProfileModel()
        {
            employeeManager = new EmployeeManager();
            employeeManager.LoadEmployees();
            ErrorMessages = new List<string>();
        }

        [BindProperty]
        public Employee employee { get; set; }
        public List<string> ErrorMessages { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {


            employee = employeeManager.GetEmployeeById(Convert.ToInt32(User.Identity.Name));
            return Page();
        }
        public IActionResult OnPost()
        {
            employee.Id = employeeManager.GetEmployeeById(Convert.ToInt32(User.Identity.Name)).Id;
        
            employeeManager.UpdateEmployee(employee.Id, employee.FirstName, employee.LastName, employee.EmailAddress, employee.DateOfBirth, employee.ContactInfo, employee.Bsn, employee.Address);
            return RedirectToPage("/Details");
            
        }
    }
}

