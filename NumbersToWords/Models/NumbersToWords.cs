using System.Collections.Generic;

namespace NumbersToWords.Models
{
  interface INumbersToWords
  {
    string getInstance(string number);
  }
  public abstract class NumbersToWords
  {
    public Dictionary<string, string> First { get; set; }
    public Dictionary<string, string> Second { get; set; }
    public Dictionary<string, string> Third { get; set; }
    public Dictionary<string, string> Teen { get; set; }
    public string Number { get; set; }
    public string Result { get; set; }
    public virtual int NumberOfPlaces { get; set; }
    public NumbersToWords(string number)
    {
      Number = number;
      First = new Dictionary<string, string>
      {
        {"0", ""},
        {"1", "one"},
        {"2", "two"},
        {"3", "three"},
        {"4", "four"},
        {"5", "five"},
        {"6", "six"},
        {"7", "seven"},
        {"8", "eight"},
        {"9", "nine"}
      };
      Second = new Dictionary<string, string>
      {
        {"0", "and"},
        {"1", ""}, //Special case
        {"2", "twenty"},
        {"3", "thrirty"},
        {"4", "fourty"},
        {"5", "fifty"},
        {"6", "sixty"},
        {"7", "seventy"},
        {"8", "eighty"},
        {"9", "ninety"}
      };
      Third = new Dictionary<string, string>
      {
        {"0", ""},
        {"1", "one"},
        {"2", "two"},
        {"3", "three"},
        {"4", "four"},
        {"5", "five"},
        {"6", "six"},
        {"7", "seven"},
        {"8", "eight"},
        {"9", "nine"}
      };
      Teen = new Dictionary<string, string>
      {
        {"0", "ten"},
        {"1", "eleven"},
        {"2", "twelve"},
        {"3", "thirteen"},
        {"4", "fourteen"},
        {"5", "fifteen"},
        {"6", "sixteen"},
        {"7", "seventeen"},
        {"8", "eighteen"},
        {"9", "nineteen"}
      };
    }
    public string getInstance(string startNumber)
    {
      int numberLength = startNumber.Length;
      string placesDigits = startNumber.Substring(0, (numberLength - NumberOfPlaces));
      int placeLength = placesDigits.Length;
      // string one = "";
      // string oneDigit = "";
      // string two = "";
      // string twoDigit = "";
      // string three = "";
      // string thirdDigit = "";

      // if (placeLength == 3)
      // {
      //   one = placesDigits[0].ToString();
      //   oneDigit = First[one];
      //   two = placesDigits[1].ToString();
      //   twoDigit = Second[two];
      //   three = placesDigits[2].ToString();
      //   thirdDigit = Third[three];
      // }
      // else if (placeLength == 2)
      // {
      //   one = placesDigits[0].ToString();
      //   oneDigit = First[one];
      //   two = placesDigits[1].ToString();
      // }
      // else
      // {
      //   one = placesDigits[0].ToString();
      //   oneDigit = First[one];
      // }

      bool isTeen = false;
      string threeDigits = "";
      for (int i = placeLength - 1; i >= 0; i--)
      {
        string word = "";
        string digit = placesDigits[i].ToString();
        if (i == 2)
        {
          word = Third[digit] + "Hundred";
        }
        else if (i == 1)
        {
          if (digit == "1")
          {
            isTeen = true;
          }
          word = Second[digit];
        }
        else if (i == 0)
        {
          if (isTeen)
          {
            word = Teen[digit];
          }
          else
          {
            word = First[digit];
          }
        }
        threeDigits += (word + " ");
      }
      return threeDigits;
    }
  }
}