using System.ComponentModel.DataAnnotations;

namespace FlightDocs_System.Data
{
    public class Flight
    {
        [Key]
        public int ID_Flight { get; set; }
        public string? FlightNumber { get; set; }
        public string? DepartureAirport { get; set; }
        public string? ArrivalAirport { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int ID_Pilot { get; set; }
        public Pilot? Pilot { get; set; }
        public int ID_Aircraft { get; set; }
        public Aircraft? Aircraft { get; set; }

    }

}
