using System;

namespace AQA_02__example_7__new
{
    public class Overload
    {
        public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }

        private void DisplayOverload(int a, params int[] parameterArray)//the compiler does not understand which method to call
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }

        private void DisplayOverload(int a, params string[] parameterArray)//the compiler does not understand which method to call
        {
            foreach (var i in parameterArray)
                Console.WriteLine(i + " " + a);
        }

        /*private void DisplayOverload(int a, params string[][] parameterArray) { }

        private void DisplayOverload(int a, params string[,] parameterArray)// The parameter array must be a single dimensional array { }*/
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
