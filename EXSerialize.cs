using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Address
    {
        public int Id;
        public string Name;
        public Address(int i,string j)
        {
            this.Id = i;
            this.Name = j;
        }
    }
    public class EXSerialize
    {
        static void Main(string[] args)
        {
            /*
            Address add = new Address(101, "Mahesh");
            FileStream fs = new FileStream(@"F:\JAVA\C#\Serialization\mahesh.exe", FileMode.OpenOrCreate);
            BinaryFormatter farm = new BinaryFormatter();
            farm.Serialize(fs,add);
            fs.Close();
            Console.WriteLine("Data Successfully Stored");
            */
            FileStream fs = new FileStream(@"F:\JAVA\C#\Serialization\mahesh.exe", FileMode.OpenOrCreate);
            BinaryFormatter farm = new BinaryFormatter();
            Address add = (Address)farm.Deserialize(fs);
            Console.WriteLine("The Data Is :" +add.Id+"--"+add.Name);
            Console.WriteLine("Data Successfully Retrived");
        }
    }
}
