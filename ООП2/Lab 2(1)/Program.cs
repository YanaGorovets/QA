using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{ 
    class ClassA :ClassB//example 1
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

    class ClassB//example 2
    {
        public int x = 100;
        public void Display1()
        {
            Console.WriteLine("ClassB Display1");
        }
    }

    class ClassA
    {
        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();//example 1
            a.Display1();
            ClassB b = new ClassB();//example 2
            b.Display2();
        }
    }
}
