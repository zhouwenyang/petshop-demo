using System;
using System.Linq;

namespace petshop.Common
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int Sum(params int[] values)
        {
            return values.Sum();
        }
    }
}
