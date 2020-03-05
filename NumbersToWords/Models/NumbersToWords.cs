using System.Collections.Generic;

namespace NumbersToWords.Models
{
  interface INumbersToWords
  {
    string getInstance(string number);
  }
  public abstract class NumbersToWords
  {
    public Dictionary<string, string> First { get; set; }
    public Dictionary<string, string> Second { get; set; }
    public Dictionary<string, string> Third { get; set; }
    public Dictionary<string, string> Teen { get; set; }
    public string Number { get; set; }
    public string Result { get; set; }
    public NumbersToWords(string number)
    {
      Number = number;
      First = new Dictionary<string, string>
      {
        {"0", ""},
        {"1", "one"},
        {"2", "two"},
        {"3", "three"},
        {"4", "four"},
        {"5", "five"},
        {"6", "six"},
        {"7", "seven"},
        {"8", "eight"},
        {"9", "nine"}
      };
      Second = new Dictionary<string, string>
      {
        {"0", "and"},
        {"1", "one"}, //Special case
        {"2", "twenty"},
        {"3", "thrirty"},
        {"4", "fourty"},
        {"5", "fifty"},
        {"6", "sixty"},
        {"7", "seventy"},
        {"8", "eighty"},
        {"9", "ninety"}
      };
      Third = new Dictionary<string, string>
      {
        {"0", ""},
        {"1", "one"},
        {"2", "two"},
        {"3", "three"},
        {"4", "four"},
        {"5", "five"},
        {"6", "six"},
        {"7", "seven"},
        {"8", "eight"},
        {"9", "nine"}
      };
      Teen = new Dictionary<string, string>
      {
        {"0", "ten"},
        {"1", "eleven"},
        {"2", "twelve"},
        {"3", "thirteen"},
        {"4", "fourteen"},
        {"5", "fifteen"},
        {"6", "sixteen"},
        {"7", "seventeen"},
        {"8", "eighteen"},
        {"9", "nineteen"}
      };
    }
  }
}