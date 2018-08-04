using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        private string getDisplayName()
        {
            return "ConsoleApp1.Class1: Hello";
        }

        private string addAndZeroFormat(int x, int y)
        {
            return (x + y).ToString("0000000");
        }

        public double zeroDivide()
        {
            var a = 0;
            return 1 / a;
        }
    }
}
