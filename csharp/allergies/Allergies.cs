using System;
using System.Collections.Generic;
using System.Linq;
public enum Allergen
{
  Eggs = 1,
  Peanuts = 2,
  Shellfish = 4,
  Strawberries = 8,
  Tomatoes = 16,
  Chocolate = 32,
  Pollen = 64,
  Cats = 128
}

public class Allergies
{
  private int _mask;

  private IEnumerable<Allergen> _allergies;

  public Allergies(int mask)
  {
    this._mask = mask;
    _allergies = Enum
        .GetValues(typeof(Allergen))
        .Cast<Allergen>()
        .Where(s => (mask & (int)s) != 0);
  }

  public bool IsAllergicTo(Allergen allergen)
  {
    return this._allergies.Contains(allergen);
  }

  public Allergen[] List()
  {
    return this._allergies.ToArray();
  }
}