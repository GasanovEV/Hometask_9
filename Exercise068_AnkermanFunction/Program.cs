using System;

class AckermannFunction
{
    static void Main()
    {
        Console.WriteLine("Введите значение m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        int result = CalculateAckermannFunction(m, n);

        Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");
    }

    static int CalculateAckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }

        if (m > 0 && n == 0)
        {
            return CalculateAckermannFunction(m - 1, 1);
        }

        if (m > 0 && n > 0)
        {
            return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
        }

        throw new ArgumentException("Входные значения m и n должны быть неотрицательными числами.");
    }
}

