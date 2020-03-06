using System;

namespace NumbersToWords.Models
{
  public class NumbersToWordsFactory
  {
    public string CreateInstance(string number)
    {
      int numberStringLength = number.Length;
      string words = "";
      if (numberStringLength == 1)
      {
        Ones ones = new Ones(number);
        return ones.getInstance(number, words);
      }
      else if (numberStringLength == 2)
      {
        Tens tens = new Tens(number);
        return tens.getInstance(number, words);
      }
      else if (numberStringLength == 3)
      {
        Hundreds hundreds = new Hundreds(number);
        return hundreds.getInstance(number, words);
      }
      if (numberStringLength <= 6)
      {
        Thousands thousands = new Thousands(number);
        return thousands.getInstance(number, words);
      }
      else if (numberStringLength <= 9)
      {
        Millions millions = new Millions(number);
        return millions.getInstance(number, words);
      }
      else if (numberStringLength <= 12)
      {
        Billions billions = new Billions(number);
        return billions.getInstance(number, words);
      }
      else if (numberStringLength <= 15)
      {
        Trillions trillions = new Trillions(number);
        return trillions.getInstance(number, words);
      }
      else
      {
        throw new ArgumentException();
      }
    }
  }

}