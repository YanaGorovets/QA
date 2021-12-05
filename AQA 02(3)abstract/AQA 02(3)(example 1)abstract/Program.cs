using System;

namespace AQA_02_3_abstract
{
    public abstract class ClassA
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassA();//We cannot instantiate abstract class using the new keyword
        }
    }
}
