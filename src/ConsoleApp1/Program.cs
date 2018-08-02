using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ConsoleApp1");
            int a = int.MaxValue;
            Console.WriteLine(a + 1);  //-2147483648
            Console.ReadLine();
        }
    }
}
