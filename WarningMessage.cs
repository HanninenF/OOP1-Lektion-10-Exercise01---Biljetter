namespace P01;

public class WarningMessage(string recipient, string text) : Message(recipient, text)
{
  public override void Send()
  {
    Console.Write(GetContentUser());
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.DarkYellow;

    Console.Write($"VARNING: {GetContentText()}");

    Console.ResetColor();
    Console.WriteLine();
  }
}
