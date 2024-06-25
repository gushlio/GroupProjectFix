using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using ZooBazaarWebApp.Model;

namespace ZooBazaarWebApp.Pages
{
    public class PurchaseTicketModel : PageModel
    {
        [BindProperty]
        public TicketSelectionViewModel TicketSelection { get; set; }

        public void OnGet()
        {
            TicketSelection = new TicketSelectionViewModel();
        }

        public IActionResult OnPost()
        {
            var selectedTickets = new Dictionary<string, int>();
            var visitDateString = Request.Form["visitDate"];
            if (DateTime.TryParse(visitDateString, out DateTime visitDate))
            {
                TicketSelection.VisitDate = visitDate;
            }
            else
            {
                ModelState.AddModelError("VisitDate", "Invalid date.");
                return Page();
            }

            foreach (var ticket in TicketSelection.AvailableTickets)
            {
                string quantityString = Request.Form[$"selectedTickets[{ticket.Type}]"];
                if (int.TryParse(quantityString, out int quantity) && quantity > 0)
                {
                    selectedTickets[ticket.Type] = quantity;
                }
            }

            TicketSelection.SelectedTickets = selectedTickets;

            HttpContext.Session.SetString("SelectedTickets", JsonSerializer.Serialize(TicketSelection.SelectedTickets));
            HttpContext.Session.SetString("VisitDate", TicketSelection.VisitDate.ToString("yyyy-MM-dd"));

            return RedirectToPage("/TicketOverview");
        }
    }
}
