namespace NumbersToWords.Models
{
  public class Billions : NumbersToWords, INumbersToWords
  {

    public Billions(string number) : base(number)
    {
      NumberOfPlaces = 9;
    }
    // public string GetNumbers()
    // {
    //   Millions m = new Millions()
    // }

  }
}
