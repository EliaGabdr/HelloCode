﻿// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int firstLength = ReadInt("first length");
int secondLength = ReadInt("second length");

int[,] array = GetArray(firstLength, secondLength);
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали равна {FindSumMainDiagonal(array)}");



int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
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

int FindSumMainDiagonal(int[,] array)
{
    int sum = 0;
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    // if (array.GetLength(0) < array.GetLength(1))
    // {
    //     length = array.GetLength(0);
    // }
    // else length = array.GetLength(1);

    for (int i = 0; i < length; i++)
    {
        sum = sum + array[i, i];
    }
    return sum;
}

// int length = ReadInt();
// int secondLength = ReadInt();
// int[,] array = GetArray(length, secondLength);
// PrintArray(array);
// int sum = SumDiagonal(array);
// UpdateArray(array);
// Console.WriteLine();
// Console.WriteLine($"сумма по диагонали {sum}");
// PrintArray(array);
// Console.ReadLine();



// int ReadInt()
// {
//     return int.Parse(Console.ReadLine());
// }

// int[,] GetArray(int length, int secondLength)
// {
//     int[,] array = new int[length, secondLength];
//     Random random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         for (int j = 0; j < secondLength; j++)
//         {
//             array[i, j] = i + j;
//             random.Next(1000); 
//         }
//     }
//     return array;
// }

// void  UpdateArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] = (int) Math.Pow(array[i, j], 2);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumDiagonal(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//                 sum += array[i, j];
//         }
//     }
//     return sum;
// }