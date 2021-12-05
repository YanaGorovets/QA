using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQA_02_3__example_3__new
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            b.Display2();//‘InheritanceAndPolymorphism.ClassB’ does not contain a definition for ‘Display2’ and no extension method ‘Display2’ accepting a first
                         //argument of type ‘InheritanceAndPolymorphism.ClassB’ could be found(are you missing a using directive or an assembly reference ?
        }
    }


    class ClassB
    {
        public int x = 100;
        public void Display1()
        {
            Console.WriteLine("ClassB Display1");
        }
    }


    class ClassA: ClassB
    {
        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }
    }
}
