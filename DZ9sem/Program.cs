using System;
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
namespace DZ9sem
{
    class Program
    {
        static void NaturalNumberShow(int n)
        {
            Console.Write(String.Format("{0,3}",n));
            n--;
            if(n>=1)
            {
                NaturalNumberShow(n);
            }
        }
        static int SumNaturalNumberShow(int n,int m)
        {
            int sum = 0;
            sum += n;
            if (n==m)
            {
                return n;
                
            }
            return SumNaturalNumberShow(n+1,m)+sum;
        }
        static int AkkermanNaturalNumberShow(int n,int m)
        {
            if (n==0)
            {
                return m+1;
            }
            if (m==0)
            {
                return AkkermanNaturalNumberShow(n-1,1);
            }
            return AkkermanNaturalNumberShow(n-1,AkkermanNaturalNumberShow(n,m-1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:  ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите М:  ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Полученная последовательность натуральных чисел: ");
            NaturalNumberShow(N);
            Console.WriteLine(" ");
            Console.Write("Сумма натуральных чисел от {0} до {1} = ",N,M);
            int sum = SumNaturalNumberShow(N,M);
            Console.WriteLine(sum);
            int number = AkkermanNaturalNumberShow(N,M);
            Console.Write("Значение функции Аккермана для {0} и {1} = ",N,M);
            Console.WriteLine(number);     
        }
    }
}
