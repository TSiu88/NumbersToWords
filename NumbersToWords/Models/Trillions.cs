using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Trillions : NumbersToWords, INumbersToWords
  {

    public Trillions(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {

      return number;
    }
  }
}