using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Deserialization
    {
        static void Main(string[] args)
        {
            
            FileStream fs = new FileStream(@"F:\JAVA\C#\Serialization\serialize.exe", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            ByteCode bcde = (ByteCode)format.Deserialize(fs);
            Console.WriteLine("Id is :" + bcde.Zeros);
            Console.WriteLine("IP Address is :" + bcde.Ones);
            Console.WriteLine("Name is :" + bcde.Data);
        }
    }
    
}
