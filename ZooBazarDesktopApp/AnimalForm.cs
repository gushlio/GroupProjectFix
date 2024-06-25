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
    public partial class AnimalForm : Form
    {
        AnimalManager animalManager;
        LocationManager locationManager;
        List<string> locNames;
        Image image;
        Employee loggedEmployee;
        private bool isViewingInZoo;
        public AnimalForm(Employee loggedUser)
        {
            locationManager = new LocationManager();
            animalManager = new AnimalManager();
            InitializeComponent();
            locNames = locationManager.GetLocationNames();
            locNames.Insert(0, "");
            cbLocation.DataSource = locNames;
            AnimalCards(animalManager.GetAnimalsInZoo());
            isViewingInZoo = true;

            this.loggedEmployee = loggedUser;
        }

        public void AnimalCards(List<Animal> animalList)
        {
            flpAnimals.Controls.Clear();
            animalManager.LoadAnimals();
            animalList = animalManager.GetAnimalsInZoo();
            btnHistory.Visible = true;
            btnGoBack.Visible = false;
            isViewingInZoo = true;

            foreach (Animal animal in animalList)
            {
                string text = $"ID: {animal.id}\nSpecies: {animal.species}\nLocation: {animal.locationName}";
                Button button = new Button();
                button.Size = new Size(300, 250);



                int scaledWidth = 300;
                int scaledHeight = 200;
                try
                {
                    image = new Bitmap(new Bitmap(animal.imgURL), scaledWidth, scaledHeight);
                }
                catch (Exception ex)
                {
                    image = null;
                }


                button.Image = image;
                button.Text = text;
                button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Bold);
                button.BackColor = Color.White;
                button.TextAlign = ContentAlignment.BottomLeft;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.Click += (sender, e) =>
                {
                    AnimalDetailsForm animalDetailsForm = new AnimalDetailsForm(this, animal, loggedEmployee);
                    animalDetailsForm.ShowDialog();
                };

                flpAnimals.Controls.Add(button);
            }

        }

        public void AnimalCardsSearch(List<Animal> animalList)
        {
            flpAnimals.Controls.Clear();
            animalManager.LoadAnimals();

            btnHistory.Visible = true;
            btnGoBack.Visible = false;

            foreach (Animal animal in animalList)
            {
                string text = $"ID: {animal.id}\nSpecies: {animal.species}\nLocation: {animal.locationName}";
                Button button = new Button();
                button.Size = new Size(300, 250);



                int scaledWidth = 300;
                int scaledHeight = 200;
                try
                {
                    image = new Bitmap(new Bitmap(animal.imgURL), scaledWidth, scaledHeight);
                }
                catch (Exception ex)
                {
                    image = null;
                }


                button.Image = image;
                button.Text = text;
                button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Bold);
                button.BackColor = isViewingInZoo ? Color.White : Color.Gray;
                button.TextAlign = ContentAlignment.BottomLeft;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.Click += (sender, e) =>
                {
                    AnimalDetailsForm animalDetailsForm = new AnimalDetailsForm(this, animal, loggedEmployee);
                    animalDetailsForm.ShowDialog();
                };

                flpAnimals.Controls.Add(button);
            }

        }

        public void AnimalCardsGrey(List<Animal> animalList)
        {
            flpAnimals.Controls.Clear();
            animalManager.LoadAnimals();
            animalList = animalManager.GetAnimalsOutOfZoo();
            btnHistory.Visible = false;
            btnGoBack.Visible = true;
            isViewingInZoo = false;

            foreach (Animal animal in animalList)
            {
                string text = $"ID: {animal.id}\nSpecies: {animal.species}\nLocation: {animal.locationName}";
                Button button = new Button();
                button.Size = new Size(300, 250);



                int scaledWidth = 300;
                int scaledHeight = 200;
                try
                {
                    image = new Bitmap(new Bitmap(animal.imgURL), scaledWidth, scaledHeight);
                }
                catch (Exception ex)
                {
                    image = null;
                }


                button.Image = image;
                button.Text = text;
                button.BackColor = Color.Gray;
                button.TextAlign = ContentAlignment.BottomLeft;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.Click += (sender, e) =>
                {
                    AnimalDetailsForm animalDetailsForm = new AnimalDetailsForm(this, animal, loggedEmployee);
                    animalDetailsForm.ShowDialog();
                };

                // Add the button to the FlowLayoutPanel
                flpAnimals.Controls.Add(button);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = tbId.Text;
            string searchSpecies = tbSpecies.Text;
            string searchLocation = cbLocation.Text;

            List<Animal> filteredAnimals;

            if (isViewingInZoo)
            {
                filteredAnimals = animalManager.SearchAnimal(searchId, searchSpecies, searchLocation)
                                                .Where(a => animalManager.GetAnimalsInZoo().Contains(a))
                                                .ToList();
            }
            else
            {
                filteredAnimals = animalManager.SearchAnimal(searchId, searchSpecies, searchLocation)
                                                .Where(a => animalManager.GetAnimalsOutOfZoo().Contains(a))
                                                .ToList();
            }

            AnimalCardsSearch(filteredAnimals);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm(this, animalManager);
            addAnimalForm.ShowDialog();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            AnimalCards(animalManager.GetAnimalsInZoo());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            AnimalCardsGrey(animalManager.GetAnimalsOutOfZoo());
        }
    }
}
