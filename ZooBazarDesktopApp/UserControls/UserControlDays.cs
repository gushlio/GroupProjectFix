using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLittleHousing
{
    public partial class UserControlDays : UserControl
    {
        private Control dayContainer;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void SetDays(int numday)
        {
            label1.Text = numday + "";
        }

        public void SetSubject(string subject)
        {
            label2.Text = subject;
            this.BackColor = System.Drawing.Color.Pink;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
