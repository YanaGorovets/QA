using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SimpleAlgorithmsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("N man:");
            PrintList(list);
            bool delete = false;
            while (list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (delete) list.RemoveAt(i--);
                    delete = !delete;
                }
                PrintList(list);
            }
            Console.Read();

        }
        static void PrintList(IEnumerable<int> list)
        {
            Console.WriteLine("iteration with deletion:");
            foreach (var i in list)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }
    }
}
