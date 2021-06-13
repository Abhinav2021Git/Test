using System;
using System.Collections.Generic;
using System.Text;

namespace Dummy
{
    public class Class1
    {
        public static double num1;
        public static double num2;
        public static double sum;

       
            public static void Sum(double n1, double n2)
        {
            sum = n1 + n2;
            Console.WriteLine("The Sum of {0} and {1} is = {2}", num1, num2, sum);
        }

    }
}
