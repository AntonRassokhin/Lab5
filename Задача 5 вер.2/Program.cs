using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5_вер._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк=столбцов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = 1 - (i + j) % 2; //вот это выражение мне подсказали :-)
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
