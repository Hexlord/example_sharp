using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_sharp
{
    class Example_class
    {
        static void Main(string[] args)
        {
        }

        public int calculate_sum_multiplied(int a, int b, int mul)
        {
            return (a + b) * mul;
        }

        public string longest_string(string s1, string s2)
        {
            return s1.Length >= s2.Length ? s1 : s2;
        }
    }
}
