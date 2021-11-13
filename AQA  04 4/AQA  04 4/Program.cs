using System;
using System.Collections.Generic;

namespace AQA__04_4
{
    interface IPrint
    {
        void printArray<T>(List<T> number);
    }
    public class Insertion<T> : IPrint
    {
        public void Sort<T>(List<T> number) // where T : Int32 // ????
        {
            int n = number.Count;
            for (int i = 1; i < n; ++i)
            {
                T key = number[i];
                int j = i - 1;
                while (j >= 0 && number[j] > key) /////////////////////// ????
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

    public class Pancake<T>
    {
        public void flip<T>(List<T> arr1, int i)
        {
            T temp;
            int start = 0;
            while (start < i)
            {
                temp = arr1[start];
                arr1[start] = arr1[i];
                arr1[i] = temp;
                start++;
                i--;
            }
        }
        public int findMax<T>(List<T> arr1, int n)
        {
            int mi, i;
            for (mi = 0, i = 0; i < n; ++i)
                if (arr1[i] > arr1[mi]) //////////////////////////////// ????
                    mi = i;

            return mi;
        }
        public void pancakeSort<T>(List<T> arr1)
        {
            int n = arr1.Count;
            for (int curr_size = n; curr_size > 1; --curr_size)
            {
                int mi = findMax<T>(arr1, curr_size);
                if (mi != curr_size - 1)
                {
                    flip<T>(arr1, mi);
                    flip<T>(arr1, curr_size - 1);
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
            Insertion<int> ob = new Insertion<int>();

            Console.WriteLine("Array1 :");
            ob.printArray(numbers);
            ob.Sort(numbers);
            Console.WriteLine("Insertion Sort Array :");
            ob.printArray(numbers);

            //Pancake Sort
            List<string> numbers1 = new List<string>() { "", "45", "78", "45", "33", "56", "78", "304" };
            Pancake<string> ob1 = new Pancake<string>();

            Console.WriteLine("\n" + "Array2 :");
            ob1.printArray(numbers1);
            ob1.pancakeSort(numbers1);
            Console.Write("\n" + "Pancake Sort Array: ");
            ob1.printArray(numbers1);
        }


    }
}

