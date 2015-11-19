using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99multiplicatio_table
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int row = 1; row <= 9; row++)
            {
                for (int Column = 1; Column <= 9; Column++)
                {
                    Console.Write("{0}x{1}", row, Column);
                    Console.Write("={0} ", row * Column);

                    if (Column != 9)
                    {
                    }
                    else
                    {
                        Console.WriteLine("");
                    };
                }
            };
        }
    }
}