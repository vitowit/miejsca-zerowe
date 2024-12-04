using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miejscaZerowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj współczynnik a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("To nie jest funkcja kwadratowa (a = 0).");
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Dwa miejsca zerowe w liczbach rzeczywistych:");
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Jedno miejsce zerowe w liczbach rzeczywistych:");
                Console.WriteLine("x = {0}", x);
            }
            else if(delta < 0)
            {
                double real = -b / (2 * a);
                double imaginary = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("Dwa miejsca zerowe w liczbach zespolonych:");
                Console.WriteLine("x1 = {0} + {1}i", real, imaginary);
                Console.WriteLine("x2 = {0} - {1}i", real, imaginary);
            }
        }
    }
}
