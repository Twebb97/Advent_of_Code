using System.Runtime.CompilerServices;
using System.Reflection;
using System.Dynamic;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solutions.Year2020
{

    class Day01 : ASolution
    {
        Hashtable my_hashtable = new Hashtable();


        public Day01() : base(01, 2020, "")
        {
            string[] Lines = this.Input.SplitByNewline();
            foreach (string line in Lines)
            {
                my_hashtable.Add(Int32.Parse(line), 2020 - Int32.Parse(line));
            }
        }

        protected override string SolvePartOne()
        {
            IDictionaryEnumerator denum = my_hashtable.GetEnumerator();
            while (denum.MoveNext())
            {
                if (my_hashtable.ContainsKey(denum.Value)) {
                    return Convert.ToString(Convert.ToInt32(denum.Key) * Convert.ToInt32(denum.Value));
                    break;
                }
            }
            return null;
        }

        protected override string SolvePartTwo()
        {
            IDictionaryEnumerator denum = my_hashtable.GetEnumerator();
            IDictionaryEnumerator denum2 = my_hashtable.GetEnumerator();
            while (denum.MoveNext())
            {
                while (denum2.MoveNext()) {
                    if(my_hashtable.ContainsKey((Convert.ToInt32(denum.Value) - Convert.ToInt32(denum2.Key)))) {
                        return Convert.ToString(Convert.ToInt32(denum.Key) * Convert.ToInt32(denum2.Key) * (Convert.ToInt32(denum.Value) - Convert.ToInt32(denum2.Key)));
                        break;
                    }
                }
            }
            return null;
        }
    }
}
