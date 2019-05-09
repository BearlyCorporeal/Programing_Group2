using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cows_and_bulls
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> digits = new List<string>();
            Random r = new Random();
            string digitstring;
            string digit1;
            string digit2;
            string digit3;
            string digit4;
            
            int done = 0;
            int count = 0;
            int bulls = 0;
            int cows = 0;
            int digit1i = r.Next(0, 10);
            int digit2i = r.Next(0, 10);
            while(digit1i == digit2i)
            {
                digit2i = r.Next(0, 10);
            }
            int digit3i = r.Next(0, 10);
            while (digit1i == digit3i || digit2i == digit3i)
            {
                digit3i = r.Next(0, 10);
            }
            int digit4i = r.Next(0, 10);
            while (digit1i == digit4i || digit2i == digit4i || digit3i == digit4i)
            {
                digit4i = r.Next(0, 10);
            }
            digit1 = digit1i.ToString();
            digit2 = digit2i.ToString();
            digit3 = digit3i.ToString();
            digit4 = digit4i.ToString();
            while (done == 0)
            {
                Console.WriteLine("enter a number");
                while (count < 4)
                {
                    var input = Console.ReadKey();
                    digitstring = input.KeyChar.ToString();
                    digits.Add(digitstring);
                    count = count + 1;
                }
                

                if (digit1 == digits[0])
                {
                    cows = cows + 1;
                }
                if (digit1 == digits[1] || digit1 == digits[2] || digit1 == digits[3])
                {
                    bulls = bulls + 1;
                }
                if (digit2 == digits[1])
                {
                    cows = cows + 1;
                    bulls = bulls - 1;
                }
                if (digit2 == digits[0] || digit2 == digits[2] || digit2 == digits[3])
                {
                    bulls = bulls + 1;
                }
                if (digit3 == digits[2])
                {
                    cows = cows + 1;
                    bulls = bulls - 1;
                }
                if (digit3 == digits[0] || digit3 == digits[1] || digit3 == digits[3])
                {
                    bulls = bulls + 1;
                }
                if (digit4 == digits[3])
                {
                    cows = cows + 1;
                    bulls = bulls - 1;
                }
                if (digit4 == digits[0] || digit4 == digits[1] || digit4 == digits[2])
                {
                    bulls = bulls + 1;
                }
                if(digit1 == digits[0]&&digit2 == digits[1]&&digit3 == digits[2]&& digit4 == digits[3])
                {
                    Console.WriteLine();
                    Console.WriteLine("thats the one");
                    done = 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("you got " + cows + " cows and " + bulls + " bulls");
                    bulls = 0;
                    cows = 0;
                    count = 0;
                    digits.Clear();
                }
            }

            Console.WriteLine("thats the one");
            Console.ReadKey();
        }
    }
}
