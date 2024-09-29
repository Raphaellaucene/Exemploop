using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemploop.Interfaces;

namespace Exemploop.Models
{
    public class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}