// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа: ");

int number_a = int.Parse(Console.ReadLine());
int number_b = int.Parse(Console.ReadLine());
int number_c = int.Parse(Console.ReadLine());

int max = number_a;

if (number_b > max)
{
    max = number_b;
}
if (number_c > max)
{
    max = number_c;
}

Console.Write($"Max number = {max}");

