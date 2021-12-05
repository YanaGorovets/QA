using System;

namespace AQA_02__example_5__new
{
    public class Overload
    {

        public void Display()
        {
            DisplayOverload(100, "Akhil", "Mittal", "OOP");
            DisplayOverload(200, "Akhil");
            DisplayOverload(300);
        }

        private void DisplayOverload(int a, params string[] parameterArray)
        {
            foreach (string str in parameterArray)
                Console.WriteLine(str + " " + a);
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
