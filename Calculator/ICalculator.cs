using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator<T>
    {
        T Add(T first, T last);
        T Mul(T first, T last);
        T Sub(T first, T last);
        decimal Div(T first, T last);
    }
}
