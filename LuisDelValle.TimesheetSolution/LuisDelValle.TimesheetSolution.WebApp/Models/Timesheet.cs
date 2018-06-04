using LuisDelValle.TimesheetSolution.Abstractions;
using System;

namespace LuisDelValle.TimesheetSolution.WebApp.Models
{
    public class Timesheet : ITimesheet
    {
        public DateTime Date { get; set; }
        public double Hours { get; set; }
    }
}
