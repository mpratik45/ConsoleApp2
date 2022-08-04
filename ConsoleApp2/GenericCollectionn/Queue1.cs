using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            int remove = q.Dequeue();
            //q.Clear();

            foreach (int r in q)
                Console.WriteLine(r);
        }
    }
    
}



