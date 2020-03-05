namespace NumbersToWords.Models
{
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
}