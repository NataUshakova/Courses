using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter N: ");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            Console.Read();

            return;
        }
    }
}
