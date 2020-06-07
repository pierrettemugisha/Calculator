using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double value1, double value2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "a":
                    result = value1 + value2;
                    break;
                case "s":
                    result = value1 - value2;
                    break;
                case "m":
                    result = value1 * value2;
                    break;
                case "d":
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
