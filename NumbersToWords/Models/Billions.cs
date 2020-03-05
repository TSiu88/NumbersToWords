using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Billions : NumbersToWords, INumbersToWords
  {
    public Billions(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      string numberToWords = "";
      if (number.Length == 12)
      {
        NumbersToWordsFactory factory = new NumbersToWordsFactory();
        INumbersToWords hundred = new Hunderds();

      }
      else if (number.Length == 11)
      {

      }
      else if (number.Length == 10)
      {

      }

      Dictionary<string, string> d = new Dictionary<string, string>();

      return number;
    }
  }
}
