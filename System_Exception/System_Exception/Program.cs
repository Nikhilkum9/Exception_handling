using System;

namespace System_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Num1 : ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the Num2 : ");
                int n2 = int.Parse(Console.ReadLine());

                int res = n1 / n2;
                Console.WriteLine("Result is : " + res);
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
                Console.WriteLine();
                Console.WriteLine(f);
            }
            catch (DivideByZeroException r)
            {
                Console.WriteLine("Cannot Divide By Zero Exception");
                Console.WriteLine(r.ToString());
            }
        }
    }
}
