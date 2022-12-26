//Двумерный массив, заполненный случайныйми целыми числами

int length = ReadInt("m");
int secondLength = ReadInt("n");
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}:");
    return int.Parse(Console.ReadLine());
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(1000);
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
