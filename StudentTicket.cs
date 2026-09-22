namespace P01;

public class StudentTicket : Ticket
{
  public StudentTicket(string eventName, int basePrice)
    : base(eventName, basePrice) { }

  public override int GetPrice()
  {
    return BasePrice * 80 / 100;
  }
}
