using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int beginning;
            int final;
            string enterNumber;

            Console.WriteLine("尋找質數\n");

            do
            {
                Console.Write("請輸入起始數字：");
                enterNumber = Console.ReadLine();
                beginning = prise(enterNumber);

                Console.Write("請輸入結束數字：");
                enterNumber = Console.ReadLine();
                final = prise(enterNumber);

                Console.WriteLine("");

                if (beginning > final)
                {
                    Console.WriteLine("起始數字不能比結束數字大，請重新輸入。\n");
                }
            } while (beginning > final);

            primeCheck(beginning, final);
        }

        private static int prise(string number)
        {
            int correctNumber = 0;
            bool tryPrise = false;

            do
            {
                tryPrise = int.TryParse(number, out correctNumber);

                if (tryPrise == false)
                {
                    Console.Write("輸入錯誤，請輸入重新輸入： ");
                    number = Console.ReadLine();
                }
            } while (tryPrise == false);

            return correctNumber;
        }

        private static void primeCheck(int min, int max)
        {
            Console.WriteLine("從{0}到{1}的質數有： ", min, max);

            for (int count = min; count != max; count++)
            {
                if (prime(count) == true)
                {
                    Console.WriteLine("{0}", count);
                };
            }
        }

        private static bool prime(int number)
        {
            switch (number)
            {
                case 0:
                    return false;

                case 1:
                    return false;

                case 2:
                    return true;

                case 3:
                    return true;
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 5; i * i <= number; i += 2)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}