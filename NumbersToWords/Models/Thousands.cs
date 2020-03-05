namespace NumbersToWords.Models
{
  public class Thousands : NumbersToWords, INumbersToWords
  {
    public Thousands(string number) : base(number)
    {
      NumberOfPlaces = 3;
    }
  }
}