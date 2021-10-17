using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{

   private class Overload// exapmle 1
    {
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload:{a}");
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload:{a}");
        }
        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload:{a} {b}");
        }
        public void DisplayOverload() { }
        public int DisplayOverload() { }//  error 
        static void DisplayOverload(int a) { }// error
        public void DisplayOverload(int a) { }// error
        public void DisplayOverload(string a) { }//error
        public void DisplayOverload(int a)// error
        {
            Console.WriteLine($"DisplayOverload:{a}");
        }
        private void DisplayOverload(out int a)
        {
            a = 100;
        }
        private void DisplayOverload(ref int a) { }//error

        public void DisplayOverload(int a, string a) { }//error
        public void Display(int a) { string a; }//error  
    }



    private class Overload// example 2
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


    public class Overload// example 3
    {
        public void Display()
        {
            DisplayOverload(100, "Akhil", "Mittal", "OOP");
            DisplayOverload(200, "Akhil");
            DisplayOverload(300);
        }
        private void DisplayOverload(int a,params string[] parameterArray)
        {
            foreach (string str in parameterArray)
                Console.WriteLine(str + " " + a);
        }
    }


    public class Overload//example 4
    {
        public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }
        private void Display void DisplayOverload(int a, params int [] parameterArray)
        {
            foreach (var i:int in parameterArray)
                Console.WriteLine(int + " " + a);
        }
    }


    public class Overload// example 5
    {
        public void Display()
        {
            DisplayOverload(100, 200, 300);
            DisplayOverload(200, 100);
            DisplayOverload(200);
        }
        private void DisplayOverload(int a, params int[] paramererArray)//the compiler does not understand which method to call
        {
            foreach (var i:int in parameterArray)
                Console.WriteLine(int + " " + a);
        }
        private void DisplayOverload(int a, params string[] parameterArray)//the compiler does not understand which method to call
        {
            foreach (var i:string in parameterArray)
                Console.WriteLine(i + " " + a);
        }
        private void DisplayOverload(int a, params string [][] parameterArray) { }//error
        private void DisplayOverload(int a, params string[,] parameterArray) { }//error
    }


    public class Overload //example 6
    {
        public void Display()
        {
            DisplayOverload(100, "200", "300");
            DisplayOverload(200, "100");
            string names = {"Akhil","Ekta","Arsh");
            DisplayOverload(200, names);
        }
        private void DisplayOverload(int a,params string[] parameterArray)
        {
            foreach (var i:string in parameterArray)
                Console.WriteLine(i + " " + a);
        }
    }

    public class Overload//example 7
    {
        public void Display()
        {
            int[] numbers = { 10, 20, 20 };
            DisplayOverload(40,numbers);
            Console.WriteLine(numbers[1]);
        }
        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }
    }

    public class Overload//example 8
    {
        public void Display()
        {
            int number = 182;
            DisplayOverload(40, 1000, number, 4000);
            Console.WriteLine(number);
        }
        private void DisplayOverload(int a,params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }
    }


    public class Overload//example 9
    {
        public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }
        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The two integers" + x + " " + y);
        }
        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine("parameterArray");
        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();//exapmle 1
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading",100);
            var overload = new Overload();// exapmle 2
            overload.Display();
        }
    }
}
