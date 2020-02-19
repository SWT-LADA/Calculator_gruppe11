using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Uge5
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            double result = a + b;

            Accumulator = result;

            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;

            Accumulator = result;

            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;

            Accumulator = result;

            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(exp, x);

            Accumulator = result;

            return result;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
