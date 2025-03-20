using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальную точку a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите конечную точку b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите шаг h:");
        double h = Convert.ToDouble(Console.ReadLine());

        //вывод заголовка таблицы
        Console.WriteLine("x\t\ty(x)");

        //вычисление и вывод значений функции
        for (double x = a; x <= b; x += h)
        {
            double y = Math.Cos(x * x) + Math.Sin(x);
            Console.WriteLine($"{x}\t\t{y}");
        }
    }
}
