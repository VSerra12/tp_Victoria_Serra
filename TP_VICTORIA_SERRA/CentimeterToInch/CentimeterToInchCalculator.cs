using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.CentimeterToInch
{
    internal class CentimeterToInchCalculator
    {
        private const double INCHES = 2.54;
        public void getNumber()
        {
            Console.WriteLine("Ingrese la longitud en centimetros: ");
            double centimiter =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Calculate(centimiter) + " In");
        }

        private double Calculate(double centimiter)
        {
            return centimiter / INCHES;
        }
    }
}
