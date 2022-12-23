﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Input command: ");
switch (Console.ReadLine())
{
    case "Task25": Task25(); break;
    case "Task27": Task27(); break;

}

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}

int Pow(int firstNumber, int secondNumber)
{
    int result = 1;

    for (int i = 0; i < secondNumber; i++)
    {
        result *= firstNumber;
    }

    return result;
}

void Task25()
{
    Console.WriteLine("Task25");

    int numberA = ReadInt("А");
    int numberB = ReadInt("B");

    Console.WriteLine($"А = {numberA} в степени B = {numberB} это {Pow(numberA, numberB)} ");

}
void Task27()
{
    Console.WriteLine("Task27");

    int numberA = ReadInt("А");

    Console.WriteLine($"The sum of the digits in a number {numberA} = {SumDig(numberA)}");

}

int SumDig(int numberA)
{
    int result = 0;

    while (numberA > 9)
    {
        result = result + (numberA % 10);
        numberA = numberA / 10;
    }

    result = result + numberA;
    return result;

}