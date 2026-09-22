namespace P01;

public class WarningMessage(string recipient, string text) : Message(recipient, text)
{
  public override void Send(string warningMessage = "")
  {
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkYellow;
    base.Send("VARNING");
  }
}
