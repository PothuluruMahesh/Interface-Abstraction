using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
   interface Calculator1
    {
        void Add(double i, double j);
    }
   interface Calculator2
    {
        void Sub(double i, double j);
    }
   interface Calculator3  
    {
        void Multi(double i, double j); 
    }
   interface Calculator4 
    {
        void Div(double i, double j);
    }
   public abstract class Calculator5 :Calculator4, Calculator3, Calculator2, Calculator1
    {
        public void Add(double i, double j)
        {
            double c = i + j;
            Console.WriteLine("The Addition is : " + c);
        }
        public void Sub(double i, double j)
        {
            double c = i - j;
            Console.WriteLine("The Substraction is : " + c);
        }
        public abstract void Multi(double i, double j);
        public abstract void Div(double i, double j);
    }
    public class Calculator : Calculator5
    {
        public override void Multi(double i, double j)
        {
            double c = i * j;
            Console.WriteLine("The Multiplication is : " + c);
        }
        public override void Div(double i, double j)
        {
            double c = i / j;
            Console.WriteLine("The Substraction is : " + c);
        }
        static void Main(string[] args)
        {
            TOP:
            Calculator obj = new Calculator();
            try
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("*****WecoMe tO oUr CalCulAtoR****");
                Console.WriteLine("*********************************");
                Console.WriteLine("Enter First Number :");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Second Number :");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Which Operation do you want perform like (- , + , * , /)");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case '+':
                        obj.Add(a, b);
                        break;

                    case '-':
                        obj.Sub(a, b);
                        break;

                    case '*':
                        obj.Multi(a, b);
                        break;

                    case '/':
                        obj.Div(a, b);
                        break;

                    default:
                        Console.WriteLine("You Entered Wrong Arithmetic Operent");
                        break;
                }

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
               
                Console.WriteLine("============================");
                Console.WriteLine("If you Want to continue then enter (Y/y) otherwise Enter (N)");
                char choice = Convert.ToChar(Console.ReadLine());
                if(choice == 'Y' || choice == 'y')
                {
                    goto TOP;
                }
                else
                {
                    Console.WriteLine("Thank You for Using !");
                }

        
        }
    }
}
