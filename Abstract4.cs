using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    abstract class Abstract4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter A and B Numbers");
                int i = Convert.ToInt32(Console.ReadLine());
                int j = Convert.ToInt32(Console.ReadLine());
                int c = i / j;
                Console.WriteLine("The result is :" + c);
            }
            catch(Exception ex )
            {
                if(ex is DivideByZeroException || ex is FormatException)
                {
                    Console.WriteLine("Plz Give Input Properly Zero And String Not Accept type");
                    return;
                }

            }
        }
    }
}
