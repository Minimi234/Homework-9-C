int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEvenTwoNaturalList(int M, int N)
{
    if (N < M)
    {
        return;
    }
    PrintEvenTwoNaturalList(M, N - 1);
    if (N % 2 == 0) Console.Write(N + " ");
}

int M = Promt("Введите натуральное число M > ");
int N = Promt("Введите натуральное число N > ");
PrintEvenTwoNaturalList(M, N);