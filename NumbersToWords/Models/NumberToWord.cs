using System.Collections.Generic;
using System;

namespace NumbersToWords.Models
{
  interface INumbersToWords
  {
    string getInstance(string number);
  }

  interface INumbersToWordsFactory
  {
    INumbersToWords GetNumbersToWords();

  }
  public class NumbersToWordsFactory
  {
    public INumbersToWords CreateInstance(string number)
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
        return new Hunderds(number);
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
  public abstract class NumbersToWords
  {
    public string Number { get; set; }
    public NumbersToWords(string number)
    {
      Number = number;
    }
  }
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
  public class Hunderds : NumbersToWords, INumbersToWords
  {
    public Hunderds(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      return number;
    }
  }
  public class Thousands : NumbersToWords, INumbersToWords
  {
    public Thousands(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      return number;
    }
  }
  public class Millions : NumbersToWords, INumbersToWords
  {
    public Millions(string number) : base(number)
    {
    }
    public string getInstance(string number)
    {
      return number;
    }
  }
  public class Billions : NumbersToWords, INumbersToWords
  {
    public Billions(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      return number;
    }
  }
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
  public class NumberToWord
  {
    //5,438,384
    //five million four hundred thirty eight thousand three hundred eighty four

  }
}