using System;

public class Kata
{
    // Collision formula
    // (x1 - x2)^2 + (y1 - y2)^2 <= (r1 + r2)
    public static bool Collision(double x1, double y1, double r1, double x2, double y2, double r2) => Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) <= r1 + r2;
}