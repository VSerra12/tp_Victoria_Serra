using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class AverageCalculator
    {

        public int Average(int a, int b, int c)
        {
            return a + b + c / 3;
        }

        public double Average(double a, double b, double c)
        {
            return a + b + c / 3;
        }

        public float Average(float a, float b, float c)
        {
            return a + b + c / 3;
        }

        public decimal Average(decimal a, decimal b, decimal c)
        {
            return a + b + c / 3;
        }
    }
}
