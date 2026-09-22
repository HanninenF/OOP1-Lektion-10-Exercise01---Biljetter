namespace P01;

public class EmailMessage : Message
{
  public string Subject { get; set; }

  public EmailMessage(string recipient, string subject, string text)
    : base(recipient, text)
  {
    Subject = subject;
  }

  public override void Send()
  {
    Console.WriteLine($"EMAIL to {Recipient}");
    Console.WriteLine($"Subject: {Subject}");
    Console.WriteLine(Text);
  }
}
