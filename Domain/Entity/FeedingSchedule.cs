using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class FeedingSchedule
    {
        public string Species { get; set; }
        public string Habitat {  get; set; }
        public List<TimeSpan> FeedingTimes { get; set; }
        public FeedingSchedule(string species, string habitat, List<TimeSpan> feedingTimes)
        {
            Species = species;
            Habitat = habitat;
            FeedingTimes = feedingTimes;
        }

        public static List<FeedingSchedule> GetFeedingSchedules()
        {
            return new List<FeedingSchedule>
            {
            new FeedingSchedule("Shark", "Aqua Odyssey", new List<TimeSpan> { new TimeSpan(15, 0, 0) }),
            new FeedingSchedule("Sea Turtle", "Aqua Odyssey", new List<TimeSpan> { new TimeSpan(10, 0, 0) }),
            new FeedingSchedule("Clown Fish", "Aqua Odyssey", new List<TimeSpan> { new TimeSpan(8, 0, 0) }),
            new FeedingSchedule("Arctic Fox", "Frost Frontier", new List<TimeSpan> { new TimeSpan(9, 0, 0) }),
            new FeedingSchedule("Walrus", "Frost Frontier", new List<TimeSpan> { new TimeSpan(14, 0, 0) }),
            new FeedingSchedule("Seal", "Frost Frontier", new List<TimeSpan> { new TimeSpan(11, 0, 0), new TimeSpan(16, 0, 0) }),
            new FeedingSchedule("Scorpion", "Sunfire Desert", new List<TimeSpan> { new TimeSpan(17, 0, 0) }),
            new FeedingSchedule("Roadrunner", "Sunfire Desert", new List<TimeSpan> { new TimeSpan(8, 0, 0) }),
            new FeedingSchedule("Lion", "Savanna Kingdom", new List<TimeSpan> { new TimeSpan(17, 0, 0) }),
            new FeedingSchedule("Elephant", "Savanna Kingdom", new List<TimeSpan> { new TimeSpan(8, 0, 0), new TimeSpan(15, 0, 0) }),
            new FeedingSchedule("Zebra", "Savanna Kingdom", new List<TimeSpan> { new TimeSpan(9, 0, 0), new TimeSpan(14, 0, 0) }),
            new FeedingSchedule("Tiger", "Emerald Canopy", new List<TimeSpan> { new TimeSpan(18, 0, 0) }),
            new FeedingSchedule("Chimpanzee", "Emerald Canopy", new List<TimeSpan> { new TimeSpan(10, 0, 0), new TimeSpan(15, 0, 0) }),
            new FeedingSchedule("Poison Dart Frog", "Emerald Canopy", new List<TimeSpan> { new TimeSpan(12, 0, 0) })
            };   
        }
    }
}
