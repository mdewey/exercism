using System;
using System.Collections.Generic;
using System.Linq;

public static class RomanNumeralExtension
{

  static Dictionary<int, string> _romans = new Dictionary<int, string>{
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9,"IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
        {400, "CD"},
        {500, "D"},
        {900, "CM"},
        {1000, "M"},
        {4000, "-"}
    };


  public static string ToRoman(this int value)
  {
    var rv = String.Empty;
    // get the largest digit
    var digits = new List<int>();
    var first = value;
    while (value > 0)
    {
      if (value >= 1000)
      {
        first = (value / 1000) * 1000;
      }
      else if (value >= 100 && value < 1000)
      {
        first = (value / 100) * 100;
      }
      else if (value >= 10 && value < 100)
      {
        first = (value / 10) * 10;
      }
      else
      {
        first = value;
      }
      var lastBiggest = 0;
      foreach (var roman in _romans)
      {
        if (roman.Key <= first)
        {
          lastBiggest = roman.Key;
        }
        else
        {
          digits.Add(lastBiggest);
          break;
        }
      }
      value = value - lastBiggest;

    }
    var romans = digits.Select(s => _romans[s]);
    return String.Join(String.Empty, romans);

  }
}
