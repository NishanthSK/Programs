using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication59
{
    class Program
    {
        static double getVal()
        { 
            return 3.14;
        }
            static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter the radius of circle. ");
            radius = Convert.ToDouble(Console.ReadLine());
            double area = getVal() * radius*radius;
            Console.WriteLine($"The area of circle is {area}");
            Console.ReadKey();
        }
    }
}
