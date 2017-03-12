using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsorted = { 23, 12, 1, 56, 76, 3, 21, 110 };

            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
                Console.Write(unsorted[i] + " ");

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
                Console.Write(unsorted[i] + " ");

            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2]; //setze pivot in die mitte
            int tmp = 0;

            while (i <= j)
            {
                while (elements[i] < pivot) //suche ein Element auf der linken Seite, das nicht nach links gehört
                    i++;

                while (elements[j]  > pivot) //suche ein Element auf der rechten Seite, das nicht nach rechts gehört
                    j--;

                if (i <= j)
                {
                    // Swap
                    tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
                Quicksort(elements, left, j);

            if (i < right)
                Quicksort(elements, i, right);
        }

    }
}
