using System;
namespace lab5zad2
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int multiple = 1;
            Console.Write("Введите количество столбцов будущего массива ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк будущего массива ");
            int b = int.Parse(Console.ReadLine());
            int[,] Array = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("A[{0},{1}]=", i, j);
                    int c = int.Parse(Console.ReadLine());
                    Array [i, j] = c;
                }
;
            }
            for (int j = 0; j < a; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < b; i++)
                    {
                        sum += Array[i, j];
                    }
                    Array[0, j] = sum;
                    sum = 0;
                }
                else
                {
                    for (int i = 0; i < b; i++)
                    {
                        multiple = multiple * Array[i, j];
                    }
                    Array[0, j] = multiple;
                    multiple = 1;
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("{0} ", Array [i, j]);
                }
                Console.WriteLine();
;
            }
        }
    }
}