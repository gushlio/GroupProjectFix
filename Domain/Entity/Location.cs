using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Entity
{
    public class Location
    {
        public string Zone { get; set; }
        public List<string> AcceptedSpecies { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Employee ResponsibleEmployee { get; set; }
        public string ImgURL { get; set; }
        public Location(string zone, List<string> acceptedSpecies, string name, string description, string url)
        {
            this.Zone = zone;
            this.AcceptedSpecies = acceptedSpecies;
            this.Name = name;
            this.Description = description;
            ResponsibleEmployee = null;
            ImgURL = url;
        }
        public Location()
        {
        }

        public string GetFullImagePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ImgURL);
        }
    }
}
