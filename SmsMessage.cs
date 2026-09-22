namespace P01;

internal partial class Program
{
  public class SmsMessage : Message
  {
    public SmsMessage(string phoneNumber, string text)
      : base(phoneNumber, text) { }

    public override void Send(string warningMessage = "")
    {
      // SMS has a length limit
      string shortText = Text.Length > 160 ? Text.Substring(0, 160) : Text;
      Console.WriteLine($"SMS to {Recipient}: {shortText}");
    }
  }
}
