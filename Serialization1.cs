using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Serialization1
    {
        
        static void Main(string[] args)
        {
          
            ByteCode bc = new ByteCode(101, "010:01:1012", "Mahesh");
            FileStream fs = new FileStream(@"F:\JAVA\C#\Serialization\serialize.exe", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(fs, bc);
            fs.Close();
            Console.WriteLine("The data has been store as byte code in file");
           /* 
            Console.WriteLine("Id is :" + bc.Zeros);
            Console.WriteLine("IP Address is :" + bc.Ones);
            Console.WriteLine("Name is :" + bc.Data);
            */
        }
    }
    [Serializable]
    public  class ByteCode
    {
        
        public int Zeros;
        public string Ones;
        public string Data;
        public ByteCode(int i,string j,string k)
        {
            this.Zeros = i;
            this.Ones = j;
            this.Data = k;
        }
    }
}
