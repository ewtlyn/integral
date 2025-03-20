using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите нижний предел интегрирования a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите верхний предел интегрирования b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите количество разбиений n:");
        int n = Convert.ToInt32(Console.ReadLine());

        double h = (b - a) / n; // формула вычисление ширины разбиений

        double integral = 0; //переменная для хранения приближеннгого значения
        double x = a; //представляет текущую точку x в интервале интегрирования

        for (int i = 0; i < n; i++) //формула
        {
            x += h; // переход к правой точке подынтервала
            integral += (2 * x * x + 3 * x) * h; // вычисление значения функции и добавление к интегралу
        }

        // Вывод результата
        Console.WriteLine($"Приближенное значение интеграла: {integral}");
    }
}