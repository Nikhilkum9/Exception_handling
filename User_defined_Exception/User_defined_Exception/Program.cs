using System;

namespace User_defined_Exception
{
    class InvalidAgeException:Exception
    {
        public InvalidAgeException(string msg):base()
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the Number : ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter the Name : ");
                string name = Console.ReadLine();
                
                Console.Write("Enter the age : ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (age > 0)
                {
                    Console.WriteLine("Emp num is  : " + n);
                    Console.WriteLine("Emp name is : " + name);
                    Console.Write("Emp age is  : " + age);
                }
                else
                {
                    throw new InvalidAgeException("");
                }
            }
            
            catch(FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
