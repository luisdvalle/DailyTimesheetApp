using LuisDelValle.TimesheetSolution.Models;
using System.Threading.Tasks;

namespace LuisDelValle.TimesheetSolution.Abstractions
{
    public interface IRestClient<T>
    {
        string Host { get; set; }
        string Path { get; set; }

        Task<T> GetResponseAsync();

        Task<Response> PostAsync(T requestObject);
    }
}
