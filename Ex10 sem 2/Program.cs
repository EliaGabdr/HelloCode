﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// 1.
// ГЛАВНАЯ ЗАДАЧА
// 100 <= N <= 999
// число, которое вводит пользователь
// как выводить результат

// 
// 2.
// 2.1. Метод, который -> Ввод числа
// 2.2. Метод, который -> Проверка числа на валидность
// 2.3. Метод, который -> Отковырять вторую цифру +++
// 2.4. Метод, который -> Распечать результат
// 2.5. Метод, который -> Декоратор для вывода
//
// 3. 
// ___
// abc = a*100 + b*10 + c 
// 456 = 4*100 + 5*10 + 6
// ДЕЛЕНИЕ  Целочисленное        14 div 5 => 2       int / int => int
//          Обычное              14 / 5 => 2.8       double / int = double
//                                                   int / double = double
//                                                   double / double = double
//          С остатком             14 mod 5 => 4       int % int => int
// ___
// abc = value
// a = value div 100
// b = (value div 10) mod 10
// c = value mod 10


// 2.1. Метод, который -> Ввод числа
int GetNumberFromUser()
{
    Console.Write("Введите число от 100 до 999: ");
    int temp = int.Parse(Console.ReadLine());
    return temp;
}

// 2.2. Метод, который -> Проверка числа на валидность
bool IsValid(int number)
{
    // and -> &&
    return number >= 100 && number <= 999;
    // if (number >= 100)
    // {
    //   if (number <= 999)
    //   {
    //     return true;
    //   }
    // }
    // return false;
}

// 2.3. Метод, который -> Отковырять вторую цифру +++
int GetNumber(int value)
{
    int b = (value / 10) % 10;

    return b;
}

// 2.4. Метод, который -> Распечать результат
string GetText(int input, int output)
{
    return input + " -> " + output;
}

// 2.5. Метод, который -> Декоратор для вывода

string Decorator(string text)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    return text;
}


void Decorator2(string text)
{
    Console.Clear();
    System.Console.WriteLine("-----------------------");
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine(text);
    Console.ForegroundColor = old;
    System.Console.WriteLine("-----------------------");
}

void Task10()
{
    int value = GetNumberFromUser();

    if (IsValid(value))
    {
        int result = GetNumber(value);
        //System.Console.WriteLine(GetText(value, result));
        Decorator2(GetText(value, result));
    }
    else
    {
        System.Console.WriteLine("число кривое");
    }
}
