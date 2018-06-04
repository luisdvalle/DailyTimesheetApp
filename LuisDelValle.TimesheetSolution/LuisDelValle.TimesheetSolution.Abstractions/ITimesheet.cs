using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisDelValle.TimesheetSolution.Abstractions
{
    public interface ITimesheet
    {
        DateTime Date { get; set; }
        double Hours { get; set; }
    }
}
