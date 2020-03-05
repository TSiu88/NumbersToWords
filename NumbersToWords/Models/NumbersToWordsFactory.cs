using System;

namespace NumbersToWords.Models
{

  public class NumbersToWordsFactory
  {
    public string CreateInstance(string number)
    {
      int numberStringLength = number.Length;
      if (numberStringLength == 1)
      {
        return new Ones(number).getInstance(number);
      }
      else if (numberStringLength == 2)
      {
        return new Tens(number).getInstance(number);
      }
      else if (numberStringLength == 3)
      {
        return new Hundreds(number).getInstance(number);
      }
      if (numberStringLength <= 6)
      {
        return new Thousands(number).getInstance(number);
      }
      else if (numberStringLength <= 9)
      {
        return new Millions(number).getInstance(number);
      }
      else if (numberStringLength <= 12)
      {
        return new Billions(number).getInstance(number);
      }
      else if (numberStringLength <= 15)
      {
        return new Trillions(number).getInstance(number);
      }
      else
      {
        throw new ArgumentException();
      }
    }
  }

}