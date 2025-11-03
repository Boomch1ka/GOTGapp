using System;
using System.ComponentModel.DataAnnotations;

namespace gotgApp.Models
{
    public class Donation
    {
        public int ID { get; set; }

        [Required]
        public string DonorName { get; set; } = null!;

        [Required]
        public string ResourceType { get; set; } = null!; // e.g., Food, Clothing, Medical

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
