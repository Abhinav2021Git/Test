using System;
using System.IO;

namespace Dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStreamReader f = new FileStreamReader();

                Console.WriteLine("Enter 1st number");
                Class1.num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter 2nd number");
                Class1.num2 = Convert.ToDouble(Console.ReadLine());

                Class1.Sum(Class1.num1, Class1.num2);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }

    }
}
