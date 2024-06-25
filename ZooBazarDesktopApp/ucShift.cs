using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZooBazarDesktopApp
{
    public partial class ucShift : UserControl
    {
        private string name;
        public ucShift()
        {
            InitializeComponent();
        }

        [Category("Custom Pops")]
        public string Name
        {
            get { return name; }
            set { name = value; lblName.Text = value; }
        }


        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
