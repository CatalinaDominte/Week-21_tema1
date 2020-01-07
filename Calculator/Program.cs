using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorApp();
            Console.WriteLine(calc.Add(1, 5));
            try
            {
                Console.WriteLine(calc.Div(1, 9));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
