using System;

namespace Homework_4_Source_Task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            
            int MatrixSize = 1;
            int MatrixSize1 = 1;
            int MinNuber = 0;
            int MaxNuber = 20;

            
            while (MatrixSize < 2 || MatrixSize > 255)
            {
                Console.WriteLine("Введите количество столбцов матриц от 2 до 255: ");
                MatrixSize = int.Parse(Console.ReadLine());
            }

            while (MatrixSize1 < 2 || MatrixSize1 > 255)
            {
                Console.WriteLine("Введите количество строк матриц от 2 до 255: ");
                MatrixSize1 = int.Parse(Console.ReadLine());
            }

            int[,] matrix = new int[MatrixSize, MatrixSize1];
            int[,] matrix1 = new int[MatrixSize, MatrixSize1];
            int[,] SumMatrix = new int[MatrixSize, MatrixSize1];
            int[,] SubMatrix = new int[MatrixSize, MatrixSize1];

            //заполнение
            var Rand = new Random();

            Console.WriteLine();
            Console.WriteLine("Исходная матрица 1:");
            Console.WriteLine();

            //матрица 1
            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize1; j++)
                {
                    matrix[i, j] = Rand.Next(MinNuber, MaxNuber);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Исходная матрица 2:");
            Console.WriteLine();
            //матрица 2
            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize1; j++)
                {
                    matrix1[i, j] = Rand.Next(MinNuber, MaxNuber);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            //сложение

            Console.WriteLine();
            Console.WriteLine("Сложение:");
            Console.WriteLine();

            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize1; j++)
                {
                    SumMatrix[i, j] = matrix[i, j] + matrix1[i, j];
                    Console.Write($"{SumMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Вычитание:");
            Console.WriteLine();

            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize1; j++)
                {
                    SubMatrix[i, j] = matrix[i, j] - matrix1[i, j];
                    Console.Write($"{SubMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
