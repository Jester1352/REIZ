using TimeDegree.Core;

namespace TimeDegree;

public class Time : ICalculate
{
    public Time(double a, double b)
    {
        H = a;
        M = b;
    }

    public double H { get; }

    public double M { get; }

    public double CalculateDegree()
    {
        var degree = (int)Math.Abs(M * 6 - H * 30);
        if (degree > 180)
            degree = 360 - degree;
        return degree;
    }
}




