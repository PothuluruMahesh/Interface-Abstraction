using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    abstract class Abstract1
    {
        public abstract void Test2();
        public void Test()
        {
            Console.WriteLine("From Abstrct1.Test()");
        }
        public static void Test1()
        {
            Console.WriteLine("From Static Abstrct1.Test()");
        }
        public static int i = 1000;
        public static string name = "mahesh";
        public int j = 120;
        public string name1 = "maheshs";//it requerd object
        public Abstract1()
        {
            Console.WriteLine("I Am From Constructor()");
        }
        static void Main(string[] args)
        {
            //Abstract1 obj = new Abstract1(); we can not create Object to abstrct and interface
            Test1();
            Console.WriteLine("The Id is :"+i);
            Console.WriteLine("The Name is "+name);
            Console.WriteLine("Hello World!");
            
        }
    }
}
