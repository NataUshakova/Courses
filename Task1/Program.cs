using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool c;
            int a, b;
            do {
                c = false;
                Console.Write("Enter the length of the rectangle: ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                b = Int32.Parse(Console.ReadLine());
                if (a <= 0 || b <= 0)
                {
                    c = true;
                    Console.WriteLine("Invalid values. Please enter the values again");

                }
            }
            while (c);
            Console.Write("Area of the rectangle is {0}.", a*b);
            
            Console.Read();
            return;
        }
    }
}
