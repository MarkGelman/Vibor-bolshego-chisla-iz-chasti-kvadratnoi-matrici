using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zashtrihovanaia_Chast
{
    class Program
    {
        static void Main(string[] args)
        {
                        /*Дана квадратная матрица действительных чисел порядка N(от 1 до 10).
            Найти наибольшее из значений элементов, расположенных в заштрихованной части матрицы.
            Начальные данные: на первой строчке вводится порядок матрицы N.Далее вводятся N строк с элементами матрицы через пробел.
            Вывод результата: одно число по условию с точностью до 4 знаков.*/

            int N = int.Parse(Console.ReadLine());
            double[,] a = new double[N,N];
            for(int i=0;i<N;i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < N; j++)
                    a[i, j] = double.Parse(s [j]);
            }

            double max = a[0, N - 1];
            for (int i = 0; i < N / 2; i++)
                for (int j = (N - 1) - i; j < N; j++)
                    if (a[i, j] > max) max = a[i, j];
            for (int i = N / 2; i < N; i++) 
                for (int j=i; j<N; j++)
                    if (a[i, j] > max) max = a[i, j];
            Console.WriteLine("{0:f4}", max);
        }
    }
}
