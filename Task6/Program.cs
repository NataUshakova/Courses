using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Параметры надписи: None");
            string ex = "y";
            bool bold = false;
            bool italic = false;
            bool underline = false;
            while (ex == "y")
            {
                Console.WriteLine("Введите:\n \t 1: bold\n \t 2: italic\n \t 3: underline");
                int val = Int32.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        bold = !bold;
                        break;
                    case 2:
                        italic = !italic;
                        break;
                    case 3:
                        underline = !underline;
                        break;
                    default:
                        Console.WriteLine("Введите цифру от 1 до 3!");
                        break;
                }
                Console.Write("Параметры надписи: ");
                if (!bold && !italic && !underline)
                {
                    Console.Write("None ");
                }
                if (bold)
                {
                    Console.Write("Bold ");
                }
                if (italic)
                {
                    Console.Write("Italic ");
                }
                if (underline)
                {
                    Console.Write("Underline ");
                }
                Console.WriteLine();
                Console.WriteLine("Повторить? (y/n)");
                ex = Console.ReadLine();
            }
        }
    }
}
