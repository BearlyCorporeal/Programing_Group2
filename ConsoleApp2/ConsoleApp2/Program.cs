using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int space = 0;
            int spacecounter = 0;
            int xamount = 11;
            int xamountcount = 0;
            while (counter < 6)
            {
                while (spacecounter <= space)
                {
                    spacecounter = spacecounter +1;
                    Console.Write(" ");
                }
                spacecounter = 0;
                space = space + 1;
                while (xamount > xamountcount)
                {
                    xamountcount = xamountcount + 1;
                    Console.Write("x");
                    
                }
                xamountcount = 0;
                xamount = xamount - 2;
                Console.WriteLine();
                counter = counter + 1;
            }
            Console.ReadKey();

        }
    }
}
