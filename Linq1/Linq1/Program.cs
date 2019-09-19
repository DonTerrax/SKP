using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            OddNumbers(number);
            Console.WriteLine();
            EvenNumbers(number);
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers ");
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);

            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
        
        static void EvenNumbers(int[] numbers)
        {
            Console.WriteLine("Even Numbers ");
            IEnumerable<int> EvenNumbers = from number in numbers where number % 1 != 0 select number;
            Console.WriteLine(EvenNumbers);

            foreach (int i in EvenNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
