namespace P01;

public class Message
{
  public string Recipient { get; set; }
  public string Text { get; set; }

  public Message(string recipient, string text)
  {
    Recipient = recipient;
    Text = text;
  }

  protected const string RecipientPrefix = "Sending to";

  public virtual void Send()
  {
    Console.WriteLine($"{RecipientPrefix} {Recipient}: {Text}");
  }
}
