namespace P01;

public enum PractiseTask
{
  Biljetter,
  Meddelanden,
}

internal partial class Program
{
  static void Main(string[] args)
  {
    Person newPerson = new("Janne", 23);

    string p = newPerson.ToString();

    Console.WriteLine(newPerson);

    PractiseTask exercise = PractiseTask.Meddelanden;

    switch (exercise)
    {
      case PractiseTask.Biljetter:
        /* Övning 01 - Biljetter */
        Ticket ticket = new("Konsert", 500);
        /* ticket.PrintInfo(); */

        StudentTicket studentTicket = new("Konsert", 500);
        /*  studentTicket.PrintInfo(); */

        VipTicket vipTicket = new("Konsert", 500, "A12", false);
        /* vipTicket.PrintInfo(); */

        ChildTicket childTicket = new("Konsert", 500);

        List<Ticket> tickets = [ticket, studentTicket, vipTicket, childTicket];

        int totalPrice = 0;
        foreach (Ticket t in tickets)
        {
          int price = t.GetPrice();
          totalPrice += price;
          t.PrintInfo();
        }
        Console.WriteLine(totalPrice);

        break;
      case PractiseTask.Meddelanden:
        // Tre olika meddelandetyper ligger i en lista:
        List<Message> outbox = new List<Message>
        {
          new EmailMessage("anna@mail.se", "Welcome!", "Thanks for signing up."),
          new SmsMessage("070-123 45 67", "Your code is 4821"),
          new Message("admin", "Server restarted"),
          new WarningMessage("user", "fel på nåt"),
        };

        // Varje meddelande skickas på sitt eget sätt:
        foreach (Message message in outbox)
        {
          message.Send();
          Console.WriteLine("----");
        }

        break;
    }
  }
}
