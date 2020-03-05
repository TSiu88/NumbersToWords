namespace NumbersToWords.Models
{
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
}
