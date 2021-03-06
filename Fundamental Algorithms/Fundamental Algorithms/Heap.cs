﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Algorithms
{
    class Heap
    {
        public static void HeapSort(int[] input)
        {
            Console.WriteLine("HEAP SORT");
            Console.WriteLine("Unsorted array " + string.Join(",", input));
            int heapSize = input.Length;
            BuildMaxHeap(input,heapSize);

            for (int i = input.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
            Console.WriteLine("Sorted array " + string.Join(",", input));
        }

        private static void BuildMaxHeap(int[] input, int heapSize)
        {
            //Build-Max-Heap
            for (int i = (heapSize - 1) / 2; i >= 0; i--)
            {
                MaxHeapify(input, heapSize, i);
            }
        }

        private static void MaxHeapify(int[] input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }
    }
}
