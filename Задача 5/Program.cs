using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во строк=столбцов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            int x = 0;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x++;
                    if ((x % 2) != 0)
                    {
                        array[i, j] = 1;
                        Console.Write("{0} ",array[i,j]);
                    }
                    else
                    {
                        array[i, j] =0;
                        Console.Write("{0} ", array[i, j]);
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
