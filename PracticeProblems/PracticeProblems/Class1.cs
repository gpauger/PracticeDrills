using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Class1
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            string bar = "";
            foreach (string str in strarr)
            {
                string result = String.Join("", strarr, Array.IndexOf(strarr, str), k);
                if (result.Count() > bar.Count())
                { bar = result; }
            }
            return bar;
        }
    }
}
