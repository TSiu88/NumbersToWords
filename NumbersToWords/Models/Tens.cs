using System.Collections.Generic;
using System;

namespace NumbersToWords.Models
{
  public class Tens : NumbersToWords, INumbersToWords
  {
    public Tens(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      return number;
    }
  }
}