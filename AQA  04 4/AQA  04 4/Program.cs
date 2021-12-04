using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AQA__04_4
{

    interface IPrint
    {
        public void printArray<T>(List<T> number);
    }


    class SimpleNumberComparer : IComparer<int>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            return x - y;
        }
    }


    class StringLenghtComparer : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            return x.Length - y.Length;
        }
    }


    class StringAlphabetComparer : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            return x.CompareTo(y);
        }
    }


    interface Sorter<T>:IPrint
    {
        public void Sort<T>(List<T> number, IComparer<T> comparer);
    }



    public class Insertion<T> :Sorter<T>
    {

        public void Sort<T>(List<T> number, IComparer<T> comparer) 
        {
            int n = number.Count;
            for (int i = 1; i < n; ++i)
            {
                T key = number[i];
                int j = i - 1;
                while (j >= 0 && comparer.Compare(number[j], key) > 0)
                {
                    number[j + 1] = number[j];
                    j = j - 1;
                }
                number[j + 1] = key;
            }
        }

        public void printArray<T>(List<T> number)
        {
            int n = number.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(number[i] + " ");

            Console.Write("\n");
        }
    }


    public class Pancake<T> : Sorter<T>
    {
        public void flip<T>(List<T> arr1, int i)
        {
            for (int pi = 0; pi <= i; pi++, i--)
            {
                T temp = arr1[pi];
                arr1[pi] = arr1[i];
                arr1[i] = temp;
            }
        }

        public int findMax<T>(List<T> arr1, int n, IComparer<T> comparer)
        {
            var result = 0;
            //int mi, i;
            for (int mi = 1; mi <= n; mi++)
            {
                if (comparer.Compare(arr1[mi], arr1[result]) < 0)
                {
                    result = mi;
                }
            }
            return result;
        }

        public void Sort<T>(List<T> arr1, IComparer<T> comparer)
        {
            //int n = arr1.Count;
            for (int curr_size = arr1.Count-1; curr_size >= 0; curr_size--)
            {
                var mi = findMax(arr1, curr_size, comparer);
                if (mi != curr_size )
                {
                    flip(arr1, mi);
                    flip(arr1, curr_size);
                }
            }
        }

        public void printArray<T>(List<T> number)
        {
            int n = number.Count;
            for (int i = 0; i < n; ++i)
                Console.Write(number[i] + " ");

            Console.Write("\n");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Insertion Sort
            List<int> numbers = new List<int>() { 2, 45, 78, 45, 33, 56, 78, 304 };
            //Insertion<int> ob = new Insertion<int>();
            Sorter<int> ob = new Pancake<int>();

            Console.WriteLine("Array1 :");
            ob.printArray(numbers);
            ob.Sort(numbers, new SimpleNumberComparer());
            Console.WriteLine("Insertion Sort Array :");
            ob.printArray(numbers);

            //Pancake Sort
            List<string> numbers1 = new List<string>() { "fghr", "tyu", "ghjrr", "yana", "igoriop", "olegt", "gl", "o" };
            Sorter<string> ob1 = new Pancake<string>();

            Console.WriteLine("\n" + "Array2 :");
            ob1.printArray(numbers1);
            ob1.Sort(numbers1, new StringLenghtComparer());
            Console.Write("Pancake Sort Array: "+ "\n");
            ob1.printArray(numbers1);
        }
    }
}

