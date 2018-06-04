using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuisDelValle.TimesheetSolution.WebApi.Models
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [ForeignKey("Manager")]
        public string ManagerId { get; set; }
        public virtual Employee Manager { get; set; }

        [ForeignKey("ManagerId")]
        public virtual ICollection<Employee> ManagedEmployees { get; set; }

        public ICollection<Timesheet> Timesheets { get; set; }
    }
}
