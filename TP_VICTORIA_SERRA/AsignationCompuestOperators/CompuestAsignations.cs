using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_VICTORIA_SERRA.AsignationCompuestOperators
{
    internal class CompuestAsignations
    {
        private int addResult = 0;

        public void getValuesSum() {

            Console.WriteLine("Ingrese el numero para sumar: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(sum));

            Console.WriteLine("Ingrese otro numero para sumar: ");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(sum2));

        }

        public void getValuesIncrement()
        {

            Console.WriteLine("Ingrese numero a incrementar: ");
            int increment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Increment(increment));
        }

        public void getValuesIsSame()
        {

            Console.WriteLine("Partiendo de los ejercicios anteriores ingrese dos números que al pasar por una función sean iguales los dos: ");
            Console.WriteLine("Primer número:");

            int sum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            int increment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsSame(sum, increment));
        }

        public void getValuesIsProvablySame()
        {

            Console.WriteLine("Partiendo de los ejercicios anteriores ingrese dos números que al pasar por una función alguno de los dos pueden ser iguales: ");
            Console.WriteLine("Primer número:");

            int sum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            int increment = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsProbablySame(sum, increment));

        }

        public void getValuesIsInt()
        {
            Console.WriteLine("Ingrese algo para ver si es un int: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsInt(value));

        }

        public void getValuesCalculateBinary()
        {
            Console.WriteLine("Ingrese un numero de desplazamiento: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateBinary(value));
        }

        public int Sum(int add)
        {
            return addResult += add;
        }

        public int Increment(int a)
        {
            return a++;
        }

        public bool IsSame(int sum, int increment)
        {
            return sum == Sum(sum) & increment == Increment(increment);
        }

        public bool IsProbablySame(int addNumber, int sum)
        {
            return addNumber == Sum(addNumber) || sum == Increment(sum);
        }

        public bool IsInt(int value)
        {
            int? a = value;
            return a != null;
        }

        public string CalculateBinary(int propagate)
        {
            uint value = 0b_0111;

            uint result = value >> propagate;

            return Convert.ToString(propagate, toBase: 10);
        }
    }
}
