using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day01 : ASolution
    {

        private static Hashtable readfile(String path) {
            Hashtable my_hashtable = new Hashtable();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    my_hashtable.Add(Int32.Parse(s), 2020 - Int32.Parse(s));
                }
                return my_hashtable;
            }
        }
        
        public Day01() : base(01, 2020, "")
        {

        }

        protected override string SolvePartOne()
        {
            Hashtable my_hashtable = readfile("./input.txt");
            IDictionaryEnumerator denum = my_hashtable.GetEnumerator();
            while (denum.MoveNext())
            {
                if (my_hashtable.ContainsKey(denum.Value)) {
                    System.Console.WriteLine(Convert.ToInt32(denum.Key) * Convert.ToInt32(denum.Value));
                    break;
                }
            }
        }

        protected override string SolvePartTwo()
        {
            Hashtable my_hashtable = readfile("./input.txt");
            IDictionaryEnumerator denum = my_hashtable.GetEnumerator();
            IDictionaryEnumerator denum2 = my_hashtable.GetEnumerator();
            while (denum.MoveNext())
            {
                while (denum2.MoveNext()) {
                    if(my_hashtable.ContainsKey((Convert.ToInt32(denum.Value) - Convert.ToInt32(denum2.Key)))) {
                        System.Console.WriteLine(Convert.ToInt32(denum.Key) * Convert.ToInt32(denum2.Key) * (Convert.ToInt32(denum.Value) - Convert.ToInt32(denum2.Key)));
                        break;
                    }
                }
                break;
            }
        }
    }
}
