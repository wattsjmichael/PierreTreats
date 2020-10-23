namespace SweetTreats.Models
{
  public class FlavorTreat
  {
    public int FlavorTreat {get; set;}
    public int FlavorId {get; set;}
    public int TreatId {get; set;}
    public Flavor Flavor {get; set;}
    public Book Book {get; set;}
  }
}