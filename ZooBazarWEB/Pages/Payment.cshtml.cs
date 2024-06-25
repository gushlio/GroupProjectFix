using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazaarWebApp.Pages
{
    public class PaymentTicketModel : PageModel
    {
        public IActionResult OnPost()
        {
            return RedirectToPage("/Confirmation");
        }
    }
}
