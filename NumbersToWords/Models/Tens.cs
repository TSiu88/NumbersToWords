namespace NumbersToWords.Models
{
  public class Tens : NumbersToWords, INumbersToWords
  {
    public Tens(string number) : base(number)
    {
      NumberOfPlaces = 0;
    }
  }
}