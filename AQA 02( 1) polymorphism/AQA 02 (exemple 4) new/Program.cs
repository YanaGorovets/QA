using System;

namespace AQA_02__exemple_4__new
{
    public class Overload
    {
        private string name = "Akhil";

        public void Display()
        {
            Display2(ref name, ref name);
            Console.WriteLine(name);
        }

        private void Display2(ref string x, ref string y)
        {
            Console.WriteLine(name);
            x = "Akhil 1";
            Console.WriteLine(name);
            y = "Akhil 2";
            Console.WriteLine(name);
            name = "Akhil 3";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.Display();
        }
    }
}
