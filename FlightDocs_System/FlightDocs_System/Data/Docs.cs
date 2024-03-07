using System.ComponentModel.DataAnnotations;

namespace FlightDocs_System.Data
{
    public class Docs
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Version { get; set; }
        public string? File { get; set; }
        public string? Note { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime UpdataDate { get; set; } = DateTime.Now;


    }
}
