using Domain.Entity;
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
    public partial class VetForm : Form
    {
        private AnimalManager animalManager;
        private VetManager vetAppointmentManager;
        public VetForm()
        {
            animalManager = new AnimalManager();
            vetAppointmentManager = new VetManager();
            InitializeComponent();
            LoadAnimals();
            LoadAppointments();

        }

        private void LoadAnimals()
        {
            var animalsWithDisplayText = animalManager.animals
                .Select(a => new
                {
                    a.id,
                    DisplayText = $"{a.species} (ID: {a.id})"
                })
                .ToList();

            cmbAnimals.DataSource = animalsWithDisplayText;
            cmbAnimals.DisplayMember = "DisplayText";
            cmbAnimals.ValueMember = "Id";
        }
        private void LoadAppointments()
        {
            vetAppointmentManager.LoadAppointments();
            DisplayVet(vetAppointmentManager.GetAllAppointments());
        }

        private void ClearInputFields()
        {
            txtVetName.Clear();
            txtDateVet.Clear();
            txtTimeVet.Clear();
            cmbAnimals.SelectedIndex = -1;
        }

        private void DisplayVet(List<VetAppointment> vet)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var artist in vet)
            {
                uCVet artistControl = new uCVet(artist);
                flowLayoutPanel1.Controls.Add(artistControl);
            }
        }

        private void VetForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string species = txtSearchSpecies.Text;
            string date = txtSearchDate.Text;
            string time = txtSearchTime.Text;

            List<VetAppointment> searchResult = vetAppointmentManager.SearchAppointments(species, date, time);
            DisplayVet(searchResult);

            txtSearchSpecies.Clear();
            txtSearchDate.Clear();
            txtSearchTime.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string vetName = txtVetName.Text;
                string dayOfWeek = txtDateVet.Text;
                string vetTime = txtTimeVet.Text;
                int animalId = (int)cmbAnimals.SelectedValue;

                vetAppointmentManager.AddAppointment(vetName, animalId, dayOfWeek, vetTime);
                MessageBox.Show("Appointment added successfully!");
                LoadAppointments();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
