using System;

namespace Calculator
{
    public static class Calculator
    {
        public static int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public static int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public static int Multiply(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        public static double Division(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Man kann nicht durch 0 dividieren.");
            }

            return dividend / divisor;
        }
    }
}
