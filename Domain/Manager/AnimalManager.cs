using DataAccessLayer;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class AnimalManager
    {
        private AnimalDataAccess dalAnimalManager;
        public List<Animal> animals { get; set; }


        public AnimalManager()
        {
            dalAnimalManager = new AnimalDataAccess();
            animals = new List<Animal>();

            LoadAnimals();
        }

        public void LoadAnimals()
        {
            animals.Clear();
            dalAnimalManager.LoadAnimalsData();
            foreach (List<string> animalData in dalAnimalManager.animalsData)
            {
                int? motherId = string.IsNullOrEmpty(animalData[9]) ? (int?)null : Convert.ToInt32(animalData[9]);
                int? fatherId = string.IsNullOrEmpty(animalData[10]) ? (int?)null : Convert.ToInt32(animalData[10]);

                Animal animal = new Animal(
                    Convert.ToInt32(animalData[0]),
                    animalData[1],
                    animalData[3],
                    animalData[4],
                    animalData[5],
                    animalData[6],
                    animalData[2],
                    animalData[7],
                    animalData[8],
                    motherId,
                    fatherId
                );
                animals.Add(animal);

            }
        }

        public void DeleteAnimal(Animal animal)
        {
            dalAnimalManager.DeleteAnimalData(animal.id);
            LoadAnimals();
        }

        public void AddAnimal(string species, string locationName, string dateOfBirth, string reasonForEntry, string? reasonForLeave, string? imgURL, int? motherId, int? fatherId)
        {
            DateTime dateOfEntry = DateTime.Now;
            DateTime? dateOfLeave = null;

            dalAnimalManager.AddAnimalData(species, locationName, dateOfBirth, reasonForEntry, reasonForLeave, "Resources\\" + imgURL, dateOfEntry, dateOfLeave, motherId, fatherId);
            LoadAnimals();
        }

        public void UpdateAnimalReasonForLeave(int id, string reason)
        {
            DateTime dateOfLeave = DateTime.Now;

            dalAnimalManager.UpdateReasonForLeave(id, reason, dateOfLeave);
            LoadAnimals();
        }
        public void UpdateAnimalReasonForEntry(int id, string reason)
        {
            DateTime dateOfEntry = DateTime.Now;

            dalAnimalManager.UpdateReasonForEntry(id, reason, dateOfEntry);
            LoadAnimals();
        }
        public void UpdateAnimalSpecies(int id, string species)
        {
            dalAnimalManager.UpdateSpecies(id, species);
            LoadAnimals();
        }
        public void UpdateAnimalMotherId(int id, int motherId)
        {
            dalAnimalManager.UpdateMotherId(id, motherId);
            LoadAnimals();
        }
        public void UpdateAnimalFatherId(int id, int fatherId)
        {
            dalAnimalManager.UpdateFatherId(id, fatherId);
            LoadAnimals();
        }

        public void UpdateAnimalImgURL(int id, string imgURL)
        {
            dalAnimalManager.UpdateImgURL(id, imgURL);
            LoadAnimals();
        }

        public List<Animal> SearchAnimal(string id, string species, string location)
        {
            List<Animal> searchedAnimals = new List<Animal>();
            if (id != "" && species != "" && location != "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.id.ToString() == id && animal.species == species && animal.locationName == location)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else if (id != "" && species != "" && location == "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.id.ToString() == id && animal.species == species)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else if (id != "" && species == "" && location != "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.id.ToString() == id && animal.locationName == location)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else if (id == "" && species != "" && location != "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.species == species && animal.locationName == location)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else if (id != "" && species == "" && location == "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.id.ToString() == id)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else if (id == "" && species != "" && location == "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.species == species)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else if (id == "" && species == "" && location != "")
            {
                foreach (Animal animal in animals)
                {
                    if (animal.locationName == location)
                    {
                        searchedAnimals.Add(animal);
                    }
                }
                return searchedAnimals;
            }
            else
            {
                return animals;
            }
        }

        public Dictionary<DateTime, int> GetAnimalsInZooStatistics(DateTime startDate, DateTime endDate)
        {
            Dictionary<DateTime, int> statistics = new Dictionary<DateTime, int>();

            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                DateTime monthStart = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime nextMonthStart = monthStart.AddMonths(1).AddDays(-1);

                int animalsInZooCount = 0;

                foreach (Animal animal in animals)
                {
                    bool isInZooDuringMonth = (animal.dateOfEntry <= nextMonthStart &&
                                               (animal.dateOfLeave == null || animal.dateOfLeave >= monthStart));

                    if (isInZooDuringMonth && animal.reasonForLeave == "")
                    {
                        animalsInZooCount++;
                    }
                }

                statistics.Add(monthStart, animalsInZooCount);

                currentDate = nextMonthStart.AddDays(1);
            }

            return statistics;
        }
        public Dictionary<DateTime, int> GetAnimalsOutOfZooStatistics(DateTime startDate, DateTime endDate)
        {
            Dictionary<DateTime, int> statistics = new Dictionary<DateTime, int>();

            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                DateTime monthStart = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime nextMonthStart = monthStart.AddMonths(1).AddDays(-1);

                int animalsOutOfZooCount = 0;

                foreach (Animal animal in animals)
                {
                    bool isInZooDuringMonth = (animal.dateOfEntry <= nextMonthStart &&
                                               (animal.dateOfLeave == null || animal.dateOfLeave >= monthStart));

                    if (isInZooDuringMonth && animal.reasonForLeave != "")
                    {
                        animalsOutOfZooCount++;
                    }
                }

                statistics.Add(monthStart, animalsOutOfZooCount);

                currentDate = nextMonthStart.AddDays(1);
            }

            return statistics;
        }

        public Animal GetAnimalById(int id)
        {
            foreach (Animal animal in animals)
            {
                if (animal.id == id)
                {
                    return animal;
                }
            }
            return null;
        }
        public List<Animal> GetAnimalsInZoo()
        {
            List<Animal> inzoo = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if (animal.reasonForLeave == "")
                {
                    inzoo.Add(animal);
                }
            }
            return inzoo;
        }
        public List<Animal> GetAnimalsOutOfZoo()
        {
            List<Animal> outofzoo = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if (animal.reasonForLeave != "")
                {
                    outofzoo.Add(animal);
                }
            }
            return outofzoo;
        }


    }
}
