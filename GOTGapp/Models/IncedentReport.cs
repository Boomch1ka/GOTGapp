using System;
using System.ComponentModel.DataAnnotations;

namespace gotgApp.Models
{
    public class IncidentReport
    {
        public int ID { get; set; }

        [Required]
        public string Location { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string ReporterName { get; set; } = null!;
    }
}

