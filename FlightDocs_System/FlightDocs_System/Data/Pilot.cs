using System.ComponentModel.DataAnnotations;

namespace FlightDocs_System.Data
{
    public class Pilot
    {
        [Key]
        public int ID_Pilot { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime LicenseExpirationDate { get; set; }

    }

}
