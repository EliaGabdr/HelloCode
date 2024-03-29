﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int length = ReadInt("Input m: ");
int secondLength = ReadInt("Input n: ");
Console.WriteLine();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.WriteLine();
AverageMeanOfColumnElements(array);
Console.ReadLine();



int ReadInt(string argument)
{
    Console.Write($"{argument} ");
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void AverageMeanOfColumnElements(int[,] array)
{
    double average = 0;
    double sum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == k)
                    sum += array[i, j];
            }
        }
        average = sum / array.GetLength(0);
        Console.WriteLine($"average {k + 1} column - {Math.Round(average, 2)}");
        sum = 0;
    }

}

