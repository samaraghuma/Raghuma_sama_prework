using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raghuma_sama_prework
{
    class Program
    {
        static void Main(string[] args)
        {
            int urNum;

            int urdigits;
            Console.Write(" Enter a number to reverse: ");
            urNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Reversed Number: ");

            do
            {

                urdigits = urNum % 10;

                Console.Write(urdigits);

                urNum = urNum / 10;

            } while (urNum > 0);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
