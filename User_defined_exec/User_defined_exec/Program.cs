using System;

namespace User_defined_exec
{
    class CheckAgeException : Exception
    {
        public override string ToString()
        {
            return "Age must be in given range";
        }
        /*public CheckAgeException(string msg)
        {
            Console.WriteLine(msg);
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the name of employee : ");
                string ename = Console.ReadLine();
                Console.Write("Enter the Age of employee : ");
                int age = int.Parse(Console.ReadLine());
                if (age > 0 && age < 100)
                {
                    Console.WriteLine("name of Employee is : " + ename);
                    Console.WriteLine("Age is : " + age);
                }
                else
                {
                    /*CheckAgeException cae = new CheckAgeException();
                    throw cae;*/
                    throw new CheckAgeException();
                    //throw new CheckAgeException(" ");
                }
            }
            catch(CheckAgeException r)
            {
                Console.WriteLine(r);
            }
        }
    }
}
