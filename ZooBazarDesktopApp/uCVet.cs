using Domain.Entity;
using ScottPlot.Colormaps;
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
    public partial class uCVet : UserControl
    {
        private VetAppointment _vetAppointment;
        public uCVet(VetAppointment vet)
        {
            _vetAppointment = vet;
            InitializeComponent();
            AttachClickEvent(this);

            lblAnimal.Text = $"{_vetAppointment.animal.species} (ID: {_vetAppointment.animal.id})";
            lblVetName.Text = _vetAppointment.VetName;
            lblTime.Text = _vetAppointment.VetTime;
            lblDate.Text = _vetAppointment.DayOfWeek;
            InitializeComponent();
        }

        private void AttachClickEvent(Control control)
        {
            control.Click += uCVet_Click;
            foreach (Control childControl in control.Controls)
            {
                AttachClickEvent(childControl);
            }
        }

        private void uCVet_Click(object sender, EventArgs e)
        {
            VetDetails vetDetailsForm = new VetDetails(_vetAppointment);
            vetDetailsForm.ShowDialog();
        }

        private void uCVet_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(239, 215, 128); //change user control back color when mouse enters.
        }

        private void uCVet_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255); //reset user control back color when mouse leaves.
        }
    }
}
