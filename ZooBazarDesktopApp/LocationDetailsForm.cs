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
    public partial class LocationDetailsForm : Form
    {
        string locationName;
        LocationManager locationManager;
        Location location;
        public LocationDetailsForm(string ln)
        {
            locationManager = new LocationManager();
            locationName = ln;
            location = locationManager.GetLocationByName(locationName);
            InitializeComponent();
            lblName.Text = location.Name;
            lblZone.Text = location.Zone;
            lbAcceptedSpecies.DataSource = location.AcceptedSpecies;
            lblDescription.Text = location.Description;
            if (location.ImgURL == null)
            {

            }
            else
            {
                pbLocation.Image = new Bitmap(location.ImgURL);
            }
        }
    }
}
