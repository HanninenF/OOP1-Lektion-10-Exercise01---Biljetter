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

  protected string GetContentUser()
  {
    return $"Sending to {Recipient}: ";
  }

  protected string GetContentText()
  {
    return Text;
  }

  public virtual void Send()
  {
    Console.WriteLine(GetContentUser() + GetContentText());
  }
}
