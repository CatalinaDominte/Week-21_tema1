using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class CalculatorApp:ICalculator<int>
    {
       
        public int Add(int first, int last)
        {
           
            int res = first + last;
            return res;
        }
        public int Mul(int first, int last)
        {
            int res = first * last;
            return res;
        }
        public int Sub(int first, int last)
        {
            int res = first - last;
            return res;
        }
        public decimal Div(int first, int last)
        {
            if (last==0)
            {
                throw new DivideByZeroException("Division of number by zero");
            }

            decimal res = (decimal)first / last;
            return res;
        }
    }
}
