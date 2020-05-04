using System;

public static class TwoFer
{
  // In order to get the tests running, first you need to make sure the Speak method 
  // can be called both without any arguments and also by passing one string argument.

  private static string _getSaying(string name) => $"One for {name}, one for me.";

  public static string Speak() => _getSaying("you");
  public static string Speak(string name) => _getSaying(name);
}
