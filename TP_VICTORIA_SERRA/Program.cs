
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TP_VICTORIA_SERRA.AsignationCompuestOperators;
using TP_VICTORIA_SERRA.AverageCalculation;
using TP_VICTORIA_SERRA.Bill;
using TP_VICTORIA_SERRA.CentimeterToInch;
using TP_VICTORIA_SERRA.Quoter;

namespace TP_VICTORIA_SERRA
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Average average = new Average();
            //average.getNumbers();

            //CentimeterToInchCalculator centimeterToInch = new CentimeterToInchCalculator();
            //centimeterToInch.getNumber();

            //QuoterInPesos quote = new QuoterInPesos();
            //quote.getNumbers();

            //BillCalculator bill = new BillCalculator();
            //bill.getBill();

            //GenericHost generic = new GenericHost();
            //generic.create();

            CompuestAsignations ca = new CompuestAsignations();
            ca.getValuesSum();
            ca.getValuesIncrement();
            ca.getValuesIsSame();
            ca.getValuesIsProvablySame();
            ca.getValuesIsInt();
            ca.getValuesCalculateBinary();


        }
    }
}