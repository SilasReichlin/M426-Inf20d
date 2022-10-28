using System;
using System.Collections.Generic;

namespace Statistics
{
    public static class Average
    {
        public static double Mean(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("Die Liste ist leer.");
            }

            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public static double Median(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("Die Liste ist leer.");
            }

            numbers.Sort();

            if (numbers.Count % 2 == 0)
            {
                double num1 = numbers[numbers.Count / 2 - 1];
                double num2 = numbers[numbers.Count / 2];

                return (num1 + num2) / 2;
            }
            else
            {
                return numbers[numbers.Count / 2];
            }
        }
    }
}
