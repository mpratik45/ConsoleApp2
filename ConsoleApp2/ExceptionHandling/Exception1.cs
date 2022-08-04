using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ExceptionHandling
{
    class Exception1
    {
        static void a1()
        {
            Console.WriteLine("a1 starts:");
            Console.WriteLine("Enter Number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a1 ends.");
        }
        static void a2()
        {
            a1();
            Console.WriteLine("In a2");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts.");
            try
            {
                a2();
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main Ends.");
        }
    }
}
