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
    public partial class AddAnimalForm : Form
    {
        LocationManager locationManager;
        AnimalManager animalManager;
        AnimalForm animalForm;
        RegularExpression regexManager;
        Location location;
        int? fatherId;
        int? motherId;
        string imgURL;
        string species;
        List<string> reasons;
        public AddAnimalForm(AnimalForm af, AnimalManager am)
        {
            locationManager = new LocationManager();
            animalManager = am;
            regexManager = new RegularExpression();
            animalForm = af;
            reasons = new List<string>
            {
                "Born in the zoo",
                "Moved from another zoo"
            };
            InitializeComponent();

            cbReasonForEntry.DataSource = reasons;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            species = tbSpecies.Text;
            string dateOfBirth = tbDateOfBirth.Text;
            string reasonForEntry = cbReasonForEntry.Text;
            string locationName = lblLocation.Text;

            imgURL = tbImgURL.Text;
            if (tbMotherId.Text == "")
            {
                motherId = 0;
            }
            else
            {
                motherId = Convert.ToInt32(tbMotherId.Text);
            }

            if (tbFatherId.Text == "")
            {
                fatherId = 0;
            }
            else
            {
                fatherId = Convert.ToInt32(tbFatherId.Text);
            }


            if (!regexManager.regexBirthday.IsMatch(dateOfBirth))
            {
                MessageBox.Show("Date of birth is inputted incorrectly (dd-mm-yyyy)");
            }
            else
            {
                animalManager.AddAnimal(species, locationName, dateOfBirth, reasonForEntry, "", imgURL, motherId, fatherId);
                animalForm.AnimalCards(animalManager.animals);
            }
        }

        private void btnSelectSpecies_Click(object sender, EventArgs e)
        {
            SpeciesSelectForm speciesSelectForm = new SpeciesSelectForm(this);
            speciesSelectForm.ShowDialog();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        string destinationFolder = Path.Combine(Application.StartupPath, "Resources");

                        string fileName = Path.GetFileName(selectedFilePath);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        File.Copy(selectedFilePath, destinationFilePath, true);
                        imgURL = Path.GetFileName(openFileDialog.FileName);
                        //imgURL = Path.Combine(destinationFolder, fileName);
                        tbImgURL.Text = imgURL;

                    }
                    catch (Exception ex)
                    {
                        imgURL = Path.GetFileName(openFileDialog.FileName);
                        tbImgURL.Text = imgURL;

                    }
                }
            }
        }

        public void GetFatherId(int id)
        {
            fatherId = id;
            tbFatherId.Text = id.ToString();
        }
        public void GetMotherId(int id)
        {
            motherId = id;
            tbMotherId.Text = id.ToString();
        }

        public void GetSpecies(string spec)
        {
            species = spec;
            tbSpecies.Text = species;
            lblLocation.Text = locationManager.GetLocationForSpecies(species);
            if (locationManager.GetLocationForSpecies(species) == "Savanna Kingdom")
            {
                lblLocation.BackColor = Color.FromArgb(80, Color.Orange);
            }
            else if (locationManager.GetLocationForSpecies(species) == "Emerald Canopy")
            {
                lblLocation.BackColor = Color.FromArgb(80, Color.LimeGreen);
            }
            else if (locationManager.GetLocationForSpecies(species) == "Aqua Odyssey")
            {
                lblLocation.BackColor = Color.FromArgb(80, Color.Cyan);
            }
            else if (locationManager.GetLocationForSpecies(species) == "Frost Frontier")
            {
                lblLocation.BackColor = Color.FromArgb(80, Color.LightBlue);
            }
            else if (locationManager.GetLocationForSpecies(species) == "Sunfire Desert")
            {
                lblLocation.BackColor = Color.FromArgb(80, Color.Yellow);
            }

        }

        private void btnChooseMother_Click(object sender, EventArgs e)
        {
            MomForm motherForm = new MomForm(this);
            motherForm.ShowDialog();
        }

        private void btnChooseFather_Click(object sender, EventArgs e)
        {
            DadForm motherForm = new DadForm(this);
            motherForm.ShowDialog();
        }
    }
}
