using Domain.Manager;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ZooBazaarWebApp.Pages
{
    public class EditPasswordModel : PageModel
    {
        EmployeeManager employeeManager;
        public EditPasswordModel()
        {
            employeeManager = new EmployeeManager();
            employeeManager.LoadEmployees();
           
        }


        public Employee employee { get; set; }
        [BindProperty]
        [Required]

        public string OldPassword { get; set; }
        [BindProperty]
        [Required]

        public string NewPassword { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            employee = employeeManager.GetEmployeeById(Convert.ToInt32(User.Identity.Name));

            return Page();
        }

        public IActionResult OnPost()
        {

            employee = employeeManager.GetEmployeeById(Convert.ToInt32(User.Identity.Name));
            if (ModelState.IsValid)
            {

                string hashedEnteredPassword = BCrypt.Net.BCrypt.HashPassword(OldPassword + employee.Salt, employee.Salt);

                if (employee.Password == hashedEnteredPassword)
                {
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(NewPassword, salt);

                    employeeManager.UpdatePassword(employee.Id, hashedPassword, salt);
                    return RedirectToPage("/Details");
                } else
                {
                    ModelState.AddModelError("emailblabla", "Incorrect password.");
                }
            } else
            {
                ModelState.AddModelError("emailblabla", "Incorrect password.");
            }

            return null;

        }
    }
}
