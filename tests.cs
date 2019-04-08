using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class DateTimeToHumanReadableFormFormatter
    {
        public static string Format(DateTime date, DateTime current)
        {
            //calculate the timespan by subtracting entry time with current datetime
            var timespan = Convert.ToInt32(current.Subtract(date).TotalDays);
            //set conditions for displaying timespan.  Ran out of time to round off answers and add other 
            //conditions e.g., seconds, weeks, years, etc.
            if (timespan < 1)
            {
                return timespan.ToString() + " hours(s) ago";
            }
            else 
            {
                return timespan.ToString() + " days(s) ago";
            }
            
        }
    }


    class Solution2
    {
        public static int solution2(int[] A)
        {
            //create empty list ints
            //if A[n] =! -1, add item to list, repeat with A[item]
            //if item == -1, add to list end loop
            //get length of list
            List<int> ints = new List<int>();
            int value = 0;
            while (A[value] != -1)
            {
                ints.Add(A[value]);
                value = A[value];
            }
            return ints.Count() + 1;
        }
    }

    class Solution1
    {
        public static int solution(int D, string S)
        {
            int x = 1;
            List<string> ints = new List<string>(new string[] { "one", "two", "three", "four", "five" });
            foreach (string s in ints)
            {
                if (s == S) { x = ints.IndexOf(s) + 1; }
            }
            int answer = D * x;
            return answer;
        }
    }




    class mult
    {
        public static int Persistence(long n)
        {
            int count = 0;
            string str = n.ToString();
            while (str.Count() > 1)
            {
                List<int> newlist = new List<int>();
                foreach (char c in str)
                { newlist.Add(int.Parse(c.ToString())); }
                int x = 1;
                foreach (int i in newlist)
                { x = x * i; }
                str = x.ToString();
                count++;
            }
           
           
            //foreach char in x, convert to 
            return count;
        }
    }
    




    class Solution12
    {
        public static int solution(int[] A)
        {
            //set num 1, loop through A, if num == item in A, ++, else return num
            int x = 1;
            foreach (int i in A)
            {
                bool inlist = A.Contains(x);
                if (inlist == false)
                {
                    return x;
                }
                else x++;
            }
           

            return x;
        }
    }

    public static class Stairs
    {
        public static long StairsIn20(int[][] stairs)
        {
            //foreach item in dayofweek, sum all, add to total
            int grandtotal = 0;
            foreach (Array day in stairs)
            {
                int daytotal = 0;
                foreach (int x in day)
                {
                    daytotal = daytotal + x;
                }
                grandtotal = grandtotal + daytotal;
            }
            return grandtotal * 20;
            

            //foreach total in stairs, summ all
            //multiply by 20
        }
    }
   

    public static class Filter
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            //create new list
            List<string> newlist = new List<string>();
            //foreach item in birds, compare for each item in geese, if b != g, +1, else +0
            foreach (string b in birds)
            {
                int x = 0;
                foreach (string g in geese)
                {
                    if (b != g)
                    { x++; }
                    //if number = listlength, add to new list
                    if (x == 5)
                    { newlist.Add(b); }
                }
            }

            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] array = newlist.ToArray();

            return array;
        }
    }

    public class Kata
    {
        public static string AlphabetPosition(string text)
        {
            //foreach char in text, convert to int, append to new string
            string newtext = "";
            string upper = text.ToLowerInvariant();
            foreach (char l in upper)
            {
                
                int m = char.ToUpper(l) - 64;
                if (m > 0 && m < 27)
                { newtext = newtext + m.ToString() + " "; }
               
            }
            return newtext.TrimEnd(' ');
        }

        public static int SquareDigits(int n)
        {
            //convert n to string
            string nstring = n.ToString();
            //create new string
            string newstring = "";
            //foreach char in string, convert to int, square, convert to string, add to string
            foreach (var l in nstring)
            {
                string m = l.ToString();
                int x = Convert.ToInt16(m);
                int z = x * x;
                newstring = newstring + z.ToString();
            }
            //convert new string to int, return value
            Int32 ans = Convert.ToInt32(newstring);
            return ans;
        }
    }


    public class LongestConsecutives
    {

            public static void LongestConsec(string[] strarr, int k)
            {
            int n = strarr.Count();
            if (n == 0 || n < k || k <= 0)
            { Console.WriteLine("null");
                Console.ReadLine();
            }
            else { 
            
                string bar = "";
               
                foreach (string str in strarr)
                {
                    Int32 length = strarr.Count();
                    Int32 index = Array.IndexOf(strarr, str);
                    Int32 range = k;
                    if (length < index + range) { range = 0; }
                    string result = String.Join("", strarr, index, range);
                        if (result.Count() > bar.Count())
                        { bar = result; }
                    
                }

                Console.WriteLine(String.Join(", ", strarr) + " " + k + ", " + n);
                Console.WriteLine(bar);
                Console.ReadLine();
            }
        }
    }
}
