// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координаты xA: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координаты yA: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координаты zA: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите координаты xB: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координаты yB: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите координаты zB: ");
int zB = int.Parse(Console.ReadLine());
double S = 0;
S = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Расстояние между точками = {Math.Round(S, 2)}");