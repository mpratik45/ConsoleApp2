using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Collectionn
{
    class UnboxingArray
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(100);
            l1.Add(200);
            l1.Add(300);
            l1.Add(400);
            l1.Add(500);
            l1.Add(600);
            l1.Add(700);
            l1.Add(800);
            l1.Add(900);
            l1.Remove(300);

            l1[0] = 1000;
            Console.WriteLine(l1.Count);
            Console.WriteLine(l1.Capacity);

            for(int i=0;i<=l1.Count;i++)
            {
                Console.WriteLine(l1[i]);
            }
            foreach(int items in l1)
            {
                Console.WriteLine(items);
            }
        }
    }
}
