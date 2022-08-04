using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Delegates
{
    //Delegates-it is a variable which holds refreence of a function. its a pointer to function(if we want to store function address then
    //we can use delegates) delegate can declare inside a class or outside the class.

    public delegate void mydele();
    class Delegate1
    {

        public delegate int myde12(int a, int b);

        public static int Add(int a, int b)
        {
            Console.WriteLine("Add=" + (a + b));
            return a + b;
        }
        public static int Prod(int a, int b)
        {
            Console.WriteLine("Prod=" + (a + b));
            return a * b;
        }
        static void greet()
        {
            Console.WriteLine("Good Evening");
        }
        static void Main(string[] args)
        {
            mydele d1 = greet;
            d1();

            myde12 d2 = Add;
            myde12 d3 = Prod;

            d2 = d2 + Prod;
            int pc = d2(10, 20);
        }
    }
    class Overload
    {
        public delegate void mydel13(int a);

        public static void m1(int a)
        {
            Console.WriteLine("In m1" + a);
        }
        public static void square(int n)
        {
            Console.WriteLine("Square=" + n);
        }
        static void Main(string[] args)
        {
            //singleCast
            //mydel13 d1=square;

            //MultiCast-holding Reference of more than one function
            mydel13 d2 = square;
            d2 = d2 + m1;
            d2(9);
        }
        public static void m1(int a, int b)
        {
            Console.WriteLine("In m1" + a + " " + b);
        }
    }







    //Anonymous and Delegate



    class LambdaDeleg
    {
        public delegate int Factorial(int n);
        static void Main(string[] args)
        {
            Factorial f = (n) =>
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            };
            int c = f(12);
            Console.WriteLine("Factorial of given number is=" + c);
        }
    }
    class Delegates2
    {
        public delegate void mydel7(int a, int b);
        public delegate int mydel8(int a);
        static void Main(string[] args)
        {
            //anonymus function
            mydel7 d = delegate (int a, int b)
            {
                Console.WriteLine("Product=" + (a * b));
            };
            d(2, 3);

            //Lambda
            mydel7 d2 = (a, b) => Console.WriteLine("Area of Rectangle=" + (a * b));
            d2(11, 22);

            mydel8 add = (a) =>
            {
                return a * a;
            };
            int sq = add(4);

            mydel8 add2 = (a) => a * a;
            int sq2 = add2(3);
            Console.WriteLine("Square=" + sq2);
        }
    }
    /*Predefined Deligated-1)Action-it is a generic delegate and the return type is void. we accept zero or more parameters,Action<in T1,...inT16>
    Action delegates not return any value.
    2)func-if your function has return some value then use this delegates.
    3)Predicate-if your function has bool return type & may take zero or more parameters then use this delegates.*/
    class PreDelegate
    {
        static double m1(int r, char c)
        {
            return r * 3.4;
        }
        static void m2(byte a, string e)
        {
            Console.WriteLine("In M2" + e + +a);
        }
        static bool m3(long a, String s)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, char, double> ff = m1;
            double xx = ff(88, 'a');

            Action<byte, string> aa = m2;
            aa(233, "Jyoti");

            Func<long, string, bool> f = m3;
            bool bb = f(9321765456, "Yes/No");

        }
    }




    class Delegates1
    {
        static void m1(int a, float b)
        {
            Console.WriteLine("In m1" + (a + b));
        }
        static void m2(string msg)
        {
            Console.WriteLine("Welcome" + msg);
        }
        static int cube(int x)
        {
            return x * x * x;
        }
        static float AreaOfCircle(int r)
        {
            return 3.14f * r * r;
        }
        static bool isEven(int x)
        {
            return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            Action<int, float> d1 = m1;
            d1(11, 2.3f);
            Action<string> d2 = m2;
            d2("GoodEvening");

            Func<int, float> d3 = AreaOfCircle;
            float area = d3(2);

            Func<int, bool> d4 = isEven;

            Predicate<int> d5 = isEven;
        }
    }





    class Delegates3
    {
        static void greet()
        {
            Console.WriteLine("Happy Morning");
            //return 90;
        }
        static void m2(int a, int b, Action d1)
        {
            Console.WriteLine("Addition " + (a + b));
        }
        static bool isEven(int n)
        {
            Console.WriteLine("In Even" + n);
            return n % 2 == 0;
        }
        static void print(int a)
        {
            Console.WriteLine("***" + a);
        }
        static void Main(string[] args)
        {
            m2(10, 20, () => Console.WriteLine("Happy Eve"));

            List<int> lst = new List<int>() { 11, 23, 67, 24, 98, 22, 40, 32, 7 };
            List<int> lst2 = lst.FindAll(a => a % 2 == 0);

            //print All
            lst.ForEach(print);

            /*foreach(int d in lst2)
                Console.WriteLine(d);*/

            /*List<int> l2 = new List<int>();
            foreach(int d in lst)
            {
                if(d%2==0)
                {
                    l2.Add(d);
                }
            }*/
        }
    }
}


