using DataAccessLayer;
using Domain.Manager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class VetManager
    {
        public VetDataAccess dalVetAppointmentManager;
        public AnimalManager animalManager;
        public List<VetAppointment> vetAppointments { get; set; }
        public List<Animal> animals { get; set; }

        public VetManager()
        {
            dalVetAppointmentManager = new VetDataAccess();
            vetAppointments = new List<VetAppointment>();
            animalManager = new AnimalManager();
            animals = new List<Animal>();
        }
        public void LoadAppointments()
        {
            vetAppointments.Clear();
            DataTable dt = dalVetAppointmentManager.LoadVetsData();
            foreach (DataRow row in dt.Rows)
            {

                int animalId = Convert.ToInt32(row["AnimalID"]);
                Animal animal = new AnimalManager().GetAnimalById(animalId);

                VetAppointment appointment = new VetAppointment
                (
                    id: Convert.ToInt32(row["Id"]),
                    vetName: row["VetName"].ToString(),
                    animal: animal,
                    dayOfWeek: row["DayOfWeek"].ToString(),
                    vetTime: row["VetTime"].ToString()
                );
                vetAppointments.Add(appointment);
            }
        }

        public void AddAppointment(string vetName, int animalId, string dayOfWeek, string vetTime)
        {

            dalVetAppointmentManager.AddVetData(vetName, animalId.ToString(), dayOfWeek, vetTime);
            LoadAppointments();
        }

        public void RemoveAppointment(VetAppointment appointment)
        {
            dalVetAppointmentManager.DeleteVetData(appointment.Id);
            LoadAppointments();
        }
        public List<VetAppointment> GetAllAppointments()
        {
            LoadAppointments();
            return new List<VetAppointment>(vetAppointments);
        }
        public List<VetAppointment> SearchAppointments(string species, string date, string time)
        {
            LoadAppointments();
            List<VetAppointment> searchResult = new List<VetAppointment>();

            foreach (VetAppointment vetAppointment in vetAppointments)
            {

                bool matchesSpecies = string.IsNullOrEmpty(species) || vetAppointment.animal.species.ToLower().Contains(species.ToLower());
                bool matchesDate = string.IsNullOrEmpty(date) || vetAppointment.DayOfWeek.ToLower().Contains(date.ToLower());
                bool matchesTime = string.IsNullOrEmpty(time) || vetAppointment.VetTime.ToLower().Contains(time.ToLower());

                if (matchesSpecies && matchesDate && matchesTime)
                {
                    searchResult.Add(vetAppointment);
                }
            }

            return searchResult;
        }
    }
}
