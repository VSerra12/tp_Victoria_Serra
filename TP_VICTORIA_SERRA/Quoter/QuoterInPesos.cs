using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.Quoter
{
    internal class QuoterInPesos
    {
        public void getNumbers()
        {
            Console.WriteLine("Ingrese valor en pesos: ");
            double pesos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese cotización: ");
            double quote = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Calculate(pesos, quote) + " dolares.");
        }

        private double Calculate(double pesos, double quote)
        {
            return pesos / quote;
        }
    }
}
