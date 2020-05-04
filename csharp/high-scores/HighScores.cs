using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

  private List<int> _scores { get; set; }

  public HighScores(List<int> list)
  {
    _scores = list;
  }

  public List<int> Scores()
  {
    return _scores;
  }

  public int Latest()
  {
    return _scores.Last();
  }

  public int PersonalBest()
  {
    return _scores.Max();
  }

  public List<int> PersonalTopThree()
  {
    return _scores.OrderByDescending(o => o).Take(3).ToList();
  }
}