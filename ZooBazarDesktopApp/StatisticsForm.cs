using Domain.Entity;
using Domain.Manager;
using ScottPlot;
using ScottPlot.Plottables;
using ScottPlot.TickGenerators.TimeUnits;
using ScottPlot.TickGenerators;
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
    public partial class StatisticsForm : Form
    {
        EmployeeManager em = new();
        AnimalManager an = new();
        TicketManager tm = new();
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            tm.LoadTickets();
            plotTitleLBL.Text = string.Empty;
            grpBxForMoreStatistics.Visible = false;
        }

        private void DateTimeCustomTickGenerator(ScottPlot.Plot plot, string type)
        {
            switch (type)
            {
                case "monthly":
                    plot.RenderManager.RenderStarting += (s, e) =>
                    {
                        Tick[] ticks = plot.Axes.Bottom.TickGenerator.Ticks;
                        for (int i = 0; i < ticks.Length; i++)
                        {
                            System.DateTime dt = System.DateTime.FromOADate(ticks[i].Position);
                            string label = $"{dt:MMM} '{dt:yy}";
                            ticks[i] = new Tick(ticks[i].Position, label);
                        }
                    };
                    break;
                case "daily":
                    plot.RenderManager.RenderStarting += (s, e) =>
                    {
                        Tick[] ticks = plot.Axes.Bottom.TickGenerator.Ticks;
                        for (int i = 0; i < ticks.Length; i++)
                        {
                            System.DateTime dt = System.DateTime.FromOADate(ticks[i].Position);
                            string label = $"{dt:dd} {dt:MMM} '{dt:yy}";
                            ticks[i] = new Tick(ticks[i].Position, label);
                        }
                    };
                    break;
            }
        }
        private void GetEmployeeStatsFor6Months()
        {
            formsPlot1.Reset();
            ScottPlot.Plot plot = formsPlot1.Plot;
            plot.ScaleFactor = 0.9;
            plot.Clear();

            System.DateTime endDate = System.DateTime.Now;
            System.DateTime startDate = endDate.AddMonths(-6);

            var employeeCountStatistics = em.GetEmployeeCountStatistics(startDate, endDate);

            List<System.DateTime> dates = new List<System.DateTime>();
            List<double> employeeCounts = new List<double>();

            foreach (var entry in employeeCountStatistics)
            {
                dates.Add(entry.Key);
                employeeCounts.Add(entry.Value);
            }

            double[] positions = new double[dates.Count];
            for (int i = 0; i < dates.Count; i++)
            {
                positions[i] = dates[i].ToOADate();
            }

            plot.Axes.SetLimits(positions.Min(), positions.Max(), employeeCounts.Min(), employeeCounts.Max());

            var scatter = plot.Add.Scatter(positions, employeeCounts.ToArray());
            scatter.Color = Colors.Olive;
            scatter.LineWidth = 2;
            scatter.MarkerSize = 6;

            plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;
            var dtAx = plot.Axes.DateTimeTicksBottom();
            dtAx.TickGenerator = new DateTimeFixedInterval(new Month(), 1);

            plot.RenderManager.RenderStarting += (s, e) =>
            {
                Tick[] ticks = plot.Axes.Bottom.TickGenerator.Ticks;
                for (int i = 0; i < ticks.Length; i++)
                {
                    System.DateTime dt = System.DateTime.FromOADate(ticks[i].Position);
                    string label = $"{dt:MMM} '{dt:yy}";
                    ticks[i] = new Tick(ticks[i].Position, label);
                }
                plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
                plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

                float largestLabelWidth = 0;
                foreach (Tick tick in ticks)
                {
                    PixelSize size = plot.Axes.Bottom.TickLabelStyle.Measure(tick.Label);
                    largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
                }

                // ensure axis panels do not get smaller than the largest label
                plot.Axes.Bottom.MinimumSize = largestLabelWidth;
                plot.Axes.Right.MinimumSize = largestLabelWidth;
            };
            plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(1);

            plot.Title("Employee Hiring Statistics for 6 Months");
            plot.YLabel("Employee Count");
            plot.XLabel("Date");

            formsPlot1.Refresh();
        }
        public void GetAnimalStatisticsFor6Months()
        {
            System.DateTime endDate = System.DateTime.Now;
            System.DateTime startDate = endDate.AddMonths(-6);

            var inZooStatistics = an.GetAnimalsInZooStatistics(startDate, endDate);
            var outZooStatistics = an.GetAnimalsOutOfZooStatistics(startDate, endDate);

            List<System.DateTime> dates = new List<System.DateTime>();
            List<double> inZooCounts = new List<double>();
            List<double> outZooCounts = new List<double>();

            // Populate lists with data
            foreach (var entry in inZooStatistics)
            {
                dates.Add(entry.Key);
                inZooCounts.Add(entry.Value);
                outZooCounts.Add(0); // Initialize outZooCounts with zeros for matching dates
            }

            foreach (var entry in outZooStatistics)
            {
                int index = dates.IndexOf(entry.Key);
                if (index == -1)
                {
                    // If the date does not exist in inZooStatistics, add it to dates and set inZooCounts to zero
                    dates.Add(entry.Key);
                    inZooCounts.Add(0);
                    index = dates.Count - 1;
                }
                outZooCounts[index] = entry.Value;
            }

            // Now, call a method to create the bar chart using ScottPlot
            CreateZooStatisticsBarChart(dates.ToArray(), inZooCounts.ToArray(), outZooCounts.ToArray());
        }
        public void CreateZooStatisticsBarChart(System.DateTime[] dates, double[] inZooCounts, double[] outZooCounts)
        {
            ScottPlot.Palettes.Microcharts palette = new();

            formsPlot1.Reset();
            ScottPlot.Plot plot = formsPlot1.Plot;
            plot.ScaleFactor = 1;
            plot.Clear();

            plot.Axes.Margins(bottom: 0);
            plot.Axes.AutoScaleX();
            plot.Legend.Show();

            plot.Axes.SetLimitsY(0, inZooCounts.Length);

            var dtAx = plot.Axes.DateTimeTicksBottom();
            dtAx.TickGenerator = new DateTimeFixedInterval(new Month(), 1);

            plot.RenderManager.RenderStarting += (s, e) =>
            {
                Tick[] ticks = plot.Axes.Bottom.TickGenerator.Ticks;
                for (int i = 0; i < ticks.Length; i++)
                {
                    System.DateTime dt = System.DateTime.FromOADate(ticks[i].Position);
                    string label = $"{dt:MMM} '{dt:yy}";
                    ticks[i] = new Tick(ticks[i].Position, label);
                }
            };

            plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(5);
            double[] positions = new double[dates.Length];
            for (int i = 0; i < dates.Length; i++)
            {
                positions[i] = dates[i].ToOADate();
            }

            BarPlot inZooBars;
            BarPlot outZooBars;

            for (int i = 0; i < positions.Length; i++)
            {
                Bar inZooBar = new()
                {
                    Position = positions[i],
                    Value = inZooCounts[i],
                    FillColor = palette.GetColor(8),
                    Size = 4
                };
                inZooBars = plot.Add.Bar(inZooBar);
            }
            for (int i = 0; i < positions.Length; i++)
            {
                Bar outZooBar = new()
                {
                    Position = positions[i],
                    Value = outZooCounts[i],
                    FillColor = palette.GetColor(9),
                    Size = 4
                };
                outZooBars = plot.Add.Bar(outZooBar);
            }

            plot.Legend.IsVisible = true;
            plot.Legend.Location = ScottPlot.Alignment.UpperLeft;
            LegendItem inZooLegend = new()
            {
                Label = "Animals in the Zoo",
                FillColor = palette.GetColor(8),
            };
            plot.Legend.ManualItems.Add(inZooLegend);
            LegendItem outZooLegend = new()
            {
                Label = "Animals out of the Zoo",
                FillColor = palette.GetColor(9),
            };
            plot.Legend.ManualItems.Add(outZooLegend);

            plot.Axes.AutoScale();

            plot.Title("Animals in the zoo over 6 months");
            plot.YLabel("Animal Count");
            plot.XLabel("Date");

            formsPlot1.Refresh();
        }
        public void CreateTicketChart(string type)
        {
            formsPlot1.Reset();
            ScottPlot.Plot plot = formsPlot1.Plot;
            plot.ScaleFactor = 0.9;
            plot.Clear();

            Dictionary<System.DateTime, int> ticketSales = new();
            var dtAx = plot.Axes.DateTimeTicksBottom();

            switch (type)
            {
                case "monthlyTotal":
                    ticketSales = tm.GetMonthlyTicketSales();
                    dtAx.TickGenerator = new DateTimeFixedInterval(new Month(), 1);
                    DateTimeCustomTickGenerator(plot, "monthly");
                    break;
                case "dailyTotal":
                    ticketSales = tm.GetDailyTicketSales();
                    dtAx.TickGenerator = new DateTimeFixedInterval(new ScottPlot.TickGenerators.TimeUnits.Day(), 7);
                    DateTimeCustomTickGenerator(plot, "daily");
                    break;
                case "dailyChild":
                    ticketSales = tm.GetDailyChildTicketSales();
                    dtAx.TickGenerator = new DateTimeFixedInterval(new ScottPlot.TickGenerators.TimeUnits.Day(), 7);
                    DateTimeCustomTickGenerator(plot, "daily");
                    break;
                case "monthlyChild":
                    ticketSales = tm.GetMonthlyChildTicketSales();
                    dtAx.TickGenerator = new DateTimeFixedInterval(new Month(), 1);
                    DateTimeCustomTickGenerator(plot, "monthly");
                    break;
                case "dailyAdult":
                    ticketSales = tm.GetDailyAdultTicketSales();
                    dtAx.TickGenerator = new DateTimeFixedInterval(new ScottPlot.TickGenerators.TimeUnits.Day(), 7);
                    DateTimeCustomTickGenerator(plot, "daily");
                    break;
                case "monthlyAdult":
                    ticketSales = tm.GetMonthlyAdultTicketSales();
                    dtAx.TickGenerator = new DateTimeFixedInterval(new Month(), 1);
                    DateTimeCustomTickGenerator(plot, "monthly");
                    break;
                    //default:
                    //    ticketSales = tm.GetMonthlyTicketSales();
                    //    dtAx.TickGenerator = new DateTimeFixedInterval(new Month(), 1);
                    //    DateTimeCustomTickGenerator(plot, "monthly");
                    //    break;
            }

            List<System.DateTime> dates = new List<System.DateTime>();
            List<double> ticketCount = new List<double>();

            foreach (var entry in ticketSales)
            {
                dates.Add(entry.Key);
                ticketCount.Add(entry.Value);
            }

            double[] positions = new double[dates.Count];
            for (int i = 0; i < dates.Count; i++)
            {
                positions[i] = dates[i].ToOADate();
            }

            var scatter = plot.Add.Scatter(positions, ticketCount.ToArray());
            scatter.Color = Colors.Olive;
            scatter.LineWidth = 2;
            scatter.MarkerSize = 6;

            plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(10);
            plot.Axes.SetLimits(positions.Min(), positions.Max(), ticketCount.Min(), ticketCount.Max());

            plot.Title("Ticket sale statistics");
            plot.YLabel("Ticket count");
            plot.XLabel("Date");

            formsPlot1.Refresh();
        }

        private void animalRB_CheckedChanged(object sender, EventArgs e)
        {
            GetAnimalStatisticsFor6Months();
        }

        private void employeeRB_CheckedChanged(object sender, EventArgs e)
        {
             GetEmployeeStatsFor6Months();
        }

        private void salesRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dailyTotalRB_CheckedChanged(object sender, EventArgs e)
        {
            CreateTicketChart("dailyTotal");
            plotTitleLBL.Text = "Daily total ticket sales";
        }

        private void dailyChildTcktRB_CheckedChanged(object sender, EventArgs e)
        {
            CreateTicketChart("dailyChild");
            plotTitleLBL.Text = "Daily child ticket sales";
        }

        private void monthlyChildTcktRB_CheckedChanged(object sender, EventArgs e)
        {
            CreateTicketChart("monthlyChild");
            plotTitleLBL.Text = "Monthly child ticket sales";
        }

        private void dailyAdultTcktRB_CheckedChanged(object sender, EventArgs e)
        {
            CreateTicketChart("dailyAdult");
            plotTitleLBL.Text = "Daily adult ticket sales";
        }

        private void monthlyAdultTcktRB_CheckedChanged(object sender, EventArgs e)
        {
            CreateTicketChart("monthlyAdult");
            plotTitleLBL.Text = "Monthly adult ticket sales";
        }
    }
}
