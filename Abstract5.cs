using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    interface Kadapa
    {
        void Run();
    }
    interface Tirupati
    {
        void Run();
    }
    class State :Kadapa,Tirupati
    {
        public void Run()
        {
            Console.WriteLine("From Run() Method");
        }
    }
    public class Abstract5
    {
        static void Main(string[] args)
        {
            Kadapa ka = new State();
            ka.Run();
            Tirupati tr = new State();
            tr.Run();

        }
    }
}
