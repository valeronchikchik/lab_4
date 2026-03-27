using System;

public class SequenceCalculator
{
    public static long CalculateX(int n)
    {
        if (n == 0) return 0;
        if (n == 1 || n == 2) return 9;

        return CalculateX(n - 1) + 4 * CalculateX(n - 3);
    }

    public static void Run()
    {
        Console.Write("Введіть n: ");
        
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            long result = CalculateX(n);
            Console.WriteLine($"x_{n} = {result}");
        }
        else
        {
            Console.WriteLine("Помилка: введіть коректне невід'ємне ціле число");
        }
    }
}