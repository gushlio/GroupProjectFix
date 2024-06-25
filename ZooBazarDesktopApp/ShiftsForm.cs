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
    public partial class ShiftsForm : Form
    {
        private ShiftManager shiftManager = new ShiftManager();
        private Dictionary<string, List<int>> shifts;

        private Button[] dayButtons = new Button[7];
        private FlowLayoutPanel[] shiftPanels = new FlowLayoutPanel[3];
        public ShiftsForm()
        {
            InitializeDeez();
            InitializeComponent();
            InitializeCustomComponents();
            LoadShifts();
            
        }

        private void InitializeDeez()
        {
            // Basic form setup
            this.Text = "Employee Schedule";
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void InitializeCustomComponents()
        {
            // Create buttons for each day of the current week
            DateTime today = DateTime.Today;
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime currentMonday = today.AddDays(daysUntilMonday);

            for (int i = 0; i < 7; i++)
            {
                DateTime date = currentMonday.AddDays(i);
                dayButtons[i] = new Button();
                dayButtons[i].Text = date.ToString("dddd dd");
                dayButtons[i].Size = new System.Drawing.Size(100, 50);
                dayButtons[i].Location = new System.Drawing.Point(10 + i * 110, 10);
                dayButtons[i].Tag = date; // Store the actual date in the Tag property
                dayButtons[i].Click += new EventHandler(DayButton_Click);
                this.Controls.Add(dayButtons[i]);
            }

            // Create flow layout panels for the three shifts
            for (int i = 0; i < 3; i++)
            {
                shiftPanels[i] = new FlowLayoutPanel();
                shiftPanels[i].Size = new System.Drawing.Size(760, 150);
                shiftPanels[i].Location = new System.Drawing.Point(10, 70 + i * 160);
                this.Controls.Add(shiftPanels[i]);
            }
        }

        private void LoadShifts()
        {
           /* DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            shifts = shiftManager.LoadShiftsForWeek(startOfWeek);*/
        }

        private void DayButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            DateTime selectedDate = (DateTime)clickedButton.Tag; // Retrieve the date from the Tag property

            // Clear current shift panels
            foreach (var panel in shiftPanels)
            {
                panel.Controls.Clear();
            }

            // Update shift panels with the shifts for the selected day
            string[] shiftTimes = { "07:00 - 12:00", "12:00 - 17:00", "17:00 - 22:00" };
            for (int i = 0; i < shiftTimes.Length; i++)
            {
                string key = $"{selectedDate.DayOfWeek} {selectedDate:dd} {shiftTimes[i]}";
                if (shifts.ContainsKey(key))
                {
                    foreach (int employeeId in shifts[key])
                    {
                        shiftPanels[i].Controls.Add(new Label() { Text = "Employee " + employeeId });
                    }
                }
            }
        }
    }
}
