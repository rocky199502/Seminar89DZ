using System;
using System.Collections.Generic;
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
namespace DZ60
{
    class Program
    {
         struct Range
        {
            public int M;
            public int N;
            public int P;
        }
        const int minNumber = 10;
        const int maxNumber = 99;
        static private List<int> UniqNumberList()
        {
            List<int> numbers = new List<int>();
            for (int i = minNumber; i <= maxNumber; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        static void OutArray(int[,,] array)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Сформированный массив:");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j, k] + "(" + i + j + k + ")");
                    }
                    Console.WriteLine();

                }
            }
        }


        static Range FormRange()
        {
            Range range;
            do
            {
                Console.WriteLine("Введите кол-во M:");
                range.M = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во N:");
                range.N = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во P:");
                range.P = int.Parse(Console.ReadLine());
                if ((range.M * range.N * range.P) > (maxNumber - minNumber))
                {
                    Console.WriteLine("Ошибка ввода, введите размерность меньше");
                }
                else
                {
                    break;
                }
            }
            while (true);
            return range;
        }


        static int[,,] RandArray(Range range)
        {
            //Список разрешенных чисел
            List<int> numbers = UniqNumberList();
            int[,,] array = new int[range.M, range.N, range.P];

            Random rand = new Random();
            for (int i = 0; i < range.M; i++)
            {
                for (int j = 0; j < range.N; j++)
                {
                    for (int k = 0; k < range.P; k++)
                    {
                        int nextNumber = rand.Next(0, numbers.Count);
                        array[i, j, k] = numbers[nextNumber];
                        numbers.RemoveAt(nextNumber);
                    }
                }

            }

            return array;
        }
        static void Main(string[] args)
        {
            int[,,] initArray = RandArray(FormRange());
            OutArray(initArray);
        }
    }
}
