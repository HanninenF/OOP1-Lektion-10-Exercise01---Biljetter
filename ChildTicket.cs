namespace P01;

public class ChildTicket : Ticket
{
  public ChildTicket(string evenName, int basePrice)
    : base(evenName, basePrice)
  {
    BasePrice = basePrice / 2;
  }
}
