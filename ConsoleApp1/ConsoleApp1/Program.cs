using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adj meg egy szamot tesa");
            int a =int.Parse( Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
