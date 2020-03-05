namespace NumbersToWords.Models
{
  public class Ones : NumbersToWords, INumbersToWords
  {
    public Ones(string number) : base(number)
    {
      NumberOfPlaces = 0;
    }
  }
}