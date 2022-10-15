using System;
//Напишите программу, которая заполнит спирально массив 4 на 4.
namespace DZ62
{
     class Spyral
    {
        public int[,] MakeSpyral(int size)
        {
            int[,] array = new int[size, size];
            int fill = 0;
            int move = 0;
            int row = 0;
            int col = 0;
            while (move <= size - 2)
            {
                while (col < (size - 1 - move))
                {
                    array[row, col] = fill++;
                    col++;
                }
                while ((row) < (size - 1 - move))
                {
                    array[row, col] = fill++;
                    row++;
                }
                while ((col) > (move))
                {
                    array[row, col] = fill++;
                    col--;
                }
                while ((row) > (move + 1))
                {
                    array[row, col] = fill++;
                    row--;
                }
                move++;
            }
            //Добавление последнего элемента
            array[row, col] = fill;
            return array;
        }

        public void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,7}", array[i, j]));

                }
                Console.WriteLine();
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы");
            int N = int.Parse(Console.ReadLine());
            Spyral spyral = new Spyral();
            spyral.ShowArray(spyral.MakeSpyral(N));
        }
    }
}
