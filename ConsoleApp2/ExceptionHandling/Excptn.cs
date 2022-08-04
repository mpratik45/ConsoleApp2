using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.ExceptionHandling
{
    class Excptn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter Numbers:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division:" + a / b);
                try
                {
                    Console.WriteLine("Enter age:");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch (SystemException e) //Universal Exception
            {
                Console.WriteLine(e.Message);
            }
            for(int i=0;i<=10;i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
