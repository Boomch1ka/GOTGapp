using Microsoft.AspNetCore.Mvc;

namespace GOTGapp.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Skills { get; set; }
        public string AssignedTask { get; set; }
    }
}
