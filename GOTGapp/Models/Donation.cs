using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace GOTGapp.Models
{
    public class Donation
    {
        public int ID { get; set; }

        [Required]
        public string DonorName { get; set; }

        [Required]
        public string ResourceType { get; set; } // e.g., Food, Clothing, Medical

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
