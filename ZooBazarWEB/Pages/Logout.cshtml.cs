using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ZooBazaarWebApp.Model;


namespace ZooBazaarWebApp.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }
    }
}
