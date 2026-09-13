  using System;
  public class Cockroach
  {
    private const double CmInKm = 100000.00;
    private const double SecondsPerHour = 3600.00;
    public static int CockroachSpeed(double x)
    {
      var totalCm = x * CmInKm;      //
      double cmPerSecond = totalCm/SecondsPerHour;
      return (int)cmPerSecond;
    }
  }
