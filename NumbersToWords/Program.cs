using System;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number between 0 and 1000000000000 (one trillion)");
      string answer = Console.ReadLine();
      NumbersToWordsFactory factory = new NumbersToWordsFactory();
      Console.WriteLine(factory.CreateInstance(answer));
      Console.ReadLine();
    }
  }
}