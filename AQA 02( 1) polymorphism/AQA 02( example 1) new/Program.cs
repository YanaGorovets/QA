using System;
namespace AQA_02__exaple_1__new
{
    private class Overload// does not work since the access modifier is private and not public
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload:{a}");
        }

        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload:{a}");
        }

        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload:{a} {b}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);
        }
    }
}
