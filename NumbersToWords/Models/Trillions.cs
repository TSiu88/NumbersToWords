namespace NumbersToWords.Models
{
  public class Trillions : NumbersToWords, INumbersToWords
  {
    public Trillions(string number) : base(number)
    {
      NumberOfPlaces = 12;
    }
  }
}