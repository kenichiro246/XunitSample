using ConsoleApp1;
using System;
using Xunit;

namespace ConsoleApp1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var c1 = new Class1();
            Assert.Equal(4, c1.add(1, 3));
        }
        [Fact]
        public void TestMethod2()
        {
            var c1 = new Class1();
            Assert.Equal(2, c1.add(1, 1));
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(3, 1, 2)]
        //[InlineData(2147483648, 1, int.MaxValue)]
        public void TestMethod3(int ans, int x, int y)
        {
            var c1 = new Class1();
            Assert.Equal(ans, c1.add(x, y));
        }

        [Fact]
        public void TestMethod4()
        {
            var c1 = new Class1();
            Assert.Equal(-2147483648, c1.add(1, int.MaxValue));
        }

        [Fact]
        public void TestMethod5()
        {
            var obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(new Class1());
            var actual = obj.Invoke("getDisplayName") as string;
            Assert.Equal("ConsoleApp1.Class1: Hello", actual);
        }
        [Fact]
        public void TestMethod6()
        {
            var obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(new Class1());
            var actual = obj.Invoke("addAndZeroFormat", 10, 3) as string;
            Assert.Equal("0000013", actual);
        }
    }
}
