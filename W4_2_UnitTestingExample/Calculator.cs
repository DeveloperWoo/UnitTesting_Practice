using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_2_UnitTestingExample
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;

        public int Divide(int a, int b)
        {
            if(b == 0)
                throw new DivideByZeroException();
            return a / b;
        }

    }
}
