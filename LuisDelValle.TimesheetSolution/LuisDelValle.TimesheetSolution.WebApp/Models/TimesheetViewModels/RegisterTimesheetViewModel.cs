using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuisDelValle.TimesheetSolution.WebApp.Models.TimesheetViewModels
{
    public class RegisterTimesheetViewModel
    {
        [Required, DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        [Required, Range(0, 8)]
        public int Hours { get; set; }
    }
}
