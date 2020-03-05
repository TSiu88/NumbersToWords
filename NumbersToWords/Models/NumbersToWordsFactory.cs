using System;

namespace NumbersToWords.Models
{

  public class NumbersToWordsFactory
  {
    public NumbersToWords CreateInstance(string number)
    {
      if (number.Length == 13)
      {
        return new Trillions(number);
      }
      else if (number.Length < 13 && number.Length >= 10)
      {
        return new Billions(number);
      }
      else if (number.Length < 10 && number.Length >= 7)
      {
        return new Millions(number);
      }
      else if (number.Length < 7 && number.Length >= 4)
      {
        return new Thousands(number);
      }
      else if (number.Length == 3)
      {
        return new Hundreds(number);
      }
      else if (number.Length == 2)
      {
        return new Tens(number);
      }
      else if (number.Length == 1)
      {
        return new Ones(number);
      }
      else
      {
        throw new ArgumentException();
      }
    }
  }

}