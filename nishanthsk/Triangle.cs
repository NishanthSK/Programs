using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace triangle
{
    class Program
    {
            static void Main(string[] args)
        {
            double breadth,height,area;
            Console.WriteLine("Enter the Breadth of Triangle. ");
            breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Height of Triangle. ");
            height = Convert.ToDouble(Console.ReadLine());
            double area = (1/2)*breadth*height;
            Console.WriteLine($"The area of Triangle is {area}");
            Console.ReadKey();
        }
    }
}