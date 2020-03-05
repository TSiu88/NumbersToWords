using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Billions : NumbersToWords, INumbersToWords
  {
    public Billions(string number) : base(number)
    {

    }
    public string getInstance(string number)
    {
      int numberLength = number.Length;
      string billionsPlaces = number.Substring(0, (numberLength - 9));
      int billionsPlacesCount = billionsPlaces.Length;
      string one = billionsPlaces[0].ToString();
      string oneDigit = First[one];
      string two = billionsPlaces[1].ToString();
      string twoDigit = Second[two];
      string three = billionsPlaces[2].ToString();
      string thirdDigit = Third[three];

      if (billionsPlacesCount == 3)
      {
        one = billionsPlaces[0].ToString();
        oneDigit = First[one];
        two = billionsPlaces[1].ToString();
        twoDigit = Second[two];
        three = billionsPlaces[2].ToString();
        thirdDigit = Third[three];
      }
      else if (billionsPlacesCount == 2)
      {
        one = billionsPlaces[0].ToString();
        oneDigit = First[one];
        two = billionsPlaces[1].ToString();
      }
      else
      {
        one = billionsPlaces[0].ToString();
        oneDigit = First[one];
      }

      return number;
    }
  }
}
