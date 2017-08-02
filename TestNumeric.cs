
//
// Copyright 2017 Paul Perrone.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDA.Numeric
{
    public class TestNumeric
    {
        public static void Main(string[] args)
        {
            // Answers should be 1.0 and -3.0
            List<double> doubleRoots = NumericalMethods.GetQuadraticRoots(1.0, 2.0, -3.0);

            // Answers should be -1.0
            List<double> singleRoots = NumericalMethods.GetQuadraticRoots(1.0, 2.0, 1.0);

            // No roots since they are imaginary
            List<double> noRoots = NumericalMethods.GetQuadraticRoots(1.0, 1.0, 1.0);

            // Should throw an error since a=0.0
            string errorMsg = "";
            try
            {
                List<double> errorRoots = NumericalMethods.GetQuadraticRoots(0.0, 2.0, 1.0);
            }
            catch (System.Exception e)
            {
                errorMsg = e.Message;
            }   
        }
    }
}
