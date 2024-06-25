namespace WebAppZoo.Logic
{
    public class TicketSelectionViewModel
    {
        public List<Ticket> AvailableTickets { get; set; }
        public Dictionary<string, int> SelectedTickets { get; set; } = new Dictionary<string, int>();
        public DateTime VisitDate { get; set; }


        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in SelectedTickets)
                {
                    Ticket ticket = null;
                    foreach (var t in AvailableTickets)
                    {
                        if (t.Type == item.Key)
                        {
                            ticket = t;
                            break;
                        }
                    }

                    if (ticket != null)
                    {
                        totalPrice += ticket.Price * item.Value;
                    }
                }
                return totalPrice;
            }
        }

        public TicketSelectionViewModel()
        {
            AvailableTickets = new List<Ticket>
            {
                new Ticket { Type = "Adult", Price = 20.0m, Description = "Adult Ticket" },
                new Ticket { Type = "Child", Price = 10.0m, Description = "Under the age of 12" },
                new Ticket { Type = "Senior", Price = 15.0m, Description = "Senior Ticket" }
            };
        }
    }
}
