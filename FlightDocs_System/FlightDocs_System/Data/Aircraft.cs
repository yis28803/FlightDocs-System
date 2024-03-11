using System.ComponentModel.DataAnnotations;

namespace FlightDocs_System.Data
{
    public class Aircraft
    {
        [Key]
        public int ID_Aircraft { get; set; }
        public string? Manufacturer { get; set; }
        public string? AircraftType { get; set; }
        public string? TailNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public int YearOfManufacture { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
    }
}
