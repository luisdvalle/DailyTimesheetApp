using System.Threading.Tasks;
using LuisDelValle.TimesheetSolution.Abstractions;
using LuisDelValle.TimesheetSolution.WebApp.Models;
using LuisDelValle.TimesheetSolution.WebApp.Models.TimesheetViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LuisDelValle.TimesheetSolution.WebApp.Controllers
{
    public class TimesheetController : Controller
    {
        private IConfiguration          _configuration;
        private IRestClient<Timesheet>  _restClient;
        private ITimesheet              _timesheet;

        public TimesheetController(IConfiguration configuration, IRestClient<Timesheet> restClient, ITimesheet timesheet)
        {
            _configuration = configuration;
            _restClient = restClient;
            _timesheet = timesheet;

            _restClient.Host = _configuration.GetSection("TimesheetService")["Host"];
            _restClient.Path = _configuration.GetSection("TimesheetService")["RegisterPath"];
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterTimesheetViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // map to model
                _timesheet.Date = vm.Date;
                _timesheet.Hours = vm.Hours;

                var response = await _restClient.PostAsync(_timesheet as Timesheet);
            }

            return View(vm);
        }
    }
}