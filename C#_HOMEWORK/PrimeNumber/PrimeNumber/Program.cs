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
            int beginning = 0;
            int final = 1;
            string enterNumber;

            Console.WriteLine("尋找質數");
            Console.Write("請輸入起始數字：");
            enterNumber = Console.ReadLine();
            beginning = prise(enterNumber);

            Console.Write("請輸入結束數字：");
            enterNumber = Console.ReadLine();
            final = prise(enterNumber);

            if (beginning < final)
            {
                Console.Write("輸入錯誤請重新輸入");
            }

            primeCheck(beginning, final);
        }

        private static int prise(string number)
        {
            int correctNumber = 0;
            bool tryPrise;

            do
            {
                tryPrise = int.TryParse(number, out correctNumber);

                if (tryPrise == false)
                {
                    Console.WriteLine("輸入錯誤，請輸入重新輸入");
                    number = Console.ReadLine();
                }
            } while (tryPrise == false);

            return correctNumber;
        }

        private static void primeCheck(int min, int max)
        {
            bool isPrime = true;

            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17 };

            Console.WriteLine("輸入錯誤，請輸入重新輸入");
        }
    }
}