using Domain.Entity;
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
    public partial class DayDetails : Form
    {
        public DayDetails(string DateInfo)
        {
            InitializeComponent();
            labelDate.Text = DateInfo;
            LoadFeedingSchedules();
        }

        private void LoadFeedingSchedules()
        {
            List<FeedingSchedule> schedules = FeedingSchedule.GetFeedingSchedules();

            var scheduleDisplay = schedules.Select(schedule => new
            {
                Species = schedule.Species,
                Habitat = schedule.Habitat,
                FeedingTimes = string.Join(", ", schedule.FeedingTimes.Select(time => time.ToString(@"hh\:mm")))
            }).ToList();

            dataFeedingView.DataSource = scheduleDisplay;



            dataFeedingView.Columns["Species"].HeaderText = "Species";
            dataFeedingView.Columns["Habitat"].HeaderText = "Habitat";
            dataFeedingView.Columns["FeedingTimes"].HeaderText = "Feeding Times";
            dataFeedingView.AutoResizeColumns();
        }
    }
}
