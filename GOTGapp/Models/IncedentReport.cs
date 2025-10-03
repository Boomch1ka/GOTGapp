using System;
using System.ComponentModel.DataAnnotations;

public class IncidentReport
{
    public int ID { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    [StringLength(500)]
    public string Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required]
    public string ReporterName { get; set; }
}

