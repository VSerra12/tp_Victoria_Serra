using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class MultiplyCalculator:Calculable
    {
        public void Calculate()
        {

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Multiply(a, b));
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
    }
}
