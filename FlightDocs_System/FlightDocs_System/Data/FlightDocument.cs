using System.ComponentModel.DataAnnotations;

namespace FlightDocs_System.Data
{
    public class FlightDocument
    {
        [Key]
        public int ID_Document { get; set; }
        public string? DocumentName { get; set; }
        public string? DocumentType { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int ID_Flight { get; set; }
        public Flight? Flight { get; set; }
    }

}
