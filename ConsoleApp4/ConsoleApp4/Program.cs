using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int count = 0;
            int count2 = 0;
            while (count < 5)
            {
                names[count] = Console.ReadLine();
                count = count + 1;
            }
            while (count2 < 5)
            {
                Console.WriteLine("hello " + names[count2]);
                count2 = count2 + 1;
            }
            Console.ReadKey();
        }
    }
}
