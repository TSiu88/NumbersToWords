namespace NumbersToWords.Models
{
  public class Trillions : NumbersToWords, INumbersToWords
  {
    public Trillions(string number) : base(number)
    {
      NumberOfPlaces = 12;
    }

    // public string GetNumbers()
    // {

    //   Billions b = new Billions();
    //   b.getInstance(this.)
    // }
  }
}