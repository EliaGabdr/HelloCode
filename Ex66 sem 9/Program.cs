// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SumInteger(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        System.Console.Write($"{sum}");
        return;
    }
    SumInteger(m, n - 1, sum);
}
SumInteger(4, 8, 0);

