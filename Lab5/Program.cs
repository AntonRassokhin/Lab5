using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7; //или заменить на требуемое кол-во ячеек в массиве
            int[] array = new int [n];
            double s = 0;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            double x = s / n;
            Console.WriteLine("Среднее арифметическое значение элементов массива ={0:f2}", x);
            Console.ReadKey();
        }
    }
}
