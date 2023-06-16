using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class Triangle
    {
        public double CalculateArea(int base_, int height)
        {
            return (base_ * height) / 2;
        }

        public float CalculateArea(float base_, float height) {
            return (height * base_) / 2;
        }

        public decimal CalculateArea(decimal base_, decimal height)
        {
            return (base_ * height) / 2;
        }
    }
}
