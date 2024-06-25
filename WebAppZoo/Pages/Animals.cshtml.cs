using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ZooBazaarWebApp.Pages
{
    public class AnimalsModel : PageModel
    {

        private AnimalManager animalManager;
        public AnimalsModel()
        {
            animalManager = new AnimalManager();
        }
        public Animal animal { get; set; }
        [BindProperty]
        [Required]
        public string species { get; set; }
        [BindProperty]
        [Required]
        public string dateOfBirth { get; set; }
        [BindProperty]
        [Required]
        public string locationName { get; set; }
        [BindProperty]
        [Required]
        public string imageUrl { get; set; }
        public List<Animal> Animals { get; set; }
        public void OnGet()
        {
            Animals = animalManager.GetAnimalsInZoo();
        }
    }
}
