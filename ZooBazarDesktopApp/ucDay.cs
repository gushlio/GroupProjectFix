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
    public partial class ucDay : UserControl
    {
        public event EventHandler DayClicked;
        string _day, date, weekDay;
        public ucDay()
        {
            InitializeComponent();
        }

        private void ucDay_Load(object sender, EventArgs e)
        {
            sundays();
        }

        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            lblUC.Text = day;
            checkBox1.Hide();
            this.Load += ucDay_Load;
            date = FeedingTimeTable._month + "/" + _day + "/" + FeedingTimeTable._year;
            this.Click += UcDay_Click;
            foreach (Control control in this.Controls)
            {
                control.Click += UcDay_Click;
            }
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                weekDay = day.ToString("ddd");
                if (weekDay == "Sun")
                {
                    lblUC.ForeColor = Color.FromArgb(255, 128, 128);

                }
                else
                {
                    lblUC.ForeColor = Color.FromArgb(64, 64, 64);
                }

            }
            catch (Exception) { }
        }

        private void UcDay_Click(object sender, EventArgs e)
        {
            DayDetails dayDetails = new DayDetails(date);
            dayDetails.Show();

        }

        private void panelUserControlDay_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }
    }
}
