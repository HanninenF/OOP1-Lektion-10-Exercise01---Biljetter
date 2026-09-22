namespace P01;

public class VipTicket(string eventName, int basePrice, string seatNumber, bool includesDrink)
  : Ticket(eventName, basePrice)
{
  bool IncludesDrink { get; set; } = includesDrink;
  string SeatNumber { get; set; } = seatNumber;

  public override int GetPrice()
  {
    int vipPrice = BasePrice + 300;

    if (IncludesDrink)
      return vipPrice + 100;
    else
      return vipPrice;
  }

  public override void PrintInfo()
  {
    base.PrintInfo();
    Console.WriteLine($"Plats: {SeatNumber}");
  }
}
