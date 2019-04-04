using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many lines");
            string input;
            int inputnumber;
            int counter = 0;
            int space = 0;
            int spacecounter = 0;
            int xamount = 0;
            int xamountcount = 0;
            input = Console.ReadLine();
            inputnumber = int.Parse(input);
            while (counter < inputnumber)
            {
                counter = counter + 1;
                space = inputnumber - counter;
                if (counter == 1)
                {
                    xamount = counter;
                    space = inputnumber - 1;
                }
                else
                {
                    xamount = ((counter + 1)*2) - 3;
                    space = inputnumber - counter;
                }
                while(spacecounter < space)
                {
                    spacecounter = spacecounter + 1;
                    Console.Write(" ");
                }
                spacecounter = 0;
                while (xamountcount < xamount)
                {
                    xamountcount = xamountcount + 1;
                    Console.Write("x");
                }
                xamountcount = 0;
                Console.WriteLine();
               

            }
            Console.ReadKey();
        }
    }
}
