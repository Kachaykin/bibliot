using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLib;

namespace bibliot
{
    class Program
    {
        public static void Main(string[] args)
        {


            double a = 8, b = 5;
            Console.WriteLine("a + b = {0}", CalculationLib.CalculationLib.Plus(a, b));
            Console.WriteLine("a - b = {0}", CalculationLib.CalculationLib.Minus(a, b));
            Console.WriteLine("a / b = {0}", CalculationLib.CalculationLib.Divide(a, b));
            Console.WriteLine("a * b = {0}", CalculationLib.CalculationLib.Multiply(a, b));
            Console.ReadLine();
        }
    }
}
    

