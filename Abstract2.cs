using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Abstract2 :Abstract1
    {
        public override void Test2()
        {
            Console.WriteLine("From Abstrct2.Test2()");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main Begine()");
            Abstract1 abs;
            abs = new Abstract2();
            abs.Test();
            abs.Test2();
            Abstract1.Test1();
            Console.WriteLine("From Instannce Varaibles in Abstract1 "+abs.j+"::::::::"+abs.name1);
            Console.WriteLine("From Static Variables in Abstract CLass :" + Abstract1.i + "::::" + Abstract1.name);
            Console.WriteLine("From Main End()");
        }
    }
}
