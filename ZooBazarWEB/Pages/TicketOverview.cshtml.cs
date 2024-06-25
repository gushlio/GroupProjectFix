using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using ZooBazaarWebApp.Model;

namespace ZooBazaarWebApp.Pages
{
    public class TicketOverviewModel : PageModel
    {
        public TicketSelectionViewModel TicketSelection { get; set; }
        public DateTime VisitDate { get; set; }

        public void OnGet()
        {
            var selectedTicketsJson = HttpContext.Session.GetString("SelectedTickets");
            var visitDateString = HttpContext.Session.GetString("VisitDate");

            if (selectedTicketsJson != null && DateTime.TryParse(visitDateString, out DateTime visitDate))
            {
                var selectedTickets = JsonSerializer.Deserialize<Dictionary<string, int>>(selectedTicketsJson);
                TicketSelection = new TicketSelectionViewModel
                {
                    SelectedTickets = selectedTickets,
                    VisitDate = visitDate
                };
            }
            else
            {
                TicketSelection = new TicketSelectionViewModel();
            }
        
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Payment");
        }
    }
}
