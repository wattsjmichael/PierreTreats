using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SweetTreats.Models
{
  public class SweetTreatsContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors {get; set;}
    public DbSet<Treat> Treats {get; set;}
    public DbSet<FlavorTreat> FlavorTreat {get; set;}
    public SweetTreatsContext(DbContextOptions options) : base(options) { }
}
}
