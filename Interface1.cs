using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public interface A
    {
        void draw();
    }
    public class B : A
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class C : A
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class Interface1
    {
        public static void Main()
        {
            A a;
            a = new B();
            a.draw();
            a = new C();
            a.draw();
        }
    }
}