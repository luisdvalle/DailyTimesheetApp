using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LuisDelValle.TimesheetSolution.WebApi.Models;
using LuisDelValle.TimesheetSolution.WebApi.Services;

namespace LuisDelValle.TimesheetSolution.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/timesheet")]
    public class TimesheetsController : Controller
    {
        private readonly TimesheetDbContext _context;

        public TimesheetsController(TimesheetDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostTimesheet([FromBody] Timesheet timesheet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Timesheets.Add(timesheet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTimesheet", new { id = timesheet.TimesheetId }, timesheet);
        }

        private bool TimesheetExists(int id)
        {
            return _context.Timesheets.Any(e => e.TimesheetId == id);
        }
    }
}