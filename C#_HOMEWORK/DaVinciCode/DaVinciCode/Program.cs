using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinciCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int guessNumber = 0;
            int playerGuessNumber = 0;
            string playerGuessNumber_string;
            int maxNumber = 100;
            int minNumber = 0;
            int count = 0;
            bool intCheck;

            Random random = new Random();
            guessNumber = random.Next(1, 101);

            //Console.WriteLine(guessNumber);

            do
            {
                do
                {
                    do
                    {
                        Console.Write("請輸入{0}~{1}的數字：", minNumber, maxNumber);
                        playerGuessNumber_string = Console.ReadLine();
                        intCheck = int.TryParse(playerGuessNumber_string, out playerGuessNumber);
                    } while (intCheck == false);
                } while (playerGuessNumber <= minNumber && playerGuessNumber > maxNumber);
                if (playerGuessNumber > guessNumber)
                {
                    Console.WriteLine("再猜小一點！");
                    if (maxNumber > playerGuessNumber)
                    {
                        maxNumber = playerGuessNumber;
                    }
                }
                else if
                    (playerGuessNumber < guessNumber)
                {
                    Console.WriteLine("再猜大一點！");
                    if (minNumber < playerGuessNumber)
                    {
                        minNumber = playerGuessNumber;
                    }
                }
                else if
                    (playerGuessNumber == guessNumber)
                {
                    Console.WriteLine("Bingo！！！");
                    Console.WriteLine("你總共猜了：{0}", count);
                }
                count++;
            } while (playerGuessNumber != guessNumber);
        }
    }
}