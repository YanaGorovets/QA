using System;

namespace AQA_02_3__example_3__new
{
    public abstract class ClassA
    {
        public int a;
        public void XXX() { }
        abstract public void YYY();
    }


    public class ClassB : ClassA
    {
        public override int YYY() { }//'ClassB.YYY()':return type must be 'void' to match overridden member 'ClassA.YYY()'
        /*public override void YYY(){
        base.YYY();
        }*/
    }


    public class Program
    {
        private static void Main(string[] args)
        {
            ClassB classB = new ClassB();
        }
    }
}
