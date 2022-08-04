using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Stack<string> sk = new Stack<string>();
            sk.Push("A");
            sk.Push("B");
            sk.Push("C");
            sk.Push("D");

            string[] arr = new string[sk.Count];
            sk.CopyTo(arr, 0);

            foreach (string s in sk)
                Console.WriteLine(s);

            string DataRemove = sk.Pop();
            string DataPeek = sk.Peek();
            Console.WriteLine("Peek" + DataPeek);
            foreach (string s in sk)
                Console.WriteLine(s);
        }
    }
}
