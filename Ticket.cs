namespace P01;

public class Ticket
{
  public string EventName { get; set; }
  public int BasePrice { get; set; }

  public Ticket(string eventName, int basePrice)
  {
    EventName = eventName;
    BasePrice = basePrice;
  }

  public virtual int GetPrice()
  {
    return BasePrice;
  }

  public virtual void PrintInfo()
  {
    Console.WriteLine($"{EventName}: {GetPrice()} kr");
  }
}
