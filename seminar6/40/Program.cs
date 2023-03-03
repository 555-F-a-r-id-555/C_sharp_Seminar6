// Задача 40: Напишите программу,
// которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

(int a, int b, int c) = (Convert.ToInt16(Console.ReadLine()),
Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
Console.WriteLine($"{a},{b},{c}");
void maxABC()
{
    int max_abc = a;
    if (b > a && b > c)
    {
        max_abc = b;
        if (max_abc < a + c) Console.WriteLine($"Треугольник существует");
        else Console.WriteLine($"Треугольник не существует");

    }
    else if (c > a && c > b)
    {
        max_abc = c;
        if (max_abc < a + b) Console.WriteLine($"Треугольник существует");
        else Console.WriteLine($"Треугольник не существует");
    }
    else
    {
        if (max_abc < b + c) Console.WriteLine($"Треугольник существует");
        else Console.WriteLine($"Треугольник не существует");
    }
}


maxABC();