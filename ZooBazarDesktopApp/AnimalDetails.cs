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
    public partial class AnimalDetails : Form
    {
        Animal animal;
        AnimalManager animalManager;
        Location location;
        LocationManager locationManager;
        List<string> reasonsForEntry;
        List<string> reasonsForLeave;
        string imgURL;
        AnimalForm animalForm;
        string orig;
        Employee loggedEmployee;
        public AnimalDetails(AnimalForm af, Animal a, Employee loggedUser)
        {
            animalForm = af;
            animal = a;
            imgURL = "";
            orig = animal.reasonForLeave;

            this.loggedEmployee = loggedUser;
            locationManager = new LocationManager();
            location = locationManager.GetLocationByName(animal.locationName);
            animalManager = new AnimalManager();
            reasonsForEntry = new List<string>
            {
                "Born in the zoo",
                "Moved from another zoo"
            };
            reasonsForLeave = new List<string>
            {
                "",
                "Died in the zoo",
                "Moved to another zoo"
            };
            InitializeComponent();
            cbSpecies.DataSource = location.AcceptedSpecies;
            cbReasonForEntry.DataSource = reasonsForEntry;
            cbReasonForLeave.DataSource = reasonsForLeave;
            RefreshPage();
        }

        public void RefreshPage()
        {

            if (animal.motherId != 0)
            {
                lblMotherId.Text = animal.motherId.ToString();
            }
            else
            {
                lblMotherId.Text = "No mother selected.";
            }
            if (animal.fatherId != 0)
            {
                lblFatherId.Text = animal.fatherId.ToString();
            }
            else
            {
                lblFatherId.Text = "No father selected.";
            }
            animalManager.LoadAnimals();
            animal = animalManager.GetAnimalById(animal.id);
            lblId.Text = animal.id.ToString();
            lblSpecies.Text = animal.species.ToString();
            lblReasonForEntry.Text = animal.reasonForEntry.ToString();
            lblReasonForLeave.Text = animal.reasonForLeave.ToString();
            lblLocation.Text = animal.locationName.ToString();


            try
            {
                pbAnimal.Image = new Bitmap(animal.imgURL);
            }
            catch
            {
                pbAnimal.Image = null;
            }

            cbSpecies.Text = animal.species.ToString();
            cbReasonForEntry.Text = animal.reasonForEntry.ToString();
            cbReasonForLeave.Text = animal.reasonForLeave.ToString();
            tbMotherIdModify.Text = animal.motherId.ToString();
            tbFatherIdModify.Text = animal.fatherId.ToString();

            lblSpecies.Visible = true;
            lblReasonForEntry.Visible = true;
            lblReasonForLeave.Visible = true;
            lblMotherId.Visible = true;
            lblFatherId.Visible = true;

            cbSpecies.Visible = false;
            cbReasonForEntry.Visible = false;
            cbReasonForLeave.Visible = false;
            tbMotherIdModify.Visible = false;
            tbFatherIdModify.Visible = false;


            btnChangePicture.Visible = false;
        }

        private void btnViewNotes_Click(object sender, EventArgs e)
        {
            AnimalNoteForm noteForm = new AnimalNoteForm(loggedEmployee, animal);
            noteForm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (cbSpecies.Visible == false)
            {
                lblSpecies.Visible = false;
                lblReasonForEntry.Visible = false;
                lblReasonForLeave.Visible = false;
                lblMotherId.Visible = false;
                lblFatherId.Visible = false;

                cbSpecies.Visible = true;
                cbReasonForEntry.Visible = true;
                cbReasonForLeave.Visible = true;
                tbMotherIdModify.Visible = true;
                tbFatherIdModify.Visible = true;

                btnChangePicture.Visible = true;
            }
            else
            {
                animalManager.UpdateAnimalReasonForLeave(animal.id, cbReasonForLeave.Text);
                animalManager.UpdateAnimalReasonForEntry(animal.id, cbReasonForEntry.Text);
                animalManager.UpdateAnimalSpecies(animal.id, cbSpecies.Text);
                if (!string.IsNullOrEmpty(tbMotherIdModify.Text))
                {
                    animalManager.UpdateAnimalMotherId(animal.id, Convert.ToInt32(tbMotherIdModify.Text));
                }

                if (!string.IsNullOrEmpty(tbFatherIdModify.Text))
                {
                    animalManager.UpdateAnimalFatherId(animal.id, Convert.ToInt32(tbFatherIdModify.Text));
                }

                if (imgURL != "")
                {
                    animalManager.UpdateAnimalImgURL(animal.id, imgURL);
                }

                MessageBox.Show("Animal data changed successfully!");
                if (orig == "")
                {
                    animalForm.AnimalCards(animalManager.GetAnimalsInZoo());
                }
                else
                {
                    animalForm.AnimalCardsGrey(animalManager.GetAnimalsInZoo());
                }
                RefreshPage();
            }
        }

        private void btnChangePicture_Click(object sender, EventArgs e)
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

                        imgURL = "Resources\\" + Path.GetFileName(openFileDialog.FileName);

                    }
                    catch (Exception ex)
                    {
                        imgURL = "Resources\\" + Path.GetFileName(openFileDialog.FileName);


                    }
                }
            }

            pbAnimal.Image = new Bitmap(imgURL);
        }

        private void btnLocationDetails_Click(object sender, EventArgs e)
        {
            LocationDetailsForm frm = new LocationDetailsForm(animal.locationName);
            frm.ShowDialog();
        }

        private void btnMotherDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int motherId = Convert.ToInt32(lblMotherId.Text);
                if (motherId != 0)
                {
                    AnimalDetails animalDetailsForm = new AnimalDetails(animalForm, animalManager.GetAnimalById(motherId), loggedEmployee);
                    animalDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No mother selected");
                }
            }
            catch
            {

            }
        }

        private void btnFatherDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int fatherId = Convert.ToInt32(lblFatherId.Text);
                if (fatherId != 0)
                {
                    AnimalDetails animalDetailsForm = new AnimalDetails(animalForm, animalManager.GetAnimalById(fatherId), loggedEmployee);
                    animalDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No father selected");
                }
            }
            catch
            {

            }
        }
    }
}
