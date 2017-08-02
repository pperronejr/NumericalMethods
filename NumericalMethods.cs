
//
// Copyright 2017 Paul Perrone.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDA.Numeric
{
    public static class NumericalMethods
    {
        static public List<double> GetQuadraticRoots(double a, double b, double c)
        {
            if (a != 0.0)
            {
                List<double> roots = new List<double>();
                double discriminant = Math.Pow(b, 2.0) - 4.0 * a * c;

                if (discriminant == 0.0)
                    roots.Add(-b / (2.0 * a));
                else if (discriminant > 0.0)
                {
                    roots.Add((-b + Math.Sqrt(discriminant)) / (2.0 * a));
                    roots.Add((-b - Math.Sqrt(discriminant)) / (2.0 * a));
                }

                return roots;
            }
            else
                throw new System.ApplicationException("Quadratic coefficient a is equal to 0.0");
        }
    }
}
