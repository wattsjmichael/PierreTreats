using System.Collections.Generic;
using System;

namespace SweetTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }
    public int FlavorId {get; set;}
    public string FlavorName {get; set;}
    public string FlavorDescription {get; set;}
    public virtual ApplicationUser User {get; set;}
    public virtual ICollection<FlavorTreat> Treats {get;}
  }
}