
Console.WriteLine("Введите значение M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine());

int sum = GetSumOfNaturalNumbers(M, N);

Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");


int GetSumOfNaturalNumbers(int M, int N)
{
    if (N < M)
    {
        throw new ArgumentException("Значение N должно быть больше или равно M.");
    }

    if (M <= 0 || N <= 0)
    {
        throw new ArgumentException("Значение M и N должны быть натуральными числами.");
    }

    if (N == M)
    {
        return N;
    }

    return N + GetSumOfNaturalNumbers(M, N - 1);
}


