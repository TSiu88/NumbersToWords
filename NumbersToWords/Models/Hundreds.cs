namespace NumbersToWords.Models
{
  public class Hundreds : NumbersToWords, INumbersToWords
  {
    public Hundreds(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      return number;
    }
  }



}