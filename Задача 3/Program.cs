using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10; //= требуемое кол-во ячеек в массиве
            const int razd = 5; //= до какой ячейки увеличивать, а потом уменьшать
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < razd-1; i++)
            {
                for (int j = i+1; j < razd; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }

                }
            }
            for (int i = razd; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[i])
                    {
                        int t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
