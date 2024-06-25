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

namespace ZooBazarDesktopApp
{
    public partial class TicketForm : Form
    {
        private TicketManager ticketManager = new TicketManager();
        public TicketForm()
        {
            InitializeComponent();
            cmbTicketType.Items.AddRange(new string[] { "Adult", "Kids", "Elderly" });
            this.Load += TicketForm_Load;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            LoadTicketData();
        }

        private void LoadTicketData()
        {
         /*   DataTable dataTable = ticketManager.LoadTicketData();
            dataGridViewTickets.DataSource = dataTable;*/
        }

        private void buttonEditPrice_Click(object sender, EventArgs e)
        {
            /*string ticketType = cmbTicketType.SelectedItem.ToString();
            decimal newPrice;

            if (!decimal.TryParse(txtNewPrice.Text, out newPrice))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ticketManager.UpdateTicketPrice(ticketType, newPrice);

            LoadTicketData();*/
        }

        private void buttonAddTickets_Click(object sender, EventArgs e)
        {
         /*   string ticketType = cmbTicketType.SelectedItem.ToString();
            int quantityToAdd;

            if (!int.TryParse(txtQuantityToAdd.Text, out quantityToAdd))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ticketManager.UpdateQuantityAvailable(ticketType, quantityToAdd);

            LoadTicketData();
            txtQuantityToAdd.Clear();*/
        }

        private void cmbTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string ticketType = cmbTicketType.SelectedItem.ToString();
            decimal price = ticketManager.GetTicketPrice(ticketType);
            txtNewPrice.Text = price.ToString();*/
        }
    }
}
