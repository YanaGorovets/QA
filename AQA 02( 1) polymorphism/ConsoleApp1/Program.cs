using System;

namespace ConsoleApp1
{
    public class Overload
    {
        public void Display()
        {
            DisplayOverload(100, "200", "300");
            DisplayOverload(200, "100");
            string[] names = { "Akhil", "Ekta", "Arsh" };
            DisplayOverload(200, names);
            //DisplayOverload(200, names, "Akhil");    Argument 2: cannot convert from 'string[]' to 'string
        }

        private void DisplayOverload(int a, params string[] parameterArray)
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
