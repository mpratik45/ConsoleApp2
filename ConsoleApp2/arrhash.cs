using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class arrhash
    {
        static void Main(string[] args)
        {
            string s = "hello";
            string str = "hello";
            string st = new string("hello");

            Console.WriteLine(str == s);
            Console.WriteLine(str == st);
            Console.WriteLine(str.GetHashCode());

            str = str + "C#";

            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(str);
        }
    }
}
