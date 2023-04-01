using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorClass
    {
        public int a;
        public int b;
        public CalculatorClass(int A, int B)
        {
            a = A;
            b = B;
        }
        public int Additional()
        {
            return a + b;
        }

        public int Subtraction()
        {
            return a - b;
        }

        public int Miltiplication()
        {
            return a * b;
        }

        public int Division()
        {
            return a / b;
        }
    }
}
