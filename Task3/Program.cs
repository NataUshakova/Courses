using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter N: ");
            int N = Int32.Parse(Console.ReadLine());
            string s = "*".PadLeft(N);
            for (int k = 0; k < N; k++)
            {
                Console.WriteLine(s);
                s = s.Substring(1) + "**";
            }
            Console.Read();
            
        }
    }
}
