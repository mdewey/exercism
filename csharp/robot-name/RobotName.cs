using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
  private static HashSet<string> _pastNames = new HashSet<string>();
  const string alphabet = "ABCDEFGHIJKLOMOPQRSTUVWXYZ";
  const string numbers = "0123456789";
  private readonly string NAME_MASK = "AA000";
  private static Random rand = new Random();
  private Dictionary<char, Func<char>> _digitGenerator = new Dictionary<char, Func<char>>{
      {'A', () => alphabet[rand.Next(alphabet.Length - 1)]},
      {'0', () => numbers[rand.Next(numbers.Length - 1)]}
  };

  private string _generateName()
  {
    return String.Join(String.Empty, NAME_MASK.Select(s => _digitGenerator[s]()));
  }


  private string _Name;
  public string Name
  {
    get
    {
      if (String.IsNullOrWhiteSpace(_Name))
      {
        do
        {
          _Name = _generateName();
        } while (_pastNames.Contains(_Name));
        _pastNames.Add(_Name);
      }
      return _Name;
    }
  }

  public void Reset()
  {
    this._Name = String.Empty;
  }
}