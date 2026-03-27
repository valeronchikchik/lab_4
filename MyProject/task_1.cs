using System;

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
            
            double top;
            double top_secondpart;
            double down;
            double down_middle;
            double u;

            if(x + y> x*y || x+y > 4 * z)
            {
                top_secondpart = x+y;
            }
            else if(x*y>(x+y) || x * y > 4 * z)
            {
                top_secondpart = x*y;
            }
            else
            {
                top_secondpart = 4*z;
            }

            if(x > y || x > z)
            {
                top = x + top_secondpart;
            }
        
            else if(y > x || y > z)
            {
                top = y + top_secondpart;
            }

            else
            {
                top = z + top_secondpart;
            }

            if((x + y) > x*y || (x+y)> x *x)
        {
            down_middle = (x + y)*(x + y);
        }
            else if(x * y> (x+y) || x*y> x * x)
        {
            down_middle = (x*y)*(x*y);
        }
        else
        {
            down_middle = (x*x)*(x*x);
        }

        if(down_middle> 7 || down_middle > z * z)
        {
            down = down_middle;
        }
        else if(7 > down_middle || 7 > z * z)
        {
            down = 7;
        }
        else
        {
            down = z*z;
        }
        
        u = top/down;
        Console.WriteLine($"Результат: {u}");
             
        }
    }
