using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("how many?");
            string input;
            int pin;
            input = Console.ReadLine();
            pin = int.Parse(input);
            int counter = 0;
            while (counter < 9999)
            {
                Console.WriteLine(name);
                counter = counter + 1;
                if (counter == pin)
                {
                   
                    counter = 9999;

                }
                    

            }
            Console.ReadKey();
        }
        
    }
}
