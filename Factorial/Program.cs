using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculateFact(5));
            Console.WriteLine(calculateFactLoop(5));
            Console.ReadKey();
        }

        private static int calculateFact(int num) {
            return (num - 1 > 0) ? num *= calculateFact(num - 1) : 1;
        }

        private static int calculateFactLoop(int num)
        {
            for (int i = num-1; i > 0; i--) { num *= i; }
            return num;
        }
    }
}
