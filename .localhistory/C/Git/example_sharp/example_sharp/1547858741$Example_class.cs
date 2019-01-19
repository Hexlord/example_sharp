using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_sharp
{
    public class Example_class
    {
        static void Main(string[] args)
        {
        }

        public int Calculate_sum_multiplied(int a, int b, int mul)
        {
            return a + b * mul;
        }

        public string Longest_string(string s1, string s2)
        {
            return s1.Length >= s2.Length ? s1 : s2;
        }
    }
}
