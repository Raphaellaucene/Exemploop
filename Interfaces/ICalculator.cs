using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemploop.Interfaces
{
    public interface ICalculator
    {
        //Methods that have no body are mandatory to be implemented
        int Sum(int a, int b);
        int Sub(int a, int b);
        int Mul(int a, int b);

        //Methods that have a body are optional to be implemented
        int Div(int a, int b)
        {
            return a / b;
        }
    }
}