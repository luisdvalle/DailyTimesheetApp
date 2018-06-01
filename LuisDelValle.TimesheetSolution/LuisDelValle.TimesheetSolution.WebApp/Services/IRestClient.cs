using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuisDelValle.TimesheetSolution.WebApp.Services
{
    public interface IRestClient<T>
    {
        string Host { get; set; }
        string Path { get; set; }

        Task<T> GetResponseAsync();
    }
}
