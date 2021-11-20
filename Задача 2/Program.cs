using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15; //или заменить на требуемое кол-во ячеек в массиве
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int x in array)
            {
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }
            Console.WriteLine("Максимальное значение - {0}, минимальное - {1}", max, min);
            Console.WriteLine("Сумма максимального и минимального значений - {0}", max + min);
            Console.ReadKey();
        }
    }
}
