using Microsoft.EntitiyFrameworkCore;
using Micorsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SweetTreats.Models
{
  public class SweetTreatsContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavor> Flavors {get; set;}
    public DbSet<Treat> Treats {get; set;}
    public DbSet<FlavorTreat> FlavorTreat {get; set;}
    public SweetTreatsCcontext(DbContextOptions options) : base(options) { }
}
}
