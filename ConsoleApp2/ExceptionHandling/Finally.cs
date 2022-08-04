using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp2
{
    class Finally
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("Enter Number:");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("R://a.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("In Finally");
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
