using System;

namespace Game
{
  public class PingPong
  {
    public static string Convert(int input)
    {
      string output = "";
      if (input % 3 == 0)
      {
        output = "ping ";
      }
      if (input % 5 == 0)
      {
        output += "pong ";
      }
      if (output == "")
      {
        output = input.ToString();
      }
      return output.Trim();
    }
    public static void Main()
    {
      Console.WriteLine("Enter a number:");
      int inputNumber = int.Parse(Console.ReadLine());

      for (int i = 1; i <= inputNumber; i++)
      {
          Console.WriteLine(Convert(i));
      }

    }
  }
}
