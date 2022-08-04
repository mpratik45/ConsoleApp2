using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{
    class HashS
    {
        static void Main(string[] args)
        {
            HashSet<string> hs1 = new HashSet<string>() { "Om", "Raj", "Ram", "Siya" };
            HashSet<string> hs2 = new HashSet<string>() { "Omkar", "Raja", "Ram", "Siya" };
            HashSet<string> hs3 = new HashSet<string>() { "hisd", "tth", "gg", "Siya" };
            HashSet<string> h3 = hs1.Intersect(hs2).ToHashSet();
            bool b1 = hs1.IsSubsetOf(hs2);
            bool b2 = hs2.IsSupersetOf(hs1);

            foreach (string d in hs1)
                Console.WriteLine(d + " ");

            Console.WriteLine();

            foreach (string d in hs2)
                Console.Write(d + " ");
        }

    }

}
