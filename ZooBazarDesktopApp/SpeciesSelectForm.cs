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
    public partial class SpeciesSelectForm : Form
    {
        AnimalManager animalManager;
        Bitmap image;
        AddAnimalForm addAnimalForm;
        List<Tuple<string, string>> species;
        public SpeciesSelectForm(AddAnimalForm af)
        {
            addAnimalForm = af;
            animalManager = new AnimalManager();
            species = new List<Tuple<string, string>>();
            species.Add(new Tuple<string, string>("Lion", "Resources\\lion.jpg"));
            species.Add(new Tuple<string, string>("Giraffe", "Resources\\giraffe.jpg"));
            species.Add(new Tuple<string, string>("Zebra", "Resources\\zebra.jpg"));
            species.Add(new Tuple<string, string>("Elephant", "Resources\\elephant.jpg"));
            species.Add(new Tuple<string, string>("Gazelle", "Resources\\gazelle.jpg"));

            species.Add(new Tuple<string, string>("Chimpanzee", "Resources\\chimpanzee.jpg"));
            species.Add(new Tuple<string, string>("Gorilla", "Resources\\gorilla.jpg"));
            species.Add(new Tuple<string, string>("Tiger", "Resources\\tiger.jpg"));
            species.Add(new Tuple<string, string>("Parrot", "Resources\\parrot.jpg"));
            species.Add(new Tuple<string, string>("Poison Dart Frog", "Resources\\poisondartfrog.jpg"));

            species.Add(new Tuple<string, string>("Dolphin", "Resources\\dolphine.jpg"));
            species.Add(new Tuple<string, string>("Shark", "Resources\\shark.jpg"));
            species.Add(new Tuple<string, string>("Sea Turtle", "Resources\\turtle.jpg"));
            species.Add(new Tuple<string, string>("Clownfish", "Resources\\clownfish.jpg"));
            species.Add(new Tuple<string, string>("Jellyfish", "Resources\\jellyfish.jpg"));

            species.Add(new Tuple<string, string>("Polar Bear", "Resources\\polarbear.jpg"));
            species.Add(new Tuple<string, string>("Arctic Fox", "Resources\\arcticfox.jpg"));
            species.Add(new Tuple<string, string>("Penguin", "Resources\\penguin.jpg"));
            species.Add(new Tuple<string, string>("Walrus", "Resources\\walrus.jpg"));
            species.Add(new Tuple<string, string>("Seal", "Resources\\seal.jpg"));

            species.Add(new Tuple<string, string>("Camel", "Resources\\camel.jpg"));
            species.Add(new Tuple<string, string>("Desert Tortoise", "Resources\\deserttortoise.jpg"));
            species.Add(new Tuple<string, string>("Scorpion", "Resources\\scorpion.jpg"));
            species.Add(new Tuple<string, string>("Roadrunner", "Resources\\roadrunner.jpg"));
            species.Add(new Tuple<string, string>("Desert Lizard", "Resources\\desertlizard.jpeg"));
            InitializeComponent();
            SpeciesCards();
        }

        public void SpeciesCards()
        {
            flpSpecies.Controls.Clear();
            animalManager.LoadAnimals();


            foreach (var spec in species)
            {
                string text = $"{spec.Item1}";
                Button button = new Button();
                button.Size = new Size(200, 150);



                int scaledWidth = 200;
                int scaledHeight = 120;
                try
                {
                    image = new Bitmap(new Bitmap(spec.Item2), scaledWidth, scaledHeight);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in SpeciesCards: {ex.Message}");
                    image = null;
                }


                button.Image = image;
                button.Text = text;
                button.Font = new Font(button.Font.FontFamily, 12, FontStyle.Bold);
                button.BackColor = Color.White;
                button.TextAlign = ContentAlignment.BottomCenter;
                button.TextImageRelation = TextImageRelation.ImageAboveText;
                button.Click += (sender, e) =>
                {
                    addAnimalForm.GetSpecies(spec.Item1);
                    this.Close();
                };

                // Add the button to the FlowLayoutPanel
                flpSpecies.Controls.Add(button);
            }

        }
    }
}
