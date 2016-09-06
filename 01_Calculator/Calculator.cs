using System;

namespace _01_Calculator
{
    public class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return (v1 + v2);
        }

        internal static int Subtract(int v1, int v2)
        {
            return (v1 - v2);
        }

        internal static int Sum(int[] numbers)
        {
            int number = 0;

            foreach (int numb in numbers)
            {
                number = number + numb;
            }
            return number;
        }
    }
}