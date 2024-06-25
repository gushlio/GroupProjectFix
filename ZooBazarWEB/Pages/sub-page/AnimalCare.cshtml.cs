using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazarWEB.Pages.sub_page
{
    public class AnimalCareModel : PageModel
    {
        public List<AnimalHealthStatus> Animals { get; set; }

        public void OnGet()
        {
            // Populate Animals property with fake data (placeholders)
            Animals = new List<AnimalHealthStatus>
            {
                new AnimalHealthStatus { Name = "Animal name", Species = "Type Animal", HealthStatus = "Healthy" },
                new AnimalHealthStatus { Name = "Animal name", Species = "Type Animal", HealthStatus = "Sick" },
                new AnimalHealthStatus { Name = "Animal name", Species = "Type Animal", HealthStatus = "Recovery" }
            };
        }

        // Define a class to represent each animal's health status
        public class AnimalHealthStatus
        {
            public string Name { get; set; }
            public string Species { get; set; }
            public string HealthStatus { get; set; }
        }
    }
}
