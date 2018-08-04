using System;
using Xunit;

namespace ConsoleApp1.TestStd
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var c1 = new Class1();
            Assert.Equal(4, c1.add(1, 3));
        }
    }
}
