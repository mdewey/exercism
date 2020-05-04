using System;

public static class Gigasecond
{
  readonly static private int gigisecond = 1000000000;
  public static DateTime Add(DateTime moment) => moment.AddSeconds(gigisecond);

}