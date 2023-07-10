Console.WriteLine("Введите значение N:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Натуральные числа от N до 1:");
PrintNaturalNumbers(N);

void PrintNaturalNumbers(int N)
{
    if (N <= 0)
    {
        return;
    }

    Console.WriteLine(N);
    PrintNaturalNumbers(N - 1);
}


