using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class ModuleCalculator
    {

        public int Module(int a, int b)
        {
            return checked(a % b);
        }

        public double Module(double a, double b)
        {
            return checked(a % b);
        }

        public float Module(float a, float b)
        {
            return checked(a % b);
        }

        public decimal Module(decimal a, decimal b)
        {
            return checked(a % b);
        }
    }
}
