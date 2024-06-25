
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Domain.Entity;
using Domain.Manager;
namespace ZooBazaarWebApp.Pages
{
    public class LoginModel : PageModel
    {
        private EmployeeManager employeeManager;
        private List<Claim> claims;
        private Employee em;

        public LoginModel()
        {
            employeeManager = new EmployeeManager();
            employeeManager.LoadEmployees();
        }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public string password { get; set; }

        public string ErrorMessage { get; set; }


        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            claims = new List<Claim>();
            
            em = employeeManager.GetEmployeeByEmail(email);
            if (em != null)
            {
                if (em.FirstLogin == false)
                {
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
                    employeeManager.EmployeeFirstLogin(em.Id, hashedPassword, salt);

                    claims.Add(new Claim(ClaimTypes.Name, em.Id.ToString()));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    return RedirectToPage("/Index");
                }
                else
                {
                    if (employeeManager.EmployeeExists(email))
                    {
                        claims.Add(new Claim(ClaimTypes.Name, em.Id.ToString()));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, em.Id.ToString()));
                        if (em.Contract != null)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, em.Contract.JobTitle.ToString()));
                        }
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                        return RedirectToPage("/Index");

                    }
                    else
                    {
                        ModelState.AddModelError("emailblabla", "Incorrect email or password.");
                        return Page();
                    }
                }

            }
            else
            {
                ModelState.AddModelError("emailblabla", "Incorrect email or password.");
                return Page();  
            }
        }
    }
}
