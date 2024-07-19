using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class Сircle
    {

        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }

        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }

        static public void СontainsPoint(double r, double x0, double y0)
        {
            Console.WriteLine("Введите координату точки x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату точки y");
            double y = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(x0 - x, 2) + Math.Pow(y0 - y, 2));
            if (c <= r)
            {
                Console.WriteLine("Точка принадлежит окружности");

            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }
           
                
        }

    }
}
