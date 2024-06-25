using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.DTOs;
using DataAccessLayer.Repository;
using Domain.Entity;

namespace Domain.Manager
{
    public class ShiftManager
    {
        private ShiftDB dalShiftManager;
        public List<Dictionary<string, object>> shifts { get; set; }

        public ShiftManager()
        {
            shifts = new List<Dictionary<string, object>>();
            dalShiftManager = new ShiftDB();
        }



        public void AddShift(string dayOfTheWeek, string time, int employeeID)
        {
            var employeeShifts = shifts
            .Where(shift => shift["DayOfWeek"].ToString().Equals(dayOfTheWeek, StringComparison.OrdinalIgnoreCase) && (int)shift["EmployeeID"] == employeeID)
            .ToList();

            if (employeeShifts.Count >= 2)
            {
                throw new InvalidOperationException("An employee cannot have more than two shifts in a single day.");
            }

            if (employeeShifts.Count == 1)
            {
                string existingShiftTime = employeeShifts.First()["ShiftTime"].ToString();
                if (!AreShiftsAdjacent(existingShiftTime, time))
                {
                    throw new InvalidOperationException("An employee can only work two shifts in a day if the shifts are adjacent.");
                }
            }

            dalShiftManager.AddShiftData(dayOfTheWeek, time, employeeID);
        }

        private bool AreShiftsAdjacent(string shiftTime1, string shiftTime2)
        {
            var adjacentShifts = new Dictionary<string, string[]>
        {
            { "8AM - 12PM", new[] { "1PM - 5PM" } },
            { "1PM - 5PM", new[] { "8AM - 12PM", "6PM - 10PM" } },
            { "6PM - 10PM", new[] { "1PM - 5PM" } }
        };

            return adjacentShifts.ContainsKey(shiftTime1) && adjacentShifts[shiftTime1].Contains(shiftTime2);
        }

        public void LoadShifts()
        {
            shifts = dalShiftManager.LoadShiftsData();
        }

        public int GetTotalShiftsForEmployeeInDay(string dayOfTheWeek, int employeeID)
        {
            int totalShifts = dalShiftManager.GetTotalShiftsForEmployeeInDay(dayOfTheWeek, employeeID);
            return totalShifts;
        }

        public List<Domain.Entity.Shift> GetShiftsByEmployee(int employeeID)
        {
            return shifts
                .Where(shift => (int)shift["EmployeeID"] == employeeID)
                .Select(shift => new Domain.Entity.Shift
                {
                    Id = (int)shift["Id"],
                    EmployeeId = (int)shift["EmployeeID"]
                    // Map other properties here
                })
                .ToList();
        }

        public void DeleteShift(string dayOfWeek, string time, int employeeID)
        {
            dalShiftManager.DeleteShiftData(dayOfWeek, time, employeeID);
        }
    }
}
