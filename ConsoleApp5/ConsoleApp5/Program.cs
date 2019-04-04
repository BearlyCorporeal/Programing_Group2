using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            string[] values  = new string[10];
            values[0] = "34";
            values[1] = "5";
            values[2] = "67";
            values[3] = "1";
            values[4] = "99";
            values[5] = "34";
            values[6] = "44";
            values[7] = "78";
            values[8] = "34";
            values[9] = "0";
            while ( count < 10)
            {
                sum = sum + int.Parse(values[count]);
                count = count + 1;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
