using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.AverageCalculation
{
    public class Average
    {
        private const int AMOUNT_NUMBERS = 4;
        public void getNumbers()
        {
            Console.WriteLine("Introduzca el primer número: ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número: ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer número: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduzca el cuarto número: ");
            decimal num4 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(Calculate(num1, num2, num3, num4));
        }

        private decimal Calculate(decimal a, decimal b, decimal c, decimal d)
        {
            return (a + b + c + d) / AMOUNT_NUMBERS;
        }
    }
}
