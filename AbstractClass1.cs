using System;

namespace Serialization
{
    public abstract class AbstrctClass
    {
        public abstract void Test();
    }
    public class Rectangle : AbstrctClass
    {
        public override void Test()
        {
            Console.WriteLine("From  rectangle...");
        }
    }
    public class Circle : AbstrctClass
    {
        public override void Test()
        {
            Console.WriteLine("From circle...");
        }
    }
    public class AbstractClass
    {
        public static void Main()
        {
            AbstrctClass s;
            s = new Rectangle();
            s.Test();
            s = new Circle();
            s.Test();
        }
    }
}