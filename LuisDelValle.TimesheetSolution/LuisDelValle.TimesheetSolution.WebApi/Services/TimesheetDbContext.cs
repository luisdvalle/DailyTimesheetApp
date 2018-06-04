using LuisDelValle.TimesheetSolution.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LuisDelValle.TimesheetSolution.WebApi.Services
{
    public class TimesheetDbContext : DbContext
    {
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public TimesheetDbContext()
            : this(new DbContextOptions<TimesheetDbContext>())
        {
        }

        public TimesheetDbContext(DbContextOptions<TimesheetDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}
