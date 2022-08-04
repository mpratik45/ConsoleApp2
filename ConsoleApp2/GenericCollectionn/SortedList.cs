using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.GenericCollectionn
{
        class Stud : IComparable<Stud>
        {
            string sname;
            long mob;
            int percent;

            public Stud(string sname, long mob, int percent)
            {
                this.Sname = sname;
                this.Mob = mob;
                this.Percent = percent;
            }

            public string Sname { get => sname; set => sname = value; }
            public long Mob { get => mob; set => mob = value; }
            public int Percent { get => percent; set => percent = value; }

            public int CompareTo(Stud other)
            {
                //if (this.percent < other.percent)
                //    return -1;
                //else if (this.percent > other.percent)
                //    return 1;
                //else return 0;

                if (this.percent == other.percent)
                {
                    if (this.sname == other.sname)
                        return this.mob.CompareTo(other.mob);
                    else

                        return this.sname.CompareTo(other.sname);
                }
                else
                    return this.percent.CompareTo(other.percent);

                //return this.sname.CompareTo(other.sname);
                /*return other.sname.CompareTo(this.sname);  */ //this will print data in decending order
            }

            public override string ToString()
            {
                return $"StudentName=" + sname + "StudentMobileNo=" + mob + "StudentPercentage=" + percent;
            }
        }
        class SortedList
        {
            static void Main(string[] args)
            {
                SortedList<Stud, string> ss = new SortedList<Stud, string>();
                ss.Add(new Stud("Adi", 908838333, 50), "Python");
                ss.Add(new Stud("Jyoti", 898923121, 98), "C#");
                ss.Add(new Stud("Anu", 48783920, 60), "RDBMS");
                ss.Add(new Stud("Priya", 39390390, 90), "SQL");
                foreach (KeyValuePair<Stud, string> kv in ss)
                    Console.WriteLine(kv.Key + "===>" + kv.Value);
            }
        }
}
