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
    public partial class DadForm : Form
    {
        AnimalManager animalManager;
        LocationManager locationManager;
        List<string> locNames;
        System.Drawing.Image image;
        AddAnimalForm addAnimalForm;
        public DadForm(AddAnimalForm aaf)
        {
            addAnimalForm = aaf;
            locationManager = new LocationManager();
            animalManager = new AnimalManager();
            InitializeComponent();
            locNames = locationManager.GetLocationNames();
            locNames.Insert(0, "");
            cboLocation.DataSource = locNames;
            AnimalCards(animalManager.animals);
        }

        public void AnimalCards(List<Animal> animalList)
        {
            flpAnimals.Controls.Clear();
            animalManager.LoadAnimals();


            foreach (Animal animal in animalList)
            {
                string text = $"ID: {animal.id}\nSpecies: {animal.species}\nLocation: {animal.locationName}";
                Button button = new Button();
                button.Size = new Size(600, 500);



                int scaledWidth = 600;
                int scaledHeight = 350;

                image = new Bitmap(new Bitmap(animal.imgURL), scaledWidth, scaledHeight);

                button.Image = image;
                button.Text = text;
                button.BackColor = System.Drawing.Color.White;
                button.TextAlign = ContentAlignment.BottomLeft;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.Click += (sender, e) =>
                {
                    addAnimalForm.GetMotherId(animal.id);
                    this.Close();
                };

                // Add the button to the FlowLayoutPanel
                flpAnimals.Controls.Add(button);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtID.Text;
            string searchSpecies = txtSpecies.Text;
            string searchLocation = cboLocation.Text;

            AnimalCards(animalManager.SearchAnimal(searchId, searchSpecies, searchLocation));
        }
    }
}
