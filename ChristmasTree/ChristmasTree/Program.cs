using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 6;

            for (int r = 0; r <= max; r++)
            {
                for (int c = 0; c <= r; c++)
                {
                    //char spacesAdded = ' ';
                    string starsAdded = "*";
                    string spaces = " ";
                    Console.Write(spaces.PadLeft(2));
                    Console.Write(starsAdded.PadLeft(2));
                }
               Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
