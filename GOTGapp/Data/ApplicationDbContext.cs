using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GOTGapp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Add your custom entities here
         public DbSet<IncidentReport> IncidentReports { get; set; }
         public DbSet<Donation> Donations { get; set; }
         public DbSet<Volunteer> Volunteers { get; set; }
    }
}


