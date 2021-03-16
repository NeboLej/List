using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace List.Tests
{
    class ArrayListTests
    {
        [TestCase()]
        public void Test1(int value)
        {
            ArrayList expected = new ArrayList();
            ArrayList actual = new ArrayList();

            Assert.AreEqual(expected, actual);
        }
    }
}
