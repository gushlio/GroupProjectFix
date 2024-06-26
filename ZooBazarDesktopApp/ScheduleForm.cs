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
        private DateTime _currentDay;
        private Button _currentButton;
        private ShiftManager _shiftManager;
        private EmployeeManager _employeeManager;
        private DateTime currentWeekStartDate;
        public ScheduleForm()
        {
            InitializeComponent();
            _shiftManager = new ShiftManager();
            _employeeManager = new EmployeeManager();
            _shiftManager.LoadShifts();
            _employeeManager.LoadEmployees();

            currentWeekStartDate = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            _currentDay = DateTime.Now;
            SetDayButtonDates(currentWeekStartDate);
            LoadShifts(_currentDay, null);
        }

        private void LoadShifts(DateTime currentDate, object? btnSender = null)
        {
            string currentDayName = currentDate.ToString("dddd dd MMM");

            if (btnSender != null && btnSender is Button)
            {
                EnableButton((Button)btnSender);
            }

            flpMorning.Controls.Clear();
            flpAfternoon.Controls.Clear();
            flpNight.Controls.Clear();

            List<Dictionary<string, object>> filteredShifts = _shiftManager.shifts
                .Where(shift => shift["DayOfWeek"].ToString().Equals(currentDayName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            List<Dictionary<string, object>> morningShifts = filteredShifts
                .Where(shift => shift["ShiftTime"].ToString() == "8AM - 12PM")
                .ToList();
            AddShiftsToPanel(morningShifts, flpMorning, currentDate);

            List<Dictionary<string, object>> afternoonShifts = filteredShifts
                .Where(shift => shift["ShiftTime"].ToString() == "1PM - 5PM")
                .ToList();
            AddShiftsToPanel(afternoonShifts, flpAfternoon, currentDate);

            List<Dictionary<string, object>> eveningShifts = filteredShifts
                .Where(shift => shift["ShiftTime"].ToString() == "6PM - 10PM")
                .ToList();
            AddShiftsToPanel(eveningShifts, flpNight, currentDate);
        }

        private void AddShiftsToPanel(List<Dictionary<string, object>> shifts, FlowLayoutPanel panel, DateTime currentDate)
        {
            if (shifts.Count > 0)
            {
                ucShift[] listItems = new ucShift[shifts.Count];

                for (int i = 0; i < shifts.Count; i++)
                {
                    var shift = shifts[i];
                    listItems[i] = new ucShift
                    {
                        Name = GetEmployeeName((int)shift["EmployeeID"]),
                        Tag = currentDate <= DateTime.Now ? null : (object)currentDate
                    };

                    // Prevent editing if the shift is in the past
                    if (currentDate < DateTime.Now.Date)
                    {
                        listItems[i].Enabled = false;
                    }

                    panel.Controls.Add(listItems[i]);
                }
            }
        }

        private void SetDayButtonDates(DateTime startOfWeek)
        {
            btnMonday.Text = $"Monday {startOfWeek.ToString("dd MMM")}";
            btnTuesday.Text = $"Tuesday {startOfWeek.AddDays(1).ToString("dd MMM")}";
            btnWednesday.Text = $"Wednesday {startOfWeek.AddDays(2).ToString("dd MMM")}";
            btnThursday.Text = $"Thursday {startOfWeek.AddDays(3).ToString("dd MMM")}";
            btnFriday.Text = $"Friday {startOfWeek.AddDays(4).ToString("dd MMM")}";
            btnSaturday.Text = $"Saturday {startOfWeek.AddDays(5).ToString("dd MMM")}";
            btnSunday.Text = $"Sunday {startOfWeek.AddDays(6).ToString("dd MMM")}";
        }

        private string GetEmployeeName(int employeeId)
        {
            var employee = _employeeManager.Employees.FirstOrDefault(e => e.Id == employeeId);
            return employee != null ? $"{employee.Contract.JobTitle} - {employee.FirstName} {employee.LastName}" : "Unknown Employee";
        }

        private void EnableButton(Button btnSender)
        {
            if (btnSender != null)
            {
                if (_currentButton != btnSender)
                {
                    DisableButtons();
                    _currentButton = btnSender;
                    _currentButton.BackColor = Color.FloralWhite;
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
            // Load shifts for the previous week
            currentWeekStartDate = currentWeekStartDate.AddDays(-7);
            SetDayButtonDates(currentWeekStartDate);
            LoadCurrentWeek();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Load shifts for the next week
            currentWeekStartDate = currentWeekStartDate.AddDays(7);
            SetDayButtonDates(currentWeekStartDate);
            LoadCurrentWeek();
        }

        private void LoadCurrentWeek()
        {
            LoadShifts(_currentDay, null);
        }

        private void buttonShift1_Click(object sender, EventArgs e)
        {
            if (_currentDay >= DateTime.Now.Date)
            {
                EditShiftsForm editMorningShiftsForm = new EditShiftsForm(_currentDay.ToString("dddd dd MMM"), "8AM - 12PM");
                editMorningShiftsForm.ShiftUpdated += EditShiftsForm_ShiftUpdated;
                editMorningShiftsForm.ShowDialog();
            }
        }

        private void buttonShift2_Click(object sender, EventArgs e)
        {
            if (_currentDay >= DateTime.Now.Date)
            {
                EditShiftsForm editAfternoonShiftsForm = new EditShiftsForm(_currentDay.ToString("dddd dd MMM"), "1PM - 5PM");
                editAfternoonShiftsForm.ShiftUpdated += EditShiftsForm_ShiftUpdated;
                editAfternoonShiftsForm.ShowDialog();
            }
        }

        private void buttonShift3_Click(object sender, EventArgs e)
        {
            if (_currentDay >= DateTime.Now.Date)
            {
                EditShiftsForm editEveningShiftsForm = new EditShiftsForm(_currentDay.ToString("dddd dd MMM"), "6PM - 10PM");
                editEveningShiftsForm.ShiftUpdated += EditShiftsForm_ShiftUpdated;
                editEveningShiftsForm.ShowDialog();
            }
        }

        private void EditShiftsForm_ShiftUpdated(object? sender, EventArgs e)
        {
            _shiftManager.LoadShifts();
            LoadShifts(_currentDay, null);
        }

        private void btnMonday_Click(object sender, EventArgs e)
        {
            _currentDay = currentWeekStartDate;
            LoadShifts(_currentDay, sender);
        }

        private void btnTuesday_Click(object sender, EventArgs e)
        {
            _currentDay = currentWeekStartDate.AddDays(1);
            LoadShifts(_currentDay, sender);
        }

        private void btnWednesday_Click(object sender, EventArgs e)
        {


            _currentDay = currentWeekStartDate.AddDays(2);
            LoadShifts(_currentDay, sender);
        }

        private void btnThursday_Click(object sender, EventArgs e)
        {


            _currentDay = currentWeekStartDate.AddDays(3);
            LoadShifts(_currentDay, sender);
        }

        private void btnFriday_Click(object sender, EventArgs e)
        {


            _currentDay = currentWeekStartDate.AddDays(4);
            LoadShifts(_currentDay, sender);
        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {


            _currentDay = currentWeekStartDate.AddDays(5);
            LoadShifts(_currentDay, sender);
        }

        private void btnSunday_Click(object sender, EventArgs e)
        {


            _currentDay = currentWeekStartDate.AddDays(6);
            LoadShifts(_currentDay, sender);
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
        }
    }
}
