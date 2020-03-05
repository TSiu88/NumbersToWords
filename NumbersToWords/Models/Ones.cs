using System.Collections.Generic;
using System;

namespace NumbersToWords.Models
{
  public class Ones : NumbersToWords, INumbersToWords
  {
    public Ones(string number) : base(number)
    {
    }
    public string getInstance(string number)
    {
      return number;
    }
  }
}