using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1;
public class LExpression
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }

    public LExpression()
    {
        
        A = Random.Shared.Next(1, 10);
        B = Random.Shared.Next(1, 10);
        C = Random.Shared.Next(1, 10);
    }

    public LExpression(double a)
    {
        A = a;
        B = Random.Shared.Next(1, 10);
        C = Random.Shared.Next(1, 10);
    }

    public LExpression(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double GetDiscriminant()
    {
        return Math.Pow(B, 2) - 4 * A * C;
    }

    public double[] Calculate()
    {
        double discriminant = GetDiscriminant();
        if (discriminant > 0)
        {
            double root1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
            double root2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
            return new double[] { root1, root2 };
        }
        else if (discriminant == 0)
        {
            double root = -B / (2 * A);
            return new double[] { root };
        }
        return new double[] { };
    }
}
