using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4_sum_from_one_to_hundred
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double sum = 0;
            string enterNumber;
            int failNumber;
            bool result;

            Console.Write("輸入要加總到數字：");

            do
            {
                enterNumber = Console.ReadLine();
                result = int.TryParse(enterNumber, out failNumber);
                if (result == false)
                {
                    Console.WriteLine("輸入錯誤，請重新輸入");
                };
            } while (result == false);

            sum = ((1 + failNumber) * failNumber) / 2;
            Console.WriteLine("總和為：{0}", sum);
        }
    }
}