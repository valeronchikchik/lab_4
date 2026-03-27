using System;

public class Task3
{
    static double CalculateExpression(double x, double a)
    {
        if (a == 0)
        {
            throw new ArgumentException("Параметр 'a' не може дорівнювати нулю, оскільки відбувається ділення на 'a'.");
        }
        if (x < 0)
        {
            throw new ArgumentException("Параметр 'x' не може бути від'ємним, оскільки присутня операція sqrt(x).");
        }

        double term1 = x;
        double term2 = x * 2.0 / 3.0 * x / a / 4.0;
        double term3 = Math.Sqrt(Math.Abs(Math.Sin(x))) / 2.0 * Math.Sqrt(x);
        double term4 = 1.0e4 * Math.Pow(x, 4.0 / 7.0);

        return term1 + term2 + term3 + term4;
    }

    public static void Run(string[] args)
    {
        double x = 5.0; 
        double a = 2.0; 

        try
        {
            double result = CalculateExpression(x, a);
            Console.WriteLine($"При x = {x} та a = {a}");
            Console.WriteLine($"Результат обчислення: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}