using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите радиус");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату центра окружности x0");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату центра окружности y0");
                double y0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Длина окружности: {Сircle.GetLength(r)}");
                Console.WriteLine($"Площадь круга: {Сircle.GetSquare(r)}");
                Сircle.СontainsPoint(r, x0, y0);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
              




        }
    }
}
