using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
  public static IDictionary<char, int> Count(string sequence) =>
    sequence.Aggregate("ACGT".ToDictionary(key => key, value => 0), (acc, gene) =>
    {

      var test = new Dictionary<char, int>
      {
        ['B'] = 2,
        new KeyValuePair<char, int> { 'b', 3 },


      };
      if (acc.ContainsKey(gene))
      {
        acc[gene] += 1;
      }
      else
      {
        throw new ArgumentException();
      }
      return acc;
    });
}
