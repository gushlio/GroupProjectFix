using DataAccessLayer;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class TicketManager
    {
        public TicketsDB dalTicketManager { get; set; }
        public List<Ticket> tickets;
        public TicketManager()
        {
            dalTicketManager = new TicketsDB();
            tickets = new List<Ticket>();
        }
        public void LoadTickets()
        {
            tickets.Clear();
            dalTicketManager.LoadTicketsData();
            foreach (List<string> ticketData in dalTicketManager.ticketsData)
            {
                Ticket ticket = new Ticket(Convert.ToInt32(ticketData[0]), Convert.ToDateTime(ticketData[1]), ticketData[2], ticketData[3]);
                tickets.Add(ticket);

            }
        }

        public void DeleteTicket(Ticket ticket)
        {
            dalTicketManager.DeleteTicketData(ticket.Id);
            LoadTickets();
        }

        public void AddTicket(string type, string time)
        {
            dalTicketManager.AddTicketData(type, time);
            LoadTickets();
        }
        public int CalculateChildTickets()
        {
            return CalculateTicketsByTypeAndTime("child");
        }

        public int CalculateAdultTickets()
        {
            return CalculateTicketsByTypeAndTime("adult");
        }

        private int CalculateTicketsByTypeAndTime(string type)
        {
            int count = 0;
            DateTime now = DateTime.Now;
            TimeSpan currentTime = now.TimeOfDay;

            foreach (Ticket ticket in tickets)
            {
                if (ticket.Type == type && IsTicketInTimeSlot(ticket, currentTime))
                {
                    count++;
                }
            }

            return count;
        }

        private bool IsTicketInTimeSlot(Ticket ticket, TimeSpan currentTime)
        {
            TimeSpan start;
            TimeSpan end;

            switch (ticket.Time)
            {
                case "Morning (8am-12pm)":
                    start = new TimeSpan(8, 0, 0);
                    end = new TimeSpan(12, 0, 0);
                    break;
                case "Afternoon (1pm-5pm)":
                    start = new TimeSpan(13, 0, 0);
                    end = new TimeSpan(17, 0, 0);
                    break;
                case "Evening (6pm-10pm)":
                    start = new TimeSpan(18, 0, 0);
                    end = new TimeSpan(22, 0, 0);
                    break;
                default:
                    return false;
            }

            return currentTime >= start && currentTime < end;
        }

        public Dictionary<DateTime, int> GetDailyTicketSales()
        {
            return tickets.GroupBy(t => t.DateTime.Date).OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<DateTime, int> GetMonthlyTicketSales()
        {
            return tickets.GroupBy(t => new DateTime(t.DateTime.Year, t.DateTime.Month, 1)).OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<DateTime, int> GetDailyChildTicketSales()
        {
            return tickets.Where(t => t.Type == "child")
                          .GroupBy(t => t.DateTime.Date).OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<DateTime, int> GetMonthlyChildTicketSales()
        {
            return tickets.Where(t => t.Type == "child")
                          .GroupBy(t => new DateTime(t.DateTime.Year, t.DateTime.Month, 1)).OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<DateTime, int> GetDailyAdultTicketSales()
        {
            return tickets.Where(t => t.Type == "adult")
                          .GroupBy(t => t.DateTime.Date).OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<DateTime, int> GetMonthlyAdultTicketSales()
        {
            return tickets.Where(t => t.Type == "adult")
                          .GroupBy(t => new DateTime(t.DateTime.Year, t.DateTime.Month, 1)).OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
