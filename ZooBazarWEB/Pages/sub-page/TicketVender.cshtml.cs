using Domain.Manager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ZooBazarWEB.Pages.sub_page
{
    public class TicketVenderModel : PageModel
    {
        private readonly TicketManager ticketManager;

        public SelectList TicketTypes { get; set; }

        [BindProperty]
        public string ticketType { get; set; }

        [BindProperty]
        public int quantity { get; set; }

        public TicketVenderModel(TicketManager ticketManager)
        {
            this.ticketManager = ticketManager;
        }

        public IActionResult OnGet()
        {
            var ticketTypes = new[] { "Adult", "Child", "Senior" }; 
            TicketTypes = new SelectList(ticketTypes);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                ticketManager.PurchaseTickets(ticketType, quantity);
                
                return RedirectToPage("/Index"); 
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while processing your request.");
                return Page();
            }
        }
    }
}
