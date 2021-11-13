using System;

namespace AQA_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new arrays:");
            int[] number1 = new int[10] { 1, 34, 78, 37, 90, 55, 100, 30, 37, 88 };
            int[] number2 = new int[10] { 5,80,78,69,55,77,100,45,37,44};
            int[] number3= new int[10];
            int k = 0;
            for (int i = 0; i < number1.Length; i++)
            {
                for (int j = 0; j < number2.Length; j++)
                    if (number1[i] == number2[j])
                    {
                        number3[k] = number1[i];
                        Console.Write(" " + number3[k]);
                        k++;
                    }
            }
        }
    }
}
