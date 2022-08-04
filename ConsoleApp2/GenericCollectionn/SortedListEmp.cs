using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{

    public class Emplo1 : IComparable<Emplo1>
    {
        int eid;
        string ename;
        string edept;

        public Emplo1(int eid, string ename, string edept)
        {
            this.Eid = eid;
            this.Ename = ename;
            this.Edept = edept;
        }
        public int CompareTo(Emplo1 other)
        {
            return this.ename.CompareTo(other.ename);
        }
        public override string ToString()
        {
            return $"Eno:" + eid + "Name:" + ename + "Depaertment:" + edept;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Ename { get => ename; set => ename = value; }
        public string Edept { get => edept; set => edept = value; }
    }
    class SortedListEmp
    {
        static void Main(string[] args)
        {
            SortedList<Emplo1, string> ss = new SortedList<Emplo1, string>();
            ss.Add(new Emplo1(101, "Raj", "It"), "Java");
            ss.Add(new Emplo1(102, "Anu", "Finance"), "Account");
            ss.Add(new Emplo1(103, "Mithali", "Marketing"), "Market");
            ss.Add(new Emplo1(104, "Siddi", "It"), "Java");

            foreach (KeyValuePair<Emplo1, string> kv in ss)
                Console.WriteLine(kv.Key + "==>" + kv.Value);
        }
    }

}
