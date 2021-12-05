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

        /*public void DisplayOverload() { }
        public int DisplayOverload() { }//Type 'Program.Overload' already defines a member called 'DisplayOverload' with the same parameter types
        //the method is not identified by its return type,this is not polymorphism
        static void DisplayOverload(int a) { }//Type 'Program.Overload' already defines a member called 'DisplayOverload' with the same parameter types
        //modifiers like static are also not method-identifying properties
        public void DisplayOverload(int a) { }
        public void DisplayOverload(string a) { }*/
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload:{a}");
        }

        private void DisplayOverload(out int a)//'Program.Overload' cannot define an overloaded method that differs onlyon parameter modifiers 'ref' and 'out'
        {
            a = 100;
        }

        private void DisplayOverload(ref int a) { }//'Program.Overload' cannot define an overloaded method that differs only on parameter modifiers 'ref' and 'out'
        //Two methods with the same identifier cannot exist

        public void DisplayOverload(int a, string a) { }//The parameter name ‘a’ is a duplicate

        public void Display(int a) { string a; }//A local variable named ‘a’ cannot be declared in this scope because it would give a different meaning to ‘a’, which is already used in a ‘parent orcurrent’ scope to denote something else
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

