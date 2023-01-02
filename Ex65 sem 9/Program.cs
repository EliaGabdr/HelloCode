// от N до M
void PrintFromUntil(int M, int N)
{
    if (M >= N)
    {
        Console.WriteLine(M);
        return;
    }
    Console.Write($"{M}, ");
    PrintFromUntil(M + 1, N);
}
PrintFromUntil(4, 8);