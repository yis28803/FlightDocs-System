using FlightDocs_System.Data;

namespace FlightDocs_System.Services.Dashboard
{
    public interface IFlightService
    {
        Task<IEnumerable<Flight>> GetFlightsAsync();
    }
}
