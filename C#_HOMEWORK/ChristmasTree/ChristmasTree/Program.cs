using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int floor;
            string enterNumber;
            Console.Write("聖誕樹要幾層：");
            start:
            enterNumber = Console.ReadLine();

            if (Int32.TryParse(enterNumber, out floor))
            {
                //Console.WriteLine("{0}", floor);
                //Console.WriteLine("{0}", enterNumber);

                //蓋幾層
                for (int dofloor = 0; dofloor < floor; dofloor++)
                {
                    //吐幾個空格
                    for (int space = 0; space < (floor - dofloor - 1); space++)
                    {
                        Console.Write(" ");
                    }
                    //吐幾個星星
                    for (int star = 0; star <= (dofloor * 2); star++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("請重新輸入");
                goto start;
            }
        }
    }
}