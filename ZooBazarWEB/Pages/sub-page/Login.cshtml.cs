using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Domain;
using Domain.Manager;
using System.Security.Cryptography;
using System.Text;
using DataAccessLayer;

namespace ZooBazarWEB.Pages.sub_page
{
    public class LoginModel : PageModel
    {
        private readonly UserDB _userDB;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginModel(UserDB userDB, IHttpContextAccessor httpContextAccessor)
        {
            _userDB = userDB;
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(string username, string password)
        {
            if (!_userDB.IsUsernameTaken(username))
            {
                ModelState.AddModelError("InvalidLogin", "Username is not known.");
                return Page();
            }

            if (!_userDB.IsPasswordCorrect(username, password))
            {
                ModelState.AddModelError("InvalidLogin", "Password is incorrect.");
                return Page();
            }

            string role = _userDB.GetUserRole(username);

            _httpContextAccessor.HttpContext.Session.SetString("role", role);
            _httpContextAccessor.HttpContext.Session.SetString("username", username);

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostLogout()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
            return RedirectToPage("/Index");
        }
    }
}
