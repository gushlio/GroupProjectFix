using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazarWEB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndexModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostLogout()
        {
            _httpContextAccessor.HttpContext.Session.Remove("username");
            _httpContextAccessor.HttpContext.Session.Remove("role");

            return RedirectToPage("/Index");
        }
    }
}
