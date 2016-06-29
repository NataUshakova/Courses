using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void triangle(int N, int center)
        {
            string s = "*".PadLeft(center);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(s);
                s = s.Substring(1) + "**";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please, enter N: ");
            int N = Int32.Parse(Console.ReadLine());
            for (int j = 1; j <= N; j++)
            {
                triangle(j,N);
            }
            Console.Read();
        }
    }
}
