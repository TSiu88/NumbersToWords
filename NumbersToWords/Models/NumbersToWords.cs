using System.Collections.Generic;

namespace NumbersToWords.Models
{
  interface INumbersToWords
  {
    string getInstance(string number);
  }
  public abstract class NumbersToWords
  {
    Dictionary<string, string> First { get; set; }
    Dictionary<string, string> Second { get; set; }
    Dictionary<string, string> Third { get; set; }
    public string Number { get; set; }
    public NumbersToWords(string number)
    {
      Number = number;
    }
  }
}