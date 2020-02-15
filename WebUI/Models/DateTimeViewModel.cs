using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class DateTimeViewModel
    {
        public string Year { get; set; }
        public int Month { get; set; }
        public List<Day> Days { get; set; }
    }
    public class Day
    {
        public int DayNumber { get; set; }
        public bool IsHoliday { get; set; }
        public bool IsWeekend { get; set; }
    }
}
