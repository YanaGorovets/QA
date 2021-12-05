using System;

namespace AQA_02_3__example_2__new
{
    public abstract class ClassA
    {

        public int a;
        public void XXX() { }
        abstract public void YYY();
    }


    public class ClassB : ClassA // 'ClassB' does not implement inherited abstract member ' ClassA.YYY()'
    {
        public void YYY() { }
    }


    public class Program
    {
        private static void Main(string[] args)
        {
            ClassB classB = new ClassB();
        }
    }
}
