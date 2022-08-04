using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{
    class Dictionary1
    {
            static void Main(string[] args)
            {
                List<string> ll = new List<string>()
            { "Red", "Pink","blue","Red", "Pink","blue","Green","Red","Green"};

                string s = "Jyoti";
                char[] carr = s.ToCharArray();

                Dictionary<string, int> dd = new Dictionary<string, int>();
                foreach (string color in ll)
                {
                    if (dd.ContainsKey(color))
                    {
                        int oldvalue = dd[color];
                        dd[color] = oldvalue + 1;
                    }
                    else
                    {
                        dd.Add(color, 1);
                    }
                }

            }
      }
}
