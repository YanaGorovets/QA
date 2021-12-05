using System;

namespace AQA_02_example_10__new
{
    public class Overload
    {
        public void Display()
        {
            int number = 102;
            DisplayOverload(40, 1000, number, 4000);
            Console.WriteLine(number);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.Display();
        }
    }
}
