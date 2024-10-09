using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd3laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {



                Console.WriteLine("Введіть номер групи елементів (1 - Основа та висота, 2 - Дві сторони і кут між ними, 3 - Три сторони, 0 - Вихід):");
                int group = int.Parse(Console.ReadLine());

                double area = 0;

                switch (group)

                {
                    case 0:
                        Console.WriteLine("Програма завершена.");
                        break;

                    case 1:
                        Console.WriteLine("Введіть основу:");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть висоту:");
                        double height = double.Parse(Console.ReadLine());
                        area = 0.5 * baseLength * height;
                        Console.WriteLine($"Площа трикутника: {area}");
                        break;

                    case 2:
                        Console.WriteLine("Введіть першу сторону:");
                        double sideA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть другу сторону:");
                        double sideB = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть кут між сторонами (у радіанах):");
                        double angle = double.Parse(Console.ReadLine());
                        area = 0.5 * sideA * sideB * Math.Sin(angle);
                        Console.WriteLine($"Площа трикутника: {area}");
                        break;

                    case 3:
                        Console.WriteLine("Введіть першу сторону:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть другу сторону:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть третю сторону:");
                        double c = double.Parse(Console.ReadLine());
                        double perimeter = (a + b + c) / 2;
                        area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
                        Console.WriteLine($"Площа трикутника: {area}");
                        break;

                    default:
                        Console.WriteLine("Невірний номер групи. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}
