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

namespace ZooBazarDesktopApp
{
    public partial class FeedingTimeTable : Form
    {
        public static int _year, _month;
        public FeedingTimeTable()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FeedingTimeTable_Load); //added new
        }

        public void FeedingTimeTable_Load(object sender, EventArgs e)
        {
            _month = DateTime.Now.Month;
            _year = DateTime.Now.Year;
            showDays(_month, _year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            labelMonth.Text = $"{monthName.ToUpper()} {year}";

            if (!IsValidYear(year) || !IsValidMonth(month))
            {
                return;
            }

            DateTime startofthemonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);

            int week = (int)startofthemonth.DayOfWeek;

            for (int i = 0; i < week; i++)
            {
                ucDay uc = new ucDay("");
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= day; i++)//changed <=
            {
                ucDay uc = new ucDay(i + "");
                flowLayoutPanel1.Controls.Add(uc);

            }
        }

        private bool IsValidYear(int year)
        {
            return year >= 1 && year <= 9999;
        }

        private bool IsValidMonth(int month)
        {
            return month >= 1 && month <= 12;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }
    }
}

