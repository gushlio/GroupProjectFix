using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class LocationManager
    {
        public List<Location> locations { get; set; }
        public LocationManager()
        {
            locations = new List<Location>();
            List<string> acceptedSpecies1 = new List<string>
            {
                "Lion",
                "Giraffe",
                "Zebra",
                "Elephant",
                "Gazelle"
            };

            List<string> acceptedSpecies2 = new List<string>
            {
                "Chimpanzee",
                "Gorilla",
                "Tiger",
                "Parrot",
                "Poison Dart Frog"
            };

            List<string> acceptedSpecies3 = new List<string>
            {
                "Dolphin",
                "Shark",
                "Sea Turtle",
                "Clownfish",
                "Jellyfish"
            };

            List<string> acceptedSpecies4 = new List<string>
            {
                "Polar Bear",
                "Arctic Fox",
                "Penguin",
                "Walrus",
                "Seal"
            };

            List<string> acceptedSpecies5 = new List<string>
            {
                "Camel",
                "Desert Tortoise",
                "Scorpion",
                "Roadrunner",
                "Desert Lizard"
            };

            Location loc1 = new Location("Savanna Zone", acceptedSpecies1, "Savanna Kingdom", "Step into the regal expanse of the Savannah Kingdom, where the untamed beauty of the African savannah unfolds before your eyes.", "Resources\\savanna.jpg");
            Location loc2 = new Location("Rainforest Zone", acceptedSpecies2, "Emerald Canopy", "Journey through the lush depths of the Emerald Canopy, where the verdant rainforest teems with life and adventure.", "Resources\\rainforest.jpg");
            Location loc3 = new Location("Aquatic Zone", acceptedSpecies3, "Aqua Odyssey", "Dive into the immersive wonders of Aqua Odyssey, where the mysteries of the deep blue sea await exploration.", "Resources\\aquatic.jpg");
            Location loc4 = new Location("Arctic Zone", acceptedSpecies4, "Frost Frontier", "Embark on an icy expedition to the Frost Frontier, where the majestic landscapes of the Arctic come alive in stunning detail.", "Resources\\arctic.jpg");
            Location loc5 = new Location("Desert Zone", acceptedSpecies5, "Sunfire Desert", "Brave the scorching sands of Sunfire Desert, where the sun beats down on a realm of rugged beauty and ancient secrets.", "Resources\\desert.jpg");

            locations.Add(loc1);
            locations.Add(loc2);
            locations.Add(loc3);
            locations.Add(loc4);
            locations.Add(loc5);

        }

        public List<string> GetLocationNames()
        {
            List<string> locNames = new List<string>();
            foreach (Location location in locations)
            {
                locNames.Add(location.Name);
            }
            return locNames;
        }

        public Location GetLocationByName(string name)
        {
            foreach (Location location in locations)
            {
                if (location.Name == name) return location;
            }
            return null;
        }
        public string GetLocationForSpecies(string species)
        {
            foreach (Location location in locations)
            {
                if (location.AcceptedSpecies.Contains(species))
                {
                    return location.Name;
                }


            }
            return "";
        }
    }
}
