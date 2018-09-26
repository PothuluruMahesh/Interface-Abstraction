using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    interface Kadapa1
    {
       
        void Run();
    }
    interface Tirupati1
    {
        void Run();
    }
    class State1 : Kadapa1, Tirupati1
    {
         void Kadapa1.Run()
        {
            Console.WriteLine("From Run(Kadapa1) Method");
        }
       void Tirupati1.Run()
        {
            Console.WriteLine("From Run(Tirupati) Method");
        }
    }
    public class Abstract6
    {
        static void Main(string[] args)
        {
            Kadapa1 ka = new State1();
            ka.Run();
            Tirupati1 tr = new State1();
            tr.Run();
        }
    }
}
