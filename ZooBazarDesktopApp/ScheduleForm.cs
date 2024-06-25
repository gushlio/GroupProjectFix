using DataAccessLayer;
using DataAccessLayer.DTOs;
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
    public partial class ScheduleForm : Form
    {
        // private fields
        private string _currentDay;
        private Button _currentButton;
        private ShiftManager _shiftManager;
        private EmployeeManager _employeeManager;
        public ScheduleForm()
        {
            InitializeComponent();
            _currentDay = "Monday";
            _shiftManager = new ShiftManager();
            _employeeManager = new EmployeeManager();
            _shiftManager.LoadShifts();
            _employeeManager.LoadEmployees();
            LoadShifts(_currentDay);
        }

        private void LoadShifts(string currentDay, object? btnSender = null)
        {
            if (btnSender != null)
            {
                EnableButton(btnSender);
            }

            // Clear the controls before loading new ones
            flpMorning.Controls.Clear();
            flpAfternoon.Controls.Clear();
            flpNight.Controls.Clear();

            List<Dictionary<string, object>> filteredShifts = _shiftManager.shifts
                .Where(shift => shift["DayOfWeek"].ToString().Equals(currentDay, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Load morning shifts
            List<Dictionary<string, object>> morningShifts = filteredShifts
                .Where(shift => shift["ShiftTime"].ToString() == "8AM - 12PM")
                .ToList();
            AddShiftsToPanel(morningShifts, flpMorning);

            // Load afternoon shifts
            List<Dictionary<string, object>> afternoonShifts = filteredShifts
                .Where(shift => shift["ShiftTime"].ToString() == "1PM - 5PM")
                .ToList();
            AddShiftsToPanel(afternoonShifts, flpAfternoon);

            // Load evening shifts
            List<Dictionary<string, object>> eveningShifts = filteredShifts
                .Where(shift => shift["ShiftTime"].ToString() == "6PM - 10PM")
                .ToList();
            AddShiftsToPanel(eveningShifts, flpNight);
        }

        private void AddShiftsToPanel(List<Dictionary<string, object>> shifts, FlowLayoutPanel panel)
        {
            if (shifts.Count > 0)
            {
                ucShift[] listItems = new ucShift[shifts.Count];

                for (int i = 0; i < shifts.Count; i++)
                {
                    var shift = shifts[i];
                    listItems[i] = new ucShift
                    {
                        Name = GetEmployeeName((int)shift["EmployeeID"])
                    };

                    panel.Controls.Add(listItems[i]);
                }
            }
        }

        private string GetEmployeeName(int employeeId)
        {
            var employee = _employeeManager.Employees.FirstOrDefault(e => e.Id == employeeId);
            return employee != null ? $"{employee.FirstName} {employee.LastName}" : "Unknown Employee";
        }

        private void EnableButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != (Button)btnSender)
                {
                    DisableButtons();
                    _currentButton = (Button)btnSender;
                    _currentButton.BackColor = Color.DarkKhaki;
                    _currentButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Control previousBtn in flpDay.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.PaleGoldenrod;
                    previousBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*    // Load shifts for the previous week
                currentWeekStartDate = currentWeekStartDate.AddDays(-7);
                SetDayButtonDates(currentWeekStartDate);
                LoadCurrentWeek();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /* // Load shifts for the next week
             currentWeekStartDate = currentWeekStartDate.AddDays(7);
             SetDayButtonDates(currentWeekStartDate);
             LoadCurrentWeek();*/
        }

        private void buttonShift1_Click(object sender, EventArgs e)
        {
            EditShiftsForm editMorningShiftsForm = new EditShiftsForm(_currentDay, "8AM - 12PM");
            editMorningShiftsForm.ShiftUpdated += EditShiftsForm_ShiftUpdated;
            editMorningShiftsForm.ShowDialog();
        }

        private void buttonShift2_Click(object sender, EventArgs e)
        {
            EditShiftsForm editMorningShiftsForm = new EditShiftsForm(_currentDay, "8AM - 12PM");
            editMorningShiftsForm.ShiftUpdated += EditShiftsForm_ShiftUpdated;
            editMorningShiftsForm.ShowDialog();
        }

        private void buttonShift3_Click(object sender, EventArgs e)
        {
            EditShiftsForm editMorningShiftsForm = new EditShiftsForm(_currentDay, "8AM - 12PM");
            editMorningShiftsForm.ShiftUpdated += EditShiftsForm_ShiftUpdated;
            editMorningShiftsForm.ShowDialog();
        }

        private void EditShiftsForm_ShiftUpdated(object? sender, EventArgs e)
        {
            _shiftManager.LoadShifts();
            LoadShifts(_currentDay);
        }

        private void btnMonday_Click(object sender, EventArgs e)
        {
            _currentDay = "Monday";
            LoadShifts(_currentDay, sender);
        }

        private void btnTuesday_Click(object sender, EventArgs e)
        {
            _currentDay = "Tuesday";
            LoadShifts(_currentDay, sender);
        }

        private void btnWednesday_Click(object sender, EventArgs e)
        {
            _currentDay = "Wednesday";
            LoadShifts(_currentDay, sender);
        }

        private void btnThursday_Click(object sender, EventArgs e)
        {
            _currentDay = "Thursday";
            LoadShifts(_currentDay, sender);
        }

        private void btnFriday_Click(object sender, EventArgs e)
        {
            _currentDay = "Friday";
            LoadShifts(_currentDay, sender);
        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {
            _currentDay = "Saturday";
            LoadShifts(_currentDay, sender);
        }

        private void btnSunday_Click(object sender, EventArgs e)
        {
            _currentDay = "Sunday";
            LoadShifts(_currentDay, sender);
        }
    }
}
