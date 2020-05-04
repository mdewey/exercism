using System;
using System.Collections.Generic;

public class SpaceAge
{

  readonly double _seconds;
  private double _secondsPerEarthYear = 365.25 * 24 * 60 * 60;

  private Dictionary<string, double> _solarSystemModifiers = new Dictionary<string, double>{
      {"mercury", 0.2408467},
      {"venus",0.61519726 },
      {"earth",1 },
      {"mars",1.8808158 },
      {"jupiter",11.862615 },
      {"saturn", 29.447498 },
      {"uranus",84.016846 },
      {"neptune",164.79132 },
  };

  public SpaceAge(int seconds) => this._seconds = seconds;

  private double _getAge(string where) => this._seconds / (_secondsPerEarthYear * _solarSystemModifiers[where]);

  public double OnEarth() => this._getAge("earth");

  public double OnMercury() => this._getAge("mercury");

  public double OnVenus() => this._getAge("venus");

  public double OnMars() => this._getAge("mars");

  public double OnJupiter() => this._getAge("jupiter");

  public double OnSaturn() => this._getAge("saturn");

  public double OnUranus() => this._getAge("uranus");
  public double OnNeptune() => this._getAge("neptune");
}