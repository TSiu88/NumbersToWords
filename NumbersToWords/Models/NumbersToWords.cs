using System.Collections.Generic;

namespace NumbersToWords.Models
{
  interface INumbersToWords
  {
    string getInstance(string number, string words);
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
        {"0", ""},
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
    public string getInstance(string startNumber, string words)
    {
      //the start number should always be at 0. The length of the string should decrease in size with each pass of getInstance. The numbers to words from each
      //543,204
      //after first getInstance call, start number = to 543,204 should be 204.
      //we need to pass the new string into the next recursive call as 204 so we need to take off the first 3 characters of the string
      string toBeSliced = startNumber;
      int remainingPlaces = startNumber.Length;
      string numbersToWords = words;
      if (remainingPlaces == 0)
      {
        return numbersToWords;
      }
      string placesDigits = startNumber.Substring(0, (remainingPlaces - NumberOfPlaces));
      int placeLength = placesDigits.Length;

      bool isTeen = false;
      bool zeroTens = false;
      string threeDigits = "";
      for (int i = placeLength - 1; i >= 0; i--)
      {
        string word = "";
        string digit = placesDigits[i - placeLength + 1].ToString();
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
          else if (digit == "0")
          {
            zeroTens = true;
          }
          word = Second[digit];
        }
        else if (i == 0)
        {
          if (isTeen)
          {
            word = Teen[digit];
          }
          else if (zeroTens && digit != "0")
          {
            word = ("and" + First[digit]);
          }
          else
          {
            word = First[digit];
          }
        }
        threeDigits += (word + " ");
      }
      numbersToWords += threeDigits;
      toBeSliced = numbersToWords.Substring(placeLength - 1, toBeSliced.Length);
      return getInstance(toBeSliced, numbersToWords);
    }
  }
}