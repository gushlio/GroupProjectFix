using Domain.Entity;
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
    public partial class VetDetails : Form
    {
        private VetAppointment _vetAppointment;
        private VetManager vetAppointmentManager;
        public VetDetails(VetAppointment vetAppointment)
        {
            _vetAppointment = vetAppointment;
            vetAppointmentManager = new VetManager();
            InitializeComponent();
            LoadVetDetails();
        }
        private void LoadVetDetails()
        {
            lblSpeciesDisplay.Text = $"{_vetAppointment.animal.species} (ID: {_vetAppointment.animal.id})";
            lblVetNameDisplay.Text = _vetAppointment.VetName;
            lblDateDisplay.Text = _vetAppointment.DayOfWeek;
            lblTimeDisplay.Text = _vetAppointment.VetTime;
        }

        private void btnRemoveAppointment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Appointment?", "Delete Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                vetAppointmentManager.RemoveAppointment(_vetAppointment);
                MessageBox.Show("Appointment deleted successfully.", "Delete Artist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void lblTimeDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
