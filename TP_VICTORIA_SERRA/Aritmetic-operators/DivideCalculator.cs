using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class DivideCalculator:Calculable
    {

        public void Calculate()
        {

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Divide(a, b));
        }

        public double Divide(int a, int b)
        {
            return checked(a / b);
        }

        public double Divide(double a, double b)
        {
            return checked(a / b);
        }

        public float Divide(float a, float b)
        {
            return checked(a / b);
        }

        public decimal Divide(decimal a, decimal b)
        {
            return checked(a / b);
        }
    }
}
