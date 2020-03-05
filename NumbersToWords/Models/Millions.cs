namespace NumbersToWords.Models
{
  public class Millions : NumbersToWords, INumbersToWords
  {
    public Millions(string number) : base(number)
    {
      NumberOfPlaces = 6;
    }
  }
}
