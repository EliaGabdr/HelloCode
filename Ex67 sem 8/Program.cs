// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDigital(int M)
{
    if (M / 10 == 0)
    {
        return (M % 10);
    }
    return M % 10 + SumDigital(M / 10);
}
Console.Write($"{SumDigital(453)}");

