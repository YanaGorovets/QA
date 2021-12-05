using System;

namespace AQA_02_2_inheritance
{
    class ClassA { }


    class ClassB
    {
        public int x = 100;
        public void Display1()
        {
            Console.WriteLine("ClassB Display1");
        }

        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Display1(); //'ClassA' does not contain a definition for 'Display1' and no accessible extension method 'Display1' accepting a first argument of type 'ClassA' could be found(are you missing a using directive or an assembly reference ?
        }
    }
}
