using System;

namespace AQA_02__example_2__new
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

        public void DisplayOverload() { }

        public int DisplayOverload() { }//Type 'Program.Overload' already defines a member called 'DisplayOverload' with the same parameter types
        //the method is not identified by its return type,this is not polymorphism

        static void DisplayOverload(int a) { }//Type 'Program.Overload' already defines a member called 'DisplayOverload' with the same parameter types
        //modifiers like static are also not method-identifying properties

        public void DisplayOverload(int a) { }

        public void DisplayOverload(string a) { }

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
