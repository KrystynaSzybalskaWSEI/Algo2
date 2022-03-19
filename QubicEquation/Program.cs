using System;
 
namespace CubicEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b, c, d, w, p, q, delta;
 
            Console.WriteLine("Algorytm rozwiązuje równanie sześcienne: ax ^ 3 + bx ^ 2 + cx + d = 0");
 
            while (a == 0)
            {
                Console.WriteLine("Wpisz a różne od 0");
                a = Double.Parse(Console.ReadLine());
            }
 
            Console.WriteLine("Wpisz b");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz c");
            c = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz d");
            d = Double.Parse(Console.ReadLine());
 
            w = -(b / 3.0) * a;
            p = (3 * a * w * w + 2 * b * w + c) / a;
            q = (a * w * w * w + b * w * w + c * w + d) / a;
            delta = q * q / 4.0 + p * p * p / 27.0;
 
            if (delta > 0)
            {
                double x, xR, xIm, u, v;
 
                u = Math.Cbrt(-q / 2.0 + Math.Sqrt(delta));
                v = Math.Cbrt(-q / 2.0 - Math.Sqrt(delta));
                x = u + v + w;
                xR = -1.0 / 2.0 * (u + v) + w;
                xIm = Math.Sqrt(3) / 2 * (u - v);
 
                string x1 = xR.ToString() + " + " + xIm.ToString() + "i";
                string x2 = xR.ToString() + " - " + xIm.ToString() + "i";
 
                Console.WriteLine($"Równanie posiada jeden pierwiastek rzeczywisty: {x} i dwa zespolone pierwiastki sprzężone:\n{x1}\n{x2}");
            }
            else if (delta < 0)
            {
                double x1, x2, x3, fi;
                fi = Math.Acos((3.0 * q) / (2.0 * p * Math.Sqrt(- p / 3.0)));
 
                x1 = w + 2 * Math.Sqrt(- p / 3.0) * Math.Cos(fi / 3.0);
                x2 = w + 2 * Math.Sqrt(- p / 3.0) * Math.Cos(fi / 3.0 + 2.0 / 3.0 * Math.PI);
                x3 = w + 2 * Math.Sqrt(- p / 3.0) * Math.Cos(fi / 3.0 + 4.0 / 3.0 * Math.PI);
 
                Console.WriteLine($"Równanie posiada trzy pierwiastki rzeczywiste:\n{x1}\n{x2}\n{x3}");
            }
            else
            {
                double x1, x2;
                x1 = w - 2 * Math.Cbrt(q / 2);
                x2 = w + Math.Cbrt(q / 2);
                Console.WriteLine($"Równanie posiada pierwiastek rzeczywisty: {x1} i podwójny pierwiastek rzeczywisty: {x2}");
            }
        }
    }
}
