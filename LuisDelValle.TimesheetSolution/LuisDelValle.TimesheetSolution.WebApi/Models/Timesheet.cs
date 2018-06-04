using System;
using System.ComponentModel.DataAnnotations;
using LuisDelValle.TimesheetSolution.Abstractions;

namespace LuisDelValle.TimesheetSolution.WebApi.Models
{
    public class Timesheet : ITimesheet
    {
        public int TimesheetId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Hours { get; set; }
        // FK
        public string EmployeeId { get; set; }
        
    }
}
