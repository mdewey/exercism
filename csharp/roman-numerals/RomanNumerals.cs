using System;
using System.Collections.Generic;
using System.Linq;


namespace RomanNumerals
{
  public static class RomanNumeralExtension
  {

    static Dictionary<int, string> _romans = new Dictionary<int, string>{
        {1, "I"},
        {5, "V"},
        {10, "X"},
        {50, "L"}
    };


    public static string ToRoman(this int value)
    {
      var rv = String.Empty;
      // get the largest digit
      var digits = new List<int>();
      var first = value;
      while (value > 0)
      {

        if (value >= 10 && value < 100)
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

    public static void Main(string[] args)
    {
      Console.WriteLine(36.ToRoman());
      Console.WriteLine(3.ToRoman());
      Console.WriteLine(1.ToRoman());
      Console.WriteLine(4.ToRoman());
    }
  }
}
