using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Collectionn
{

    class Empp
    {
        string name;
        int exp;

        public Empp(string name, int exp)
        {
            this.name = name;
            this.exp = exp;
        }


    }


    class LinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);
            ll.AddLast(200);

            LinkedListNode<int> nn = ll.Find(200);
            ll.AddBefore(nn, 1000);
            ll.AddAfter(nn, 2000);

            //ll.Clear();
            Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Contains(34));

            ll.Remove(90);

            foreach (int d in ll)
                Console.WriteLine(d);
        }

    }


    class Diction
    {
        static void Main(string[] args)
        {

            List<Empp> ll = new List<Empp>();
            ll.Add(new Empp("anu", 8));

            ll.Add(new Empp("Jyoti", 9));

            //keys should be unique, both are object type
            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Shubham", 90);
            dd.Add("vikas", 98);
            dd.Add("Mugdha", 89);
            dd.Add("shubham", 92);

            Console.WriteLine(dd["shubham"]);
            dd["mugdha"] = 87;

            //dd.Remove("vikas");
            //Console.WriteLine(dd["vikas"]);
            dd.ContainsKey("Jyoti");
            dd.ContainsValue(90);

            Dictionary<Empp, int> d2 = new Dictionary<Empp, int>();
            d2.Add(new Empp("Omkar", 9), 98777777);
            d2.Add(new Empp("Omkar", 9), 98777777);

            foreach (KeyValuePair<Empp, int> jp in d2)
                Console.WriteLine(jp.Key + "==>" + jp.Value);

        }

    }

}
