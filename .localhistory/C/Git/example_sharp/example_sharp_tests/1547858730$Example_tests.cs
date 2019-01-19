using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using example_sharp;

namespace example_sharp_tests
{
    [TestClass]
    public class Example_tests
    {
        [TestMethod]
        public void Test_calculate_sum_multiplied()
        {
            Example_class example = new Example_class();

            // make sure (2 + 2) * 2 = 8
            Assert.AreEqual(8,
                example.Calculate_sum_multiplied(2, 2, 2));

            // make sure (2 + 3) * 5 = 25
            Assert.AreEqual(25,
                example.Calculate_sum_multiplied(2, 3, 5));
        }

        [TestMethod]
        public void Test_longest_string()
        {
            Example_class example = new Example_class();

            // make sure it returns longest string
            Assert.AreEqual("BBB",
                example.Longest_string("AA", "BBB"));

            // make sure that even-case result is the first arg
            Assert.AreEqual("Hey",
                example.Longest_string("Hey", "Bro"));
        }
    }
}
