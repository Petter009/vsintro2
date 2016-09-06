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
        internal static int Multiply(int v1, int v2, int v3)
        {
            return (v1 * v2 * v3);
        }
        internal static double Power(int v1, int v2)
        {
            return Math.Pow(v1, v2);
        }
        internal static double Factorial(int v1)
        {
            for (int n=v1-1; n => 1 ; n--)
            { v1 }
            return (v1 * (v1-1));
        }
    }
}