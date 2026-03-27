using System;
using System.ComponentModel.DataAnnotations;

public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Введіть x: ");
            double x = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введіть y: ");
            double y = Double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введіть z: ");
            double z = Double.Parse(Console.ReadLine()!);

            double first_top = Max(x,y,z);
            double second_top = Max(x+y, x*y, 4*z);
            double first_down = Math.Pow(Max(x+y, x*y, x*x), 2);
            double second_down = Max(first_down, 7, z*z);

            double u = (first_top + second_top)/second_down;

            Console.WriteLine($"Результат: {u}");
        }

        static Double Max(double a, double b, double c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
    }
