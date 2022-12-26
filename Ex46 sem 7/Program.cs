﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

int m = ReadInt("m");
int n = ReadInt("n");

int[,] newArray = GetArray(m, n);
PrintArray(newArray);



int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    return int.Parse(Console.ReadLine()!);
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = i + j;
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
