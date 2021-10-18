using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism.Properties
{
    public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }
    public abstract class ClassB:ClassA
    {
        public new abstract void XXX();
    }
    public class ClassC:ClassB
    {
        public override void XXX()
        {
            System.Console.WriteLine("ClassC XXX");
        }
    }
    public class Program
    {
        private static void Main(string [] args)
        {
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();
        }
    }
}
