using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class Seriali1
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"F:\JAVA\C#\Serialization\student.exe", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student(101, "MAHESH");
            formatter.Serialize(stream, s);

            stream.Close();
            Console.WriteLine("File created and stored the student data !successfully");
        }
    }
}
