using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSortingAlgorithms();
            Console.ReadKey();
        }
        public static void TestSortingAlgorithms()
        {
            int[] unsortedArray = GenerateArrayOfRandomNumbers();
            Heap.HeapSort(unsortedArray);
        }
        public static int[] GenerateArrayOfRandomNumbers()
        {
            int Minimum = 0;
            int Maximum = 9999;
            Random randNum = new Random();
            int[] randomNumArray = Enumerable
                .Repeat(0, 10)
                .Select(i => randNum.Next(Minimum, Maximum))
                .ToArray();
            return randomNumArray;
        }
    }
}
