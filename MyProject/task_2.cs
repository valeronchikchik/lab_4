using System;
using System.ComponentModel;

public class Task2
{
    static void Run(string[] args)
        {
            Console.WriteLine("Введіть координати вершини A (x y):");
            double[] a = ReadCoordinates();
            
            Console.WriteLine("Введіть координати вершини B (x y):");
            double[] b = ReadCoordinates();
            
            Console.WriteLine("Введіть координати вершини C (x y):");
            double[] c = ReadCoordinates();

            double[] ab = { b[0] - a[0], b[1] - a[1] };
            double[] ac = { c[0] - a[0], c[1] - a[1] };

            double[] ba = { a[0] - b[0], a[1] - b[1] };
            double[] bc = { c[0] - b[0], c[1] - b[1] };

            double[] ca = { a[0] - c[0], a[1] - c[1] };
            double[] cb = { b[0] - c[0], b[1] - c[1] };

            double angleA = GetAngleBetweenVectors(ab, ac);
            double angleB = GetAngleBetweenVectors(ba, bc);
            double angleC = GetAngleBetweenVectors(ca, cb);

            Console.WriteLine($"\nКути трикутника: A ≈ {angleA:F2}°, B ≈ {angleB:F2}°, C ≈ {angleC:F2}°");

            double epsilon = 0.0001;

            if (angleA > 90 + epsilon || angleB > 90 + epsilon || angleC > 90 + epsilon)
            {
                Console.WriteLine("Результат: Трикутник є тупокутним.");
            }
            else if (Math.Abs(angleA - 90) <= epsilon || Math.Abs(angleB - 90) <= epsilon || Math.Abs(angleC - 90) <= epsilon)
            {
                Console.WriteLine("Результат: Трикутник є прямокутним.");
            }
            else
            {
                Console.WriteLine("Результат: Трикутник є гострокутним.");
            }
        }

    static double GetAngleBetweenVectors(double[] u, double[] v)
        {
            double dotProduct = u[0] * v[0] + u[1] * v[1];

            double magnitudeU = Math.Sqrt(u[0] * u[0] + u[1] * u[1]);
            double magnitudeV = Math.Sqrt(v[0] * v[0] + v[1] * v[1]);

            double cosTheta = dotProduct / (magnitudeU * magnitudeV);

            if (cosTheta > 1.0) cosTheta = 1.0;
            if (cosTheta < -1.0) cosTheta = -1.0;

            double angleRadians = Math.Acos(cosTheta);
            return angleRadians * (180.0 / Math.PI);
        }

       static double[] ReadCoordinates()
{
    while (true) 
    {
        string inputLine = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(inputLine))
        {
            Console.WriteLine("Ви нічого не ввели. Спробуйте ще раз:");
            continue;
        }

        string[] parts = inputLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 2)
        {
            Console.WriteLine("Потрібно ввести щонайменше два числа через пробіл. Спробуйте ще раз:");
            continue;
        }

        bool isXValid = double.TryParse(parts[0], out double x);
        bool isAValid = double.TryParse(parts[1], out double a);

        if (isXValid && isAValid)
        {
            return new double[] { x, a }; 
        }
        else
        {
            Console.WriteLine("Помилка формату. Переконайтеся, що ви ввели числа (можливо, потрібно використати кому замість крапки, залежно від налаштувань системи). Спробуйте ще раз:");
        }
    }
}
}