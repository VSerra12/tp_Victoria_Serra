using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Aritmetic_operators
{
    internal class RestCalculate:Calculable
    {
        public void Calculate()
        {

            Console.WriteLine("Ingrese el primer numero:");
            var a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Y el segundo:");
            var b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Rest(a, b));
        }

        public int Rest(int a, int b)
        {
            return a - b;
        }

        public double Rest(double a, double b)
        {
            return a - b;
        }

        public float Rest(float a, float b)
        {
            return a - b;
        }

        public decimal Rest(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
