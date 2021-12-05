using System;

namespace AQA_02_3__example_4__new
{
    public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }


    public abstract class ClassB : ClassA
    {
        public new abstract void XXX();
    }


    public class ClassC : ClassB
    {
        public override void XXX()
        {
            System.Console.WriteLine("ClassC XXX");
        }
    }


    class Program
    {
        private void Main(string[] args)
        {
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();
        }
    }
}
