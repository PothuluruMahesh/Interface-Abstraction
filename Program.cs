using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        public void SerializationMethod()
        {
            Console.WriteLine("-------------------------------------------");
            
            Console.WriteLine("Serialization means to convert the Object in \n to byte and store the data into any file or any db");
            Console.WriteLine("-------------------------------------------");
        }
        public void DeserializationMethod()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Deserialization means to converting data in \n to byte to object it is revere processes of Serialization");
            Console.WriteLine("-------------------------------------------");
        }
        static void Main(string[] args)
        {
            mahesh ms = new mahiesd();
            ms.multi();
            Program pr = new Program();
            Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            pr.SerializationMethod();
            Console.WriteLine("===========================================");
            pr.DeserializationMethod();
            
        }
    }
    interface mahesh
    {
        void multi();

    }
    interface maheshsh
    {
        void maulllty();
    }
    class mahiesd :mahesh
    {
        public void multi()
        {
            Console.WriteLine("From Multi");
        }
    }
}
