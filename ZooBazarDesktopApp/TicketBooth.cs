using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ZooBazarDesktopApp
{
    public partial class TicketBooth : Form
    {
        List<string> times;
        int childTickets;
        int adultTickets;
        string time;
        TicketManager ticketManager;
        public TicketBooth()
        {
            times = new List<string>
            {
                "Morning (8am-12pm)",
                "Afternoon (1pm-5pm)",
                "Evening (6pm-10pm)"
            };
            ticketManager = new TicketManager();
            ticketManager.LoadTickets();
            InitializeComponent();
            cbTime.DataSource = times;
            lblAdultsInZoo.Text = ticketManager.CalculateAdultTickets().ToString();
            lblChildrenInZoo.Text = ticketManager.CalculateChildTickets().ToString();
            lblOverallInZoo.Text = Convert.ToString(Convert.ToInt32(lblAdultsInZoo.Text) + Convert.ToInt32(lblChildrenInZoo.Text));
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            childTickets = Convert.ToInt32(numberChild.Value);
            adultTickets = Convert.ToInt32(numberAdult.Value);
            time = cbTime.Text;
            for (int i = 0; i < childTickets; i++)
            {
                ticketManager.AddTicket("child", time);
            }
            for (int i = 0; i < adultTickets; i++)
            {
                ticketManager.AddTicket("adult", time);
            }
            lblAdultsInZoo.Text = ticketManager.CalculateAdultTickets().ToString();
            lblChildrenInZoo.Text = ticketManager.CalculateChildTickets().ToString();
            lblOverallInZoo.Text = Convert.ToString(Convert.ToInt32(lblAdultsInZoo.Text) + Convert.ToInt32(lblChildrenInZoo.Text));
        }
    }
}
