using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prcent;
            Console.WriteLine("Введите вклад: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum < 200 && sum > 100)
            {
                prcent = 0.07;
            }
            else if (sum > 200)
            {
                prcent = 0.1;
            }
            else
            {
                prcent = 0.05;
            }
            Console.WriteLine($"Общая сумма с начисленными процентами: {sum + sum * prcent}");
            Console.ReadKey();
        }
    }
}
