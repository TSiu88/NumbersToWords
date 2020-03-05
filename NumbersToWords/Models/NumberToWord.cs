using System.Collections.Generic;

namespace NumbersToWords.Models
{
  interface INumbersToWords
  {

  }

  interface INumbersToWordsFactory
  {
    NumbersToWords GetNumbersToWords();

  }
  public class NumbersToWordsFactory
  {
    public INumbersToWords getInstance(string number)
    {
      if (number.Length == 13)
      {
        return new Trillions();
      }
      else if (number.Length < 13 && number.Length >= 10)
      {
        return new Billions();
      }
      else if (number.Length < 10 && number.Length >= 7)
      {
        return new Millions();
      }
      else if (number.Length < 7 && number.Length >= 4)
      {
        return new Thousands();
      }
      else if (number.Length == 3)
      {
        return new Hunderds();
      }
      else if (number.Length == 2)
      {
        return new Tens();
      }
      else if (number.Length == 1)
      {
        return new Ones();
      }
    }
  }
  Dictionary<int, string> Trillions = new Dictionary<int, string>();
  Dictionary<int, string> Billions = new Dictionary<int, string>();
  Dictionary<int, string> Millions = new Dictionary<int, string>();
  Dictionary<int, string> Thousands = new Dictionary<int, string>();
  Dictionary<int, string> Hunderds = new Dictionary<int, string>();
  Dictionary<int, string> Tens = new Dictionary<int, string>();
  Dictionary<int, string> Ones = new Dictionary<int, string>();
  public class Ones
  {
    public Ones(string number)
    {

    }

  }
  public class Tens
  {

  }
  public class Hunderds
  {

  }
  public class Thousands
  {

  }
  public class Millions
  {

  }
  public class Billions
  {

  }
  public class Trillions
  {

  }
  public class NumberToWord
  {
    //5,438,384
    //five million four hundred thirty eight thousand three hundred eighty four

  }
}