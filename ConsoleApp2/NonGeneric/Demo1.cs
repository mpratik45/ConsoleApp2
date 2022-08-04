using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp2.NonGeneric
{
    class SS<T>
    {
        private T obj;

        public T Obj { get => obj; set => obj = value; }
    }
    class S
    {
        private object obj;

        public object Obj { get => obj; set => obj = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            SS<float> s1 = new SS<float>();
            s1.Obj = 4.5f;
            float d = s1.Obj;

            S s = new S();
            s.Obj = "Omkar";
            s.Obj = 9090;

            int x = (int)s.Obj;

        }
    }

    class Demo1
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4 };

            ArrayList al = new ArrayList(lst);
            Hashtable ht = new Hashtable();
            ht.Add(90, "A");
            ht.Add(9.4f, 78);
            ht.Add("Om", 322);
            //ht.Add(new Emp("Pratik", 09), 890909099);

            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + "===>" + kv.Value);
            }
            Console.WriteLine("................................");
            SortedList s1 = new SortedList();
            s1.Add("Ora", "Oracle");
            s1.Add("Vb", 90);
            s1.Add("CS", 7.8f);
            s1.Add(90, "Ff");

            foreach (DictionaryEntry kv in ht)
            {
                Console.WriteLine(kv.Key + "===>" + kv.Value);
            }

        }

    }
    class NonGe
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(12);
            a.Add("Jyoti");
            a.Add(true);
            a.Add(new StringBuilder("Sia"));

            foreach (object ob in a)
                Console.WriteLine(ob);

            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i]);

            string s = (string)a[2];
        }
    }
    class Arr
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Pune");
            ar.Add("kalyan");
            ar.Add("nashik");

            foreach (object s in ar)
                Console.WriteLine(s);
            Console.WriteLine("Enter city you want to delete");
            ar.Remove(ar);
            //Console.WriteLine("After Reom");

            //foreach (object s in ar)
            //    Console.WriteLine(s);


        }
    }
}

