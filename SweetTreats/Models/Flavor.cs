using System.Collection.Generic;

namespace SweetTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }
    public int TreatId {get; set;}
    public string TreatName {get; set;}
    public string TreatDescription {get; set;}
    public virtual ApplicationUser User {get; set;}
    public ICollection<FlavorTreat> Treats {get;}
  }
}