using System;

namespace AQA_02_2_inheritance
{
    class ClassA : ClassB
    {
        public void Display1()
        {
            Console.WriteLine("ClassA Display1");
        }
    }


    class ClassB
    {
        public int x = 100;
        public void Display()
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
            a.Display1(); 
        }
    }
}
