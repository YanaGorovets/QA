using System;

namespace AQA_02_example_11__new
{
    public class Overload
    {

        public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }

        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The two integers " + x + " " + y);
        }

        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine("parameterArray");
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
