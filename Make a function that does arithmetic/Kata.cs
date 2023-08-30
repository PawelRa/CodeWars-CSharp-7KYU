using System;

namespace Make_a_function_that_does_arithmetic
{
    public class Kata
    {
        public static double Arithmetic(double a, double b, string op)
        {
            double result = 0;
            if (op == "add")
            {
                result = a + b;
            }
            else if (op == "subtract")
            {
                result = a - b;
            }
            else if (op == "multiply")
            {
                result = a * b;
            }
            else if (op == "divide")
            {
                result = a / b;
            }
            else
            {
                return -1;
            }
            return result;
        }
    }
}
