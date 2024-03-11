using FlightDocs_System.Data;
using Microsoft.EntityFrameworkCore;

namespace FlightDocs_System.Services.Dashboard
{
    public class FlightService : IFlightService
    {
        private readonly ApplicationDbContext _context;

        public FlightService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Flight>> GetFlightsAsync()
        {
            return await _context.Flights.ToListAsync();
        }
    }
}
