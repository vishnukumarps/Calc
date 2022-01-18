using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int Sum;
            string name;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine( "Enter 1 num" );
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 num");
            b = Convert.ToInt32(Console.ReadLine());
            Sum = a + b;
            // Console.Write("Sum=");
            //Console.Write(Sum);

            Console.WriteLine("Sum      {0}",Sum);
            Console.WriteLine("{0} + {1}   =   {2}     {3}", a,b,Sum,name);
            //Console.WriteLine(name);
            Console.ReadKey();




        }
    }
}
