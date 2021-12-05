using System;

namespace AQA_02__example_6__new
{
    public class Overload
    {
        public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
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
