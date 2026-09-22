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

  public virtual void Send(string warningMessage = "")
  {
    Console.Write($"Sending to {Recipient}: {warningMessage}: {Text}");
    Console.ResetColor();
    Console.WriteLine();
  }
}
