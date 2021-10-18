using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public abstract class ClassA
    {
        public int a;
        public void XXX() { }
        abstract public void YYY();
    }

    public class ClassB : ClassA
    {
        //public void YYY() { }
        public override int YYY() 
        {
            base.YYY();//
;        }
    }
     public class Program
    {
        private static void Main(string[] args)
        {
            ClassA classA = new ClassA();//error 
            ClassB classB = new ClassB();
        }
    }
}
