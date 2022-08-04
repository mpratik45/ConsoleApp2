using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{
    class MyStringBuilerSort : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x, StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
    class Icomp
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> sb = new SortedList<StringBuilder, int>(new MyStringBuilerSort());
            sb.Add(new StringBuilder("Amit"), 90087770);
            sb.Add(new StringBuilder("sumit"), 878666545);
            sb.Add(new StringBuilder("Meet"), 866545443);
            sb.Add(new StringBuilder("Amit"), 887663321);
            sb.Add(new StringBuilder("siya"), 876655558);

            foreach (KeyValuePair<StringBuilder, int> kv in sb)
                Console.WriteLine(kv.Key + "==>" + kv.Value);
        }
    }

}
