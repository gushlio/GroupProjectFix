using MyLittleHousing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp.UserControls
{
    public partial class Calendar : UserControl
    {
        private int month, year;
        public Calendar()
        {
            InitializeComponent();
            DisplayDays();
        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            UpdateMonthLabel();

            DateTime startOfMonth = new DateTime(year, month, 1);

            int dayOfWeek = (int)startOfMonth.DayOfWeek;

            for (int i = 0; i < dayOfWeek; i++)
            {
                AddBlankDay();
            }

            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int i = 0; i < daysInMonth; i++)
            {
                AddDayControl(i);
            }
        }
        private void UpdateMonthLabel()
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblmonthyear.Text = $"{monthName} {year}";
        }

        private void AddBlankDay()
        {
            UserControlBlank ucblank = new UserControlBlank();
            flowLayoutPanel1.Controls.Add(ucblank);
        }

        private void AddDayControl(int day)
        {
            UserControlDays ucdays = new UserControlDays();
            ucdays.SetDays(day);
            flowLayoutPanel1.Controls.Add(ucdays);
        }
        private void UpdateCalendar()
        {
            flowLayoutPanel1.Controls.Clear();
            UpdateMonthLabel();

            DateTime startOfMonth = new DateTime(year, month, 1);

            int dayOfWeek = ((int)startOfMonth.DayOfWeek + 6) % 7; // Adjust for 0-based index

            for (int i = 0; i < dayOfWeek; i++)
            {
                AddBlankDay();
            }

            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int i = 0; i < daysInMonth; i++)
            {
                AddDayControl(i + dayOfWeek); // Adjust for 0-based index
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }
            ValidateAndUpdateCalendar();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            ValidateAndUpdateCalendar();
        }
        private void ValidateAndUpdateCalendar()
        {
            if (year < 1900)
            {
                year = 1900;
            }
            else if (year > 2100)
            {
                year = 2100;
            }

            UpdateCalendar();
        }
    }
}
