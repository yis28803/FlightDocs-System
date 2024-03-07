using System.ComponentModel.DataAnnotations;

namespace FlightDocs_System.Data
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FlightName { get; set; }
    }
}
