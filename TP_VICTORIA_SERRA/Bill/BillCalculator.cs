using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.Bill
{
    internal class BillCalculator
    {

        private const double HOT_DOG = 2;
        private const double FRENCH_FRIES = 1;
        private const double SODA = 0.85;
        private const double TIP = 0.1;

        public void getBill()
        {
            Console.WriteLine("Ingrese cantidad de panchos: ");
            int hotDog = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de papas fritas: ");
            int frenchFries = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de refrescos: ");
            int sodas = Convert.ToInt32(Console.ReadLine());

            double total = CalculateProduct(hotDog, HOT_DOG) + CalculateProduct(frenchFries, FRENCH_FRIES) + CalculateProduct(sodas, SODA);

            Console.WriteLine("Tu cuenta es: " + CalculateBill(total));
        }

        private double CalculateProduct(int amount, double price)
        {
            return amount * price;
        }

        private double CalculateBill(double total) {
            return total + (total * TIP);
        }


    }
}
