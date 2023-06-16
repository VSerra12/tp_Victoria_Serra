using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class SumCalculate:Calculable
    {

        public void Calculate()
        {

        Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Y el segundo:");
            var b = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine(Sum(a, b));
        }


        public int Sum(int a, int b)
        {
            return a + b;
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public float Sum(float a, float b)
        {
            return a + b;
        }

        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
