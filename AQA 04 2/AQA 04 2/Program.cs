using System;
using System.Collections.Generic;
using System.Text;
using AQA_04_2;
namespace AQA_04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(8);
            numbers.Enqueue(3);
            numbers.Enqueue(88);
            numbers.Enqueue(76);
            numbers.Enqueue(100);
            numbers.Enqueue(15);
            numbers.Enqueue(49);
            Console.WriteLine(" Queue:");
            foreach(int num in numbers)
            {
                Console.Write(" " + num);
            }
            int min = numbers.Peek();
            int max = numbers.Peek();
            int sum = 0;
            foreach (int i in numbers)
            {
                if ( min> i)
                    min = i;
                if (max<i)
                    max=i;
            }
            Console.WriteLine("\n min element: " + min + "\n max element: " + max);
            Boolean flag = false;
            Boolean minToMax = false;
            foreach (int i in numbers)
            {
                if (!flag && i == min)
                {
                    flag = true;
                    minToMax = true;
                }
                else if (!flag && i == max)
                    flag = true;
                if (flag == true)
                    sum += i;
                if (minToMax)
                {
                    if (i == max)
                        flag = false;
                }
                else if (i == min)
                    flag = false;
            }
            Console.WriteLine("sum element: " + sum);
        }
    }
}
