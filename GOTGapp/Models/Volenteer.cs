using Microsoft.AspNetCore.Mvc;

namespace gotgApp.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Skills { get; set; } = null!;
        public string AssignedTask { get; set; } = null!;
    }
}
