using System;

namespace DZ545658
{
    class Program
    {
         static int[,] RandArray(int M, int N)
        {
            int[,] array = new int[M, N];
            Random rand = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = rand.Next(0, 9);
                }
            }
            return array;
        }
        static void OutArray(int[,] array)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Сформированный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,7}", array[i, j]));

                }
                Console.WriteLine(" ");
            }
        }

//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        static int[,] SortArray(int[,] array)
        {
            int move = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int s = 0; s < array.GetLength(1); s++)
                {
                    for (int j = 0; j < array.GetLength(1) ; j++)
                    {
                         if (j + 1 < array.GetLength(1))
                         {
                             if (array[i, j] <= array[i, j + 1])
                             {
                                 move = array[i, j];
                                 array[i, j] = array[i, j + 1];
                                 array[i, j + 1] = move;
                             }

                        }

                    }
                }
            }
            return array;
        }
      //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        public static void minSumm(int[,] array)
        {
            int min = 0;
            int minRow = 0;
            for (int i= 0; i<array.GetLength(0); i++)
            {
                int locIntSumm = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    locIntSumm += array[i, j]; 
                }
                //init
                if (min == 0) 
                {
                    min = locIntSumm;
                }
                if (min > locIntSumm)
                {
                    min = locIntSumm;
                    minRow = i;
                }
            }
            Console.WriteLine("Минимальная сумма:" + min);
            Console.Write("Строка с минимальной суммой:");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(String.Format("{0,7}", array[minRow, j]));

            }
        }

//Напишите программу, которая будет находить произведение двух матриц.

        static int[,] MultiplyArray(int[,] array, int[,] array2)
        {
            int[,] resArray = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int s = 0; s < array.GetLength(1); s++)
                    {
                        resArray[i, j] += array[i, s] * array2[s, j];
                    }
                }
            }
                    return resArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк:");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов:");
            int N = int.Parse(Console.ReadLine());
            int[,] array = RandArray(M, N);
            OutArray(array);
            //перемножение матриц
            int[,] array2 = RandArray(M, N);
            OutArray(array2);
            int[,] multiArray = MultiplyArray(array, array2);
            OutArray(multiArray);
            // сортировка матриц
            int[,] sortArray = SortArray(array);
            OutArray(sortArray);
            // строка с минимальной суммой
            minSumm(sortArray);
        }
    }
}
